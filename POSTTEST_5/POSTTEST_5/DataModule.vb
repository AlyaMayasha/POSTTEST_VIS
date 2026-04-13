Imports MySql.Data.MySqlClient

Module DataModule

    Public Function GetAllProduk() As DataTable

        Dim conn As MySqlConnection = GetConnection()
        conn.Open()

        Dim da As New MySqlDataAdapter("SELECT * FROM tb_produk", conn)
        Dim dt As New DataTable
        da.Fill(dt)

        conn.Close()

        Return dt

    End Function

    Public Sub InsertProduk(kode As String, nama As String, kategori As String, harga As String, stok As String)

        Dim conn As MySqlConnection = GetConnection()
        conn.Open()

        Dim cmd As New MySqlCommand(
            "INSERT INTO tb_produk VALUES (@kode,@nama,@kategori,@harga,@stok)", conn)

        cmd.Parameters.AddWithValue("@kode", kode)
        cmd.Parameters.AddWithValue("@nama", nama)
        cmd.Parameters.AddWithValue("@kategori", kategori)
        cmd.Parameters.AddWithValue("@harga", harga)
        cmd.Parameters.AddWithValue("@stok", stok)

        cmd.ExecuteNonQuery()
        conn.Close()

    End Sub

    Public Sub UpdateProduk(kode As String, nama As String, kategori As String, harga As String, stok As String)

        Dim conn As MySqlConnection = GetConnection()
        conn.Open()

        Dim cmd As New MySqlCommand(
            "UPDATE tb_produk SET nama_produk=@nama, kategori=@kategori, harga=@harga, stok=@stok WHERE kode_produk=@kode", conn)

        cmd.Parameters.AddWithValue("@kode", kode)
        cmd.Parameters.AddWithValue("@nama", nama)
        cmd.Parameters.AddWithValue("@kategori", kategori)
        cmd.Parameters.AddWithValue("@harga", harga)
        cmd.Parameters.AddWithValue("@stok", stok)

        cmd.ExecuteNonQuery()
        conn.Close()

    End Sub

    Public Sub DeleteProduk(kode As String)

        Dim conn As MySqlConnection = GetConnection()
        conn.Open()

        Dim cmd As New MySqlCommand(
            "DELETE FROM tb_produk WHERE kode_produk=@kode", conn)

        cmd.Parameters.AddWithValue("@kode", kode)

        cmd.ExecuteNonQuery()
        conn.Close()

    End Sub

    Public Function SearchProduk(keyword As String) As DataTable

        Dim conn As MySqlConnection = GetConnection()
        conn.Open()

        Dim query As String = "
        SELECT * FROM tb_produk 
        WHERE kode_produk LIKE @key 
        OR nama_produk LIKE @key 
        OR kategori LIKE @key 
        OR harga LIKE @key 
        OR stok LIKE @key"

        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@key", "%" & keyword & "%")

        Dim da As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)

        conn.Close()

        Return dt

    End Function


    Public Function CekKodeProduk(kode As String) As Boolean

        Dim conn As MySqlConnection = GetConnection()
        conn.Open()

        Dim cmd As New MySqlCommand(
            "SELECT COUNT(*) FROM tb_produk WHERE kode_produk=@kode", conn)

        cmd.Parameters.AddWithValue("@kode", kode)

        Dim count As Integer = cmd.ExecuteScalar()
        conn.Close()

        Return count > 0

    End Function

End Module