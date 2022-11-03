Imports System.Data.OleDb
Public Class LaporanRMInakif
    Private Sub btBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBatal.Click
        cmbtahunretensi.Text = ""
    End Sub
    Private Sub LaporanRMInakif_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
    End Sub
    Private Sub btKembali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btKembali.Click
        MenuRetensi.Show()
        Me.Close()
    End Sub
    Private Sub btTampilkan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTampilkan.Click
        Dim indikator As New CRLaporanInaktif
        Dim A As CrystalDecisions.CrystalReports.Engine.Table
        Dim B As CrystalDecisions.Shared.TableLogOnInfo
        Dim c, d As String
        ' Dim d As Integer
        If cmbtahunretensi.Text = "" Then
            MsgBox("Masukkan tahun retensi!")
            Exit Sub
        Else
            c = Format(Now, "yyyy")
            d = Val(c) - Val(cmbtahunretensi.Text)
            If Val(d) < 5 Then
                MsgBox("Data Inaktif harus 5 tahun ke atas")
                Exit Sub
            Else
                cmd = New OleDbCommand("select * from tbKunjungan where [Lama_Penyimpanan]='" & d & "';", conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If Not rd.HasRows Then
                    MsgBox("Data tidak ditemukan")
                    Exit Sub
                Else
                    viewLaporanInaktif.crvLaporan.ReportSource = Nothing
                    viewLaporanInaktif.crvLaporan.RefreshReport()
                    indikator.Load(Application.StartupPath & "\CRLaporanInaktif.rpt")
                    viewLaporanInaktif.crvLaporan.SelectionFormula = "totext({tbKunjungan.Lama_Penyimpanan})='" & d & "'"
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
                    viewLaporanInaktif.crvLaporan.ReportSource = indikator
                    viewLaporanInaktif.Show()
                End If
            End If
        End If
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub
End Class