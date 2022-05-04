<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tanggal_pinjam = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.jumlah_pinjam = New System.Windows.Forms.TextBox()
        Me.kd_anggota = New System.Windows.Forms.TextBox()
        Me.kd_buku = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.simpan = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NamaAnggota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBuku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPinjamBuku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tanggal_pinjam)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.jumlah_pinjam)
        Me.GroupBox1.Controls.Add(Me.kd_anggota)
        Me.GroupBox1.Controls.Add(Me.kd_buku)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.simpan)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(808, 336)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Peminjam"
        '
        'tanggal_pinjam
        '
        Me.tanggal_pinjam.Location = New System.Drawing.Point(585, 169)
        Me.tanggal_pinjam.Name = "tanggal_pinjam"
        Me.tanggal_pinjam.Size = New System.Drawing.Size(189, 20)
        Me.tanggal_pinjam.TabIndex = 33
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(676, 211)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 30)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'jumlah_pinjam
        '
        Me.jumlah_pinjam.Location = New System.Drawing.Point(585, 135)
        Me.jumlah_pinjam.Name = "jumlah_pinjam"
        Me.jumlah_pinjam.Size = New System.Drawing.Size(189, 20)
        Me.jumlah_pinjam.TabIndex = 31
        '
        'kd_anggota
        '
        Me.kd_anggota.Location = New System.Drawing.Point(585, 64)
        Me.kd_anggota.Name = "kd_anggota"
        Me.kd_anggota.Size = New System.Drawing.Size(189, 20)
        Me.kd_anggota.TabIndex = 30
        '
        'kd_buku
        '
        Me.kd_buku.Location = New System.Drawing.Point(585, 97)
        Me.kd_buku.Name = "kd_buku"
        Me.kd_buku.Size = New System.Drawing.Size(189, 20)
        Me.kd_buku.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(499, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Tanggal Pinjam"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(499, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Jumlah Pinjam"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(498, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Kode Anggota"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(499, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Kode Buku"
        '
        'simpan
        '
        Me.simpan.Location = New System.Drawing.Point(502, 211)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(98, 30)
        Me.simpan.TabIndex = 24
        Me.simpan.Text = "Submit"
        Me.simpan.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NamaAnggota, Me.NamaBuku, Me.TotalPinjamBuku, Me.tanggal})
        Me.DataGridView1.Location = New System.Drawing.Point(4, 17)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(474, 313)
        Me.DataGridView1.TabIndex = 3
        '
        'NamaAnggota
        '
        Me.NamaAnggota.HeaderText = "NamaAnggota"
        Me.NamaAnggota.Name = "NamaAnggota"
        '
        'NamaBuku
        '
        Me.NamaBuku.HeaderText = "NamaBuku"
        Me.NamaBuku.Name = "NamaBuku"
        '
        'TotalPinjamBuku
        '
        Me.TotalPinjamBuku.HeaderText = "JumlahPinjam"
        Me.TotalPinjamBuku.Name = "TotalPinjamBuku"
        '
        'tanggal
        '
        Me.tanggal.HeaderText = "TanggalPinjam"
        Me.tanggal.Name = "tanggal"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 361)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents tanggal_pinjam As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents jumlah_pinjam As TextBox
    Friend WithEvents kd_anggota As TextBox
    Friend WithEvents kd_buku As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents simpan As Button
    Friend WithEvents NamaAnggota As DataGridViewTextBoxColumn
    Friend WithEvents NamaBuku As DataGridViewTextBoxColumn
    Friend WithEvents TotalPinjamBuku As DataGridViewTextBoxColumn
    Friend WithEvents tanggal As DataGridViewTextBoxColumn
End Class
