<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class berita_acara_retensi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(berita_acara_retensi))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.noBA = New System.Windows.Forms.TextBox()
        Me.btCari = New System.Windows.Forms.Button()
        Me.cmbhari = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtppelaksanaan = New System.Windows.Forms.DateTimePicker()
        Me.txjumlah = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txkunjunganakhir = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dbBeritaAcara = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.nocetakBA = New System.Windows.Forms.TextBox()
        Me.btTampilkan = New System.Windows.Forms.Button()
        Me.btBatalCetak = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btKembali = New System.Windows.Forms.Button()
        Me.btBatal = New System.Windows.Forms.Button()
        Me.btHapus = New System.Windows.Forms.Button()
        Me.btUbah = New System.Windows.Forms.Button()
        Me.btSimpan = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dbBeritaAcara, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Berita Acara"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hari Pelaksanaan"
        '
        'noBA
        '
        Me.noBA.Location = New System.Drawing.Point(179, 88)
        Me.noBA.Name = "noBA"
        Me.noBA.Size = New System.Drawing.Size(49, 20)
        Me.noBA.TabIndex = 2
        '
        'btCari
        '
        Me.btCari.Image = Global.level6_retensi_rekammedis.My.Resources.Resources.search
        Me.btCari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btCari.Location = New System.Drawing.Point(234, 80)
        Me.btCari.Name = "btCari"
        Me.btCari.Size = New System.Drawing.Size(69, 35)
        Me.btCari.TabIndex = 15
        Me.btCari.Text = "Cari"
        Me.btCari.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btCari.UseVisualStyleBackColor = True
        '
        'cmbhari
        '
        Me.cmbhari.FormattingEnabled = True
        Me.cmbhari.Items.AddRange(New Object() {"Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu", "Minggu"})
        Me.cmbhari.Location = New System.Drawing.Point(179, 121)
        Me.cmbhari.Name = "cmbhari"
        Me.cmbhari.Size = New System.Drawing.Size(121, 21)
        Me.cmbhari.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Waktu Pelaksanaan"
        '
        'dtppelaksanaan
        '
        Me.dtppelaksanaan.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtppelaksanaan.Location = New System.Drawing.Point(179, 148)
        Me.dtppelaksanaan.Name = "dtppelaksanaan"
        Me.dtppelaksanaan.Size = New System.Drawing.Size(92, 20)
        Me.dtppelaksanaan.TabIndex = 18
        '
        'txjumlah
        '
        Me.txjumlah.Location = New System.Drawing.Point(179, 174)
        Me.txjumlah.Name = "txjumlah"
        Me.txjumlah.Size = New System.Drawing.Size(49, 20)
        Me.txjumlah.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Jumlah Rekam Medis Inaktif"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(234, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Rekam Medis"
        '
        'txkunjunganakhir
        '
        Me.txkunjunganakhir.Location = New System.Drawing.Point(179, 200)
        Me.txkunjunganakhir.Name = "txkunjunganakhir"
        Me.txkunjunganakhir.Size = New System.Drawing.Size(86, 20)
        Me.txkunjunganakhir.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Tahun Kunjungan Akhir"
        '
        'dbBeritaAcara
        '
        Me.dbBeritaAcara.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dbBeritaAcara.Location = New System.Drawing.Point(15, 246)
        Me.dbBeritaAcara.Name = "dbBeritaAcara"
        Me.dbBeritaAcara.Size = New System.Drawing.Size(487, 177)
        Me.dbBeritaAcara.TabIndex = 42
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(77, 449)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 13)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Cetak Berita Acara"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(77, 487)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(258, 13)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Masukan Berita Acara Yang Akan di Cetak / Ditampil"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(77, 522)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 13)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "No Berita Acara"
        '
        'nocetakBA
        '
        Me.nocetakBA.Location = New System.Drawing.Point(165, 519)
        Me.nocetakBA.Name = "nocetakBA"
        Me.nocetakBA.Size = New System.Drawing.Size(100, 20)
        Me.nocetakBA.TabIndex = 46
        '
        'btTampilkan
        '
        Me.btTampilkan.Location = New System.Drawing.Point(77, 562)
        Me.btTampilkan.Name = "btTampilkan"
        Me.btTampilkan.Size = New System.Drawing.Size(75, 23)
        Me.btTampilkan.TabIndex = 47
        Me.btTampilkan.Text = "Tampilkan"
        Me.btTampilkan.UseVisualStyleBackColor = True
        '
        'btBatalCetak
        '
        Me.btBatalCetak.Location = New System.Drawing.Point(179, 562)
        Me.btBatalCetak.Name = "btBatalCetak"
        Me.btBatalCetak.Size = New System.Drawing.Size(75, 23)
        Me.btBatalCetak.TabIndex = 48
        Me.btBatalCetak.Text = "Batal"
        Me.btBatalCetak.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(103, 33)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(168, 13)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "JL. Makmur No. 13 Kab. Bandung"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(99, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(321, 24)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "Rumah Sakit Moyo Sumber Sehat"
        '
        'btKembali
        '
        Me.btKembali.Image = Global.level6_retensi_rekammedis.My.Resources.Resources._exit
        Me.btKembali.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btKembali.Location = New System.Drawing.Point(415, 474)
        Me.btKembali.Name = "btKembali"
        Me.btKembali.Size = New System.Drawing.Size(87, 39)
        Me.btKembali.TabIndex = 61
        Me.btKembali.Text = "Kembali"
        Me.btKembali.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btKembali.UseVisualStyleBackColor = True
        '
        'btBatal
        '
        Me.btBatal.Image = Global.level6_retensi_rekammedis.My.Resources.Resources.cancel
        Me.btBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btBatal.Location = New System.Drawing.Point(415, 197)
        Me.btBatal.Name = "btBatal"
        Me.btBatal.Size = New System.Drawing.Size(87, 41)
        Me.btBatal.TabIndex = 60
        Me.btBatal.Text = "Batal"
        Me.btBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btBatal.UseVisualStyleBackColor = True
        '
        'btHapus
        '
        Me.btHapus.Image = Global.level6_retensi_rekammedis.My.Resources.Resources.delete
        Me.btHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btHapus.Location = New System.Drawing.Point(415, 148)
        Me.btHapus.Name = "btHapus"
        Me.btHapus.Size = New System.Drawing.Size(87, 43)
        Me.btHapus.TabIndex = 59
        Me.btHapus.Text = "Hapus"
        Me.btHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btHapus.UseVisualStyleBackColor = True
        '
        'btUbah
        '
        Me.btUbah.Image = Global.level6_retensi_rekammedis.My.Resources.Resources.edit
        Me.btUbah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btUbah.Location = New System.Drawing.Point(415, 99)
        Me.btUbah.Name = "btUbah"
        Me.btUbah.Size = New System.Drawing.Size(87, 43)
        Me.btUbah.TabIndex = 58
        Me.btUbah.Text = "Ubah"
        Me.btUbah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btUbah.UseVisualStyleBackColor = True
        '
        'btSimpan
        '
        Me.btSimpan.Image = Global.level6_retensi_rekammedis.My.Resources.Resources.save
        Me.btSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btSimpan.Location = New System.Drawing.Point(415, 49)
        Me.btSimpan.Name = "btSimpan"
        Me.btSimpan.Size = New System.Drawing.Size(87, 44)
        Me.btSimpan.TabIndex = 57
        Me.btSimpan.Text = "Simpan"
        Me.btSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSimpan.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 54
        Me.PictureBox1.TabStop = False
        '
        'berita_acara_retensi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(514, 622)
        Me.Controls.Add(Me.btKembali)
        Me.Controls.Add(Me.btBatal)
        Me.Controls.Add(Me.btHapus)
        Me.Controls.Add(Me.btUbah)
        Me.Controls.Add(Me.btSimpan)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btBatalCetak)
        Me.Controls.Add(Me.btTampilkan)
        Me.Controls.Add(Me.nocetakBA)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dbBeritaAcara)
        Me.Controls.Add(Me.txkunjunganakhir)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txjumlah)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtppelaksanaan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbhari)
        Me.Controls.Add(Me.btCari)
        Me.Controls.Add(Me.noBA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "berita_acara_retensi"
        Me.Text = "BeritaAcaraRetensi"
        CType(Me.dbBeritaAcara, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents noBA As TextBox
    Friend WithEvents btCari As Button
    Friend WithEvents cmbhari As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtppelaksanaan As DateTimePicker
    Friend WithEvents txjumlah As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txkunjunganakhir As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dbBeritaAcara As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents nocetakBA As TextBox
    Friend WithEvents btTampilkan As Button
    Friend WithEvents btBatalCetak As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btKembali As Button
    Friend WithEvents btBatal As Button
    Friend WithEvents btHapus As Button
    Friend WithEvents btUbah As Button
    Friend WithEvents btSimpan As Button
End Class
