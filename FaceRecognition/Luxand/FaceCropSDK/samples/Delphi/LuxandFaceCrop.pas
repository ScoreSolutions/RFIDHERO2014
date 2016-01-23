///////////////////////////////////////////////////
//
//          Luxand FaceCrop Library
//
//  Copyright(c) 2005-2010 Luxand, Inc.
//           http://www.luxand.com
//
///////////////////////////////////////////////////

unit LuxandFaceCrop;

interface

uses windows;

// Error codes

const
    fcErrorOk	=			0;
    fcErrorFailed	=		-1;
    fcErrorNotActivated	=	-2;
    fcErrorOutOfMemory =		-3;
    fcErrorInvalidArgument = -4;
    fcErrorIOError =			-5;
    fcErrorImageTooSmall = -6;
    fcErrorFaceNotFound = -7;
    fcErrorInsufficientBufferSize = -8;
    fcUnsupportedImageExtension =      -9;
    fcCannotOpenFile =-10;
    fcCannotCreateFile =-11;
    fcBadFileFormat =-12;
    fcFileNotFound =-13;


// Types

type
    FcDetectionPerformance = (
        fcPerformanceRealtime,
	      fcPerformanceNormal,
	      fcPerformancePrecise
    );

    PHBitmap = ^HBitmap;



function fcInitialize(): integer; cdecl; external 'facecrop.dll';
function fcActivate(licenseKey: PChar): integer; cdecl; external 'facecrop.dll';
function fcFinalize(): integer; cdecl; external 'facecrop.dll';

function fcGetLicenseInfo(licenseInfo: PChar): integer; cdecl; external 'facecrop.dll';
function fcGetHardwareID(hardwareID: PChar): integer; cdecl; external 'facecrop.dll';

function fcCreateContextID(contextID: PInteger): integer; cdecl; external 'facecrop.dll';
function fcFreeContextID(contextID: integer): integer; cdecl; external 'facecrop.dll';

function fcFaceCrop(inFileName: PChar; outFileName: PChar; width, height: integer): integer; cdecl; external 'facecrop.dll';
function fcFaceCrop_C(inFileName: PChar; outFileName: PChar; width, height, contextID: integer): integer; cdecl; external 'facecrop.dll';
function fcFaceCrop_FileToHBITMAP(inFileName : PChar; outHBITMAP: PHbitmap; width, height: integer): integer; cdecl; external 'facecrop.dll';
function fcFaceCrop_FileToHBITMAP_C(inFileName: PChar; outHBITMAP: PHbitmap; width, height, contextID: integer): integer; cdecl; external 'facecrop.dll';
function fcFaceCrop_HBITMAPToHBITMAP(inHBITMAP, outHBITMAP: PHbitmap; width, height: integer): integer; cdecl; external 'facecrop.dll';
function fcFaceCrop_HBITMAPToHBITMAP_C(inHBITMAP, outHBITMAP: PHbitmap; width, height, contextID: integer): integer; cdecl; external 'facecrop.dll';

function fcGetFacePosition(inFileName: PChar; width, height: integer; x1, y1, x2, y2: PInteger): integer; cdecl; external 'facecrop.dll';
function fcGetFacePosition_C(inFileName: PChar; width, height: integer; x1, y1, x2, y2: PInteger; contextID: integer): integer; cdecl; external 'facecrop.dll';
function fcGetFacePosition_HBITMAP(inHBITMAP: PHbitmap; width, height: integer; x1, y1, x2, y2: PInteger): integer; cdecl; external 'facecrop.dll';
function fcGetFacePosition_HBITMAP_C(inHBITMAP: PHbitmap; width, height: integer; x1, y1, x2, y2: PInteger; contextID: integer): integer; cdecl; external 'facecrop.dll';

function fcSetFaceScale(scale: Single): integer; cdecl; external 'facecrop.dll';
function fcSetFaceScale_C(scale: Single; contextID: integer): integer; cdecl; external 'facecrop.dll';
function fcSetFaceShift(shiftX, shiftY: Single): integer; cdecl; external 'facecrop.dll';
function fcSetFaceShift_C(shiftX, shiftY: Single; contextID: integer): integer; cdecl; external 'facecrop.dll';
function fcSetDetectionThreshold(threshold: integer): integer; cdecl; external 'facecrop.dll';
function fcSetDetectionThreshold_C(threshold, contextID: integer): integer; cdecl; external 'facecrop.dll';
function fcSetDetectionPerformance(level: FcDetectionPerformance): integer; cdecl; external 'facecrop.dll';
function fcSetDetectionPerformance_C(level: FcDetectionPerformance; contextID: integer): integer; cdecl; external 'facecrop.dll';
function fcSetJpegQuality(quality: integer): integer; cdecl; external 'facecrop.dll';
function fcSetJpegQuality_C(quality, contextID: integer): integer; cdecl; external 'facecrop.dll';



implementation

end.
