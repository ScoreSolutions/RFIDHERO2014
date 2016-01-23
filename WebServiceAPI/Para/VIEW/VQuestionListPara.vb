
Imports System.Data.Linq 
Imports System.Data.Linq.Mapping 
Imports System.Linq 
Imports System.Linq.Expressions 

Namespace VIEW
    'Represents a transaction for v_question_list view Parameter.
    '[Create by  on October, 24 2011]

    <Table(Name:="v_question_list")>  _
    Public Class VQuestionListPara

        'Generate Field List
        Dim _ID As Long = 0
        Dim _QUESTIONNAIRE_SECTION_ID As Long = 0
        Dim _SECTION_NAME As  String  = ""
        Dim _QUESTIONNAIRE_QUESTION_ID As Long = 0
        Dim _QUESTION_NAME As String = ""
        Dim _CHOICE_TYPE_NAME As String = ""
        Dim _QUESTION_POINT As Double = 0
        Dim _IS_REQUIRE As Char = ""

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
        <Column(Storage:="_QUESTIONNAIRE_SECTION_ID", DbType:="BigInt NOT NULL ",CanBeNull:=false)>  _
        Public Property QUESTIONNAIRE_SECTION_ID() As Long
            Get
                Return _QUESTIONNAIRE_SECTION_ID
            End Get
            Set(ByVal value As Long)
               _QUESTIONNAIRE_SECTION_ID = value
            End Set
        End Property 
        <Column(Storage:="_SECTION_NAME", DbType:="VarChar(255)")>  _
        Public Property SECTION_NAME() As  String 
            Get
                Return _SECTION_NAME
            End Get
            Set(ByVal value As  String )
               _SECTION_NAME = value
            End Set
        End Property 
        <Column(Storage:="_QUESTIONNAIRE_QUESTION_ID", DbType:="BigInt NOT NULL ",CanBeNull:=false)>  _
        Public Property QUESTIONNAIRE_QUESTION_ID() As Long
            Get
                Return _QUESTIONNAIRE_QUESTION_ID
            End Get
            Set(ByVal value As Long)
               _QUESTIONNAIRE_QUESTION_ID = value
            End Set
        End Property 
        <Column(Storage:="_QUESTION_NAME", DbType:="VarChar(255) NOT NULL ",CanBeNull:=false)>  _
        Public Property QUESTION_NAME() As String
            Get
                Return _QUESTION_NAME
            End Get
            Set(ByVal value As String)
               _QUESTION_NAME = value
            End Set
        End Property 
        <Column(Storage:="_CHOICE_TYPE_NAME", DbType:="VarChar(255) NOT NULL ",CanBeNull:=false)>  _
        Public Property CHOICE_TYPE_NAME() As String
            Get
                Return _CHOICE_TYPE_NAME
            End Get
            Set(ByVal value As String)
               _CHOICE_TYPE_NAME = value
            End Set
        End Property 
        <Column(Storage:="_QUESTION_POINT", DbType:="Double NOT NULL ",CanBeNull:=false)>  _
        Public Property QUESTION_POINT() As Double
            Get
                Return _QUESTION_POINT
            End Get
            Set(ByVal value As Double)
               _QUESTION_POINT = value
            End Set
        End Property 
        <Column(Storage:="_IS_REQUIRE", DbType:="Char(1) NOT NULL ",CanBeNull:=false)>  _
        Public Property IS_REQUIRE() As Char
            Get
                Return _IS_REQUIRE
            End Get
            Set(ByVal value As Char)
               _IS_REQUIRE = value
            End Set
        End Property 


    End Class
End Namespace
