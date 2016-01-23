using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Luxand
{
    public unsafe class fc
    {
        public const int fcErrorOk   =                            0;
        public const int fcErrorFailed    =               -1;
        public const int fcErrorNotActivated  =           -2;
        public const int fcErrorOutOfMemory  =            -3;
        public const int fcErrorInvalidArgument = -4;
        public const int fcErrorIOError =                 -5;
        public const int fcErrorImageTooSmall = -6;
        public const int fcErrorFaceNotFound  = -7;
        public const int fcErrorInsufficientBufferSize = -8;
        public const int fcUnsupportedImageExtension    =   -9;
        public const int fcCannotOpenFile = -10;
        public const int fcCannotCreateFile = -11;
        public const int fcBadFileFormat = -12;
        public const int fcFileNotFound = -13;
        
        public enum FcDetectionPerformance
        {
            fcPerformanceRealtime,
            fcPerformanceNormal,
            fcPerformancePrecise
        }
        
        [DllImport("facecrop.dll", EntryPoint = "fcInitialize", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Initialize();

        [DllImport("facecrop.dll", EntryPoint = "fcFinalize", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Finalize();

        [DllImport("facecrop.dll", EntryPoint = "fcActivate", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Activate(string LicenseKey);


        [DllImport("facecrop.dll", EntryPoint = "fcGetHardwareID", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        private static extern int fcGetHardwareID_Old([OutAttribute] StringBuilder HardwareID);
        public static int GetHardwareID(out string HardwareID)
        {
            StringBuilder tmps = new StringBuilder(1024);
            int res = fcGetHardwareID_Old(tmps);
            HardwareID = tmps.ToString();
            return res;
        }

        [DllImport("facecrop.dll", EntryPoint = "fcGetLicenseInfo", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        private static extern int fcGetLicenseInfo_Old([OutAttribute] StringBuilder LicenseInfo);
        public static int GetLicenseInfo(out string LicenseInfo)
        {
            StringBuilder tmps = new StringBuilder(1024);
            int res = fcGetLicenseInfo_Old(tmps);
            LicenseInfo = tmps.ToString();
            return res;
        }
        





        [DllImport("facecrop.dll", EntryPoint = "fcCreateContextID", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int CreateContextID(ref int contextID);

        [DllImport("facecrop.dll", EntryPoint = "fcFreeContextID", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int FreeContextID(int contextID);


        [DllImport("facecrop.dll", EntryPoint = "fcFaceCrop", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int FaceCrop(string inFileName, string outFileName, int width, int height);
        [DllImport("facecrop.dll", EntryPoint = "fcFaceCrop_C", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int FaceCrop_C(string inFileName, string outFileName, int width, int height, int contextID);

        [DllImport("facecrop.dll", EntryPoint = "fcFaceCrop_FileToHBITMAP", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int FaceCrop_FileToHBITMAP(string inFileName, ref IntPtr outHBITMAP, int width, int height);
        [DllImport("facecrop.dll", EntryPoint = "fcFaceCrop_FileToHBITMAP_C", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int FaceCrop_FileToHBITMAP_C(string inFileName, ref IntPtr outHBITMAP, int width, int height, int contextID);

        [DllImport("facecrop.dll", EntryPoint = "fcFaceCrop_HBITMAPToHBITMAP", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int FaceCrop_HBITMAPToHBITMAP(ref IntPtr inHBITMAP, ref IntPtr outHBITMAP, int width, int height);
        [DllImport("facecrop.dll", EntryPoint = "fcFaceCrop_HBITMAPToHBITMAP_C", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int FaceCrop_HBITMAPToHBITMAP_C(ref IntPtr inHBITMAP, ref IntPtr outHBITMAP, int width, int height, int contextID);


        [DllImport("facecrop.dll", EntryPoint = "fcGetFacePosition", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetFacePosition(string inFileName, int width, int height, ref int x1, ref int y1, ref int x2, ref int y2);
        [DllImport("facecrop.dll", EntryPoint = "fcGetFacePosition_C", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetFacePosition_C(string inFileName, int width, int heigh, ref int x1, ref int y1, ref int x2, ref int y2, int contextID);

        [DllImport("facecrop.dll", EntryPoint = "fcGetFacePosition_HBITMAP", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetFacePosition_HBITMAP(ref IntPtr inHBITMAP, int width, int heigh, ref int x1, ref int y1, ref int x2, ref int y2);
        [DllImport("facecrop.dll", EntryPoint = "fcGetFacePosition_HBITMAP_C", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetFacePosition_HBITMAP_C(ref IntPtr inHBITMAP, int width, int heigh, ref int x1, ref int y1, ref int x2, ref int y2, int contextID);


        [DllImport("facecrop.dll", EntryPoint = "fcSetFaceScale", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SetFaceScale(float scale);
        [DllImport("facecrop.dll", EntryPoint = "fcSetFaceScale_C", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SetFaceScale_C(float scale, int contextID);

        [DllImport("facecrop.dll", EntryPoint = "fcSetFaceShift", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SetFaceShift(float shiftX, float shiftY);
        [DllImport("facecrop.dll", EntryPoint = "fcSetFaceShift_C", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SetFaceShift_C(float shiftX, float shiftY, int contextID);

        [DllImport("facecrop.dll", EntryPoint = "fcSetDetectionThreshold", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SetDetectionThreshold(int threshold);
        [DllImport("facecrop.dll", EntryPoint = "fcSetDetectionThreshold_C", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SetDetectionThreshold_C(int threshold, int contextID);

        [DllImport("facecrop.dll", EntryPoint = "fcSetDetectionPerformance", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SetDetectionPerformance(FcDetectionPerformance level);
        [DllImport("facecrop.dll", EntryPoint = "fcSetDetectionPerformance_C", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SetDetectionPerformance_C(FcDetectionPerformance level, int contextID);

        [DllImport("facecrop.dll", EntryPoint = "fcSetJpegQuality", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SetJpegQuality(int quality);
        [DllImport("facecrop.dll", EntryPoint = "fcSetJpegQuality_C", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SetJpegQuality_C(int quality, int contextID);
        

    }
}
