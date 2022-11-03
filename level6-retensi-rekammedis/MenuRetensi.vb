Public Class MenuRetensi
    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub PasienToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasienToolStripMenuItem.Click
        pasien.Show()
    End Sub

    Private Sub DokterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DokterToolStripMenuItem.Click
        dokter.Show()
    End Sub

    Private Sub KunjunganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KunjunganToolStripMenuItem.Click
        kunjungan.Show()
    End Sub

    Private Sub BeritaAcaraRetensiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeritaAcaraRetensiToolStripMenuItem.Click
        berita_acara_retensi.Show()
    End Sub
End Class