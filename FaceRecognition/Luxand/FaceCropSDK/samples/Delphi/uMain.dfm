object Form1: TForm1
  Left = 201
  Top = 91
  Width = 300
  Height = 400
  Caption = 'Luxand FaceCrop Sample'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  Menu = MainMenu1
  OldCreateOrder = False
  OnCreate = FormCreate
  PixelsPerInch = 96
  TextHeight = 13
  object Panel1: TPanel
    Left = 0
    Top = 0
    Width = 292
    Height = 354
    Align = alClient
    TabOrder = 0
    object imgSource: TImage
      Left = 1
      Top = 1
      Width = 290
      Height = 352
      Align = alClient
      Proportional = True
    end
  end
  object OpenDialog1: TOpenDialog
    Left = 72
  end
  object MainMenu1: TMainMenu
    Left = 32
    object OpenFile1: TMenuItem
      Caption = 'Open File...'
      OnClick = OpenFile1Click
    end
    object Exit1: TMenuItem
      Caption = 'Exit'
      OnClick = Exit1Click
    end
  end
end
