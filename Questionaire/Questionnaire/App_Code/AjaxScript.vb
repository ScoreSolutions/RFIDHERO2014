Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports Para.Common.Utilities
Imports Para.Common

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
<System.Web.Script.Services.ScriptService()> _
<WebService(Namespace:="http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class AjaxScript
    Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function GetTextAutoComplete(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
        Dim result() As String = {}
        Dim tbFld() As String = Split(contextKey, "#")
        If tbFld(0) <> "DEFAULT" And tbFld(1) <> "DEFAULT" Then
            Dim fnc As New Engine.Questionnaire.RegisterENG
            result = fnc.GetAutoCompleteList(tbFld(0), tbFld(1), prefixText)
            fnc = Nothing
        End If
        Return result
    End Function

    '<WebMethod()> _
    'Public Sub SaveTransLog(ByVal TransDesc As String)
    '    Config.SaveTransLog(TransDesc)
    'End Sub

End Class
