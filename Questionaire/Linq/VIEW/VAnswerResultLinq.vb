Imports System
Imports System.Data 
Imports System.Data.SQLClient
Imports System.Data.Linq 
Imports System.Data.Linq.Mapping 
Imports System.Linq 
Imports System.Linq.Expressions 
Imports DB = Linq.Common.Utilities.SQLDB
Imports Para.VIEW
Imports Para.Common.Utilities

Namespace VIEW
    'Represents a transaction for v_answer_result view Linq.
    '[Create by  on October, 24 2011]
    Public Class VAnswerResultLinq
        Public sub VAnswerResultLinq()

        End Sub 
        ' v_answer_result
        Const _viewName As String = "v_answer_result"

        'Set Common Property
        Dim _error As String = ""
        Dim _information As String = ""
        Dim _haveData As Boolean = False

        Public ReadOnly Property ViewName As String
            Get
                Return _viewName
            End Get
        End Property
        Public ReadOnly Property ErrorMessage As String
            Get
                Return _error
            End Get
        End Property
        Public ReadOnly Property InfoMessage As String
            Get
                Return _information
            End Get
        End Property
        Public ReadOnly Property HaveData As Boolean
            Get
                Return _haveData
            End Get
        End Property


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


        'Clear All Data
        Private Sub ClearData()
            _QUESTIONNAIRE_ID = 0
            _QUESTIONNAIRE_NAME = ""
            _OBJECTIVE = ""
            _QUESTION_DESC = ""
            _SECTION_ID = 0
            _SECTION_NAME = ""
            _SECTION_DESC = ""
            _QUESTION_ID = 0
            _QUESTION_NAME = ""
            _CHOICE_TYPE_ID = 0
            _CHOICE_TYPE_NAME = ""
            _QUESTION_POINT = 0
            _IS_REQUIRE = ""
            _ANSWER_ID = 0
            _ANSWER_NAME = ""
            _ANSWER_DATE = New DateTime(1,1,1)
            _ANSWER_RESULT_ID = 0
            _RESULT_CHOICE_NAME = ""
            _RESULT_POINT = 0
        End Sub

       'Define Public Method 
        'Execute the select statement with the specified condition and return a System.Data.DataTable.
        '/// <param name=whereClause>The condition for execute select statement.</param>
        '/// <param name=orderBy>The fields for sort data.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>The System.Data.DataTable object for specified condition.</returns>
        Public Function GetDataList(whClause As String, orderBy As String, trans As SQLTransaction) As DataTable
            Return DB.ExecuteTable(SqlSelect & IIf(whClause = "", "", " WHERE " & whClause) & IIF(orderBy = "", "", " ORDER BY  " & orderBy), trans)
        End Function


        'Execute the select statement with the specified condition and return a System.Data.DataTable.
        '/// <param name=whereClause>The condition for execute select statement.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>The System.Data.DataTable object for specified condition.</returns>
        Public Function GetListBySql(Sql As String, trans As SQLTransaction) As DataTable
            Return DB.ExecuteTable(Sql, trans)
        End Function


        '/// Returns an indication whether the record of v_answer_result by specified condition is retrieved successfully.
        '/// <param name=whText>The condition specify the deleting record(s).</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Public Function ChkDataByWhere(whText As String, trans As SQLTransaction) As Boolean
            Return doChkData(whText, trans)
        End Function



        '/// Returns an indication whether the record of v_answer_result by specified condition is retrieved successfully.
        '/// <param name=whText>The condition specify the deleting record(s).</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Private Function doChkData(whText As String, trans As SQLTransaction) As Boolean
            Dim ret As Boolean = True
            ClearData()
            _haveData  = False
            If whText.Trim() <> "" Then
                Dim tmpWhere As String = " WHERE " & whText
                Dim Rdr As SQLDataReader
                Try
                    Rdr = DB.ExecuteReader(SqlSelect() & tmpWhere, trans)
                    If Rdr.Read() Then
                        _haveData = True
                        If Convert.IsDBNull(Rdr("questionnaire_id")) = False Then _questionnaire_id = Convert.ToInt64(Rdr("questionnaire_id"))
                        If Convert.IsDBNull(Rdr("questionnaire_name")) = False Then _questionnaire_name = Rdr("questionnaire_name").ToString()
                        If Convert.IsDBNull(Rdr("objective")) = False Then _objective = Rdr("objective").ToString()
                        If Convert.IsDBNull(Rdr("question_desc")) = False Then _question_desc = Rdr("question_desc").ToString()
                        If Convert.IsDBNull(Rdr("section_id")) = False Then _section_id = Convert.ToInt64(Rdr("section_id"))
                        If Convert.IsDBNull(Rdr("section_name")) = False Then _section_name = Rdr("section_name").ToString()
                        If Convert.IsDBNull(Rdr("section_desc")) = False Then _section_desc = Rdr("section_desc").ToString()
                        If Convert.IsDBNull(Rdr("question_id")) = False Then _question_id = Convert.ToInt64(Rdr("question_id"))
                        If Convert.IsDBNull(Rdr("question_name")) = False Then _question_name = Rdr("question_name").ToString()
                        If Convert.IsDBNull(Rdr("choice_type_id")) = False Then _choice_type_id = Convert.ToInt64(Rdr("choice_type_id"))
                        If Convert.IsDBNull(Rdr("choice_type_name")) = False Then _choice_type_name = Rdr("choice_type_name").ToString()
                        If Convert.IsDBNull(Rdr("question_point")) = False Then _question_point = Convert.ToDouble(Rdr("question_point"))
                        If Convert.IsDBNull(Rdr("is_require")) = False Then _is_require = Rdr("is_require").ToString()
                        If Convert.IsDBNull(Rdr("answer_id")) = False Then _answer_id = Convert.ToInt64(Rdr("answer_id"))
                        If Convert.IsDBNull(Rdr("answer_name")) = False Then _answer_name = Rdr("answer_name").ToString()
                        If Convert.IsDBNull(Rdr("answer_date")) = False Then _answer_date = Convert.ToDateTime(Rdr("answer_date"))
                        If Convert.IsDBNull(Rdr("answer_result_id")) = False Then _answer_result_id = Convert.ToInt64(Rdr("answer_result_id"))
                        If Convert.IsDBNull(Rdr("result_choice_name")) = False Then _result_choice_name = Rdr("result_choice_name").ToString()
                        If Convert.IsDBNull(Rdr("result_point")) = False Then _result_point = Convert.ToDouble(Rdr("result_point"))
                    Else
                        ret = False
                        _error = MessageResources.MSGEV002
                    End If

                    Rdr.Close()
                Catch ex As Exception
                    ex.ToString()
                    ret = False
                    _error = MessageResources.MSGEC104
                    If Rdr IsNot Nothing And Rdr.IsClosed=False Then
                        Rdr.Close()
                    End If
                End Try
            Else
                ret = False
                _error = MessageResources.MSGEV001
            End If

            Return ret
        End Function


        '/// Returns an indication whether the record of v_answer_result by specified condition is retrieved successfully.
        '/// <param name=whText>The condition specify the deleting record(s).</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Private Function doGetData(whText As String, trans As SQLTransaction) As VAnswerResultLinq
            ClearData()
            _haveData  = False
            If whText.Trim() <> "" Then
                Dim tmpWhere As String = " WHERE " & whText
                Dim Rdr As SQLDataReader
                Try
                    Rdr = DB.ExecuteReader(SqlSelect() & tmpWhere, trans)
                    If Rdr.Read() Then
                        _haveData = True
                        If Convert.IsDBNull(Rdr("questionnaire_id")) = False Then _questionnaire_id = Convert.ToInt64(Rdr("questionnaire_id"))
                        If Convert.IsDBNull(Rdr("questionnaire_name")) = False Then _questionnaire_name = Rdr("questionnaire_name").ToString()
                        If Convert.IsDBNull(Rdr("objective")) = False Then _objective = Rdr("objective").ToString()
                        If Convert.IsDBNull(Rdr("question_desc")) = False Then _question_desc = Rdr("question_desc").ToString()
                        If Convert.IsDBNull(Rdr("section_id")) = False Then _section_id = Convert.ToInt64(Rdr("section_id"))
                        If Convert.IsDBNull(Rdr("section_name")) = False Then _section_name = Rdr("section_name").ToString()
                        If Convert.IsDBNull(Rdr("section_desc")) = False Then _section_desc = Rdr("section_desc").ToString()
                        If Convert.IsDBNull(Rdr("question_id")) = False Then _question_id = Convert.ToInt64(Rdr("question_id"))
                        If Convert.IsDBNull(Rdr("question_name")) = False Then _question_name = Rdr("question_name").ToString()
                        If Convert.IsDBNull(Rdr("choice_type_id")) = False Then _choice_type_id = Convert.ToInt64(Rdr("choice_type_id"))
                        If Convert.IsDBNull(Rdr("choice_type_name")) = False Then _choice_type_name = Rdr("choice_type_name").ToString()
                        If Convert.IsDBNull(Rdr("question_point")) = False Then _question_point = Convert.ToDouble(Rdr("question_point"))
                        If Convert.IsDBNull(Rdr("is_require")) = False Then _is_require = Rdr("is_require").ToString()
                        If Convert.IsDBNull(Rdr("answer_id")) = False Then _answer_id = Convert.ToInt64(Rdr("answer_id"))
                        If Convert.IsDBNull(Rdr("answer_name")) = False Then _answer_name = Rdr("answer_name").ToString()
                        If Convert.IsDBNull(Rdr("answer_date")) = False Then _answer_date = Convert.ToDateTime(Rdr("answer_date"))
                        If Convert.IsDBNull(Rdr("answer_result_id")) = False Then _answer_result_id = Convert.ToInt64(Rdr("answer_result_id"))
                        If Convert.IsDBNull(Rdr("result_choice_name")) = False Then _result_choice_name = Rdr("result_choice_name").ToString()
                        If Convert.IsDBNull(Rdr("result_point")) = False Then _result_point = Convert.ToDouble(Rdr("result_point"))

                        'Generate Item For Child Table
                    Else
                        _error = MessageResources.MSGEV002
                    End If

                    Rdr.Close()
                Catch ex As Exception
                    ex.ToString()
                    _error = MessageResources.MSGEC104
                    If Rdr IsNot Nothing And Rdr.IsClosed=False Then
                        Rdr.Close()
                    End If
                End Try
            Else
                _error = MessageResources.MSGEV001
            End If
            Return Me
        End Function


        '/// Returns an indication whether the Class Data of v_answer_result by specified condition is retrieved successfully.
        '/// <param name=whText>The condition specify the deleting record(s).</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Private Function doMappingParameter(whText As String, trans As SQLTransaction) As VAnswerResultPara
            ClearData()
            _haveData  = False
            Dim ret As New VAnswerResultPara
            If whText.Trim() <> "" Then
                Dim tmpWhere As String = " WHERE " & whText
                Dim Rdr As SQLDataReader
                Try
                    Rdr = DB.ExecuteReader(SqlSelect() & tmpWhere, trans)
                    If Rdr.Read() Then
                        _haveData = True
                        If Convert.IsDBNull(Rdr("questionnaire_id")) = False Then ret.questionnaire_id = Convert.ToInt64(Rdr("questionnaire_id"))
                        If Convert.IsDBNull(Rdr("questionnaire_name")) = False Then ret.questionnaire_name = Rdr("questionnaire_name").ToString()
                        If Convert.IsDBNull(Rdr("objective")) = False Then ret.objective = Rdr("objective").ToString()
                        If Convert.IsDBNull(Rdr("question_desc")) = False Then ret.question_desc = Rdr("question_desc").ToString()
                        If Convert.IsDBNull(Rdr("section_id")) = False Then ret.section_id = Convert.ToInt64(Rdr("section_id"))
                        If Convert.IsDBNull(Rdr("section_name")) = False Then ret.section_name = Rdr("section_name").ToString()
                        If Convert.IsDBNull(Rdr("section_desc")) = False Then ret.section_desc = Rdr("section_desc").ToString()
                        If Convert.IsDBNull(Rdr("question_id")) = False Then ret.question_id = Convert.ToInt64(Rdr("question_id"))
                        If Convert.IsDBNull(Rdr("question_name")) = False Then ret.question_name = Rdr("question_name").ToString()
                        If Convert.IsDBNull(Rdr("choice_type_id")) = False Then ret.choice_type_id = Convert.ToInt64(Rdr("choice_type_id"))
                        If Convert.IsDBNull(Rdr("choice_type_name")) = False Then ret.choice_type_name = Rdr("choice_type_name").ToString()
                        If Convert.IsDBNull(Rdr("question_point")) = False Then ret.question_point = Convert.ToDouble(Rdr("question_point"))
                        If Convert.IsDBNull(Rdr("is_require")) = False Then ret.is_require = Rdr("is_require").ToString()
                        If Convert.IsDBNull(Rdr("answer_id")) = False Then ret.answer_id = Convert.ToInt64(Rdr("answer_id"))
                        If Convert.IsDBNull(Rdr("answer_name")) = False Then ret.answer_name = Rdr("answer_name").ToString()
                        If Convert.IsDBNull(Rdr("answer_date")) = False Then ret.answer_date = Convert.ToDateTime(Rdr("answer_date"))
                        If Convert.IsDBNull(Rdr("answer_result_id")) = False Then ret.answer_result_id = Convert.ToInt64(Rdr("answer_result_id"))
                        If Convert.IsDBNull(Rdr("result_choice_name")) = False Then ret.result_choice_name = Rdr("result_choice_name").ToString()
                        If Convert.IsDBNull(Rdr("result_point")) = False Then ret.result_point = Convert.ToDouble(Rdr("result_point"))

                        'Generate Item For Child Table

                    Else
                        _error = MessageResources.MSGEV002
                    End If

                    Rdr.Close()
                Catch ex As Exception
                    ex.ToString()
                    _error = MessageResources.MSGEC104
                    If Rdr IsNot Nothing And Rdr.IsClosed=False Then
                        Rdr.Close()
                    End If
                End Try
            Else
                _error = MessageResources.MSGEV001
            End If
            Return ret
        End Function

        ' SQL Statements


        'Get Select Statement for table v_answer_result
        Private ReadOnly Property SqlSelect() As String
            Get
                Dim Sql As String = "SELECT * FROM " & viewName
                Return Sql
            End Get
        End Property


    End Class
End Namespace
