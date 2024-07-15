Imports System.Data.OleDb
Imports System.
Public Class listofvisitor
    Dim dat As String = "Select * from tblvl order by No"
    Dim cun As String
    Dim lc As String
    Private Sub listofvisitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datashow()
        bilang()
        enab()
    End Sub
    Sub bilang()
        Dim count As Double
        conn.Open()
        cun = "SELECT COUNT(No) from tblvl"
        Dim cmd As New OleDbCommand(cun, conn)
        count = cmd.ExecuteScalar

        num.Text = "Numbers of Student: No." & count
        conn.Close()
    End Sub
    Sub datashow()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter(dat, conn)
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        conn.Close()
    End Sub
    Sub enab()
        id.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox1.Enabled = False
        TextBox6.Enabled = False
        dte.Enabled = False
        tme.Enabled = False
        DataGridView1.Enabled = True

        id.Text = ""
        TextBox6.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox1.Text = ""
    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Dim cs As String = String.Empty
        For Each column As DataGridViewColumn In DataGridView1.Columns
            cs = cs & column.HeaderText & ","
        Next
        cs = cs.TrimEnd(",")
        cs = cs & vbCr & vbLf
        For Each row As DataGridViewRow In DataGridView1.Rows
            For Each cel As DataGridViewCell In row.Cells
                cs = cs & cel.FormattedValue & ","
            Next
            cs = cs.TrimEnd(",")
            cs = cs & vbCr & vbLf
        Next
        lc = "C:\Users\JOSHUA O. LUCERNA\Desktop\Visitor Monitoring"

        My.Computer.FileSystem.WriteAllText(lc & ".xls", cs, True)
        MsgBox("Successfuly save")
    End Sub
End Class