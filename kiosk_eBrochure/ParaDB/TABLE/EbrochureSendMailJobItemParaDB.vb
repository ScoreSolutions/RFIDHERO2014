
Imports System.Data.Linq 
Imports System.Data.Linq.Mapping 
Imports System.Linq 
Imports System.Linq.Expressions 

Namespace TABLE
    'Represents a transaction for eBROCHURE_SEND_MAIL_JOB_ITEM table Parameter.
    '[Create by  on October, 31 2014]

    <Table(Name:="eBROCHURE_SEND_MAIL_JOB_ITEM")>  _
    Public Class EbrochureSendMailJobItemParaDB

        'Generate Field List
        Dim _ID As Long = 0
        Dim _CREATE_BY As String = ""
        Dim _CREATE_ON As DateTime = New DateTime(1,1,1)
        Dim _UPDATE_BY As  String  = ""
        Dim _UPDATE_ON As  System.Nullable(Of DateTime)  = New DateTime(1,1,1)
        Dim _EBROCHURE_SEND_MAIL_JOB_ID As Long = 0
        Dim _EBROCHURE_ID As Long = 0

        'Generate Field Property 
        <Column(Storage:="_ID", DbType:="BigInt NOT NULL ",CanBeNull:=false)>  _
        Public Property ID() As Long
            Get
                Return _ID
            End Get
            Set(ByVal value As Long)
               _ID = value
            End Set
        End Property 
        <Column(Storage:="_CREATE_BY", DbType:="VarChar(100) NOT NULL ",CanBeNull:=false)>  _
        Public Property CREATE_BY() As String
            Get
                Return _CREATE_BY
            End Get
            Set(ByVal value As String)
               _CREATE_BY = value
            End Set
        End Property 
        <Column(Storage:="_CREATE_ON", DbType:="DateTime NOT NULL ",CanBeNull:=false)>  _
        Public Property CREATE_ON() As DateTime
            Get
                Return _CREATE_ON
            End Get
            Set(ByVal value As DateTime)
               _CREATE_ON = value
            End Set
        End Property 
        <Column(Storage:="_UPDATE_BY", DbType:="VarChar(100)")>  _
        Public Property UPDATE_BY() As  String 
            Get
                Return _UPDATE_BY
            End Get
            Set(ByVal value As  String )
               _UPDATE_BY = value
            End Set
        End Property 
        <Column(Storage:="_UPDATE_ON", DbType:="DateTime")>  _
        Public Property UPDATE_ON() As  System.Nullable(Of DateTime) 
            Get
                Return _UPDATE_ON
            End Get
            Set(ByVal value As  System.Nullable(Of DateTime) )
               _UPDATE_ON = value
            End Set
        End Property 
        <Column(Storage:="_EBROCHURE_SEND_MAIL_JOB_ID", DbType:="BigInt NOT NULL ",CanBeNull:=false)>  _
        Public Property EBROCHURE_SEND_MAIL_JOB_ID() As Long
            Get
                Return _EBROCHURE_SEND_MAIL_JOB_ID
            End Get
            Set(ByVal value As Long)
               _EBROCHURE_SEND_MAIL_JOB_ID = value
            End Set
        End Property 
        <Column(Storage:="_EBROCHURE_ID", DbType:="BigInt NOT NULL ",CanBeNull:=false)>  _
        Public Property EBROCHURE_ID() As Long
            Get
                Return _EBROCHURE_ID
            End Get
            Set(ByVal value As Long)
               _EBROCHURE_ID = value
            End Set
        End Property 


    End Class
End Namespace
