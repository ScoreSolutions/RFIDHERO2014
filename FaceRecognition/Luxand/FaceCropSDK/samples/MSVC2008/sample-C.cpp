#include "stdafx.h"
#include <windows.h>
#include "resource.h"
#include "LuxandFaceCrop.h"

const wchar_t g_szClassName[] = L"SimpleWindowClass";


void PaintImage(HWND hwnd, HBITMAP hBitmap, int x, int y, int *width, int *height)
{
	HDC dc = GetDC(hwnd);
			
	BITMAPINFO infobm;
	ZeroMemory( &infobm.bmiHeader, sizeof(BITMAPINFOHEADER) );
	infobm.bmiHeader.biBitCount = 0; 
	infobm.bmiHeader.biSize = sizeof(infobm);
	if (GetDIBits(dc, hBitmap, 0, infobm.bmiHeader.biHeight, 0, &infobm, DIB_RGB_COLORS) == 0){
		MessageBox(0, L"Error processing bitmap", L"Error", MB_ICONEXCLAMATION | MB_OK);
		exit(-3);	
	}
	unsigned char *databm = 0;
	databm = (unsigned char*) malloc(((infobm.bmiHeader.biWidth * 32 +31) & ~31) /8*infobm.bmiHeader.biHeight*3);
	if (GetDIBits(dc, hBitmap, 0, infobm.bmiHeader.biHeight, databm, &infobm, DIB_RGB_COLORS) == 0){
		MessageBox(0, L"Error processing bitmap", L"Error", MB_ICONEXCLAMATION | MB_OK);
		exit(-4);	
	}

	StretchDIBits(dc, x, y, infobm.bmiHeader.biWidth, infobm.bmiHeader.biHeight, 0, 0, infobm.bmiHeader.biWidth, infobm.bmiHeader.biHeight, (const void *)databm, &infobm, DIB_RGB_COLORS, SRCCOPY);
	if (width)
		*width = infobm.bmiHeader.biWidth;
	if (height)
		*height = infobm.bmiHeader.biHeight;

	DeleteDC(dc);
}



void OpenImageFile(HWND hwnd)
{
	OPENFILENAME ofn;
    wchar_t szFileName[MAX_PATH] = L"";

    ZeroMemory(&ofn, sizeof(ofn));

    ofn.lStructSize = sizeof(ofn); 
    ofn.hwndOwner = hwnd;
    ofn.lpstrFilter = L"JPEG Files (*.jpg)\0*.jpg\0Windows BITMAP Files (*.bmp)\0*.bmp\0All Files (*.*)\0*.*\0";
    ofn.lpstrFile = szFileName;
    ofn.nMaxFile = MAX_PATH;
    ofn.Flags = OFN_EXPLORER | OFN_FILEMUSTEXIST | OFN_HIDEREADONLY;
    ofn.lpstrDefExt = L"jpg";

    if(GetOpenFileName(&ofn)){
		HBITMAP hBitmapFace; 
		char * fn = new char[wcslen(szFileName)+1];
		memset(fn, 0, wcslen(szFileName)+1);
		WideCharToMultiByte(CP_ACP, 0, szFileName, -1, fn, wcslen(szFileName), NULL, NULL);
		int result = fcFaceCrop_FileToHBITMAP(fn, &hBitmapFace, 300, 400);
		if (fcErrorOk == result){
			PaintImage(hwnd, hBitmapFace, 0, 0, NULL, NULL);
			DeleteObject(hBitmapFace);
		} else if (fcErrorFaceNotFound == result)	
			MessageBox(NULL, L"Error: face not found", L"Error", MB_ICONEXCLAMATION | MB_OK);
		else
			MessageBox(NULL, L"Error: can't open image", L"Error", MB_ICONEXCLAMATION | MB_OK);
        
    }

}


LRESULT CALLBACK WndProc(HWND hwnd, UINT msg, WPARAM wParam, LPARAM lParam)
{
    switch(msg)
    {
		case WM_COMMAND: 
            switch(LOWORD(wParam))
            {
                case ID_OPEN_FILE:
					OpenImageFile(hwnd);
                break;
                case ID_EXIT:
					PostMessage(hwnd, WM_CLOSE, 0, 0);
                break;
            }
        break;
        case WM_CLOSE:
            DestroyWindow(hwnd);
        break;
        case WM_DESTROY:
            PostQuitMessage(0);
        break;
        default:
            return DefWindowProc(hwnd, msg, wParam, lParam);
    }
    return 0;
}



int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance,
    LPSTR lpCmdLine, int nCmdShow)
{
#ifndef FSDK_DEBUG
#error Please request the evaluation license key from Luxand, Inc., comment this line and pass the key to fcActivate. Please visit http://www.luxand.com/facecrop/ to request the key
#endif

	if (fcErrorOk != fcActivate("")){
		MessageBox(0, L"Error activating FaceCrop", L"Error", MB_ICONEXCLAMATION | MB_OK);
		exit(-1);
	}

	WNDCLASSEX wc;
    wc.cbSize        = sizeof(WNDCLASSEX);
    wc.style         = 0;
    wc.lpfnWndProc   = WndProc;
    wc.cbClsExtra    = 0;
    wc.cbWndExtra    = 0;
    wc.hInstance     = hInstance;
    wc.hIcon         = LoadIcon(NULL, IDI_APPLICATION);
    wc.hCursor       = LoadCursor(NULL, IDC_ARROW);
    wc.hbrBackground = (HBRUSH)(COLOR_WINDOW);
    wc.lpszMenuName  = MAKEINTRESOURCE(IDR_MYMENU);
    wc.lpszClassName = g_szClassName;
    wc.hIconSm       = LoadIcon(NULL, IDI_APPLICATION);

    if(!RegisterClassEx(&wc)){
        MessageBox(NULL, L"Window Class Registration Failed", L"Error", MB_ICONEXCLAMATION | MB_OK);
        return -1;
    }

    HWND hwnd = CreateWindowEx(
        WS_EX_WINDOWEDGE,
        g_szClassName,
		L"Luxand FaceCrop Sample",
        WS_OVERLAPPEDWINDOW,
        CW_USEDEFAULT, CW_USEDEFAULT, 300, 400,
        NULL, NULL, hInstance, NULL);

    if(hwnd == NULL){
        MessageBox(NULL, L"Window Creation Failed", L"Error", MB_ICONEXCLAMATION | MB_OK);
        return -2;
    }

    ShowWindow(hwnd, nCmdShow);
    UpdateWindow(hwnd);

	
    MSG Msg;
    while(GetMessage(&Msg, NULL, 0, 0) > 0){
        TranslateMessage(&Msg);
        DispatchMessage(&Msg);
	}

    return Msg.wParam;
}
