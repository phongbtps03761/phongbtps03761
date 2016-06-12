Imports System.Data.DataSet
Imports System.Data.SqlClient


Public Class frmSanPham
    Dim duongdan As String
    Dim db As New DataTable
    Dim chuoiketnoi As String = "Data Source=DESKTOP-OUKJKS0;Initial Catalog=PS03761_INF205;Integrated Security=True"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private DBAccess As DataBaseAccess
    'dinh nghia ham them san pham vao dtb
    Private Function themsp() As Boolean
        Dim sqlQuery As String = "INSERT INTO SANPHAM(MA_SP,TEN_SP,GIA,MA_LOAI)"
        sqlQuery += String.Format("VALUES ('{0}','{1}','{2}','{3}')", txbMaSP.Text, txbTenSP.Text, txbDonGia.Text, txbMaLoai.Text)
        Return DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function
    'dinh nghia ham kiem tra gia tri trươc khi them
    Private Function isnull() As Boolean
        Return (String.IsNullOrEmpty(txbMaSP.Text) OrElse String.IsNullOrEmpty(txbTenSP.Text) OrElse String.IsNullOrEmpty(txbDonGia.Text) OrElse String.IsNullOrEmpty(txbMaLoai.Text))
    End Function
    'dinh nghia ham tim kiem
    Private Sub timsp(value As String)
        Dim sqlQuery As String = String.Format("select MA_SP,TEN_SP,GIA,MA_LOAI FROM dbo.SANPHAM")
        If Me.cobTim.SelectedIndex = 0 Then 'tim theo ma sp
            sqlQuery += String.Format("Where MA_SP like '{0}'%", value)
        ElseIf Me.cobTim.SelectedIndex = 1 Then 'tim theo ten sp
            sqlQuery += String.Format("WHere TEN_SP like '{0}'%", value)
        End If
        Dim dtable As DataTable = DBAccess.GetDataTable(sqlQuery)
        Me.dgvSanPham.DataSource = dtable
        With Me.dgvSanPham
            .Columns(0).HeaderText = "MA_SP"
            .Columns(1).HeaderText = "TEN_SP"
            .Columns(2).HeaderText = "GIA"
            .Columns(3).HeaderText = "MA_LOAI"
        End With
    End Sub

    Private Sub frmSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sqlQuery As String = String.Format("select MA_SP,TEN_SP,GIA,MA_LOAI FROM dbo.SANPHAM")
        Dim dtable As DataTable = DBAccess.GetDataTable(sqlQuery)
        Me.dgvSanPham.DataSource = dtable
        With Me.dgvSanPham
            .Columns(0).HeaderText = "MA_SP"
            .Columns(1).HeaderText = "TEN_SP"
            .Columns(2).HeaderText = "GIA"
            .Columns(3).HeaderText = "MA_LOAI"
        End With
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If isnull() Then
            MessageBox.Show("Thieu du lieu", "Error", MessageBoxButtons.OK)
        Else
            If themsp() Then
                MessageBox.Show("Them du lieu thanh cong", "OK", MessageBoxButtons.OK)
                DialogResult = DialogResult.OK
            Else
                MessageBox.Show("loi", "error", MessageBoxButtons.OK)
                DialogResult = DialogResult.OK
            End If
            timsp(Me.txbTim.Text)
        End If
    End Sub
End Class
