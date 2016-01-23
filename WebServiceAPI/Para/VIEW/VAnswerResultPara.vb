
Imports System.Data.Linq 
Imports System.Data.Linq.Mapping 
Imports System.Linq 
Imports System.Linq.Expressions 

Namespace VIEW
    'Represents a transaction for v_answer_result view Parameter.
    '[Create by  on October, 24 2011]

    <Table(Name:="v_answer_result")>  _
    Public Class VAnswerResultPara

        'Generate Field List
        Dim _QUESTIONNAIRE_ID As Long = 0
        Dim _QUESTIONNAIRE_NAME As String = ""
        Dim _OBJECTIVE As  String  = ""
        Dim _QUESTION_DESC As  String  = ""
        Dim _SECTION_ID As Long = 0
        Dim _SECTION_NAME As  String  = ""
        Dim _SECTION_DESC As  String  = ""
        Dim _QUESTION_ID As Long = 0
        Dim _QUESTION_NAME As String = ""
        Dim _CHOICE_TYPE_ID As Long = 0
        Dim _CHOICE_TYPE_NAME As String = ""
        Dim _QUESTION_POINT As Double = 0
        Dim _IS_REQUIRE As Char = ""
        Dim _ANSWER_ID As Long = 0
        Dim _ANSWER_NAME As String = ""
        Dim _ANSWER_DATE As Date = New DateTime(1,1,1)
        Dim _ANSWER_RESULT_ID As Long = 0
        Dim _RESULT_CHOICE_NAME As String = ""
        Dim _RESULT_POINT As Double = 0

        'Generate Field Property 
        <Column(Storage:="_QUESTIONNAIRE_ID", DbType:="BigInt NOT NULL ",CanBeNull:=false)>  _
        Public Property QUESTIONNAIRE_ID() As Long
            Get
                Return _QUESTIONNAIRE_ID
            End Get
            Set(ByVal value As Long)
               _QUESTIONNAIRE_ID = value
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
        <Column(Storage:="_QUESTION_DESC", DbType:="VarChar(500)")>  _
        Public Property QUESTION_DESC() As  String 
            Get
                Return _QUESTION_DESC
            End Get
            Set(ByVal value As  String )
               _QUESTION_DESC = value
            End Set
        End Property 
        <Column(Storage:="_SECTION_ID", DbType:="BigInt NOT NULL ",CanBeNull:=false)>  _
        Public Property SECTION_ID() As Long
            Get
                Return _SECTION_ID
            End Get
            Set(ByVal value As Long)
               _SECTION_ID = value
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
        <Column(Storage:="_SECTION_DESC", DbType:="VarChar(500)")>  _
        Public Property SECTION_DESC() As  String 
            Get
                Return _SECTION_DESC
            End Get
            Set(ByVal value As  String )
               _SECTION_DESC = value
            End Set
        End Property 
        <Column(Storage:="_QUESTION_ID", DbType:="BigInt NOT NULL ",CanBeNull:=false)>  _
        Public Property QUESTION_ID() As Long
            Get
                Return _QUESTION_ID
            End Get
            Set(ByVal value As Long)
               _QUESTION_ID = value
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
        <Column(Storage:="_CHOICE_TYPE_ID", DbType:="BigInt NOT NULL ",CanBeNull:=false)>  _
        Public Property CHOICE_TYPE_ID() As Long
            Get
                Return _CHOICE_TYPE_ID
            End Get
            Set(ByVal value As Long)
               _CHOICE_TYPE_ID = value
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
        <Column(Storage:="_ANSWER_ID", DbType:="BigInt NOT NULL ",CanBeNull:=false)>  _
        Public Property ANSWER_ID() As Long
            Get
                Return _ANSWER_ID
            End Get
            Set(ByVal value As Long)
               _ANSWER_ID = value
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
        <Column(Storage:="_ANSWER_DATE", DbType:="Date NOT NULL ",CanBeNull:=false)>  _
        Public Property ANSWER_DATE() As Date
            Get
                Return _ANSWER_DATE
            End Get
            Set(ByVal value As Date)
               _ANSWER_DATE = value
            End Set
        End Property 
        <Column(Storage:="_ANSWER_RESULT_ID", DbType:="BigInt NOT NULL ",CanBeNull:=false)>  _
        Public Property ANSWER_RESULT_ID() As Long
            Get
                Return _ANSWER_RESULT_ID
            End Get
            Set(ByVal value As Long)
               _ANSWER_RESULT_ID = value
            End Set
        End Property 
        <Column(Storage:="_RESULT_CHOICE_NAME", DbType:="VarChar(255) NOT NULL ",CanBeNull:=false)>  _
        Public Property RESULT_CHOICE_NAME() As String
            Get
                Return _RESULT_CHOICE_NAME
            End Get
            Set(ByVal value As String)
               _RESULT_CHOICE_NAME = value
            End Set
        End Property 
        <Column(Storage:="_RESULT_POINT", DbType:="Double NOT NULL ",CanBeNull:=false)>  _
        Public Property RESULT_POINT() As Double
            Get
                Return _RESULT_POINT
            End Get
            Set(ByVal value As Double)
               _RESULT_POINT = value
            End Set
        End Property 


    End Class
End Namespace
