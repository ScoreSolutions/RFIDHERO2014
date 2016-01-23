Imports System
Imports System.Data 
Imports System.Data.SQLClient
Imports System.Data.Linq 
Imports System.Data.Linq.Mapping 
Imports System.Linq 
Imports System.Linq.Expressions 
Imports DB = Linq.Common.Utilities.SQLDB
Imports Para.TABLE
Imports Para.Common.Utilities

Namespace TABLE
    'Represents a transaction for QUESTIONNAIRE_QUESTIONS table Linq.
    '[Create by  on October, 24 2011]
    Public Class QuestionnaireQuestionsLinq
        Public sub QuestionnaireQuestionsLinq()

        End Sub 
        ' QUESTIONNAIRE_QUESTIONS
        Const _tableName As String = "QUESTIONNAIRE_QUESTIONS"
        Dim _deletedRow As Int16 = 0

        'Set Common Property
        Dim _error As String = ""
        Dim _information As String = ""
        Dim _haveData As Boolean = False

        Public ReadOnly Property TableName As String
            Get
                Return _tableName
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
        Dim _ID As Long = 0
        Dim _CREATE_BY As String = ""
        Dim _CREATE_ON As DateTime = New DateTime(1,1,1)
        Dim _UPDATE_BY As  String  = ""
        Dim _UPDATE_ON As  System.Nullable(Of DateTime)  = New DateTime(1,1,1)
        Dim _QUESTIONNAIRE_SECTION_ID As Long = 0
        Dim _QUESTION_NAME As String = ""
        Dim _CHOICE_TYPE_ID As Long = 0
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
        <Column(Storage:="_QUESTIONNAIRE_SECTION_ID", DbType:="BigInt NOT NULL ",CanBeNull:=false)>  _
        Public Property QUESTIONNAIRE_SECTION_ID() As Long
            Get
                Return _QUESTIONNAIRE_SECTION_ID
            End Get
            Set(ByVal value As Long)
               _QUESTIONNAIRE_SECTION_ID = value
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


        'Clear All Data
        Private Sub ClearData()
            _ID = 0
            _CREATE_BY = ""
            _CREATE_ON = New DateTime(1,1,1)
            _UPDATE_BY = ""
            _UPDATE_ON = New DateTime(1,1,1)
            _QUESTIONNAIRE_SECTION_ID = 0
            _QUESTION_NAME = ""
            _CHOICE_TYPE_ID = 0
            _QUESTION_POINT = 0
            _IS_REQUIRE = ""
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


        '/// Returns an indication whether the current data is inserted into QUESTIONNAIRE_QUESTIONS table successfully.
        '/// <param name=userID>The current user.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if insert data successfully; otherwise, false.</returns>
        Public Function InsertData(LoginName As String,trans As SQLTransaction) As Boolean
            If trans IsNot Nothing Then 
                _id = DB.GetNextID("id",tableName, trans)
                _CREATE_BY = LoginName
                _CREATE_ON = DateTime.Now
                Return doInsert(trans)
            Else 
                _error = "Transaction Is not null"
                Return False
            End If 
        End Function


        '/// Returns an indication whether the current data is updated to QUESTIONNAIRE_QUESTIONS table successfully.
        '/// <param name=userID>The current user.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if update data successfully; otherwise, false.</returns>
        Public Function UpdateByPK(LoginName As String,trans As SQLTransaction) As Boolean
            If trans IsNot Nothing Then 
                _UPDATE_BY = LoginName
                _UPDATE_ON = DateTime.Now
                Return doUpdate("id = " & DB.SetDouble(_id) & " ", trans)
            Else 
                _error = "Transaction Is not null"
                Return False
            End If 
        End Function


        '/// Returns an indication whether the current data is updated to QUESTIONNAIRE_QUESTIONS table successfully.
        '/// <returns>true if update data successfully; otherwise, false.</returns>
        Public Function UpdateBySql(Sql As String, trans As SQLTransaction) As Boolean
            If trans IsNot Nothing Then 
                Return DB.ExecuteNonQuery(Sql, trans)
            Else 
                _error = "Transaction Is not null"
                Return False
            End If 
        End Function


        '/// Returns an indication whether the current data is deleted from QUESTIONNAIRE_QUESTIONS table successfully.
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if delete data successfully; otherwise, false.</returns>
        Public Function DeleteByPK(cPK As Long, trans As SQLTransaction) As Boolean
            If trans IsNot Nothing Then 
                Return doDelete("id = " & cPK, trans)
            Else 
                _error = "Transaction Is not null"
                Return False
            End If 
        End Function


        '/// Returns an indication whether the record of QUESTIONNAIRE_QUESTIONS by specified id key is retrieved successfully.
        '/// <param name=cid>The id key.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Public Function ChkDataByPK(cid As Long, trans As SQLTransaction) As Boolean
            Return doChkData("id = " & DB.SetDouble(cid) & " ", trans)
        End Function


        '/// Returns an indication whether the record and Mapping field to Data Class of QUESTIONNAIRE_QUESTIONS by specified id key is retrieved successfully.
        '/// <param name=cid>The id key.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Public Function GetDataByPK(cid As Long, trans As SQLTransaction) As QuestionnaireQuestionsLinq
            Return doGetData("id = " & DB.SetDouble(cid) & " ", trans)
        End Function


        '/// Returns an indication whether the record and Mapping field to Para Class of QUESTIONNAIRE_QUESTIONS by specified id key is retrieved successfully.
        '/// <param name=cid>The id key.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Public Function GetParameter(cid As Long, trans As SQLTransaction) As QuestionnaireQuestionsPara
            Return doMappingParameter("id = " & DB.SetDouble(cid) & " ", trans)
        End Function


        '/// Returns an indication whether the record of QUESTIONNAIRE_QUESTIONS by specified condition is retrieved successfully.
        '/// <param name=whText>The condition specify the deleting record(s).</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Public Function ChkDataByWhere(whText As String, trans As SQLTransaction) As Boolean
            Return doChkData(whText, trans)
        End Function



        '/// Returns an indication whether the current data is inserted into QUESTIONNAIRE_QUESTIONS table successfully.
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if insert data successfully; otherwise, false.</returns>
        Private Function doInsert(trans As SQLTransaction) As Boolean
            Dim ret As Boolean = True
            If _haveData = False Then
                Try
                    ret = (DB.ExecuteNonQuery(SqlInsert, trans) > 0)
                    If ret = False Then
                        _error = MessageResources.MSGEN001
                    Else
                        _haveData = True
                    End If
                    _information = MessageResources.MSGIN001
                Catch ex As ApplicationException
                    ret = false
                    _error = ex.Message
                Catch ex As Exception
                    ex.ToString()
                    ret = False
                    _error = MessageResources.MSGEC101
                End Try
            Else
                ret = False
                _error = MessageResources.MSGEN002
            End If

            Return ret
        End Function


        '/// Returns an indication whether the current data is updated to QUESTIONNAIRE_QUESTIONS table successfully.
        '/// <param name=whText>The condition specify the updating record(s).</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if update data successfully; otherwise, false.</returns>
        Private Function doUpdate(whText As String, trans As SQLTransaction) As Boolean
            Dim ret As Boolean = True
            If _haveData = True Then
                If whText.Trim() <> ""
                    Dim tmpWhere As String = " Where " & whText
                    Try
                        ret = (DB.ExecuteNonQuery(SqlUpdate & tmpWhere, trans) > 0)
                        If ret = False Then
                            _error = MessageResources.MSGEU001
                        End If
                        _information = MessageResources.MSGIU001
                    Catch ex As ApplicationException
                        ret = False
                        _error = ex.Message
                    Catch ex As Exception
                        ex.ToString()
                        ret = False
                        _error = MessageResources.MSGEC102
                    End Try
                Else
                    ret = False
                    _error = MessageResources.MSGEU003
                End If
            Else
                ret = False
                _error = MessageResources.MSGEU002
            End If

            Return ret
        End Function


        '/// Returns an indication whether the current data is deleted from QUESTIONNAIRE_QUESTIONS table successfully.
        '/// <param name=whText>The condition specify the deleting record(s).</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if delete data successfully; otherwise, false.</returns>
        Private Function doDelete(whText As String, trans As SQLTransaction) As Boolean
            Dim ret As Boolean = True
            If doChkData(whText, trans) = True Then
                If whText.Trim() <> ""
                    Dim tmpWhere As String = " Where " & whText
                    Try
                        ret = (DB.ExecuteNonQuery(SqlDelete & tmpWhere, trans) > 0)
                        If ret = False Then
                            _error = MessageResources.MSGED001
                        End If
                        _information = MessageResources.MSGID001
                    Catch ex As ApplicationException
                        ret = False
                        _error = ex.Message
                    Catch ex As Exception
                        ex.ToString()
                        ret = False
                        _error = MessageResources.MSGEC103
                    End Try
                Else
                    ret = False
                    _error = MessageResources.MSGED003
                End If
            Else
                ret = False
                _error = MessageResources.MSGEU002
            End If

            Return ret
        End Function


        '/// Returns an indication whether the record of QUESTIONNAIRE_QUESTIONS by specified condition is retrieved successfully.
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
                        If Convert.IsDBNull(Rdr("id")) = False Then _id = Convert.ToInt64(Rdr("id"))
                        If Convert.IsDBNull(Rdr("create_by")) = False Then _create_by = Rdr("create_by").ToString()
                        If Convert.IsDBNull(Rdr("create_on")) = False Then _create_on = Convert.ToDateTime(Rdr("create_on"))
                        If Convert.IsDBNull(Rdr("update_by")) = False Then _update_by = Rdr("update_by").ToString()
                        If Convert.IsDBNull(Rdr("update_on")) = False Then _update_on = Convert.ToDateTime(Rdr("update_on"))
                        If Convert.IsDBNull(Rdr("questionnaire_section_id")) = False Then _questionnaire_section_id = Convert.ToInt64(Rdr("questionnaire_section_id"))
                        If Convert.IsDBNull(Rdr("question_name")) = False Then _question_name = Rdr("question_name").ToString()
                        If Convert.IsDBNull(Rdr("choice_type_id")) = False Then _choice_type_id = Convert.ToInt64(Rdr("choice_type_id"))
                        If Convert.IsDBNull(Rdr("question_point")) = False Then _question_point = Convert.ToDouble(Rdr("question_point"))
                        If Convert.IsDBNull(Rdr("is_require")) = False Then _is_require = Rdr("is_require").ToString()
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


        '/// Returns an indication whether the record of QUESTIONNAIRE_QUESTIONS by specified condition is retrieved successfully.
        '/// <param name=whText>The condition specify the deleting record(s).</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Private Function doGetData(whText As String, trans As SQLTransaction) As QuestionnaireQuestionsLinq
            ClearData()
            _haveData  = False
            If whText.Trim() <> "" Then
                Dim tmpWhere As String = " WHERE " & whText
                Dim Rdr As SQLDataReader
                Try
                    Rdr = DB.ExecuteReader(SqlSelect() & tmpWhere, trans)
                    If Rdr.Read() Then
                        _haveData = True
                        If Convert.IsDBNull(Rdr("id")) = False Then _id = Convert.ToInt64(Rdr("id"))
                        If Convert.IsDBNull(Rdr("create_by")) = False Then _create_by = Rdr("create_by").ToString()
                        If Convert.IsDBNull(Rdr("create_on")) = False Then _create_on = Convert.ToDateTime(Rdr("create_on"))
                        If Convert.IsDBNull(Rdr("update_by")) = False Then _update_by = Rdr("update_by").ToString()
                        If Convert.IsDBNull(Rdr("update_on")) = False Then _update_on = Convert.ToDateTime(Rdr("update_on"))
                        If Convert.IsDBNull(Rdr("questionnaire_section_id")) = False Then _questionnaire_section_id = Convert.ToInt64(Rdr("questionnaire_section_id"))
                        If Convert.IsDBNull(Rdr("question_name")) = False Then _question_name = Rdr("question_name").ToString()
                        If Convert.IsDBNull(Rdr("choice_type_id")) = False Then _choice_type_id = Convert.ToInt64(Rdr("choice_type_id"))
                        If Convert.IsDBNull(Rdr("question_point")) = False Then _question_point = Convert.ToDouble(Rdr("question_point"))
                        If Convert.IsDBNull(Rdr("is_require")) = False Then _is_require = Rdr("is_require").ToString()

                        'Generate Item For Child Table
                        'Child Table Name : ANSWER_RESULT Column :questionnaire_question_id
                        Dim AnswerResult_questionnaire_question_idItem As New AnswerResultLinq
                        _ANSWER_RESULT_questionnaire_question_id = AnswerResult_questionnaire_question_idItem.GetDataList("questionnaire_question_id = " & _ID, "", Nothing)

                        'Child Table Name : QUESTION_CHOICE_CONFIG Column :questionnaire_question_id
                        Dim QuestionChoiceConfig_questionnaire_question_idItem As New QuestionChoiceConfigLinq
                        _QUESTION_CHOICE_CONFIG_questionnaire_question_id = QuestionChoiceConfig_questionnaire_question_idItem.GetDataList("questionnaire_question_id = " & _ID, "", Nothing)

                        'Child Table Name : QUESTIONNAIRE_QUESTIONS_CHOICE Column :questionnaire_questions_id
                        Dim QuestionnaireQuestionsChoice_questionnaire_questions_idItem As New QuestionnaireQuestionsChoiceLinq
                        _QUESTIONNAIRE_QUESTIONS_CHOICE_questionnaire_questions_id = QuestionnaireQuestionsChoice_questionnaire_questions_idItem.GetDataList("questionnaire_questions_id = " & _ID, "", Nothing)

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


        '/// Returns an indication whether the Class Data of QUESTIONNAIRE_QUESTIONS by specified condition is retrieved successfully.
        '/// <param name=whText>The condition specify the deleting record(s).</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Private Function doMappingParameter(whText As String, trans As SQLTransaction) As QuestionnaireQuestionsPara
            ClearData()
            _haveData  = False
            Dim ret As New QuestionnaireQuestionsPara
            If whText.Trim() <> "" Then
                Dim tmpWhere As String = " WHERE " & whText
                Dim Rdr As SQLDataReader
                Try
                    Rdr = DB.ExecuteReader(SqlSelect() & tmpWhere, trans)
                    If Rdr.Read() Then
                        _haveData = True
                        If Convert.IsDBNull(Rdr("id")) = False Then ret.id = Convert.ToInt64(Rdr("id"))
                        If Convert.IsDBNull(Rdr("create_by")) = False Then ret.create_by = Rdr("create_by").ToString()
                        If Convert.IsDBNull(Rdr("create_on")) = False Then ret.create_on = Convert.ToDateTime(Rdr("create_on"))
                        If Convert.IsDBNull(Rdr("update_by")) = False Then ret.update_by = Rdr("update_by").ToString()
                        If Convert.IsDBNull(Rdr("update_on")) = False Then ret.update_on = Convert.ToDateTime(Rdr("update_on"))
                        If Convert.IsDBNull(Rdr("questionnaire_section_id")) = False Then ret.questionnaire_section_id = Convert.ToInt64(Rdr("questionnaire_section_id"))
                        If Convert.IsDBNull(Rdr("question_name")) = False Then ret.question_name = Rdr("question_name").ToString()
                        If Convert.IsDBNull(Rdr("choice_type_id")) = False Then ret.choice_type_id = Convert.ToInt64(Rdr("choice_type_id"))
                        If Convert.IsDBNull(Rdr("question_point")) = False Then ret.question_point = Convert.ToDouble(Rdr("question_point"))
                        If Convert.IsDBNull(Rdr("is_require")) = False Then ret.is_require = Rdr("is_require").ToString()

                        'Generate Item For Child Table
                        'Child Table Name : ANSWER_RESULT Column :questionnaire_question_id
                        Dim AnswerResult_questionnaire_question_idItem As New AnswerResultLinq
                        _ANSWER_RESULT_questionnaire_question_id = AnswerResult_questionnaire_question_idItem.GetDataList("questionnaire_question_id = " & ret.id, "", Nothing)
                        ret.CHILD_ANSWER_RESULT_questionnaire_question_id = _ANSWER_RESULT_questionnaire_question_id

                        'Child Table Name : QUESTION_CHOICE_CONFIG Column :questionnaire_question_id
                        Dim QuestionChoiceConfig_questionnaire_question_idItem As New QuestionChoiceConfigLinq
                        _QUESTION_CHOICE_CONFIG_questionnaire_question_id = QuestionChoiceConfig_questionnaire_question_idItem.GetDataList("questionnaire_question_id = " & ret.id, "", Nothing)
                        ret.CHILD_QUESTION_CHOICE_CONFIG_questionnaire_question_id = _QUESTION_CHOICE_CONFIG_questionnaire_question_id

                        'Child Table Name : QUESTIONNAIRE_QUESTIONS_CHOICE Column :questionnaire_questions_id
                        Dim QuestionnaireQuestionsChoice_questionnaire_questions_idItem As New QuestionnaireQuestionsChoiceLinq
                        _QUESTIONNAIRE_QUESTIONS_CHOICE_questionnaire_questions_id = QuestionnaireQuestionsChoice_questionnaire_questions_idItem.GetDataList("questionnaire_questions_id = " & ret.id, "", Nothing)
                        ret.CHILD_QUESTIONNAIRE_QUESTIONS_CHOICE_questionnaire_questions_id = _QUESTIONNAIRE_QUESTIONS_CHOICE_questionnaire_questions_id


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


        'Get Insert Statement for table QUESTIONNAIRE_QUESTIONS
        Private ReadOnly Property SqlInsert() As String 
            Get
                Dim Sql As String=""
                Sql += "INSERT INTO " & tableName  & " (ID, CREATE_BY, CREATE_ON, UPDATE_BY, UPDATE_ON, QUESTIONNAIRE_SECTION_ID, QUESTION_NAME, CHOICE_TYPE_ID, QUESTION_POINT, IS_REQUIRE)"
                Sql += " VALUES("
                sql += DB.SetDouble(_ID) & ", "
                sql += DB.SetString(_CREATE_BY) & ", "
                sql += DB.SetDateTime(_CREATE_ON) & ", "
                sql += DB.SetString(_UPDATE_BY) & ", "
                sql += DB.SetDateTime(_UPDATE_ON) & ", "
                sql += DB.SetDouble(_QUESTIONNAIRE_SECTION_ID) & ", "
                sql += DB.SetString(_QUESTION_NAME) & ", "
                sql += DB.SetDouble(_CHOICE_TYPE_ID) & ", "
                sql += DB.SetDouble(_QUESTION_POINT) & ", "
                sql += DB.SetString(_IS_REQUIRE)
                sql += ")"
                Return sql
            End Get
        End Property


        'Get update statement form table QUESTIONNAIRE_QUESTIONS
        Private ReadOnly Property SqlUpdate() As String
            Get
                Dim Sql As String = ""
                Sql += "UPDATE " & tableName & " SET "
                Sql += "ID = " & DB.SetDouble(_ID) & ", "
                Sql += "CREATE_BY = " & DB.SetString(_CREATE_BY) & ", "
                Sql += "CREATE_ON = " & DB.SetDateTime(_CREATE_ON) & ", "
                Sql += "UPDATE_BY = " & DB.SetString(_UPDATE_BY) & ", "
                Sql += "UPDATE_ON = " & DB.SetDateTime(_UPDATE_ON) & ", "
                Sql += "QUESTIONNAIRE_SECTION_ID = " & DB.SetDouble(_QUESTIONNAIRE_SECTION_ID) & ", "
                Sql += "QUESTION_NAME = " & DB.SetString(_QUESTION_NAME) & ", "
                Sql += "CHOICE_TYPE_ID = " & DB.SetDouble(_CHOICE_TYPE_ID) & ", "
                Sql += "QUESTION_POINT = " & DB.SetDouble(_QUESTION_POINT) & ", "
                Sql += "IS_REQUIRE = " & DB.SetString(_IS_REQUIRE) + ""
                Return Sql
            End Get
        End Property


        'Get Delete Record in table QUESTIONNAIRE_QUESTIONS
        Private ReadOnly Property SqlDelete() As String
            Get
                Dim Sql As String = "DELETE FROM " & tableName
                Return Sql
            End Get
        End Property


        'Get Select Statement for table QUESTIONNAIRE_QUESTIONS
        Private ReadOnly Property SqlSelect() As String
            Get
                Dim Sql As String = "SELECT * FROM " & tableName
                Return Sql
            End Get
        End Property


            'Define Child Table 

       Dim _ANSWER_RESULT_questionnaire_question_id As DataTable
       Dim _QUESTION_CHOICE_CONFIG_questionnaire_question_id As DataTable
       Dim _QUESTIONNAIRE_QUESTIONS_CHOICE_questionnaire_questions_id As DataTable

       Public Property CHILD_ANSWER_RESULT_questionnaire_question_id() As DataTable
           Get
               Return _ANSWER_RESULT_questionnaire_question_id
           End Get
           Set(ByVal value As DataTable)
               _ANSWER_RESULT_questionnaire_question_id = value
           End Set
       End Property
       Public Property CHILD_QUESTION_CHOICE_CONFIG_questionnaire_question_id() As DataTable
           Get
               Return _QUESTION_CHOICE_CONFIG_questionnaire_question_id
           End Get
           Set(ByVal value As DataTable)
               _QUESTION_CHOICE_CONFIG_questionnaire_question_id = value
           End Set
       End Property
       Public Property CHILD_QUESTIONNAIRE_QUESTIONS_CHOICE_questionnaire_questions_id() As DataTable
           Get
               Return _QUESTIONNAIRE_QUESTIONS_CHOICE_questionnaire_questions_id
           End Get
           Set(ByVal value As DataTable)
               _QUESTIONNAIRE_QUESTIONS_CHOICE_questionnaire_questions_id = value
           End Set
       End Property
    End Class
End Namespace
