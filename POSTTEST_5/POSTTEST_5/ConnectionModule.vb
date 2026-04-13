Imports MySql.Data.MySqlClient

Module ConnectionModule

    Public ReadOnly ConnectionString As String =
        "server=localhost;port=3306;database=db_rajut;user id=root;password=;"

    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(ConnectionString)
    End Function

End Module