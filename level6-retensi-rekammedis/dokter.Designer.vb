<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dokter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dokter))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txalamatdokter = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txnamaDokter = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txIDDokter = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtelepondokter = New System.Windows.Forms.TextBox()
        Me.cbjeniskelamin = New System.Windows.Forms.ComboBox()
        Me.dbDokter = New System.Windows.Forms.DataGridView()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btKembali = New System.Windows.Forms.Button()
        Me.btBatal = New System.Windows.Forms.Button()
        Me.btHapus = New System.Windows.Forms.Button()
        Me.btUbah = New System.Windows.Forms.Button()
        Me.btSimpan = New System.Windows.Forms.Button()
        CType(Me.dbDokter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Alamat"
        '
        'txalamatdokter
        '
        Me.txalamatdokter.Location = New System.Drawing.Point(107, 136)
        Me.txalamatdokter.Name = "txalamatdokter"
        Me.txalamatdokter.Size = New System.Drawing.Size(375, 20)
        Me.txalamatdokter.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nama"
        '
        'txnamaDokter
        '
        Me.txnamaDokter.Location = New System.Drawing.Point(107, 110)
        Me.txnamaDokter.Name = "txnamaDokter"
        Me.txnamaDokter.Size = New System.Drawing.Size(281, 20)
        Me.txnamaDokter.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Image = Global.level6_retensi_rekammedis.My.Resources.Resources.search
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(213, 69)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 35)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Cari"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ID Dokter"
        '
        'txIDDokter
        '
        Me.txIDDokter.Location = New System.Drawing.Point(107, 84)
        Me.txIDDokter.Name = "txIDDokter"
        Me.txIDDokter.Size = New System.Drawing.Size(100, 20)
        Me.txIDDokter.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Telepon"
        '
        'txtelepondokter
        '
        Me.txtelepondokter.Location = New System.Drawing.Point(107, 188)
        Me.txtelepondokter.Name = "txtelepondokter"
        Me.txtelepondokter.Size = New System.Drawing.Size(194, 20)
        Me.txtelepondokter.TabIndex = 16
        '
        'cbjeniskelamin
        '
        Me.cbjeniskelamin.FormattingEnabled = True
        Me.cbjeniskelamin.Items.AddRange(New Object() {"Laki - Laki", "Perempuan"})
        Me.cbjeniskelamin.Location = New System.Drawing.Point(107, 162)
        Me.cbjeniskelamin.Name = "cbjeniskelamin"
        Me.cbjeniskelamin.Size = New System.Drawing.Size(121, 21)
        Me.cbjeniskelamin.TabIndex = 18
        '
        'dbDokter
        '
        Me.dbDokter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dbDokter.Location = New System.Drawing.Point(12, 293)
        Me.dbDokter.Name = "dbDokter"
        Me.dbDokter.Size = New System.Drawing.Size(599, 232)
        Me.dbDokter.TabIndex = 33
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(107, 33)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(168, 13)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "JL. Makmur No. 13 Kab. Bandung"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(103, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(321, 24)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Rumah Sakit Moyo Sumber Sehat"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, -14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'btKembali
        '
        Me.btKembali.Image = Global.level6_retensi_rekammedis.My.Resources.Resources._exit
        Me.btKembali.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btKembali.Location = New System.Drawing.Point(515, 250)
        Me.btKembali.Name = "btKembali"
        Me.btKembali.Size = New System.Drawing.Size(87, 39)
        Me.btKembali.TabIndex = 46
        Me.btKembali.Text = "Kembali"
        Me.btKembali.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btKembali.UseVisualStyleBackColor = True
        '
        'btBatal
        '
        Me.btBatal.Image = Global.level6_retensi_rekammedis.My.Resources.Resources.cancel
        Me.btBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btBatal.Location = New System.Drawing.Point(515, 196)
        Me.btBatal.Name = "btBatal"
        Me.btBatal.Size = New System.Drawing.Size(87, 41)
        Me.btBatal.TabIndex = 45
        Me.btBatal.Text = "Batal"
        Me.btBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btBatal.UseVisualStyleBackColor = True
        '
        'btHapus
        '
        Me.btHapus.Image = Global.level6_retensi_rekammedis.My.Resources.Resources.delete
        Me.btHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btHapus.Location = New System.Drawing.Point(515, 147)
        Me.btHapus.Name = "btHapus"
        Me.btHapus.Size = New System.Drawing.Size(87, 43)
        Me.btHapus.TabIndex = 44
        Me.btHapus.Text = "Hapus"
        Me.btHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btHapus.UseVisualStyleBackColor = True
        '
        'btUbah
        '
        Me.btUbah.Image = Global.level6_retensi_rekammedis.My.Resources.Resources.edit
        Me.btUbah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btUbah.Location = New System.Drawing.Point(515, 98)
        Me.btUbah.Name = "btUbah"
        Me.btUbah.Size = New System.Drawing.Size(87, 43)
        Me.btUbah.TabIndex = 43
        Me.btUbah.Text = "Ubah"
        Me.btUbah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btUbah.UseVisualStyleBackColor = True
        '
        'btSimpan
        '
        Me.btSimpan.Image = Global.level6_retensi_rekammedis.My.Resources.Resources.save
        Me.btSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btSimpan.Location = New System.Drawing.Point(515, 48)
        Me.btSimpan.Name = "btSimpan"
        Me.btSimpan.Size = New System.Drawing.Size(87, 44)
        Me.btSimpan.TabIndex = 42
        Me.btSimpan.Text = "Simpan"
        Me.btSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSimpan.UseVisualStyleBackColor = True
        '
        'dokter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(623, 537)
        Me.Controls.Add(Me.btKembali)
        Me.Controls.Add(Me.btBatal)
        Me.Controls.Add(Me.btHapus)
        Me.Controls.Add(Me.btUbah)
        Me.Controls.Add(Me.btSimpan)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dbDokter)
        Me.Controls.Add(Me.cbjeniskelamin)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtelepondokter)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txalamatdokter)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txnamaDokter)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txIDDokter)
        Me.Name = "dokter"
        Me.Text = "Dokter"
        CType(Me.dbDokter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents txalamatdokter As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txnamaDokter As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txIDDokter As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtelepondokter As TextBox
    Friend WithEvents cbjeniskelamin As ComboBox
    Friend WithEvents dbDokter As DataGridView
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btKembali As Button
    Friend WithEvents btBatal As Button
    Friend WithEvents btHapus As Button
    Friend WithEvents btUbah As Button
    Friend WithEvents btSimpan As Button
End Class
