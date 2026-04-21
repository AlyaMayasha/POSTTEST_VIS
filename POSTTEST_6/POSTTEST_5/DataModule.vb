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

    Function GetAllTransaksi() As DataTable
        Dim conn = GetConnection()
        conn.Open()

        Dim da As New MySqlDataAdapter(
            "SELECT t.id_transaksi, p.nama_produk, t.jumlah, t.total, t.tanggal " &
            "FROM tb_transaksi t JOIN tb_produk p ON t.kode_produk = p.kode_produk", conn)

        Dim dt As New DataTable
        da.Fill(dt)

        conn.Close()
        Return dt
    End Function

    Sub InsertTransaksi(id As String, kode As String, jumlah As Integer, total As Integer, tanggal As Date)
        Dim conn = GetConnection()
        conn.Open()

        Dim cmd As New MySqlCommand(
            "INSERT INTO tb_transaksi VALUES (@id,@kode,@jumlah,@total,@tanggal)", conn)

        cmd.Parameters.AddWithValue("@id", id)
        cmd.Parameters.AddWithValue("@kode", kode)
        cmd.Parameters.AddWithValue("@jumlah", jumlah)
        cmd.Parameters.AddWithValue("@total", total)
        cmd.Parameters.AddWithValue("@tanggal", tanggal)

        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub

    Sub UpdateTransaksi(id As String, kode As String, jumlah As Integer, total As Integer, tanggal As Date)
        Dim conn = GetConnection()
        conn.Open()

        Dim cmd As New MySqlCommand(
            "UPDATE tb_transaksi SET kode_produk=@kode, jumlah=@jumlah, total=@total, tanggal=@tanggal WHERE id_transaksi=@id", conn)

        cmd.Parameters.AddWithValue("@id", id)
        cmd.Parameters.AddWithValue("@kode", kode)
        cmd.Parameters.AddWithValue("@jumlah", jumlah)
        cmd.Parameters.AddWithValue("@total", total)
        cmd.Parameters.AddWithValue("@tanggal", tanggal)

        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub

    Sub DeleteTransaksi(id As String)
        Dim conn = GetConnection()
        conn.Open()

        Dim cmd As New MySqlCommand(
            "DELETE FROM tb_transaksi WHERE id_transaksi=@id", conn)

        cmd.Parameters.AddWithValue("@id", id)

        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Function SearchTransaksi(keyword As String) As DataTable

        If keyword = "" Then
            Return GetAllTransaksi()
        End If

        Dim conn As MySqlConnection = GetConnection()
        conn.Open()

        Dim query As String =
            "SELECT t.id_transaksi, p.nama_produk, t.jumlah, t.total, t.tanggal " &
            "FROM tb_transaksi t " &
            "JOIN tb_produk p ON t.kode_produk = p.kode_produk " &
            "WHERE " &
            "t.id_transaksi LIKE @cari OR " &
            "p.nama_produk LIKE @cari OR " &
            "CAST(t.jumlah AS CHAR) LIKE @cari OR " &
            "CAST(t.total AS CHAR) LIKE @cari OR " &
            "CAST(t.tanggal AS CHAR) LIKE @cari"

        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@cari", "%" & keyword & "%")

        Dim da As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)

        conn.Close()

        Return dt

    End Function

    Public Function GetStokProduk(kode As String) As Integer

        Dim conn As MySqlConnection = GetConnection()
        conn.Open()

        Dim cmd As New MySqlCommand("SELECT stok FROM tb_produk WHERE kode_produk=@kode", conn)
        cmd.Parameters.AddWithValue("@kode", kode)

        Dim hasil As Object = cmd.ExecuteScalar()
        conn.Close()

        If IsDBNull(hasil) Then
            Return 0
        Else
            Return Convert.ToInt32(hasil)
        End If

    End Function

    Public Sub KurangiStok(kode As String, jumlah As Integer)

        Dim conn As MySqlConnection = GetConnection()
        conn.Open()

        Dim cmd As New MySqlCommand(
            "UPDATE tb_produk SET stok = stok - @jumlah WHERE kode_produk=@kode", conn)

        cmd.Parameters.AddWithValue("@jumlah", jumlah)
        cmd.Parameters.AddWithValue("@kode", kode)

        cmd.ExecuteNonQuery()
        conn.Close()

    End Sub

    Public Function GetJumlahLama(id As String) As Integer

        Dim conn As MySqlConnection = GetConnection()
        conn.Open()

        Dim cmd As New MySqlCommand(
            "SELECT jumlah FROM tb_transaksi WHERE id_transaksi=@id", conn)

        cmd.Parameters.AddWithValue("@id", id)

        Dim hasil As Object = cmd.ExecuteScalar()
        conn.Close()

        If IsDBNull(hasil) Then
            Return 0
        Else
            Return Convert.ToInt32(hasil)
        End If

    End Function

    Public Sub TambahStok(kode As String, jumlah As Integer)

        Dim conn As MySqlConnection = GetConnection()
        conn.Open()

        Dim cmd As New MySqlCommand(
            "UPDATE tb_produk SET stok = stok + @jumlah WHERE kode_produk=@kode", conn)

        cmd.Parameters.AddWithValue("@jumlah", jumlah)
        cmd.Parameters.AddWithValue("@kode", kode)

        cmd.ExecuteNonQuery()
        conn.Close()

    End Sub

End Module