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
    'Represents a transaction for v_question_list view Linq.
    '[Create by  on October, 24 2011]
    Public Class VQuestionListLinq
        Public sub VQuestionListLinq()

        End Sub 
        ' v_question_list
        Const _viewName As String = "v_question_list"

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


        'Clear All Data
        Private Sub ClearData()
            _ID = 0
            _QUESTIONNAIRE_SECTION_ID = 0
            _SECTION_NAME = ""
            _QUESTIONNAIRE_QUESTION_ID = 0
            _QUESTION_NAME = ""
            _CHOICE_TYPE_NAME = ""
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


        '/// Returns an indication whether the record of v_question_list by specified condition is retrieved successfully.
        '/// <param name=whText>The condition specify the deleting record(s).</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Public Function ChkDataByWhere(whText As String, trans As SQLTransaction) As Boolean
            Return doChkData(whText, trans)
        End Function



        '/// Returns an indication whether the record of v_question_list by specified condition is retrieved successfully.
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
                        If Convert.IsDBNull(Rdr("questionnaire_section_id")) = False Then _questionnaire_section_id = Convert.ToInt64(Rdr("questionnaire_section_id"))
                        If Convert.IsDBNull(Rdr("section_name")) = False Then _section_name = Rdr("section_name").ToString()
                        If Convert.IsDBNull(Rdr("questionnaire_question_id")) = False Then _questionnaire_question_id = Convert.ToInt64(Rdr("questionnaire_question_id"))
                        If Convert.IsDBNull(Rdr("question_name")) = False Then _question_name = Rdr("question_name").ToString()
                        If Convert.IsDBNull(Rdr("choice_type_name")) = False Then _choice_type_name = Rdr("choice_type_name").ToString()
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


        '/// Returns an indication whether the record of v_question_list by specified condition is retrieved successfully.
        '/// <param name=whText>The condition specify the deleting record(s).</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Private Function doGetData(whText As String, trans As SQLTransaction) As VQuestionListLinq
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
                        If Convert.IsDBNull(Rdr("questionnaire_section_id")) = False Then _questionnaire_section_id = Convert.ToInt64(Rdr("questionnaire_section_id"))
                        If Convert.IsDBNull(Rdr("section_name")) = False Then _section_name = Rdr("section_name").ToString()
                        If Convert.IsDBNull(Rdr("questionnaire_question_id")) = False Then _questionnaire_question_id = Convert.ToInt64(Rdr("questionnaire_question_id"))
                        If Convert.IsDBNull(Rdr("question_name")) = False Then _question_name = Rdr("question_name").ToString()
                        If Convert.IsDBNull(Rdr("choice_type_name")) = False Then _choice_type_name = Rdr("choice_type_name").ToString()
                        If Convert.IsDBNull(Rdr("question_point")) = False Then _question_point = Convert.ToDouble(Rdr("question_point"))
                        If Convert.IsDBNull(Rdr("is_require")) = False Then _is_require = Rdr("is_require").ToString()

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


        '/// Returns an indication whether the Class Data of v_question_list by specified condition is retrieved successfully.
        '/// <param name=whText>The condition specify the deleting record(s).</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Private Function doMappingParameter(whText As String, trans As SQLTransaction) As VQuestionListPara
            ClearData()
            _haveData  = False
            Dim ret As New VQuestionListPara
            If whText.Trim() <> "" Then
                Dim tmpWhere As String = " WHERE " & whText
                Dim Rdr As SQLDataReader
                Try
                    Rdr = DB.ExecuteReader(SqlSelect() & tmpWhere, trans)
                    If Rdr.Read() Then
                        _haveData = True
                        If Convert.IsDBNull(Rdr("id")) = False Then ret.id = Convert.ToInt64(Rdr("id"))
                        If Convert.IsDBNull(Rdr("questionnaire_section_id")) = False Then ret.questionnaire_section_id = Convert.ToInt64(Rdr("questionnaire_section_id"))
                        If Convert.IsDBNull(Rdr("section_name")) = False Then ret.section_name = Rdr("section_name").ToString()
                        If Convert.IsDBNull(Rdr("questionnaire_question_id")) = False Then ret.questionnaire_question_id = Convert.ToInt64(Rdr("questionnaire_question_id"))
                        If Convert.IsDBNull(Rdr("question_name")) = False Then ret.question_name = Rdr("question_name").ToString()
                        If Convert.IsDBNull(Rdr("choice_type_name")) = False Then ret.choice_type_name = Rdr("choice_type_name").ToString()
                        If Convert.IsDBNull(Rdr("question_point")) = False Then ret.question_point = Convert.ToDouble(Rdr("question_point"))
                        If Convert.IsDBNull(Rdr("is_require")) = False Then ret.is_require = Rdr("is_require").ToString()

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


        'Get Select Statement for table v_question_list
        Private ReadOnly Property SqlSelect() As String
            Get
                Dim Sql As String = "SELECT * FROM " & viewName
                Return Sql
            End Get
        End Property


    End Class
End Namespace
