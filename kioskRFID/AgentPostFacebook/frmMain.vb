Imports Facebook
Imports System.IO
Imports System.Drawing.Imaging
Imports Newtonsoft.Json.Linq
Imports System.Configuration

Public Class frmMain


    Private _accessToken As String
    Public Property accessToken() As String
        Get
            Return _accessToken
        End Get
        Set(ByVal value As String)
            _accessToken = value
        End Set
    End Property
    Public Sub New()
        Dim frm As New frmFbLogin
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            accessToken = frm.accessToken
        End If
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 30000
        Timer1.Start()
        Timer2.Start()

        Try
            Dim t As New System.Threading.Thread(AddressOf PostImageToFB)
            t.Start()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False

        Dim IsFinish As Boolean = False
        Do While IsFinish = False
            PostImageToFB()

            Application.DoEvents()
            IsFinish = True
        Loop
        Timer1.Enabled = True
    End Sub

#Region "FaceBook"
    Private Sub PostImageToFB()
        Try
            Dim iniReader1 As New Org.Mentalis.Files.IniReader(Application.StartupPath & "\config.ini")

            'getfrompath = iniReader1.ReadString("Setting", "getfrompath")
            Dim webserviceurl As String
            webserviceurl = iniReader1.ReadString("Setting", "webserviceurl")

            Dim ws As New RFIDHERO2014WebServiceAPI.RFIDHERO2014WebServiceAPI
            ws.Url = webserviceurl

            Dim dt As New DataTable
            dt = ws.GetNewPersonalImageData()
            If dt.Rows.Count > 0 Then

                For i As Integer = 0 To dt.Rows.Count - 1
                    Try
                        'Dim path As String = dt.Rows(i)("image_file").ToString
                        'Dim buffer As Byte() = File.ReadAllBytes(path)
                        'Dim ms As New MemoryStream(buffer)

                        Dim id As String = dt.Rows(i)("id").ToString
                        Dim FileByte() As Byte
                        If Convert.IsDBNull(dt.Rows(i)("image_file")) = True Then
                            Continue For
                        End If

                        FileByte = DirectCast(dt.Rows(i)("image_file"), Byte())
                        Dim mediaObject As New FacebookMediaObject()
                        mediaObject.ContentType = "image/jpeg"
                        mediaObject.FileName = id & ".jpg"
                        mediaObject.SetValue(FileByte)
                        FileByte = Nothing

                        Dim fbParams As New Dictionary(Of String, Object)
                        fbParams("req_perms") = "publish_stream"
                        fbParams("scope") = "publish_stream"
                        fbParams("source") = mediaObject
                        Dim fbClient As New FacebookClient(GetPageAccessToken(Me.accessToken))
                        fbClient.PostAsync("/" + ConfigurationManager.AppSettings("pageId") + "/photos", fbParams)

                        ws.UpdateFacebookStatus(id)
                    Catch ex As Exception

                    End Try

                Next

            End If
        Catch ex As Exception
        End Try

    End Sub

    Public Shared Function GetPageAccessToken(ByVal userAccessToken As String) As String
        Try
            Dim fbClient As New FacebookClient(userAccessToken)
            fbClient.AppId = ConfigurationManager.AppSettings("appId").ToString()
            Dim fbParams As New Dictionary(Of String, Object)
            Dim publishedResponse As JsonObject = DirectCast(fbClient.Get("/me/accounts", fbParams), JsonObject)
            Dim data As JArray = JArray.Parse(publishedResponse("data").ToString())
            For Each account In data
                If (account("id") = ConfigurationManager.AppSettings("pageId")) Then
                    Return account("access_token")
                End If
            Next
        Catch ex As Exception

        End Try

        Return String.Empty
    End Function
#End Region

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        lbldate.Text = Now.Date.ToString("dd/MM/yyyy")
        lbltime.Text = Now.ToString("HH:mm:ss")
    End Sub
End Class
