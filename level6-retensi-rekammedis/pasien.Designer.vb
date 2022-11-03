<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pasien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pasien))
        Me.txnorm = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_cari = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txnamapasien = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txalamatpasien = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbjeniskelamin = New System.Windows.Forms.ComboBox()
        Me.cbstatus = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dttanggallahir = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txumur = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbagama = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtelepon = New System.Windows.Forms.TextBox()
        Me.txpekerjaan = New System.Windows.Forms.TextBox()
        Me.btUbah = New System.Windows.Forms.Button()
        Me.btHapus = New System.Windows.Forms.Button()
        Me.btBatal = New System.Windows.Forms.Button()
        Me.btKembali = New System.Windows.Forms.Button()
        Me.dbpasien = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btSimpan = New System.Windows.Forms.Button()
        CType(Me.dbpasien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txnorm
        '
        Me.txnorm.Location = New System.Drawing.Point(101, 86)
        Me.txnorm.Name = "txnorm"
        Me.txnorm.Size = New System.Drawing.Size(100, 20)
        Me.txnorm.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "No RM"
        '
        'btn_cari
        '
        Me.btn_cari.Image = Global.level6_retensi_rekammedis.My.Resources.Resources.search
        Me.btn_cari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cari.Location = New System.Drawing.Point(207, 69)
        Me.btn_cari.Name = "btn_cari"
        Me.btn_cari.Size = New System.Drawing.Size(64, 37)
        Me.btn_cari.TabIndex = 2
        Me.btn_cari.Text = "Cari"
        Me.btn_cari.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cari.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nama"
        '
        'txnamapasien
        '
        Me.txnamapasien.Location = New System.Drawing.Point(101, 112)
        Me.txnamapasien.Name = "txnamapasien"
        Me.txnamapasien.Size = New System.Drawing.Size(281, 20)
        Me.txnamapasien.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Alamat"
        '
        'txalamatpasien
        '
        Me.txalamatpasien.Location = New System.Drawing.Point(101, 138)
        Me.txalamatpasien.Name = "txalamatpasien"
        Me.txalamatpasien.Size = New System.Drawing.Size(375, 20)
        Me.txalamatpasien.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Jenis Kelamin"
        '
        'cbjeniskelamin
        '
        Me.cbjeniskelamin.FormattingEnabled = True
        Me.cbjeniskelamin.Items.AddRange(New Object() {"Laki - Laki", "Perempuan"})
        Me.cbjeniskelamin.Location = New System.Drawing.Point(101, 164)
        Me.cbjeniskelamin.Name = "cbjeniskelamin"
        Me.cbjeniskelamin.Size = New System.Drawing.Size(160, 21)
        Me.cbjeniskelamin.TabIndex = 8
        '
        'cbstatus
        '
        Me.cbstatus.FormattingEnabled = True
        Me.cbstatus.Items.AddRange(New Object() {"Lajang", "Menikah", "Cerai Mati", "Cerai Hidup"})
        Me.cbstatus.Location = New System.Drawing.Point(101, 191)
        Me.cbstatus.Name = "cbstatus"
        Me.cbstatus.Size = New System.Drawing.Size(160, 21)
        Me.cbstatus.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Status"
        '
        'dttanggallahir
        '
        Me.dttanggallahir.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dttanggallahir.Location = New System.Drawing.Point(101, 218)
        Me.dttanggallahir.Name = "dttanggallahir"
        Me.dttanggallahir.Size = New System.Drawing.Size(160, 20)
        Me.dttanggallahir.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Tanggal Lahir"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 247)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Umur"
        '
        'txumur
        '
        Me.txumur.Location = New System.Drawing.Point(101, 244)
        Me.txumur.Name = "txumur"
        Me.txumur.Size = New System.Drawing.Size(58, 20)
        Me.txumur.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(161, 247)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Tahun"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(271, 167)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Pekerjaan"
        '
        'cbagama
        '
        Me.cbagama.FormattingEnabled = True
        Me.cbagama.Items.AddRange(New Object() {"Islam", "Kristen", "Protestan", "Hindu", "Budha"})
        Me.cbagama.Location = New System.Drawing.Point(361, 191)
        Me.cbagama.Name = "cbagama"
        Me.cbagama.Size = New System.Drawing.Size(160, 21)
        Me.cbagama.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(271, 194)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Agama"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(271, 224)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "No Telepon"
        '
        'txtelepon
        '
        Me.txtelepon.Location = New System.Drawing.Point(361, 221)
        Me.txtelepon.Name = "txtelepon"
        Me.txtelepon.Size = New System.Drawing.Size(160, 20)
        Me.txtelepon.TabIndex = 21
        '
        'txpekerjaan
        '
        Me.txpekerjaan.Location = New System.Drawing.Point(361, 164)
        Me.txpekerjaan.Name = "txpekerjaan"
        Me.txpekerjaan.Size = New System.Drawing.Size(160, 20)
        Me.txpekerjaan.TabIndex = 22
        '
        'btUbah
        '
        Me.btUbah.Image = Global.level6_retensi_rekammedis.My.Resources.Resources.edit
        Me.btUbah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btUbah.Location = New System.Drawing.Point(556, 123)
        Me.btUbah.Name = "btUbah"
        Me.btUbah.Size = New System.Drawing.Size(87, 43)
        Me.btUbah.TabIndex = 24
        Me.btUbah.Text = "Ubah"
        Me.btUbah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btUbah.UseVisualStyleBackColor = True
        '
        'btHapus
        '
        Me.btHapus.Image = Global.level6_retensi_rekammedis.My.Resources.Resources.delete
        Me.btHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btHapus.Location = New System.Drawing.Point(556, 172)
        Me.btHapus.Name = "btHapus"
        Me.btHapus.Size = New System.Drawing.Size(87, 43)
        Me.btHapus.TabIndex = 25
        Me.btHapus.Text = "Hapus"
        Me.btHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btHapus.UseVisualStyleBackColor = True
        '
        'btBatal
        '
        Me.btBatal.Image = Global.level6_retensi_rekammedis.My.Resources.Resources.cancel
        Me.btBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btBatal.Location = New System.Drawing.Point(556, 221)
        Me.btBatal.Name = "btBatal"
        Me.btBatal.Size = New System.Drawing.Size(87, 41)
        Me.btBatal.TabIndex = 26
        Me.btBatal.Text = "Batal"
        Me.btBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btBatal.UseVisualStyleBackColor = True
        '
        'btKembali
        '
        Me.btKembali.Image = Global.level6_retensi_rekammedis.My.Resources.Resources._exit
        Me.btKembali.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btKembali.Location = New System.Drawing.Point(556, 275)
        Me.btKembali.Name = "btKembali"
        Me.btKembali.Size = New System.Drawing.Size(87, 39)
        Me.btKembali.TabIndex = 27
        Me.btKembali.Text = "Kembali"
        Me.btKembali.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btKembali.UseVisualStyleBackColor = True
        '
        'dbpasien
        '
        Me.dbpasien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dbpasien.Location = New System.Drawing.Point(12, 320)
        Me.dbpasien.Name = "dbpasien"
        Me.dbpasien.Size = New System.Drawing.Size(648, 201)
        Me.dbpasien.TabIndex = 28
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(97, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(321, 24)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Rumah Sakit Moyo Sumber Sehat"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(101, 33)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(168, 13)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "JL. Makmur No. 13 Kab. Bandung"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-5, -14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'btSimpan
        '
        Me.btSimpan.Image = Global.level6_retensi_rekammedis.My.Resources.Resources.save
        Me.btSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btSimpan.Location = New System.Drawing.Point(556, 73)
        Me.btSimpan.Name = "btSimpan"
        Me.btSimpan.Size = New System.Drawing.Size(87, 44)
        Me.btSimpan.TabIndex = 23
        Me.btSimpan.Text = "Simpan"
        Me.btSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSimpan.UseVisualStyleBackColor = True
        '
        'pasien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(673, 532)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dbpasien)
        Me.Controls.Add(Me.btKembali)
        Me.Controls.Add(Me.btBatal)
        Me.Controls.Add(Me.btHapus)
        Me.Controls.Add(Me.btUbah)
        Me.Controls.Add(Me.btSimpan)
        Me.Controls.Add(Me.txpekerjaan)
        Me.Controls.Add(Me.txtelepon)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cbagama)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txumur)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dttanggallahir)
        Me.Controls.Add(Me.cbstatus)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbjeniskelamin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txalamatpasien)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txnamapasien)
        Me.Controls.Add(Me.btn_cari)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txnorm)
        Me.Name = "pasien"
        Me.Text = "Form1"
        CType(Me.dbpasien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txnorm As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_cari As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txnamapasien As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txalamatpasien As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbjeniskelamin As ComboBox
    Friend WithEvents cbstatus As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dttanggallahir As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txumur As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbagama As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtelepon As TextBox
    Friend WithEvents txpekerjaan As TextBox
    Friend WithEvents btSimpan As Button
    Friend WithEvents btUbah As Button
    Friend WithEvents btHapus As Button
    Friend WithEvents btBatal As Button
    Friend WithEvents btKembali As Button
    Friend WithEvents dbpasien As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
End Class
