
Imports System.Data.Linq 
Imports System.Data.Linq.Mapping 
Imports System.Linq 
Imports System.Linq.Expressions 

Namespace TABLE
    'Represents a transaction for ERM_TS_PERSONAL_INFO table Parameter.
    '[Create by  on November, 11 2014]

    <Table(Name:="ERM_TS_PERSONAL_INFO")>  _
    Public Class ErmTsPersonalInfoPara

        'Generate Field List
        Dim _ID As Long = 0
        Dim _CREATE_BY As String = ""
        Dim _CREATE_ON As DateTime = New DateTime(1,1,1)
        Dim _UPDATE_BY As  String  = ""
        Dim _UPDATE_ON As  System.Nullable(Of DateTime)  = New DateTime(1,1,1)
        Dim _IDCARD_NO As  String  = ""
        Dim _TITLE_NAME As  String  = ""
        Dim _FIRST_NAME As  String  = ""
        Dim _MIDDLE_NAME As  String  = ""
        Dim _LAST_NAME As  String  = ""
        Dim _POSITION_NAME As  String  = ""
        Dim _COMPANY_NAME As  String  = ""
        Dim _ADDRESS As  String  = ""
        Dim _CITY As  String  = ""
        Dim _STATE As  String  = ""
        Dim _COUNTRY As  String  = ""
        Dim _ZIPCODE As  String  = ""
        Dim _TELNO As  String  = ""
        Dim _FAXNO As  String  = ""
        Dim _EMAIL As  String  = ""
        Dim _WEBSITE As  String  = ""
        Dim _REGISTERED_CAPITAL As  System.Nullable(Of Double)  = 0
        Dim _ANNUAL_SALE_VALUE_YEAR As  System.Nullable(Of Long)  = 0
        Dim _ANNUAL_SALE_VALUE_VOLUMNS As  String  = ""
        Dim _DIVISION As  String  = ""
        Dim _MOBILE_NO As  String  = ""
        Dim _REGISPERIOD As  String  = ""
        Dim _IS_SEND_MAIL As String = ""
        Dim _IMAGE_PATH As  String  = ""
        Dim _IS_POST_FACEBOOK As Char = "0"
        Dim _IMAGE_PATH_NOLOGO As  String  = ""

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
        <Column(Storage:="_IDCARD_NO", DbType:="VarChar(13)")>  _
        Public Property IDCARD_NO() As  String 
            Get
                Return _IDCARD_NO
            End Get
            Set(ByVal value As  String )
               _IDCARD_NO = value
            End Set
        End Property 
        <Column(Storage:="_TITLE_NAME", DbType:="VarChar(255)")>  _
        Public Property TITLE_NAME() As  String 
            Get
                Return _TITLE_NAME
            End Get
            Set(ByVal value As  String )
               _TITLE_NAME = value
            End Set
        End Property 
        <Column(Storage:="_FIRST_NAME", DbType:="VarChar(255)")>  _
        Public Property FIRST_NAME() As  String 
            Get
                Return _FIRST_NAME
            End Get
            Set(ByVal value As  String )
               _FIRST_NAME = value
            End Set
        End Property 
        <Column(Storage:="_MIDDLE_NAME", DbType:="VarChar(255)")>  _
        Public Property MIDDLE_NAME() As  String 
            Get
                Return _MIDDLE_NAME
            End Get
            Set(ByVal value As  String )
               _MIDDLE_NAME = value
            End Set
        End Property 
        <Column(Storage:="_LAST_NAME", DbType:="VarChar(255)")>  _
        Public Property LAST_NAME() As  String 
            Get
                Return _LAST_NAME
            End Get
            Set(ByVal value As  String )
               _LAST_NAME = value
            End Set
        End Property 
        <Column(Storage:="_POSITION_NAME", DbType:="VarChar(255)")>  _
        Public Property POSITION_NAME() As  String 
            Get
                Return _POSITION_NAME
            End Get
            Set(ByVal value As  String )
               _POSITION_NAME = value
            End Set
        End Property 
        <Column(Storage:="_COMPANY_NAME", DbType:="VarChar(255)")>  _
        Public Property COMPANY_NAME() As  String 
            Get
                Return _COMPANY_NAME
            End Get
            Set(ByVal value As  String )
               _COMPANY_NAME = value
            End Set
        End Property 
        <Column(Storage:="_ADDRESS", DbType:="VarChar(255)")>  _
        Public Property ADDRESS() As  String 
            Get
                Return _ADDRESS
            End Get
            Set(ByVal value As  String )
               _ADDRESS = value
            End Set
        End Property 
        <Column(Storage:="_CITY", DbType:="VarChar(255)")>  _
        Public Property CITY() As  String 
            Get
                Return _CITY
            End Get
            Set(ByVal value As  String )
               _CITY = value
            End Set
        End Property 
        <Column(Storage:="_STATE", DbType:="VarChar(255)")>  _
        Public Property STATE() As  String 
            Get
                Return _STATE
            End Get
            Set(ByVal value As  String )
               _STATE = value
            End Set
        End Property 
        <Column(Storage:="_COUNTRY", DbType:="VarChar(255)")>  _
        Public Property COUNTRY() As  String 
            Get
                Return _COUNTRY
            End Get
            Set(ByVal value As  String )
               _COUNTRY = value
            End Set
        End Property 
        <Column(Storage:="_ZIPCODE", DbType:="VarChar(50)")>  _
        Public Property ZIPCODE() As  String 
            Get
                Return _ZIPCODE
            End Get
            Set(ByVal value As  String )
               _ZIPCODE = value
            End Set
        End Property 
        <Column(Storage:="_TELNO", DbType:="VarChar(255)")>  _
        Public Property TELNO() As  String 
            Get
                Return _TELNO
            End Get
            Set(ByVal value As  String )
               _TELNO = value
            End Set
        End Property 
        <Column(Storage:="_FAXNO", DbType:="VarChar(255)")>  _
        Public Property FAXNO() As  String 
            Get
                Return _FAXNO
            End Get
            Set(ByVal value As  String )
               _FAXNO = value
            End Set
        End Property 
        <Column(Storage:="_EMAIL", DbType:="VarChar(255)")>  _
        Public Property EMAIL() As  String 
            Get
                Return _EMAIL
            End Get
            Set(ByVal value As  String )
               _EMAIL = value
            End Set
        End Property 
        <Column(Storage:="_WEBSITE", DbType:="VarChar(255)")>  _
        Public Property WEBSITE() As  String 
            Get
                Return _WEBSITE
            End Get
            Set(ByVal value As  String )
               _WEBSITE = value
            End Set
        End Property 
        <Column(Storage:="_REGISTERED_CAPITAL", DbType:="Double")>  _
        Public Property REGISTERED_CAPITAL() As  System.Nullable(Of Double) 
            Get
                Return _REGISTERED_CAPITAL
            End Get
            Set(ByVal value As  System.Nullable(Of Double) )
               _REGISTERED_CAPITAL = value
            End Set
        End Property 
        <Column(Storage:="_ANNUAL_SALE_VALUE_YEAR", DbType:="Int")>  _
        Public Property ANNUAL_SALE_VALUE_YEAR() As  System.Nullable(Of Long) 
            Get
                Return _ANNUAL_SALE_VALUE_YEAR
            End Get
            Set(ByVal value As  System.Nullable(Of Long) )
               _ANNUAL_SALE_VALUE_YEAR = value
            End Set
        End Property 
        <Column(Storage:="_ANNUAL_SALE_VALUE_VOLUMNS", DbType:="VarChar(50)")>  _
        Public Property ANNUAL_SALE_VALUE_VOLUMNS() As  String 
            Get
                Return _ANNUAL_SALE_VALUE_VOLUMNS
            End Get
            Set(ByVal value As  String )
               _ANNUAL_SALE_VALUE_VOLUMNS = value
            End Set
        End Property 
        <Column(Storage:="_DIVISION", DbType:="VarChar(255)")>  _
        Public Property DIVISION() As  String 
            Get
                Return _DIVISION
            End Get
            Set(ByVal value As  String )
               _DIVISION = value
            End Set
        End Property 
        <Column(Storage:="_MOBILE_NO", DbType:="VarChar(255)")>  _
        Public Property MOBILE_NO() As  String 
            Get
                Return _MOBILE_NO
            End Get
            Set(ByVal value As  String )
               _MOBILE_NO = value
            End Set
        End Property 
        <Column(Storage:="_REGISPERIOD", DbType:="VarChar(1)")>  _
        Public Property REGISPERIOD() As  String 
            Get
                Return _REGISPERIOD
            End Get
            Set(ByVal value As  String )
               _REGISPERIOD = value
            End Set
        End Property 
        <Column(Storage:="_IS_SEND_MAIL", DbType:="VarChar(1) NOT NULL ",CanBeNull:=false)>  _
        Public Property IS_SEND_MAIL() As String
            Get
                Return _IS_SEND_MAIL
            End Get
            Set(ByVal value As String)
               _IS_SEND_MAIL = value
            End Set
        End Property 
        <Column(Storage:="_IMAGE_PATH", DbType:="VarChar(500)")>  _
        Public Property IMAGE_PATH() As  String 
            Get
                Return _IMAGE_PATH
            End Get
            Set(ByVal value As  String )
               _IMAGE_PATH = value
            End Set
        End Property 
        <Column(Storage:="_IS_POST_FACEBOOK", DbType:="Char(1) NOT NULL ",CanBeNull:=false)>  _
        Public Property IS_POST_FACEBOOK() As Char
            Get
                Return _IS_POST_FACEBOOK
            End Get
            Set(ByVal value As Char)
               _IS_POST_FACEBOOK = value
            End Set
        End Property 
        <Column(Storage:="_IMAGE_PATH_NOLOGO", DbType:="VarChar(500)")>  _
        Public Property IMAGE_PATH_NOLOGO() As  String 
            Get
                Return _IMAGE_PATH_NOLOGO
            End Get
            Set(ByVal value As  String )
               _IMAGE_PATH_NOLOGO = value
            End Set
        End Property 


    End Class
End Namespace
