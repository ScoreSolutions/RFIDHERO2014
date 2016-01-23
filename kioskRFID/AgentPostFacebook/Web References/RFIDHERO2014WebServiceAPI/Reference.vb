﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18408
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.18408.
'
Namespace RFIDHERO2014WebServiceAPI
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="RFIDHERO2014WebServiceAPISoap", [Namespace]:="http://tempuri.org/")>  _
    Partial Public Class RFIDHERO2014WebServiceAPI
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private SaveImageFileOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetImageFileOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetNewPersonalImageDataOperationCompleted As System.Threading.SendOrPostCallback
        
        Private UpdateFacebookStatusOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetPersonalImageForRecognitionOperationCompleted As System.Threading.SendOrPostCallback
        
        Private UpdateEBrochureStatusOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.AgentPostFacebook.My.MySettings.Default.WindowsApplication1_RFIDHERO2014WebServiceAPI_RFIDHERO2014WebServiceAPI
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = true
                Me.useDefaultCredentialsSetExplicitly = false
            Else
                Me.useDefaultCredentialsSetExplicitly = true
            End If
        End Sub
        
        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = true)  _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = false))  _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = false)) Then
                    MyBase.UseDefaultCredentials = false
                End If
                MyBase.Url = value
            End Set
        End Property
        
        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property
        
        '''<remarks/>
        Public Event SaveImageFileCompleted As SaveImageFileCompletedEventHandler
        
        '''<remarks/>
        Public Event GetImageFileCompleted As GetImageFileCompletedEventHandler
        
        '''<remarks/>
        Public Event GetNewPersonalImageDataCompleted As GetNewPersonalImageDataCompletedEventHandler
        
        '''<remarks/>
        Public Event UpdateFacebookStatusCompleted As UpdateFacebookStatusCompletedEventHandler
        
        '''<remarks/>
        Public Event GetPersonalImageForRecognitionCompleted As GetPersonalImageForRecognitionCompletedEventHandler
        
        '''<remarks/>
        Public Event UpdateEBrochureStatusCompleted As UpdateEBrochureStatusCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SaveImageFile", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function SaveImageFile(ByVal PersonalInfoID As Long, <System.Xml.Serialization.XmlElementAttribute(DataType:="base64Binary")> ByVal FileByte() As Byte) As Boolean
            Dim results() As Object = Me.Invoke("SaveImageFile", New Object() {PersonalInfoID, FileByte})
            Return CType(results(0),Boolean)
        End Function
        
        '''<remarks/>
        Public Overloads Sub SaveImageFileAsync(ByVal PersonalInfoID As Long, ByVal FileByte() As Byte)
            Me.SaveImageFileAsync(PersonalInfoID, FileByte, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SaveImageFileAsync(ByVal PersonalInfoID As Long, ByVal FileByte() As Byte, ByVal userState As Object)
            If (Me.SaveImageFileOperationCompleted Is Nothing) Then
                Me.SaveImageFileOperationCompleted = AddressOf Me.OnSaveImageFileOperationCompleted
            End If
            Me.InvokeAsync("SaveImageFile", New Object() {PersonalInfoID, FileByte}, Me.SaveImageFileOperationCompleted, userState)
        End Sub
        
        Private Sub OnSaveImageFileOperationCompleted(ByVal arg As Object)
            If (Not (Me.SaveImageFileCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SaveImageFileCompleted(Me, New SaveImageFileCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetImageFile", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetImageFile(ByVal PersonalInfoID As Long) As <System.Xml.Serialization.XmlElementAttribute(DataType:="base64Binary")> Byte()
            Dim results() As Object = Me.Invoke("GetImageFile", New Object() {PersonalInfoID})
            Return CType(results(0),Byte())
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetImageFileAsync(ByVal PersonalInfoID As Long)
            Me.GetImageFileAsync(PersonalInfoID, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetImageFileAsync(ByVal PersonalInfoID As Long, ByVal userState As Object)
            If (Me.GetImageFileOperationCompleted Is Nothing) Then
                Me.GetImageFileOperationCompleted = AddressOf Me.OnGetImageFileOperationCompleted
            End If
            Me.InvokeAsync("GetImageFile", New Object() {PersonalInfoID}, Me.GetImageFileOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetImageFileOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetImageFileCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetImageFileCompleted(Me, New GetImageFileCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetNewPersonalImageData", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetNewPersonalImageData() As System.Data.DataTable
            Dim results() As Object = Me.Invoke("GetNewPersonalImageData", New Object(-1) {})
            Return CType(results(0),System.Data.DataTable)
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetNewPersonalImageDataAsync()
            Me.GetNewPersonalImageDataAsync(Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetNewPersonalImageDataAsync(ByVal userState As Object)
            If (Me.GetNewPersonalImageDataOperationCompleted Is Nothing) Then
                Me.GetNewPersonalImageDataOperationCompleted = AddressOf Me.OnGetNewPersonalImageDataOperationCompleted
            End If
            Me.InvokeAsync("GetNewPersonalImageData", New Object(-1) {}, Me.GetNewPersonalImageDataOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetNewPersonalImageDataOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetNewPersonalImageDataCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetNewPersonalImageDataCompleted(Me, New GetNewPersonalImageDataCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UpdateFacebookStatus", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function UpdateFacebookStatus(ByVal PersonalInfoID As Long) As Boolean
            Dim results() As Object = Me.Invoke("UpdateFacebookStatus", New Object() {PersonalInfoID})
            Return CType(results(0),Boolean)
        End Function
        
        '''<remarks/>
        Public Overloads Sub UpdateFacebookStatusAsync(ByVal PersonalInfoID As Long)
            Me.UpdateFacebookStatusAsync(PersonalInfoID, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub UpdateFacebookStatusAsync(ByVal PersonalInfoID As Long, ByVal userState As Object)
            If (Me.UpdateFacebookStatusOperationCompleted Is Nothing) Then
                Me.UpdateFacebookStatusOperationCompleted = AddressOf Me.OnUpdateFacebookStatusOperationCompleted
            End If
            Me.InvokeAsync("UpdateFacebookStatus", New Object() {PersonalInfoID}, Me.UpdateFacebookStatusOperationCompleted, userState)
        End Sub
        
        Private Sub OnUpdateFacebookStatusOperationCompleted(ByVal arg As Object)
            If (Not (Me.UpdateFacebookStatusCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent UpdateFacebookStatusCompleted(Me, New UpdateFacebookStatusCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetPersonalImageForRecognition", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetPersonalImageForRecognition() As System.Data.DataTable
            Dim results() As Object = Me.Invoke("GetPersonalImageForRecognition", New Object(-1) {})
            Return CType(results(0),System.Data.DataTable)
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetPersonalImageForRecognitionAsync()
            Me.GetPersonalImageForRecognitionAsync(Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetPersonalImageForRecognitionAsync(ByVal userState As Object)
            If (Me.GetPersonalImageForRecognitionOperationCompleted Is Nothing) Then
                Me.GetPersonalImageForRecognitionOperationCompleted = AddressOf Me.OnGetPersonalImageForRecognitionOperationCompleted
            End If
            Me.InvokeAsync("GetPersonalImageForRecognition", New Object(-1) {}, Me.GetPersonalImageForRecognitionOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetPersonalImageForRecognitionOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetPersonalImageForRecognitionCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetPersonalImageForRecognitionCompleted(Me, New GetPersonalImageForRecognitionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UpdateEBrochureStatus", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function UpdateEBrochureStatus(ByVal PersonalInfoID As Long) As Boolean
            Dim results() As Object = Me.Invoke("UpdateEBrochureStatus", New Object() {PersonalInfoID})
            Return CType(results(0),Boolean)
        End Function
        
        '''<remarks/>
        Public Overloads Sub UpdateEBrochureStatusAsync(ByVal PersonalInfoID As Long)
            Me.UpdateEBrochureStatusAsync(PersonalInfoID, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub UpdateEBrochureStatusAsync(ByVal PersonalInfoID As Long, ByVal userState As Object)
            If (Me.UpdateEBrochureStatusOperationCompleted Is Nothing) Then
                Me.UpdateEBrochureStatusOperationCompleted = AddressOf Me.OnUpdateEBrochureStatusOperationCompleted
            End If
            Me.InvokeAsync("UpdateEBrochureStatus", New Object() {PersonalInfoID}, Me.UpdateEBrochureStatusOperationCompleted, userState)
        End Sub
        
        Private Sub OnUpdateEBrochureStatusOperationCompleted(ByVal arg As Object)
            If (Not (Me.UpdateEBrochureStatusCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent UpdateEBrochureStatusCompleted(Me, New UpdateEBrochureStatusCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
        
        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing)  _
                        OrElse (url Is String.Empty)) Then
                Return false
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024)  _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return true
            End If
            Return false
        End Function
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")>  _
    Public Delegate Sub SaveImageFileCompletedEventHandler(ByVal sender As Object, ByVal e As SaveImageFileCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class SaveImageFileCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Boolean
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Boolean)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")>  _
    Public Delegate Sub GetImageFileCompletedEventHandler(ByVal sender As Object, ByVal e As GetImageFileCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class GetImageFileCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Byte()
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Byte())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")>  _
    Public Delegate Sub GetNewPersonalImageDataCompletedEventHandler(ByVal sender As Object, ByVal e As GetNewPersonalImageDataCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class GetNewPersonalImageDataCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As System.Data.DataTable
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),System.Data.DataTable)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")>  _
    Public Delegate Sub UpdateFacebookStatusCompletedEventHandler(ByVal sender As Object, ByVal e As UpdateFacebookStatusCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class UpdateFacebookStatusCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Boolean
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Boolean)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")>  _
    Public Delegate Sub GetPersonalImageForRecognitionCompletedEventHandler(ByVal sender As Object, ByVal e As GetPersonalImageForRecognitionCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class GetPersonalImageForRecognitionCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As System.Data.DataTable
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),System.Data.DataTable)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")>  _
    Public Delegate Sub UpdateEBrochureStatusCompletedEventHandler(ByVal sender As Object, ByVal e As UpdateEBrochureStatusCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class UpdateEBrochureStatusCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Boolean
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Boolean)
            End Get
        End Property
    End Class
End Namespace
