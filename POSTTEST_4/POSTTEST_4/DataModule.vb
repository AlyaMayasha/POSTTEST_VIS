Imports System.IO

Module DataModule

    Public Function BuatIsiFile(
    nama As String,
    id As String,
    tipe As String,
    email As String,
    alamat As String,
    gender As String,
    telepon As String,
    role As String,
    aktivitas As String
) As String

        Return "Nama=" & nama & Environment.NewLine &
           "ID=" & id & Environment.NewLine &
           "Tipe Pokemon=" & tipe & Environment.NewLine &
           "Email=" & email & Environment.NewLine &
           "Alamat=" & alamat & Environment.NewLine &
           "JenisKelamin=" & gender & Environment.NewLine &
           "Telepon=" & telepon & Environment.NewLine &
           "Role=" & role & Environment.NewLine &
           "Aktivitas=" & aktivitas
    End Function

    Public Function SimpanDataKeFile(sfd As SaveFileDialog, isi As String) As Boolean
        sfd.Filter = "Text File|*.txt|CSV File|*.csv"
        sfd.Title = "Simpan Data"

        If sfd.ShowDialog() = DialogResult.OK Then
            File.WriteAllText(sfd.FileName, isi)
            Return True
        End If

        Return False
    End Function

    Public Function BukaDataDariFile(ofd As OpenFileDialog) As Dictionary(Of String, String)
        ofd.Filter = "Text File|*.txt|CSV File|*.csv"

        If ofd.ShowDialog() <> DialogResult.OK Then Return Nothing

        Dim dict As New Dictionary(Of String, String)
        Dim lines() As String = File.ReadAllLines(ofd.FileName)

        For Each baris In lines
            Dim p() = baris.Split("="c)
            If p.Length = 2 Then dict(p(0)) = p(1)
        Next

        Return dict
    End Function

    Public Function AmbilNilai(dict As Dictionary(Of String, String), key As String) As String
        If dict.ContainsKey(key) Then Return dict(key)
        Return ""
    End Function

End Module