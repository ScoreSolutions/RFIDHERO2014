unit uMain;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, LuxandFaceCrop, StdCtrls, Buttons, ExtCtrls, Menus;

type
  TForm1 = class(TForm)
    Panel1: TPanel;
    imgSource: TImage;
    OpenDialog1: TOpenDialog;
    MainMenu1: TMainMenu;
    OpenFile1: TMenuItem;
    Exit1: TMenuItem;
    procedure FormCreate(Sender: TObject);
    procedure Exit1Click(Sender: TObject);
    procedure OpenFile1Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
    SourcePicture: TBitMap;
    Image1Handle: HBitmap;
  end;

var
  Form1: TForm1;

implementation

uses math;

{$R *.dfm}

procedure TForm1.FormCreate(Sender: TObject);
var
  LicenseKey: PChar;
  buf: array[0..4095] of char;
  r: integer;
begin
  {$IFNDEF DEBUG}
  Error: please request the evaluation license key from Luxand, Inc., comment these lines and assign the key to LicenseKey.
  Please visit http://www.luxand.com/facecrop/ to request the key
  {$ENDIF}

  LicenseKey := '';

  r := fcActivate(LicenseKey);

  if r = fcErrorNotActivated then
  begin
    Application.MessageBox('Error activating Luxand FaceCrop!', 'Error' );
    exit;
  end;

  SourcePicture := TBitMap.Create;
end;


procedure TForm1.Exit1Click(Sender: TObject);
begin
  Close
end;


procedure TForm1.OpenFile1Click(Sender: TObject);
var
  r: integer;
begin
  if OpenDialog1.Execute then
  begin
    r := fcFaceCrop_FileToHbitmap(PChar(OpenDialog1.FileName), @Image1Handle, imgSource.Width, imgSource.Height);

    if r = fcErrorOk then
    begin
      SourcePicture.Handle := Image1Handle;
      imgSource.Picture.Assign(SourcePicture);
    end
    else if r = fcErrorFaceNotFound then
      Application.MessageBox('Error: face not found', 'Error')
    else
      Application.MessageBox('Error: cannot open image', 'Error');


  end;

end;

end.
