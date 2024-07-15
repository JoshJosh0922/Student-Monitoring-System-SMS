Imports System.Data.OleDb
Imports System.IO
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Core
'Imports System.Xml.XPath
'Imports System.Xml
'Imports System.Linq
'Imports System.Data
'Imports System.Data.SqlClient
Public Class SHS
    Dim cun As String
    Dim minumber As Integer
    Dim lc As String
    Dim dat As String = "Select * from tblVisitor order by VisitorNo"

    Private Sub SHS_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        main.Show()
    End Sub
    Private Sub SHS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datashow()
        bilang()
        bt()
        dte.Visible = False
        tme.Visible = False
        enab()
        DATi()
        en()
    End Sub
    Sub en()
        TextBox9.Enabled = False
    End Sub
    Sub DATi()
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub

    Sub bilang()
        Dim count As Double
        conn.Open()
        cun = "SELECT COUNT(VisitorNo) from tblVisitor"
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
    Sub bt()
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox1.Enabled = False
    End Sub
    Sub dis()
        id.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True

        DataGridView1.Enabled = False
        DataGridView1.ClearSelection()

        Button1.Enabled = False
        Button2.Enabled = True
        Button5.Enabled = True

        id.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub
    Sub enab()
        id.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox1.Enabled = False

        DataGridView1.Enabled = True
        Button1.Enabled = True
        Button2.Enabled = False
        Button5.Enabled = False

        id.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox1.Text = ""
    End Sub


    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Dispose()
        main.Show()
        main.BringToFront()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dis()
        tt()
        generateEmpId()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        If id.Text = "" And TextBox2.Text = "" And TextBox3.Text = "" Then
            MsgBox("Pls input Student info")
        Else
            Dim cmd As New OleDb.OleDbCommand("Insert into tblVisitor values ('" & TextBox1.Text & "','" & id.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "') ", conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Successfully save")

            Dim cm As New OleDbCommand("Update tblvnum set Visitorno = '" & minumber & "'", conn)
            cm.ExecuteNonQuery()

        End If
        conn.Close()
        bilang()
        datashow()
        enab()
    End Sub
    Sub generateEmpId()
        conn.Open()
        Dim cmd As New OleDbCommand("Select Visitorno from tblvnum", conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        dr.Read()
        TextBox1.Text = "No:" & Format(dr(0) + 1, "00#")
        minumber = dr(0) + 1
        conn.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox4.Text = Date.Today
        TextBox5.Text = TimeOfDay
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        enab()
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        If ComboBox1.Text <> "" Then
            dat = "Select * from tblVisitor where " & ComboBox1.Text & " like '" & TextBox9.Text.Replace("'", "") & "%'"
            datashow()
            num.Visible = False
        End If
        If TextBox9.Text < " " Then
            num.Visible = True
        End If
    End Sub

    Private Sub DataGridView2_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        id.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        TextBox2.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        TextBox3.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        tme.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        dte.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        tm()
    End Sub
    Sub tm()
        dte.Visible = True
        tme.Visible = True
        dte.Enabled = False
        tme.Enabled = False
        dte.Location = New Point(60, 168)
        tme.Location = New Point(60, 194)
        TextBox4.Visible = False
        TextBox5.Visible = False
        'ToolStripButton2.Visible = True
    End Sub
    Sub tt()
        dte.Visible = False
        tme.Visible = False
        TextBox4.Visible = True
        TextBox5.Visible = True
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        'Dim cs As String = String.Empty
        'For Each column As DataGridViewColumn In DataGridView1.Columns
        '    cs = cs & column.HeaderText & ","
        'Next
        'cs = cs.TrimEnd(",")
        'cs = cs & vbCr & vbLf
        'For Each row As DataGridViewRow In DataGridView1.Rows
        '    For Each cel As DataGridViewCell In row.Cells
        '        cs = cs & cel.FormattedValue & ","
        '    Next
        '    cs = cs.TrimEnd(",")
        '    cs = cs & vbCr & vbLf
        'Next
        'lc = "C:\Users\JOSHUA O. LUCERNA\Desktop\Visitor Monitoring"

        'My.Computer.FileSystem.WriteAllText(lc & ".csv", cs, True)
        'MsgBox("Successfuly save")
        SaveFileDialog1.Filter = "Excel Document (*.xlsx)|*.xlsx"
        If SaveFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            MsgBox("Please Wait...")
            Dim a As Microsoft.Office.Interop.Excel.Application
            Dim w As Microsoft.Office.Interop.Excel.Workbook
            Dim s As Microsoft.Office.Interop.Excel.Worksheet
            Dim o As Object = System.Reflection.Missing.Value

            Dim i As New Integer
            Dim j As New Integer

            a = New Microsoft.Office.Interop.Excel.Application
            w = a.Workbooks.Add(o)
            s = w.Sheets("sheet1")

            For i = 0 To DataGridView1.RowCount - 1
                For j = 0 To DataGridView1.ColumnCount - 1
                    For k As Integer = 1 To DataGridView1.Columns.Count
                        s.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
                        s.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString
                    Next

                Next
            Next
            s.SaveAs(SaveFileDialog1.FileName)
            w.Close()
            a.Quit()

            MsgBox("Successfully saved" & vbCrLf & "File are save at: " & SaveFileDialog1.FileName, MsgBoxStyle.Information, "Information")

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        conn.Open()
        Dim da As New OleDbDataAdapter("Select * from tblVisitor where Date = '" & DateTimePicker1.Value.ToShortDateString & "'", conn)
        Dim ds As New DataSet
        da.Fill(ds, "tblVisitor")
        DataGridView1.DataSource = ds.Tables("tblVisitor")
        'datashow()
        conn.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim da As New OleDbDataAdapter("Select * from tblVisitor where Date between  '" & DateTimePicker2.Value.ToString & "' and '" & DateTimePicker3.Value.ToString & "'", conn)
        Dim dt As New DataTable
        da.Fill(dt) '"' and '" & DateTimePicker2.Value.Date &between
        DataGridView1.DataSource = dt
    End Sub

    Private Sub SearchByTwoDatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchByTwoDatesToolStripMenuItem.Click
        dayday.Visible = True
        dayday.Location = New Point(12, 139)
        dayday.Width = (422)
        dayday.Height = (50)
        day.Visible = False
        datashow()
    End Sub

    Private Sub SearchByOneDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchByOneDateToolStripMenuItem.Click
        dayday.Visible = False
        day.Visible = True
        datashow()
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Dim y6 As New Form9
        y6.TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        y6.id.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        y6.TextBox2.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        y6.TextBox3.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        'y6.dte.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        'y6.tme.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        Me.Enabled = False
        y6.Show()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        listofvisitor.Show()
        listofvisitor.datashow()
        listofvisitor.bilang()
        Me.Dispose()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text <> "" Then
            TextBox9.Enabled = True
        End If
    End Sub
End Class