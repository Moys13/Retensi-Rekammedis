<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaporanRMInakif
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbtahunretensi = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btTampilkan = New System.Windows.Forms.Button()
        Me.btBatal = New System.Windows.Forms.Button()
        Me.btKembali = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(474, 60)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "         Rekam medis yang diretensi adalah rekam medis inaktif yang" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sudah 5(lima" &
    ") tahun tidak berobat terhitung dari tanggal terakhir" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "kunjungan pasien."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(79, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Masukan tahun retensi *"
        '
        'cmbtahunretensi
        '
        Me.cmbtahunretensi.FormattingEnabled = True
        Me.cmbtahunretensi.Location = New System.Drawing.Point(263, 142)
        Me.cmbtahunretensi.Name = "cmbtahunretensi"
        Me.cmbtahunretensi.Size = New System.Drawing.Size(138, 21)
        Me.cmbtahunretensi.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(80, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(388, 36)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "* Tahun disini adalah tahun dimana mulai dilakukan retensi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btTampilkan
        '
        Me.btTampilkan.Image = Global.level6_retensi_rekammedis.My.Resources.Resources.report
        Me.btTampilkan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btTampilkan.Location = New System.Drawing.Point(43, 263)
        Me.btTampilkan.Name = "btTampilkan"
        Me.btTampilkan.Size = New System.Drawing.Size(92, 43)
        Me.btTampilkan.TabIndex = 4
        Me.btTampilkan.Text = "Tampilkan"
        Me.btTampilkan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btTampilkan.UseVisualStyleBackColor = True
        '
        'btBatal
        '
        Me.btBatal.BackColor = System.Drawing.SystemColors.Control
        Me.btBatal.Cursor = System.Windows.Forms.Cursors.Default
        Me.btBatal.Image = Global.level6_retensi_rekammedis.My.Resources.Resources.cancel
        Me.btBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btBatal.Location = New System.Drawing.Point(351, 265)
        Me.btBatal.Name = "btBatal"
        Me.btBatal.Size = New System.Drawing.Size(92, 41)
        Me.btBatal.TabIndex = 5
        Me.btBatal.Text = "Batal"
        Me.btBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btBatal.UseVisualStyleBackColor = False
        '
        'btKembali
        '
        Me.btKembali.Image = Global.level6_retensi_rekammedis.My.Resources.Resources._exit
        Me.btKembali.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btKembali.Location = New System.Drawing.Point(470, 265)
        Me.btKembali.Name = "btKembali"
        Me.btKembali.Size = New System.Drawing.Size(92, 41)
        Me.btKembali.TabIndex = 6
        Me.btKembali.Text = "Kembali"
        Me.btKembali.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btKembali.UseVisualStyleBackColor = True
        '
        'LaporanRMInakif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(599, 329)
        Me.Controls.Add(Me.btKembali)
        Me.Controls.Add(Me.btBatal)
        Me.Controls.Add(Me.btTampilkan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbtahunretensi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "LaporanRMInakif"
        Me.Text = "LaporanRMInakif"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbtahunretensi As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btTampilkan As Button
    Friend WithEvents btBatal As Button
    Friend WithEvents btKembali As Button
End Class
