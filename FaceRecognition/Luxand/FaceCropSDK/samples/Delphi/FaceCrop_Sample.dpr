program FaceCrop_Sample;

uses
  Forms,
  uMain in 'uMain.pas' {Form1},
  LuxandFaceCrop in 'LuxandFaceCrop.pas';

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TForm1, Form1);
  Application.Run;
end.
