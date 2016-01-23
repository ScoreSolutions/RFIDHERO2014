
Imports System.Data.Linq 
Imports System.Data.Linq.Mapping 
Imports System.Linq 
Imports System.Linq.Expressions 

Namespace TABLE
    'Represents a transaction for ANSWER table Parameter.
    '[Create by  on October, 24 2011]

    <Table(Name:="ANSWER")>  _
    Public Class AnswerPara

        'Generate Field List
        Dim _ID As Long = 0
        Dim _CREATE_BY As String = ""
        Dim _CREATE_ON As DateTime = New DateTime(1,1,1)
        Dim _UPDATE_BY As  String  = ""
        Dim _UPDATE_ON As  System.Nullable(Of DateTime)  = New DateTime(1,1,1)
        Dim _QUESTIONNAIRE_ID As Long = 0
        Dim _ANSWER_DATE As Date = New DateTime(1,1,1)
        Dim _ANSWER_NAME As String = ""
        Dim _SESSION_ID As String = ""

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
        <Column(Storage:="_QUESTIONNAIRE_ID", DbType:="BigInt NOT NULL ",CanBeNull:=false)>  _
        Public Property QUESTIONNAIRE_ID() As Long
            Get
                Return _QUESTIONNAIRE_ID
            End Get
            Set(ByVal value As Long)
               _QUESTIONNAIRE_ID = value
            End Set
        End Property 
        <Column(Storage:="_ANSWER_DATE", DbType:="Date NOT NULL ",CanBeNull:=false)>  _
        Public Property ANSWER_DATE() As Date
            Get
                Return _ANSWER_DATE
            End Get
            Set(ByVal value As Date)
               _ANSWER_DATE = value
            End Set
        End Property 
        <Column(Storage:="_ANSWER_NAME", DbType:="VarChar(255) NOT NULL ",CanBeNull:=false)>  _
        Public Property ANSWER_NAME() As String
            Get
                Return _ANSWER_NAME
            End Get
            Set(ByVal value As String)
               _ANSWER_NAME = value
            End Set
        End Property 
        <Column(Storage:="_SESSION_ID", DbType:="VarChar(500) NOT NULL ",CanBeNull:=false)>  _
        Public Property SESSION_ID() As String
            Get
                Return _SESSION_ID
            End Get
            Set(ByVal value As String)
               _SESSION_ID = value
            End Set
        End Property 


            'Define Child Table 

       Dim _ANSWER_RESULT_answer_id As DataTable

       Public Property CHILD_ANSWER_RESULT_answer_id() As DataTable
           Get
               Return _ANSWER_RESULT_answer_id
           End Get
           Set(ByVal value As DataTable)
               _ANSWER_RESULT_answer_id = value
           End Set
       End Property
    End Class
End Namespace
