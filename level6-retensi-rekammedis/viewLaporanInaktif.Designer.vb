<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewLaporanInaktif
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.crvLaporan = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CRLaporanInaktif1 = New level6_retensi_rekammedis.CRLaporanInaktif()
        Me.SuspendLayout()
        '
        'crvLaporan
        '
        Me.crvLaporan.ActiveViewIndex = 0
        Me.crvLaporan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvLaporan.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvLaporan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvLaporan.Location = New System.Drawing.Point(0, 0)
        Me.crvLaporan.Name = "crvLaporan"
        Me.crvLaporan.ReportSource = Me.CRLaporanInaktif1
        Me.crvLaporan.Size = New System.Drawing.Size(800, 450)
        Me.crvLaporan.TabIndex = 0
        '
        'viewLaporanInaktif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.crvLaporan)
        Me.Name = "viewLaporanInaktif"
        Me.Text = "viewLaporanInaktif"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crvLaporan As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CRLaporanInaktif1 As CRLaporanInaktif
End Class
