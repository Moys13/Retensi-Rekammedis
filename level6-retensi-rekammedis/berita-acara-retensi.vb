Imports System.Data.OleDb
Public Class berita_acara_retensi
    Sub kosongkan()
        noBA.Clear()
        cmbhari.Text = ""
        dtppelaksanaan.Text = ""
        txjumlah.Clear()
        txkunjunganakhir.Clear()
        noBA.Focus()
    End Sub

    Sub tampilkan()
        da = New OleDbDataAdapter("Select * from tbBeritaAcara", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbBeritaAcara")
        dbBeritaAcara.DataSource = (ds.Tables("tbBeritaAcara"))
        dbBeritaAcara.ReadOnly = True
    End Sub

    Private Sub BeritaAcaraRetensi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call kosongkan()
        Call tampilkan()
        noBA.Focus()
    End Sub

    Private Sub btTampilkan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTampilkan.Click
        Dim indikator As New CRBeritaAcaraRetensi
        Dim A As CrystalDecisions.CrystalReports.Engine.Table
        Dim B As CrystalDecisions.Shared.TableLogOnInfo
        If nocetakBA.Text = "" Then
            MsgBox("Masukkan nomor berita acara!")
            Exit Sub
        Else
            cmd = New OleDbCommand("select * from tbBeritaAcara where No_BA='" &
           nocetakBA.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                MsgBox("Data tidak ditemukan")
                Exit Sub
            Else
                viewBeritaAcara.CrystalReportViewer1.ReportSource = Nothing
                viewBeritaAcara.CrystalReportViewer1.RefreshReport()
                indikator.Load(Application.StartupPath & "\CRBeritaAcaraRetensi.rpt")
                viewBeritaAcara.CrystalReportViewer1.SelectionFormula =
               "totext({tbBeritaAcara.No_BA})='" & nocetakBA.Text & "'"
                For Each A In indikator.Database.Tables
                    B = A.LogOnInfo
                    With B.ConnectionInfo
                        .ServerName = Application.StartupPath & "\dbRetensi.mdb"
                        .UserID = ""
                        .Password = ""
                        .DatabaseName = ""
                    End With
                    A.ApplyLogOnInfo(B)
                Next A
                viewBeritaAcara.CrystalReportViewer1.ReportSource = indikator
                viewBeritaAcara.Show()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btCari.Click
        If noBA.Text = "" Then
            MsgBox("Isi ID Dokter terlebih dahulu")
            Exit Sub
        Else
            cmd = New OleDbCommand("select * from tbBeritaAcara where No_BA='" &
           noBA.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                noBA.Text = rd.Item("No_BA")
                cmbhari.Text = rd.Item("Hari")
                dtppelaksanaan.Text = rd.Item("Waktu")
                txjumlah.Text = rd.Item("Jumlah")
                txkunjunganakhir.Text = rd.Item("Tahun_Kunjungan_Akhir")
                noBA.Focus()
            Else
                MsgBox("Data tidak ditemukan")
                noBA.Focus()
                Call tampilkan()
                Call kosongkan()
            End If
        End If
    End Sub
    Private Sub nocetakBA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nocetakBA.TextChanged
        btCari.Enabled = False
        btSimpan.Enabled = False
        btBatal.Enabled = False
        btHapus.Enabled = False
        btKembali.Enabled = True
        btUbah.Enabled = False
        nocetakBA.Focus()
    End Sub
    Private Sub btBatalCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBatalCetak.Click
        nocetakBA.Text = ""
    End Sub

    Private Sub btSimpan_Click_1(sender As Object, e As EventArgs) Handles btSimpan.Click
        If noBA.Text = "" Or cmbhari.Text = "" Or dtppelaksanaan.Text = "" Or txjumlah.Text = "" Or txkunjunganakhir.Text = "" Then
            MsgBox("Data belum lengkap !")
            Exit Sub
        Else
            Try
                Dim Sqltambah As String = "insert into tbBeritaAcara values('" &
               noBA.Text & "','" & cmbhari.Text & "','" & dtppelaksanaan.Text & "','" & txjumlah.Text & "','" & txkunjunganakhir.Text & "')"
                cmd = New OleDb.OleDbCommand(Sqltambah, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data tersimpan")
                Call kosongkan()
                Call tampilkan()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btUbah_Click_1(sender As Object, e As EventArgs) Handles btUbah.Click
        cmd = New OleDbCommand("delete * from tbBeritaAcara where No_BA='" & noBA.Text & "'", conn)
        cmd.ExecuteNonQuery()
        Dim Sqltambah As String = "insert into tbBeritaAcara values('" & noBA.Text & "','" & cmbhari.Text & "','" & dtppelaksanaan.Text & "','" & txjumlah.Text & "','" & txkunjunganakhir.Text & "')"
        cmd = New OleDb.OleDbCommand(Sqltambah, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data terubah")
        Call kosongkan()
        Call tampilkan()
    End Sub

    Private Sub btHapus_Click_1(sender As Object, e As EventArgs) Handles btHapus.Click
        If noBA.Text = "" Then
            MsgBox("Isi No Berita Acara terlebih dahulu !")
            noBA.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Yakin hapus data?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New OleDbCommand("delete * from tbBeritaAcara where No_BA ='" &
               noBA.Text & "'", conn)
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

    Private Sub btKembali_Click_1(sender As Object, e As EventArgs) Handles btKembali.Click
        Me.Close()
        MenuRetensi.Show()
    End Sub
End Class