Public Module ModuleBuku

    Public daftarJudul(99) As String
    Public daftarGenre(99) As String
    Public jumlahBuku As Integer = 0

    Public Sub TambahBuku(ByVal judul As String, ByVal genre As String)

        If jumlahBuku >= daftarJudul.Length Then
            MessageBox.Show("Daftar buku sudah penuh")
            Exit Sub
        End If

        daftarJudul(jumlahBuku) = judul
        daftarGenre(jumlahBuku) = genre
        jumlahBuku += 1

    End Sub

    Public Function CariIndexBuku(ByVal judul As String) As Integer
        For i As Integer = 0 To jumlahBuku - 1
            If daftarJudul(i).ToLower() = judul.ToLower() Then
                Return i
            End If
        Next
        Return -1
    End Function

    Public Sub HapusBuku(ByRef index As Integer)
        If index >= 0 AndAlso index < jumlahBuku Then
            For i As Integer = index To jumlahBuku - 2
                daftarJudul(i) = daftarJudul(i + 1)
                daftarGenre(i) = daftarGenre(i + 1)
            Next
            jumlahBuku -= 1
        End If
    End Sub

End Module