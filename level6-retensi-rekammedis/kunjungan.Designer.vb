<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class kunjungan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(kunjungan))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txnamapasien = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txnorm = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpawal = New System.Windows.Forms.DateTimePicker()
        Me.dtpakhir = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txdiagnosa = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txkodeicd = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txdokter = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txLamaPenyimpanan = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txStatus = New System.Windows.Forms.TextBox()
        Me.dbkunjungan = New System.Windows.Forms.DataGridView()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btKembali = New System.Windows.Forms.Button()
        Me.btBatal = New System.Windows.Forms.Button()
        Me.btHapus = New System.Windows.Forms.Button()
        Me.btUbah = New System.Windows.Forms.Button()
        Me.btSimpan = New System.Windows.Forms.Button()
        CType(Me.dbkunjungan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Nama"
        '
        'txnamapasien
        '
        Me.txnamapasien.Location = New System.Drawing.Point(148, 111)
        Me.txnamapasien.Name = "txnamapasien"
        Me.txnamapasien.Size = New System.Drawing.Size(281, 20)
        Me.txnamapasien.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Image = Global.level6_retensi_rekammedis.My.Resources.Resources.search
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(254, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 35)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Cari"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "No RM"
        '
        'txnorm
        '
        Me.txnorm.Location = New System.Drawing.Point(148, 85)
        Me.txnorm.Name = "txnorm"
        Me.txnorm.Size = New System.Drawing.Size(100, 20)
        Me.txnorm.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Tanggal Kunjungan Awal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Tanggal Kunjungan Akhir"
        '
        'dtpawal
        '
        Me.dtpawal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpawal.Location = New System.Drawing.Point(148, 137)
        Me.dtpawal.Name = "dtpawal"
        Me.dtpawal.Size = New System.Drawing.Size(200, 20)
        Me.dtpawal.TabIndex = 21
        '
        'dtpakhir
        '
        Me.dtpakhir.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpakhir.Location = New System.Drawing.Point(148, 163)
        Me.dtpakhir.Name = "dtpakhir"
        Me.dtpakhir.Size = New System.Drawing.Size(200, 20)
        Me.dtpakhir.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Diagnosa Akhir"
        '
        'txdiagnosa
        '
        Me.txdiagnosa.Location = New System.Drawing.Point(148, 189)
        Me.txdiagnosa.Name = "txdiagnosa"
        Me.txdiagnosa.Size = New System.Drawing.Size(200, 20)
        Me.txdiagnosa.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Kode ICD"
        '
        'txkodeicd
        '
        Me.txkodeicd.Location = New System.Drawing.Point(148, 215)
        Me.txkodeicd.Name = "txkodeicd"
        Me.txkodeicd.Size = New System.Drawing.Size(70, 20)
        Me.txkodeicd.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 244)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Dokter"
        '
        'txdokter
        '
        Me.txdokter.Location = New System.Drawing.Point(148, 241)
        Me.txdokter.Name = "txdokter"
        Me.txdokter.Size = New System.Drawing.Size(200, 20)
        Me.txdokter.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 270)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Lama penyimpanan"
        '
        'txLamaPenyimpanan
        '
        Me.txLamaPenyimpanan.Location = New System.Drawing.Point(148, 267)
        Me.txLamaPenyimpanan.Name = "txLamaPenyimpanan"
        Me.txLamaPenyimpanan.Size = New System.Drawing.Size(70, 20)
        Me.txLamaPenyimpanan.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(224, 270)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Status"
        '
        'txStatus
        '
        Me.txStatus.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.txStatus.Location = New System.Drawing.Point(267, 267)
        Me.txStatus.Name = "txStatus"
        Me.txStatus.Size = New System.Drawing.Size(70, 20)
        Me.txStatus.TabIndex = 32
        '
        'dbkunjungan
        '
        Me.dbkunjungan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dbkunjungan.Location = New System.Drawing.Point(19, 320)
        Me.dbkunjungan.Name = "dbkunjungan"
        Me.dbkunjungan.Size = New System.Drawing.Size(553, 223)
        Me.dbkunjungan.TabIndex = 38
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(101, 33)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(168, 13)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "JL. Makmur No. 13 Kab. Bandung"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(97, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(321, 24)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "Rumah Sakit Moyo Sumber Sehat"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-5, -14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'btKembali
        '
        Me.btKembali.Image = Global.level6_retensi_rekammedis.My.Resources.Resources._exit
        Me.btKembali.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btKembali.Location = New System.Drawing.Point(474, 269)
        Me.btKembali.Name = "btKembali"
        Me.btKembali.Size = New System.Drawing.Size(87, 39)
        Me.btKembali.TabIndex = 51
        Me.btKembali.Text = "Kembali"
        Me.btKembali.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btKembali.UseVisualStyleBackColor = True
        '
        'btBatal
        '
        Me.btBatal.Image = Global.level6_retensi_rekammedis.My.Resources.Resources.cancel
        Me.btBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btBatal.Location = New System.Drawing.Point(474, 215)
        Me.btBatal.Name = "btBatal"
        Me.btBatal.Size = New System.Drawing.Size(87, 41)
        Me.btBatal.TabIndex = 50
        Me.btBatal.Text = "Batal"
        Me.btBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btBatal.UseVisualStyleBackColor = True
        '
        'btHapus
        '
        Me.btHapus.Image = Global.level6_retensi_rekammedis.My.Resources.Resources.delete
        Me.btHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btHapus.Location = New System.Drawing.Point(474, 166)
        Me.btHapus.Name = "btHapus"
        Me.btHapus.Size = New System.Drawing.Size(87, 43)
        Me.btHapus.TabIndex = 49
        Me.btHapus.Text = "Hapus"
        Me.btHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btHapus.UseVisualStyleBackColor = True
        '
        'btUbah
        '
        Me.btUbah.Image = Global.level6_retensi_rekammedis.My.Resources.Resources.edit
        Me.btUbah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btUbah.Location = New System.Drawing.Point(474, 117)
        Me.btUbah.Name = "btUbah"
        Me.btUbah.Size = New System.Drawing.Size(87, 43)
        Me.btUbah.TabIndex = 48
        Me.btUbah.Text = "Ubah"
        Me.btUbah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btUbah.UseVisualStyleBackColor = True
        '
        'btSimpan
        '
        Me.btSimpan.Image = Global.level6_retensi_rekammedis.My.Resources.Resources.save
        Me.btSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btSimpan.Location = New System.Drawing.Point(474, 67)
        Me.btSimpan.Name = "btSimpan"
        Me.btSimpan.Size = New System.Drawing.Size(87, 44)
        Me.btSimpan.TabIndex = 47
        Me.btSimpan.Text = "Simpan"
        Me.btSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSimpan.UseVisualStyleBackColor = True
        '
        'kunjungan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(588, 555)
        Me.Controls.Add(Me.btKembali)
        Me.Controls.Add(Me.btBatal)
        Me.Controls.Add(Me.btHapus)
        Me.Controls.Add(Me.btUbah)
        Me.Controls.Add(Me.btSimpan)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dbkunjungan)
        Me.Controls.Add(Me.txStatus)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txLamaPenyimpanan)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txdokter)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txkodeicd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txdiagnosa)
        Me.Controls.Add(Me.dtpakhir)
        Me.Controls.Add(Me.dtpawal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txnamapasien)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txnorm)
        Me.Name = "kunjungan"
        Me.Text = "Kunjangan"
        CType(Me.dbkunjungan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txnamapasien As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txnorm As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpawal As DateTimePicker
    Friend WithEvents dtpakhir As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txdiagnosa As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txkodeicd As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txdokter As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txLamaPenyimpanan As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txStatus As TextBox
    Friend WithEvents dbkunjungan As DataGridView
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btKembali As Button
    Friend WithEvents btBatal As Button
    Friend WithEvents btHapus As Button
    Friend WithEvents btUbah As Button
    Friend WithEvents btSimpan As Button
End Class
