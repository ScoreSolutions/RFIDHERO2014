Imports System
Imports System.Data 
Imports System.Data.SQLClient
Imports System.Data.Linq 
Imports System.Data.Linq.Mapping 
Imports System.Linq 
Imports System.Linq.Expressions 
Imports DB = LinqDB.Common.Utilities.SqlDB
Imports ParaDB.TABLE
Imports ParaDB.Common.Utilities

Namespace TABLE
    'Represents a transaction for ERM_TS_PERSONAL_INFO table Linq.
    '[Create by  on October, 22 2014]
    Public Class ErmTsPersonalInfoLinq
        Public sub ErmTsPersonalInfoLinq()

        End Sub 
        ' ERM_TS_PERSONAL_INFO
        Const _tableName As String = "ERM_TS_PERSONAL_INFO"
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


        'Clear All Data
        Private Sub ClearData()
            _ID = 0
            _CREATE_BY = ""
            _CREATE_ON = New DateTime(1,1,1)
            _UPDATE_BY = ""
            _UPDATE_ON = New DateTime(1,1,1)
            _IDCARD_NO = ""
            _TITLE_NAME = ""
            _FIRST_NAME = ""
            _MIDDLE_NAME = ""
            _LAST_NAME = ""
            _POSITION_NAME = ""
            _COMPANY_NAME = ""
            _ADDRESS = ""
            _CITY = ""
            _STATE = ""
            _COUNTRY = ""
            _ZIPCODE = ""
            _TELNO = ""
            _FAXNO = ""
            _EMAIL = ""
            _WEBSITE = ""
            _REGISTERED_CAPITAL = 0
            _ANNUAL_SALE_VALUE_YEAR = 0
            _ANNUAL_SALE_VALUE_VOLUMNS = ""
            _DIVISION = ""
            _MOBILE_NO = ""
            _REGISPERIOD = ""
            _IS_SEND_MAIL = ""
            _IMAGE_PATH = ""
            _IS_POST_FACEBOOK = ""
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


        '/// Returns an indication whether the current data is inserted into ERM_TS_PERSONAL_INFO table successfully.
        '/// <param name=userID>The current user.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if insert data successfully; otherwise, false.</returns>
        Public Function InsertData(LoginName As String,trans As SQLTransaction) As Boolean
            If trans IsNot Nothing Then 
                _ID = DB.GetNextID("ID",tableName, trans)
                _CREATE_BY = LoginName
                Return doInsert(trans)
            Else 
                _error = "Transaction Is not null"
                Return False
            End If 
        End Function


        '/// Returns an indication whether the current data is updated to ERM_TS_PERSONAL_INFO table successfully.
        '/// <param name=userID>The current user.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if update data successfully; otherwise, false.</returns>
        Public Function UpdateByPK(LoginName As String,trans As SQLTransaction) As Boolean
            If trans IsNot Nothing Then 
                _UPDATE_BY = LoginName
                Return doUpdate("ID = " & DB.SetDouble(_ID), trans)
            Else 
                _error = "Transaction Is not null"
                Return False
            End If 
        End Function


        '/// Returns an indication whether the current data is updated to ERM_TS_PERSONAL_INFO table successfully.
        '/// <returns>true if update data successfully; otherwise, false.</returns>
        Public Function UpdateBySql(Sql As String, trans As SQLTransaction) As Boolean
            If trans IsNot Nothing Then 
                Return DB.ExecuteNonQuery(Sql, trans)
            Else 
                _error = "Transaction Is not null"
                Return False
            End If 
        End Function


        '/// Returns an indication whether the current data is deleted from ERM_TS_PERSONAL_INFO table successfully.
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if delete data successfully; otherwise, false.</returns>
        Public Function DeleteByPK(cID As Long, trans As SQLTransaction) As Boolean
            If trans IsNot Nothing Then 
                Return doDelete("ID = " & DB.SetDouble(cID), trans)
            Else 
                _error = "Transaction Is not null"
                Return False
            End If 
        End Function


        '/// Returns an indication whether the record of ERM_TS_PERSONAL_INFO by specified id key is retrieved successfully.
        '/// <param name=cid>The id key.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Public Function ChkDataByPK(cID As Long, trans As SQLTransaction) As Boolean
            Return doChkData("ID = " & DB.SetDouble(cID), trans)
        End Function


        '/// Returns an indication whether the record and Mapping field to Data Class of ERM_TS_PERSONAL_INFO by specified id key is retrieved successfully.
        '/// <param name=cid>The id key.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Public Function GetDataByPK(cID As Long, trans As SQLTransaction) As ErmTsPersonalInfoLinq
            Return doGetData("ID = " & DB.SetDouble(cID), trans)
        End Function


        '/// Returns an indication whether the record and Mapping field to Para Class of ERM_TS_PERSONAL_INFO by specified id key is retrieved successfully.
        '/// <param name=cid>The id key.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Public Function GetParameter(cID As Long, trans As SQLTransaction) As ErmTsPersonalInfoPara
            Return doMappingParameter("ID = " & DB.SetDouble(cID), trans)
        End Function


        '/// Returns an indication whether the record of ERM_TS_PERSONAL_INFO by specified IDCARD_NO key is retrieved successfully.
        '/// <param name=cIDCARD_NO>The IDCARD_NO key.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Public Function ChkDataByIDCARD_NO(cIDCARD_NO As String, trans As SQLTransaction) As Boolean
            Return doChkData("IDCARD_NO = " & DB.SetString(cIDCARD_NO) & " ", trans)
        End Function

        '/// Returns an duplicate data record of ERM_TS_PERSONAL_INFO by specified IDCARD_NO key is retrieved successfully.
        '/// <param name=cIDCARD_NO>The IDCARD_NO key.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Public Function ChkDuplicateByIDCARD_NO(cIDCARD_NO As String, cid As Long, trans As SQLTransaction) As Boolean
            Return doChkData("IDCARD_NO = " & DB.SetString(cIDCARD_NO) & " " & " And id <> " & DB.SetDouble(cid) & " ", trans)
        End Function


        '/// Returns an indication whether the record of ERM_TS_PERSONAL_INFO by specified FIRST_NAME key is retrieved successfully.
        '/// <param name=cFIRST_NAME>The FIRST_NAME key.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Public Function ChkDataByFIRST_NAME(cFIRST_NAME As String, trans As SQLTransaction) As Boolean
            Return doChkData("FIRST_NAME = " & DB.SetString(cFIRST_NAME) & " ", trans)
        End Function

        '/// Returns an duplicate data record of ERM_TS_PERSONAL_INFO by specified FIRST_NAME key is retrieved successfully.
        '/// <param name=cFIRST_NAME>The FIRST_NAME key.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Public Function ChkDuplicateByFIRST_NAME(cFIRST_NAME As String, cid As Long, trans As SQLTransaction) As Boolean
            Return doChkData("FIRST_NAME = " & DB.SetString(cFIRST_NAME) & " " & " And id <> " & DB.SetDouble(cid) & " ", trans)
        End Function


        '/// Returns an indication whether the record of ERM_TS_PERSONAL_INFO by specified condition is retrieved successfully.
        '/// <param name=whText>The condition specify the deleting record(s).</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Public Function ChkDataByWhere(whText As String, trans As SQLTransaction) As Boolean
            Return doChkData(whText, trans)
        End Function



        '/// Returns an indication whether the current data is inserted into ERM_TS_PERSONAL_INFO table successfully.
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if insert data successfully; otherwise, false.</returns>
        Private Function doInsert(trans As SQLTransaction) As Boolean
            Dim ret As Boolean = True
            If _haveData = False Then
                Try

                    ret = (DB.ExecuteNonQuery(SqlInsert, trans) > 0)
                    If ret = False Then
                        _error = DB.ErrorMessage
                    Else
                        _haveData = True
                    End If
                    _information = MessageResources.MSGIN001
                Catch ex As ApplicationException
                    ret = false
                    _error = ex.Message & "ApplicationException :" & ex.ToString() & "### SQL:" & SqlInsert
                Catch ex As Exception
                    ret = False
                    _error = MessageResources.MSGEC101 & " Exception :" & ex.ToString() & "### SQL: " & SqlInsert
                End Try
            Else
                ret = False
                _error = MessageResources.MSGEN002 & "### SQL: " & SqlInsert
            End If

            Return ret
        End Function


        '/// Returns an indication whether the current data is updated to ERM_TS_PERSONAL_INFO table successfully.
        '/// <param name=whText>The condition specify the updating record(s).</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if update data successfully; otherwise, false.</returns>
        Private Function doUpdate(whText As String, trans As SQLTransaction) As Boolean
            Dim ret As Boolean = True
            Dim tmpWhere As String = " Where " & whText
            If _haveData = True Then
                If whText.Trim() <> ""
                    Try

                        ret = (DB.ExecuteNonQuery(SqlUpdate & tmpWhere, trans) > 0)
                        If ret = False Then
                            _error = DB.ErrorMessage
                        End If
                        _information = MessageResources.MSGIU001
                    Catch ex As ApplicationException
                        ret = False
                        _error = ex.Message & "ApplicationException :" & ex.ToString() & "### SQL:" & SqlUpdate & tmpWhere
                    Catch ex As Exception
                        ret = False
                        _error = MessageResources.MSGEC102 & " Exception :" & ex.ToString() & "### SQL: " & SqlUpdate & tmpWhere
                    End Try
                Else
                    ret = False
                    _error = MessageResources.MSGEU003 & "### SQL: " & SqlUpdate & tmpWhere
                End If
            Else
                ret = False
                _error = MessageResources.MSGEU002 & "### SQL: " & SqlUpdate & tmpWhere
            End If

            Return ret
        End Function


        '/// Returns an indication whether the current data is deleted from ERM_TS_PERSONAL_INFO table successfully.
        '/// <param name=whText>The condition specify the deleting record(s).</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if delete data successfully; otherwise, false.</returns>
        Private Function doDelete(whText As String, trans As SQLTransaction) As Boolean
            Dim ret As Boolean = True
            Dim tmpWhere As String = " Where " & whText
            If doChkData(whText, trans) = True Then
                If whText.Trim() <> ""
                    Try
                        ret = (DB.ExecuteNonQuery(SqlDelete & tmpWhere, trans) > 0)
                        If ret = False Then
                            _error = MessageResources.MSGED001
                        End If
                        _information = MessageResources.MSGID001
                    Catch ex As ApplicationException
                        ret = False
                        _error = ex.Message & "ApplicationException :" & ex.ToString() & "### SQL:" & SqlDelete & tmpWhere
                    Catch ex As Exception
                        ret = False
                        _error = MessageResources.MSGEC103 & " Exception :" & ex.ToString() & "### SQL: " & SqlDelete & tmpWhere
                    End Try
                Else
                    ret = False
                    _error = MessageResources.MSGED003 & "### SQL: " & SqlDelete & tmpWhere
                End If
            Else
                ret = False
                _error = MessageResources.MSGEU002 & "### SQL: " & SqlDelete & tmpWhere
            End If

            Return ret
        End Function


        '/// Returns an indication whether the record of ERM_TS_PERSONAL_INFO by specified condition is retrieved successfully.
        '/// <param name=whText>The condition specify the deleting record(s).</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Private Function doChkData(whText As String, trans As SQLTransaction) As Boolean
            Dim ret As Boolean = True
            Dim tmpWhere As String = " WHERE " & whText
            ClearData()
            _haveData  = False
            If whText.Trim() <> "" Then
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
                        If Convert.IsDBNull(Rdr("idcard_no")) = False Then _idcard_no = Rdr("idcard_no").ToString()
                        If Convert.IsDBNull(Rdr("title_name")) = False Then _title_name = Rdr("title_name").ToString()
                        If Convert.IsDBNull(Rdr("first_name")) = False Then _first_name = Rdr("first_name").ToString()
                        If Convert.IsDBNull(Rdr("middle_name")) = False Then _middle_name = Rdr("middle_name").ToString()
                        If Convert.IsDBNull(Rdr("last_name")) = False Then _last_name = Rdr("last_name").ToString()
                        If Convert.IsDBNull(Rdr("position_name")) = False Then _position_name = Rdr("position_name").ToString()
                        If Convert.IsDBNull(Rdr("company_name")) = False Then _company_name = Rdr("company_name").ToString()
                        If Convert.IsDBNull(Rdr("address")) = False Then _address = Rdr("address").ToString()
                        If Convert.IsDBNull(Rdr("city")) = False Then _city = Rdr("city").ToString()
                        If Convert.IsDBNull(Rdr("state")) = False Then _state = Rdr("state").ToString()
                        If Convert.IsDBNull(Rdr("country")) = False Then _country = Rdr("country").ToString()
                        If Convert.IsDBNull(Rdr("zipcode")) = False Then _zipcode = Rdr("zipcode").ToString()
                        If Convert.IsDBNull(Rdr("telno")) = False Then _telno = Rdr("telno").ToString()
                        If Convert.IsDBNull(Rdr("faxno")) = False Then _faxno = Rdr("faxno").ToString()
                        If Convert.IsDBNull(Rdr("email")) = False Then _email = Rdr("email").ToString()
                        If Convert.IsDBNull(Rdr("website")) = False Then _website = Rdr("website").ToString()
                        If Convert.IsDBNull(Rdr("registered_capital")) = False Then _registered_capital = Convert.ToDouble(Rdr("registered_capital"))
                        If Convert.IsDBNull(Rdr("annual_sale_value_year")) = False Then _annual_sale_value_year = Convert.ToInt32(Rdr("annual_sale_value_year"))
                        If Convert.IsDBNull(Rdr("annual_sale_value_volumns")) = False Then _annual_sale_value_volumns = Rdr("annual_sale_value_volumns").ToString()
                        If Convert.IsDBNull(Rdr("division")) = False Then _division = Rdr("division").ToString()
                        If Convert.IsDBNull(Rdr("mobile_no")) = False Then _mobile_no = Rdr("mobile_no").ToString()
                        If Convert.IsDBNull(Rdr("regisperiod")) = False Then _regisperiod = Rdr("regisperiod").ToString()
                        If Convert.IsDBNull(Rdr("is_send_mail")) = False Then _is_send_mail = Rdr("is_send_mail").ToString()
                        If Convert.IsDBNull(Rdr("image_path")) = False Then _image_path = Rdr("image_path").ToString()
                        If Convert.IsDBNull(Rdr("is_post_facebook")) = False Then _is_post_facebook = Rdr("is_post_facebook").ToString()
                    Else
                        ret = False
                        _error = MessageResources.MSGEV002
                    End If

                    Rdr.Close()
                Catch ex As Exception
                    ex.ToString()
                    ret = False
                    _error = MessageResources.MSGEC104 & " #### " & ex.ToString()
                End Try
            Else
                ret = False
                _error = MessageResources.MSGEV001
            End If

            Return ret
        End Function


        '/// Returns an indication whether the record of ERM_TS_PERSONAL_INFO by specified condition is retrieved successfully.
        '/// <param name=whText>The condition specify the deleting record(s).</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Private Function doGetData(whText As String, trans As SQLTransaction) As ErmTsPersonalInfoLinq
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
                        If Convert.IsDBNull(Rdr("idcard_no")) = False Then _idcard_no = Rdr("idcard_no").ToString()
                        If Convert.IsDBNull(Rdr("title_name")) = False Then _title_name = Rdr("title_name").ToString()
                        If Convert.IsDBNull(Rdr("first_name")) = False Then _first_name = Rdr("first_name").ToString()
                        If Convert.IsDBNull(Rdr("middle_name")) = False Then _middle_name = Rdr("middle_name").ToString()
                        If Convert.IsDBNull(Rdr("last_name")) = False Then _last_name = Rdr("last_name").ToString()
                        If Convert.IsDBNull(Rdr("position_name")) = False Then _position_name = Rdr("position_name").ToString()
                        If Convert.IsDBNull(Rdr("company_name")) = False Then _company_name = Rdr("company_name").ToString()
                        If Convert.IsDBNull(Rdr("address")) = False Then _address = Rdr("address").ToString()
                        If Convert.IsDBNull(Rdr("city")) = False Then _city = Rdr("city").ToString()
                        If Convert.IsDBNull(Rdr("state")) = False Then _state = Rdr("state").ToString()
                        If Convert.IsDBNull(Rdr("country")) = False Then _country = Rdr("country").ToString()
                        If Convert.IsDBNull(Rdr("zipcode")) = False Then _zipcode = Rdr("zipcode").ToString()
                        If Convert.IsDBNull(Rdr("telno")) = False Then _telno = Rdr("telno").ToString()
                        If Convert.IsDBNull(Rdr("faxno")) = False Then _faxno = Rdr("faxno").ToString()
                        If Convert.IsDBNull(Rdr("email")) = False Then _email = Rdr("email").ToString()
                        If Convert.IsDBNull(Rdr("website")) = False Then _website = Rdr("website").ToString()
                        If Convert.IsDBNull(Rdr("registered_capital")) = False Then _registered_capital = Convert.ToDouble(Rdr("registered_capital"))
                        If Convert.IsDBNull(Rdr("annual_sale_value_year")) = False Then _annual_sale_value_year = Convert.ToInt32(Rdr("annual_sale_value_year"))
                        If Convert.IsDBNull(Rdr("annual_sale_value_volumns")) = False Then _annual_sale_value_volumns = Rdr("annual_sale_value_volumns").ToString()
                        If Convert.IsDBNull(Rdr("division")) = False Then _division = Rdr("division").ToString()
                        If Convert.IsDBNull(Rdr("mobile_no")) = False Then _mobile_no = Rdr("mobile_no").ToString()
                        If Convert.IsDBNull(Rdr("regisperiod")) = False Then _regisperiod = Rdr("regisperiod").ToString()
                        If Convert.IsDBNull(Rdr("is_send_mail")) = False Then _is_send_mail = Rdr("is_send_mail").ToString()
                        If Convert.IsDBNull(Rdr("image_path")) = False Then _image_path = Rdr("image_path").ToString()
                        If Convert.IsDBNull(Rdr("is_post_facebook")) = False Then _is_post_facebook = Rdr("is_post_facebook").ToString()
                    Else
                        _error = MessageResources.MSGEV002
                    End If

                    Rdr.Close()
                Catch ex As Exception
                    ex.ToString()
                    _error = MessageResources.MSGEC104 & " #### " & ex.ToString()
                End Try
            Else
                _error = MessageResources.MSGEV001
            End If
            Return Me
        End Function


        '/// Returns an indication whether the Class Data of ERM_TS_PERSONAL_INFO by specified condition is retrieved successfully.
        '/// <param name=whText>The condition specify the deleting record(s).</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Private Function doMappingParameter(whText As String, trans As SQLTransaction) As ErmTsPersonalInfoPara
            ClearData()
            _haveData  = False
            Dim ret As New ErmTsPersonalInfoPara
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
                        If Convert.IsDBNull(Rdr("idcard_no")) = False Then ret.idcard_no = Rdr("idcard_no").ToString()
                        If Convert.IsDBNull(Rdr("title_name")) = False Then ret.title_name = Rdr("title_name").ToString()
                        If Convert.IsDBNull(Rdr("first_name")) = False Then ret.first_name = Rdr("first_name").ToString()
                        If Convert.IsDBNull(Rdr("middle_name")) = False Then ret.middle_name = Rdr("middle_name").ToString()
                        If Convert.IsDBNull(Rdr("last_name")) = False Then ret.last_name = Rdr("last_name").ToString()
                        If Convert.IsDBNull(Rdr("position_name")) = False Then ret.position_name = Rdr("position_name").ToString()
                        If Convert.IsDBNull(Rdr("company_name")) = False Then ret.company_name = Rdr("company_name").ToString()
                        If Convert.IsDBNull(Rdr("address")) = False Then ret.address = Rdr("address").ToString()
                        If Convert.IsDBNull(Rdr("city")) = False Then ret.city = Rdr("city").ToString()
                        If Convert.IsDBNull(Rdr("state")) = False Then ret.state = Rdr("state").ToString()
                        If Convert.IsDBNull(Rdr("country")) = False Then ret.country = Rdr("country").ToString()
                        If Convert.IsDBNull(Rdr("zipcode")) = False Then ret.zipcode = Rdr("zipcode").ToString()
                        If Convert.IsDBNull(Rdr("telno")) = False Then ret.telno = Rdr("telno").ToString()
                        If Convert.IsDBNull(Rdr("faxno")) = False Then ret.faxno = Rdr("faxno").ToString()
                        If Convert.IsDBNull(Rdr("email")) = False Then ret.email = Rdr("email").ToString()
                        If Convert.IsDBNull(Rdr("website")) = False Then ret.website = Rdr("website").ToString()
                        If Convert.IsDBNull(Rdr("registered_capital")) = False Then ret.registered_capital = Convert.ToDouble(Rdr("registered_capital"))
                        If Convert.IsDBNull(Rdr("annual_sale_value_year")) = False Then ret.annual_sale_value_year = Convert.ToInt32(Rdr("annual_sale_value_year"))
                        If Convert.IsDBNull(Rdr("annual_sale_value_volumns")) = False Then ret.annual_sale_value_volumns = Rdr("annual_sale_value_volumns").ToString()
                        If Convert.IsDBNull(Rdr("division")) = False Then ret.division = Rdr("division").ToString()
                        If Convert.IsDBNull(Rdr("mobile_no")) = False Then ret.mobile_no = Rdr("mobile_no").ToString()
                        If Convert.IsDBNull(Rdr("regisperiod")) = False Then ret.regisperiod = Rdr("regisperiod").ToString()
                        If Convert.IsDBNull(Rdr("is_send_mail")) = False Then ret.is_send_mail = Rdr("is_send_mail").ToString()
                        If Convert.IsDBNull(Rdr("image_path")) = False Then ret.image_path = Rdr("image_path").ToString()
                        If Convert.IsDBNull(Rdr("is_post_facebook")) = False Then ret.is_post_facebook = Rdr("is_post_facebook").ToString()

                    Else
                        _error = MessageResources.MSGEV002
                    End If

                    Rdr.Close()
                Catch ex As Exception
                    ex.ToString()
                    _error = MessageResources.MSGEC104 & " #### " & ex.ToString()
                End Try
            Else
                _error = MessageResources.MSGEV001
            End If
            Return ret
        End Function

        ' SQL Statements


        'Get Insert Statement for table ERM_TS_PERSONAL_INFO
        Private ReadOnly Property SqlInsert() As String 
            Get
                Dim Sql As String=""
                Sql += "INSERT INTO " & tableName  & " (ID, CREATE_BY, CREATE_ON, UPDATE_BY, UPDATE_ON, IDCARD_NO, TITLE_NAME, FIRST_NAME, MIDDLE_NAME, LAST_NAME, POSITION_NAME, COMPANY_NAME, ADDRESS, CITY, STATE, COUNTRY, ZIPCODE, TELNO, FAXNO, EMAIL, WEBSITE, REGISTERED_CAPITAL, ANNUAL_SALE_VALUE_YEAR, ANNUAL_SALE_VALUE_VOLUMNS, DIVISION, MOBILE_NO, REGISPERIOD, IS_SEND_MAIL, IMAGE_PATH, IS_POST_FACEBOOK)"
                Sql += " VALUES("
                sql += DB.SetDouble(_ID) & ", "
                sql += DB.SetString(_CREATE_BY) & ", "
                sql += DB.SetDateTime(_CREATE_ON) & ", "
                sql += DB.SetString(_UPDATE_BY) & ", "
                sql += DB.SetDateTime(_UPDATE_ON) & ", "
                sql += DB.SetString(_IDCARD_NO) & ", "
                sql += DB.SetString(_TITLE_NAME) & ", "
                sql += DB.SetString(_FIRST_NAME) & ", "
                sql += DB.SetString(_MIDDLE_NAME) & ", "
                sql += DB.SetString(_LAST_NAME) & ", "
                sql += DB.SetString(_POSITION_NAME) & ", "
                sql += DB.SetString(_COMPANY_NAME) & ", "
                sql += DB.SetString(_ADDRESS) & ", "
                sql += DB.SetString(_CITY) & ", "
                sql += DB.SetString(_STATE) & ", "
                sql += DB.SetString(_COUNTRY) & ", "
                sql += DB.SetString(_ZIPCODE) & ", "
                sql += DB.SetString(_TELNO) & ", "
                sql += DB.SetString(_FAXNO) & ", "
                sql += DB.SetString(_EMAIL) & ", "
                sql += DB.SetString(_WEBSITE) & ", "
                sql += DB.SetDouble(_REGISTERED_CAPITAL) & ", "
                sql += DB.SetDouble(_ANNUAL_SALE_VALUE_YEAR) & ", "
                sql += DB.SetString(_ANNUAL_SALE_VALUE_VOLUMNS) & ", "
                sql += DB.SetString(_DIVISION) & ", "
                sql += DB.SetString(_MOBILE_NO) & ", "
                sql += DB.SetString(_REGISPERIOD) & ", "
                sql += DB.SetString(_IS_SEND_MAIL) & ", "
                sql += DB.SetString(_IMAGE_PATH) & ", "
                sql += DB.SetString(_IS_POST_FACEBOOK)
                sql += ")"
                Return sql
            End Get
        End Property


        'Get update statement form table ERM_TS_PERSONAL_INFO
        Private ReadOnly Property SqlUpdate() As String
            Get
                Dim Sql As String = ""
                Sql += "UPDATE " & tableName & " SET "
                Sql += "CREATE_BY = " & DB.SetString(_CREATE_BY) & ", "
                Sql += "CREATE_ON = " & DB.SetDateTime(_CREATE_ON) & ", "
                Sql += "UPDATE_BY = " & DB.SetString(_UPDATE_BY) & ", "
                Sql += "UPDATE_ON = " & DB.SetDateTime(_UPDATE_ON) & ", "
                Sql += "IDCARD_NO = " & DB.SetString(_IDCARD_NO) & ", "
                Sql += "TITLE_NAME = " & DB.SetString(_TITLE_NAME) & ", "
                Sql += "FIRST_NAME = " & DB.SetString(_FIRST_NAME) & ", "
                Sql += "MIDDLE_NAME = " & DB.SetString(_MIDDLE_NAME) & ", "
                Sql += "LAST_NAME = " & DB.SetString(_LAST_NAME) & ", "
                Sql += "POSITION_NAME = " & DB.SetString(_POSITION_NAME) & ", "
                Sql += "COMPANY_NAME = " & DB.SetString(_COMPANY_NAME) & ", "
                Sql += "ADDRESS = " & DB.SetString(_ADDRESS) & ", "
                Sql += "CITY = " & DB.SetString(_CITY) & ", "
                Sql += "STATE = " & DB.SetString(_STATE) & ", "
                Sql += "COUNTRY = " & DB.SetString(_COUNTRY) & ", "
                Sql += "ZIPCODE = " & DB.SetString(_ZIPCODE) & ", "
                Sql += "TELNO = " & DB.SetString(_TELNO) & ", "
                Sql += "FAXNO = " & DB.SetString(_FAXNO) & ", "
                Sql += "EMAIL = " & DB.SetString(_EMAIL) & ", "
                Sql += "WEBSITE = " & DB.SetString(_WEBSITE) & ", "
                Sql += "REGISTERED_CAPITAL = " & DB.SetDouble(_REGISTERED_CAPITAL) & ", "
                Sql += "ANNUAL_SALE_VALUE_YEAR = " & DB.SetDouble(_ANNUAL_SALE_VALUE_YEAR) & ", "
                Sql += "ANNUAL_SALE_VALUE_VOLUMNS = " & DB.SetString(_ANNUAL_SALE_VALUE_VOLUMNS) & ", "
                Sql += "DIVISION = " & DB.SetString(_DIVISION) & ", "
                Sql += "MOBILE_NO = " & DB.SetString(_MOBILE_NO) & ", "
                Sql += "REGISPERIOD = " & DB.SetString(_REGISPERIOD) & ", "
                Sql += "IS_SEND_MAIL = " & DB.SetString(_IS_SEND_MAIL) & ", "
                Sql += "IMAGE_PATH = " & DB.SetString(_IMAGE_PATH) & ", "
                Sql += "IS_POST_FACEBOOK = " & DB.SetString(_IS_POST_FACEBOOK) + ""
                Return Sql
            End Get
        End Property


        'Get Delete Record in table ERM_TS_PERSONAL_INFO
        Private ReadOnly Property SqlDelete() As String
            Get
                Dim Sql As String = "DELETE FROM " & tableName
                Return Sql
            End Get
        End Property


        'Get Select Statement for table ERM_TS_PERSONAL_INFO
        Private ReadOnly Property SqlSelect() As String
            Get
                Dim Sql As String = "SELECT ID, CREATE_BY, CREATE_ON, UPDATE_BY, UPDATE_ON, IDCARD_NO, TITLE_NAME, FIRST_NAME, MIDDLE_NAME, LAST_NAME, POSITION_NAME, COMPANY_NAME, ADDRESS, CITY, STATE, COUNTRY, ZIPCODE, TELNO, FAXNO, EMAIL, WEBSITE, REGISTERED_CAPITAL, ANNUAL_SALE_VALUE_YEAR, ANNUAL_SALE_VALUE_VOLUMNS, DIVISION, MOBILE_NO, REGISPERIOD, IS_SEND_MAIL, IMAGE_PATH, IS_POST_FACEBOOK FROM " & tableName
                Return Sql
            End Get
        End Property


    End Class
End Namespace
