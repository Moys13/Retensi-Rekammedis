Imports System.Data.OleDb
Public Class dokter
    Sub Tampilkan()
        da = New OleDbDataAdapter("Select * from tbDokter", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbDokter")
        dbDokter.DataSource = (ds.Tables("tbDokter"))
    End Sub
    Sub kosongkan()
        txIDDokter.Text = ""
        txnamaDokter.Text = ""
        txalamatdokter.Text = ""
        cbjeniskelamin.Text = ""
        txtelepondokter.Text = ""
        txIDDokter.Focus()
    End Sub
    Private Sub Dokter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call Tampilkan()
        Call kosongkan()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txIDDokter.Text = "" Then
            MsgBox("Isi ID Dokter terlebih dahulu")
            Exit Sub
        Else
            cmd = New OleDbCommand("select * from tbDokter where ID_Dokter='" & txIDDokter.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                txIDDokter.Text = rd.Item("ID_Dokter")
                txnamaDokter.Text = rd.Item("Nama_Dokter")
                txalamatdokter.Text = rd.Item("Alamat_Dokter")
                cbjeniskelamin.Text = rd.Item("Jenis_Kelamin_Dokter")
                txtelepondokter.Text = rd.Item("Telepon_Dokter")
                txIDDokter.Focus()
            Else
                MsgBox("Data tidak ditemukan")
                txIDDokter.Focus()
                Call Tampilkan()
                Call kosongkan()
            End If
        End If
    End Sub

    Private Sub btSimpan_Click_1(sender As Object, e As EventArgs) Handles btSimpan.Click
        If txIDDokter.Text = "" Or txnamaDokter.Text = "" Or txalamatdokter.Text = "" Or cbjeniskelamin.Text = "" Or txtelepondokter.Text = "" Then
            MsgBox("Data belum lengkap !")
            Exit Sub
        Else
            Try
                cmd = New OleDbCommand("select * from tbDokter where ID_Dokter='" & txIDDokter.Text & "'", conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If Not rd.HasRows Then
                    Dim Sqltambah As String = "insert into tbDokter values('" & txIDDokter.Text & "','" & txnamaDokter.Text & "','" & txalamatdokter.Text & "','" & cbjeniskelamin.Text & "','" & txtelepondokter.Text & "')"
                    cmd = New OleDb.OleDbCommand(Sqltambah, conn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data tersimpan")
                    Call kosongkan()
                    Call Tampilkan()
                Else
                    If MsgBox("Data sudah ada") Then
                        Call kosongkan()
                        Exit Sub
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btUbah_Click_1(sender As Object, e As EventArgs) Handles btUbah.Click
        cmd = New OleDbCommand("delete * from tbDokter where ID_Dokter ='" & txIDDokter.Text & "'", conn)
        cmd.ExecuteNonQuery()
        Dim Sqltambah As String = "insert into tbDokter values('" & txIDDokter.Text & "','" & txnamaDokter.Text & "','" & txalamatdokter.Text & "','" & cbjeniskelamin.Text & "','" & txtelepondokter.Text & "')"
        cmd = New OleDb.OleDbCommand(Sqltambah, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data terubah")
        Call kosongkan()
        Call Tampilkan()
    End Sub

    Private Sub btHapus_Click_1(sender As Object, e As EventArgs) Handles btHapus.Click
        If txIDDokter.Text = "" Then
            MsgBox("Isi ID dokter terlebih dahulu !")
            txIDDokter.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Yakin hapus data?", "", MessageBoxButtons.YesNo) =
           Windows.Forms.DialogResult.Yes Then
                cmd = New OleDbCommand("delete * from tbDokter where ID_Dokter ='" &
               txIDDokter.Text & "'", conn)
                cmd.ExecuteNonQuery()
                Call kosongkan()
                Call Tampilkan()
            Else
                Call kosongkan()
            End If
        End If
    End Sub

    Private Sub btBatal_Click_1(sender As Object, e As EventArgs) Handles btBatal.Click
        Call kosongkan()
    End Sub

    Private Sub btKembali_Click(sender As Object, e As EventArgs) Handles btKembali.Click
        Me.Close()
        MenuRetensi.Show()
    End Sub
End Class