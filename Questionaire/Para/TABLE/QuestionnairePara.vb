
Imports System.Data.Linq 
Imports System.Data.Linq.Mapping 
Imports System.Linq 
Imports System.Linq.Expressions 

Namespace TABLE
    'Represents a transaction for QUESTIONNAIRE table Parameter.
    '[Create by  on October, 24 2011]

    <Table(Name:="QUESTIONNAIRE")>  _
    Public Class QuestionnairePara

        'Generate Field List
        Dim _ID As Long = 0
        Dim _CREATE_BY As String = ""
        Dim _CREATE_ON As DateTime = New DateTime(1,1,1)
        Dim _UPDATE_BY As  String  = ""
        Dim _UPDATE_ON As  System.Nullable(Of DateTime)  = New DateTime(1,1,1)
        Dim _QUESTIONNAIRE_NAME As String = ""
        Dim _OBJECTIVE As  String  = ""
        Dim _DESCRIPTION As  String  = ""
        Dim _ACTIVE As  System.Nullable(Of Char)  = ""

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
        <Column(Storage:="_CREATE_BY", DbType:="VarChar(50) NOT NULL ",CanBeNull:=false)>  _
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
        <Column(Storage:="_UPDATE_BY", DbType:="VarChar(50)")>  _
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
        <Column(Storage:="_QUESTIONNAIRE_NAME", DbType:="VarChar(255) NOT NULL ",CanBeNull:=false)>  _
        Public Property QUESTIONNAIRE_NAME() As String
            Get
                Return _QUESTIONNAIRE_NAME
            End Get
            Set(ByVal value As String)
               _QUESTIONNAIRE_NAME = value
            End Set
        End Property 
        <Column(Storage:="_OBJECTIVE", DbType:="VarChar(500)")>  _
        Public Property OBJECTIVE() As  String 
            Get
                Return _OBJECTIVE
            End Get
            Set(ByVal value As  String )
               _OBJECTIVE = value
            End Set
        End Property 
        <Column(Storage:="_DESCRIPTION", DbType:="VarChar(500)")>  _
        Public Property DESCRIPTION() As  String 
            Get
                Return _DESCRIPTION
            End Get
            Set(ByVal value As  String )
               _DESCRIPTION = value
            End Set
        End Property 
        <Column(Storage:="_ACTIVE", DbType:="Char(1)")>  _
        Public Property ACTIVE() As  System.Nullable(Of Char) 
            Get
                Return _ACTIVE
            End Get
            Set(ByVal value As  System.Nullable(Of Char) )
               _ACTIVE = value
            End Set
        End Property 


            'Define Child Table 

       Dim _ANSWER_questionnaire_id As DataTable
       Dim _QUESTIONNAIRE_SECTION_questionnaire_id As DataTable

       Public Property CHILD_ANSWER_questionnaire_id() As DataTable
           Get
               Return _ANSWER_questionnaire_id
           End Get
           Set(ByVal value As DataTable)
               _ANSWER_questionnaire_id = value
           End Set
       End Property
       Public Property CHILD_QUESTIONNAIRE_SECTION_questionnaire_id() As DataTable
           Get
               Return _QUESTIONNAIRE_SECTION_questionnaire_id
           End Get
           Set(ByVal value As DataTable)
               _QUESTIONNAIRE_SECTION_questionnaire_id = value
           End Set
       End Property
    End Class
End Namespace
