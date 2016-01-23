
Imports System.Data.Linq 
Imports System.Data.Linq.Mapping 
Imports System.Linq 
Imports System.Linq.Expressions 

Namespace TABLE
    'Represents a transaction for ERM_TS_INTEREST table Parameter.
    '[Create by  on September, 19 2013]

    <Table(Name:="ERM_TS_INTEREST")>  _
    Public Class ErmTsInterestPara

        'Generate Field List
        Dim _ID As Long = 0
        Dim _CREATE_BY As String = ""
        Dim _CREATE_ON As DateTime = New DateTime(1,1,1)
        Dim _UPDATE_BY As  String  = ""
        Dim _UPDATE_ON As  System.Nullable(Of DateTime)  = New DateTime(1,1,1)
        Dim _ERM_TS_PERSONAL_INFO_ID As Long = 0
        Dim _INTEREST_CODE As String = ""
        Dim _INTEREST_NAME As String = ""

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
        <Column(Storage:="_ERM_TS_PERSONAL_INFO_ID", DbType:="BigInt NOT NULL ",CanBeNull:=false)>  _
        Public Property ERM_TS_PERSONAL_INFO_ID() As Long
            Get
                Return _ERM_TS_PERSONAL_INFO_ID
            End Get
            Set(ByVal value As Long)
               _ERM_TS_PERSONAL_INFO_ID = value
            End Set
        End Property 
        <Column(Storage:="_INTEREST_CODE", DbType:="VarChar(50) NOT NULL ",CanBeNull:=false)>  _
        Public Property INTEREST_CODE() As String
            Get
                Return _INTEREST_CODE
            End Get
            Set(ByVal value As String)
               _INTEREST_CODE = value
            End Set
        End Property 
        <Column(Storage:="_INTEREST_NAME", DbType:="VarChar(255) NOT NULL ",CanBeNull:=false)>  _
        Public Property INTEREST_NAME() As String
            Get
                Return _INTEREST_NAME
            End Get
            Set(ByVal value As String)
               _INTEREST_NAME = value
            End Set
        End Property 


    End Class
End Namespace
