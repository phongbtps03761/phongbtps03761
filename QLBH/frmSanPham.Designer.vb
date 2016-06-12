<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSanPham
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
        Me.txbMaSP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txbTenSP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txbDonGia = New System.Windows.Forms.TextBox()
        Me.cobTenLoai = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txbMaLoai = New System.Windows.Forms.TextBox()
        Me.dgvSanPham = New System.Windows.Forms.DataGridView()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cobTim = New System.Windows.Forms.ComboBox()
        Me.txbTim = New System.Windows.Forms.TextBox()
        CType(Me.dgvSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã sản phẩm:"
        '
        'txbMaSP
        '
        Me.txbMaSP.Location = New System.Drawing.Point(126, 20)
        Me.txbMaSP.Name = "txbMaSP"
        Me.txbMaSP.Size = New System.Drawing.Size(151, 20)
        Me.txbMaSP.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tên Sản phẩm:"
        '
        'txbTenSP
        '
        Me.txbTenSP.Location = New System.Drawing.Point(126, 46)
        Me.txbTenSP.Name = "txbTenSP"
        Me.txbTenSP.Size = New System.Drawing.Size(151, 20)
        Me.txbTenSP.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(306, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Đơn giá :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(310, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Mã loại:"
        '
        'txbDonGia
        '
        Me.txbDonGia.Location = New System.Drawing.Point(362, 20)
        Me.txbDonGia.Name = "txbDonGia"
        Me.txbDonGia.Size = New System.Drawing.Size(151, 20)
        Me.txbDonGia.TabIndex = 1
        '
        'cobTenLoai
        '
        Me.cobTenLoai.FormattingEnabled = True
        Me.cobTenLoai.Location = New System.Drawing.Point(362, 72)
        Me.cobTenLoai.Name = "cobTenLoai"
        Me.cobTenLoai.Size = New System.Drawing.Size(151, 21)
        Me.cobTenLoai.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(306, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Tên loại:"
        '
        'txbMaLoai
        '
        Me.txbMaLoai.Location = New System.Drawing.Point(362, 46)
        Me.txbMaLoai.Name = "txbMaLoai"
        Me.txbMaLoai.Size = New System.Drawing.Size(151, 20)
        Me.txbMaLoai.TabIndex = 1
        '
        'dgvSanPham
        '
        Me.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSanPham.Location = New System.Drawing.Point(15, 155)
        Me.dgvSanPham.Name = "dgvSanPham"
        Me.dgvSanPham.Size = New System.Drawing.Size(498, 190)
        Me.dgvSanPham.TabIndex = 3
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(519, 155)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(111, 43)
        Me.btnThem.TabIndex = 4
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(519, 204)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(111, 43)
        Me.btnSua.TabIndex = 4
        Me.btnSua.Text = "Sữa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(519, 253)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(111, 43)
        Me.btnXoa.TabIndex = 4
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Tìm:"
        '
        'cobTim
        '
        Me.cobTim.FormattingEnabled = True
        Me.cobTim.Items.AddRange(New Object() {"Mã sản phẩm", "Tên sản phẩm"})
        Me.cobTim.Location = New System.Drawing.Point(75, 120)
        Me.cobTim.Name = "cobTim"
        Me.cobTim.Size = New System.Drawing.Size(121, 21)
        Me.cobTim.TabIndex = 5
        '
        'txbTim
        '
        Me.txbTim.Location = New System.Drawing.Point(202, 121)
        Me.txbTim.Name = "txbTim"
        Me.txbTim.Size = New System.Drawing.Size(220, 20)
        Me.txbTim.TabIndex = 6
        '
        'frmSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 357)
        Me.Controls.Add(Me.txbTim)
        Me.Controls.Add(Me.cobTim)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.dgvSanPham)
        Me.Controls.Add(Me.cobTenLoai)
        Me.Controls.Add(Me.txbMaLoai)
        Me.Controls.Add(Me.txbTenSP)
        Me.Controls.Add(Me.txbDonGia)
        Me.Controls.Add(Me.txbMaSP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSanPham"
        Me.Text = "Sản Phẩm"
        CType(Me.dgvSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txbMaSP As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txbTenSP As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txbDonGia As TextBox
    Friend WithEvents cobTenLoai As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txbMaLoai As TextBox
    Friend WithEvents dgvSanPham As DataGridView
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents cobTim As ComboBox
    Friend WithEvents txbTim As TextBox
End Class
