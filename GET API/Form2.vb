Imports System.Net
Imports System.IO
Imports System.Web.Script.Serialization
Public Class Form2
    Private Sub getdata()
        Try
            Dim uriString As String = "http://localhost:8080/wp-project/api/getdatapeminjam"
            Dim uri As New Uri(uriString)
            Dim request As HttpWebRequest = HttpWebRequest.Create(uri)
            request.Method = "GET"
            Dim response As HttpWebResponse = request.GetResponse()
            Dim read = New StreamReader(response.GetResponseStream())
            Dim raw As String = read.ReadToEnd()
            Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(raw)
            For Each item As Object In dict
                DataGridView1.Rows.Add(item("NamaAnggota").ToString, item("NamaBuku").ToString, item("TotalPinjamBuku").ToString, item("tanggal").ToString)
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getdata()
    End Sub

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        Try

            simpanapi()


        Catch ex As Exception
            MsgBox("Data Berhasil Disimpan", MsgBoxStyle.Information, "Pemberitahuan")
            Clear()
        End Try
    End Sub


    Private Sub Clear()
        kd_anggota.Text = ""
        kd_buku.Text = ""
        tanggal_pinjam.Text = ""
        jumlah_pinjam.Text = ""
    End Sub

    Private Sub simpanapi()
        Dim uriString As String = "http://localhost:8080/wp-project/api/postdata/" & kd_anggota.Text.Trim & "/" & kd_buku.Text.Trim & "/" & jumlah_pinjam.Text.Trim & "/" & tanggal_pinjam.Text.Trim
        Dim uri As New Uri(uriString)
        Dim request As HttpWebRequest = HttpWebRequest.Create(uri)
        request.Method = "POST"
        Dim response As HttpWebResponse = request.GetResponse()
        Dim read = New StreamReader(response.GetResponseStream())
        Dim raw As String = read.ReadToEnd()
        Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(raw)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class