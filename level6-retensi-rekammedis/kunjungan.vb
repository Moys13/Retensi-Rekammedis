Imports System.Data.OleDb
Public Class kunjungan
    Sub kosongkan()
        txnorm.Clear()
        txnamapasien.Clear()
        dtpawal.Text = ""
        dtpakhir.Text = ""
        txdiagnosa.Clear()
        txkodeicd.Clear()
        txdokter.Clear()
        txLamaPenyimpanan.Clear()
        txStatus.Clear()
        txnorm.Focus()
    End Sub
    Sub tampilkan()
        da = New OleDbDataAdapter("Select * from tbKunjungan", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbKunjungan")
        dbkunjungan.DataSource = (ds.Tables("tbKunjungan"))
        dbkunjungan.ReadOnly = True
    End Sub
    Sub status()
        Select Case txLamaPenyimpanan.Text
            Case "0 Tahun"
                txStatus.Text = " Aktif"
            Case "1 Tahun"
                txStatus.Text = " Aktif"
            Case "2 Tahun"
                txStatus.Text = " Aktif"
            Case "3 Tahun"
                txStatus.Text = " Aktif"
            Case "4 Tahun"
                txStatus.Text = " Aktif"
            Case "5 Tahun"
                txStatus.Text = " Inaktif"
            Case "6 Tahun"
                txStatus.Text = " Inaktif"
            Case "7 Tahun"
                txStatus.Text = " Inaktif"
            Case "8 Tahun"
                txStatus.Text = " Inaktif"
        End Select
    End Sub
    Private Sub Kunjungan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampilkan()
        Call kosongkan()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txnorm.Text = "" Then
            MsgBox("Isi No Rekam Medis terlebih dahulu")
            Exit Sub
        Else
            cmd = New OleDbCommand("select * from tbKunjungan where No_RM='" &
           txnorm.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                txnorm.Text = rd.Item("No_RM")
                txnamapasien.Text = rd.Item("Nama_Pasien")
                dtpawal.Text = rd.Item("Tgl_Kunjungan_Awal")
                dtpakhir.Text = rd.Item("Tgl_Kunjungan_Akhir")
                txdiagnosa.Text = rd.Item("Diagnosa_Akhir")
                txkodeicd.Text = rd.Item("Kode_ICD")
                txdokter.Text = rd.Item("Nama_Dokter")
                txLamaPenyimpanan.Text = rd.Item("Lama_Penyimpanan")
                txStatus.Text = rd.Item("Status")
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
    Sub pengurangtahun()
        Dim lama As Long
        lama = Val(txLamaPenyimpanan.Text)
        lama = Date.Now.Year - dtpakhir.Value.Year
    End Sub
    Sub perhitunganlama()
        Dim a, b, c As String
        a = Year(Now)
        b = Year(dtpakhir.Value)
        c = a - b
        txLamaPenyimpanan.Text = c + " Tahun"
    End Sub
    Private Sub txLamaPenyimpanan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txLamaPenyimpanan.TextChanged
        Call pengurangtahun()
        Call status()
    End Sub
    Private Sub dtpakhir_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpakhir.ValueChanged
        Call perhitunganlama()
    End Sub

    Private Sub btSimpan_Click_1(sender As Object, e As EventArgs) Handles btSimpan.Click
        If txnorm.Text = "" Or txnamapasien.Text = "" Or dtpawal.Text = "" Or dtpakhir.Text = "" Or txdiagnosa.Text = "" Or txkodeicd.Text = "" Or txdokter.Text = "" Or txLamaPenyimpanan.Text = "" Or txStatus.Text = "" Then
            MsgBox("Data belum lengkap !")
            Exit Sub
        Else
            cmd = New OleDbCommand("select * from tbKunjungan where No_RM='" &
           txnorm.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                Dim Sqltambah As String = "insert into tbKunjungan values('" & txnorm.Text & "','" & txnamapasien.Text & "','" & dtpawal.Text & "','" & dtpakhir.Text & "','" & txdiagnosa.Text & "','" & txkodeicd.Text & "','" & txdokter.Text & "','" & txLamaPenyimpanan.Text & "','" & txStatus.Text & "')"
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

    Private Sub btUbah_Click_1(sender As Object, e As EventArgs) Handles btUbah.Click
        cmd = New OleDbCommand("delete * from tbKunjungan where No_RM ='" & txnorm.Text & "'", conn)
        cmd.ExecuteNonQuery()
        Dim Sqltambah As String = "insert into tbKunjungan values('" & txnorm.Text & "','" & txnamapasien.Text & "','" & dtpawal.Text & "','" & dtpakhir.Text & "','" & txdiagnosa.Text & "','" & txkodeicd.Text & "','" & txdokter.Text & "','" & txLamaPenyimpanan.Text & "','" & txStatus.Text & "')"
        cmd = New OleDb.OleDbCommand(Sqltambah, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data terubah")
        Call kosongkan()
        Call tampilkan()
    End Sub

    Private Sub btHapus_Click_1(sender As Object, e As EventArgs) Handles btHapus.Click
        If txnorm.Text = "" Then
            MsgBox("Isi No Rekam Medis terlebih dahulu !")
            txnorm.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Yakin hapus data?", "", MessageBoxButtons.YesNo) =
           Windows.Forms.DialogResult.Yes Then
                cmd = New OleDbCommand("delete * from tbKunjungan where No_RM ='" &
               txnorm.Text & "'", conn)
                cmd.ExecuteNonQuery()
                Call kosongkan()
                Call tampilkan()
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