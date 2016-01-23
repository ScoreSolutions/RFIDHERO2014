
Imports System.Data.Linq 
Imports System.Data.Linq.Mapping 
Imports System.Linq 
Imports System.Linq.Expressions 

Namespace TABLE
    'Represents a transaction for QUESTIONNAIRE_QUESTIONS_CHOICE table Parameter.
    '[Create by  on October, 24 2011]

    <Table(Name:="QUESTIONNAIRE_QUESTIONS_CHOICE")>  _
    Public Class QuestionnaireQuestionsChoicePara

        'Generate Field List
        Dim _ID As Long = 0
        Dim _CREATE_BY As String = ""
        Dim _CREATE_ON As DateTime = New DateTime(1,1,1)
        Dim _UPDATE_BY As  String  = ""
        Dim _UPDATE_ON As  System.Nullable(Of DateTime)  = New DateTime(1,1,1)
        Dim _QUESTIONNAIRE_QUESTIONS_ID As Long = 0
        Dim _CHOICE_NAME As String = ""
        Dim _IS_DEFAULT As Char = ""
        Dim _POINT As Double = 0
        Dim _IS_OTHER As Char = ""

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
        <Column(Storage:="_QUESTIONNAIRE_QUESTIONS_ID", DbType:="BigInt NOT NULL ",CanBeNull:=false)>  _
        Public Property QUESTIONNAIRE_QUESTIONS_ID() As Long
            Get
                Return _QUESTIONNAIRE_QUESTIONS_ID
            End Get
            Set(ByVal value As Long)
               _QUESTIONNAIRE_QUESTIONS_ID = value
            End Set
        End Property 
        <Column(Storage:="_CHOICE_NAME", DbType:="VarChar(255) NOT NULL ",CanBeNull:=false)>  _
        Public Property CHOICE_NAME() As String
            Get
                Return _CHOICE_NAME
            End Get
            Set(ByVal value As String)
               _CHOICE_NAME = value
            End Set
        End Property 
        <Column(Storage:="_IS_DEFAULT", DbType:="Char(1) NOT NULL ",CanBeNull:=false)>  _
        Public Property IS_DEFAULT() As Char
            Get
                Return _IS_DEFAULT
            End Get
            Set(ByVal value As Char)
               _IS_DEFAULT = value
            End Set
        End Property 
        <Column(Storage:="_POINT", DbType:="Double NOT NULL ",CanBeNull:=false)>  _
        Public Property POINT() As Double
            Get
                Return _POINT
            End Get
            Set(ByVal value As Double)
               _POINT = value
            End Set
        End Property 
        <Column(Storage:="_IS_OTHER", DbType:="Char(1) NOT NULL ",CanBeNull:=false)>  _
        Public Property IS_OTHER() As Char
            Get
                Return _IS_OTHER
            End Get
            Set(ByVal value As Char)
               _IS_OTHER = value
            End Set
        End Property 


    End Class
End Namespace
