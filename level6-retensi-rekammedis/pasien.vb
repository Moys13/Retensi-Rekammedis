Imports System.Data.OleDb
Public Class pasien
    Sub kosongkan()
        txnorm.Clear()
        txnamapasien.Clear()
        txalamatpasien.Clear()
        cbjeniskelamin.Text = ""
        cbstatus.Text = ""
        dttanggallahir.Text = ""
        txumur.Clear()
        txpekerjaan.Clear()
        cbagama.Text = ""
        txtelepon.Clear()
        txnorm.Focus()
    End Sub
    Sub tampilkan()
        da = New OleDbDataAdapter("Select * from tbPasien", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbPasien")
        dbpasien.DataSource = (ds.Tables("tbPasien"))
        dbpasien.ReadOnly = True
    End Sub
    Sub pengurangtahun()
        Dim age As Long
        age = Val(txumur.Text)
        age = Date.Now.Year - dttanggallahir.Value.Year
    End Sub
    Sub perhitunganumur()
        Dim a, b, c As String
        a = Year(Now)
        b = Year(dttanggallahir.Value)
        c = a - b
        txumur.Text = c
    End Sub
    Private Sub Pasien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampilkan()
        Call kosongkan()
    End Sub
    Private Sub btBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBatal.Click
        Call kosongkan()
    End Sub
    Private Sub btKembali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btKembali.Click
        Me.Close()
        MenuRetensi.Show()
    End Sub
    Private Sub btSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSimpan.Click
        If txnorm.Text = "" Or txnamapasien.Text = "" Or txalamatpasien.Text = "" Or cbjeniskelamin.Text = "" Or cbstatus.Text = "" Or dttanggallahir.Text = "" Or txumur.Text = "" Or txpekerjaan.Text = "" Or cbagama.Text = "" Or txtelepon.Text = "" Then
            MsgBox("Data belum lengkap !")
            Exit Sub
        Else
            cmd = New OleDbCommand("select * from tbPasien where No_RM='" &
           txnorm.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                Dim Sqltambah As String = "insert into tbPasien values('" & txnorm.Text & "','" & txnamapasien.Text & "','" & txalamatpasien.Text & "','" & cbjeniskelamin.Text & "','" & cbstatus.Text & "','" & dttanggallahir.Text & "','" & txumur.Text & "','" & txpekerjaan.Text & "','" & cbagama.Text & "','" & txtelepon.Text & "')"
                cmd = New OleDb.OleDbCommand(Sqltambah, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data tersimpan")
                Call kosongkan()
                Call tampilkan()
            Else
                If MsgBox("Data sudah ada") Then
                    Call kosongkan()
                End If
            End If
        End If
    End Sub
    Private Sub btHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btHapus.Click
        If txnorm.Text = "" Then
            MsgBox("Isi No Rekam Medis terlebih dahulu !")
            txnorm.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Yakin hapus data?", "", MessageBoxButtons.YesNo) =
           Windows.Forms.DialogResult.Yes Then
                cmd = New OleDbCommand("delete * from tbPasien where No_RM ='" &
               txnorm.Text & "'", conn)
                cmd.ExecuteNonQuery()
                Call kosongkan()
                Call tampilkan()
            Else
                Call kosongkan()
            End If
        End If
    End Sub

    Private Sub btUbah_Click(sender As Object, e As EventArgs) Handles btUbah.Click
        cmd = New OleDbCommand("delete * from tbPasien where No_RM ='" & txnorm.Text & "'", conn)
        cmd.ExecuteNonQuery()
        Dim Sqltambah As String = "insert into tbPasien values('" & txnorm.Text & "','" & txnamapasien.Text & "','" & txalamatpasien.Text & "','" & cbjeniskelamin.Text & "','" & cbstatus.Text & "','" & dttanggallahir.Text & "','" & txumur.Text & "','" & txpekerjaan.Text & "','" & cbagama.Text & "','" & txtelepon.Text & "')"
        cmd = New OleDb.OleDbCommand(Sqltambah, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data terubah")
        Call kosongkan()
        Call tampilkan()
    End Sub

    Private Sub btn_cari_Click(sender As Object, e As EventArgs) Handles btn_cari.Click
        If txnorm.Text = "" Then
            MsgBox("Isi No Rekam Medis terlebih dahulu")
            Exit Sub
        Else
            cmd = New OleDbCommand("select * from tbPasien where No_RM='" &
           txnorm.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                txnorm.Text = rd.Item("No_RM")
                txnamapasien.Text = rd.Item("Nama_Pasien")
                txalamatpasien.Text = rd.Item("Alamat_Pasien")
                cbjeniskelamin.Text = rd.Item("Jenis_Kelamin_Pasien")
                cbstatus.Text = rd.Item("Status")
                dttanggallahir.Text = rd.Item("Tanggal_Lahir")
                txumur.Text = rd.Item("Umur")
                txpekerjaan.Text = rd.Item("Pekerjaan")
                cbagama.Text = rd.Item("Agama")
                txtelepon.Text = rd.Item("No_Telepon")
                btUbah.Enabled = True
                btHapus.Enabled = True
                txnorm.Focus()
            Else
                MsgBox("Data tidak ditemukan")
                txnorm.Focus()
                Call tampilkan()
                Call kosongkan()
            End If
        End If
    End Sub

    Private Sub dttanggallahir_ValueChanged(sender As Object, e As EventArgs) Handles dttanggallahir.ValueChanged
        Call perhitunganumur()
    End Sub

    Private Sub txumur_TextChanged(sender As Object, e As EventArgs) Handles txumur.TextChanged
        Call pengurangtahun()
    End Sub
End Class
