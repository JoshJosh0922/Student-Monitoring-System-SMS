Imports System.Data.OleDb
Imports System.Data
Imports System.Configuration
Public Class changepass
    Dim search1 As String = "Select * from tblclinpas order by User "
    Dim search2 As String = "Select * from tbllatecom order by User "
    Private Sub changepass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datashow2()
        enad()
        en()
    End Sub
    Sub en()
        del.Enabled = False
    End Sub
    Sub em()
        del.Enabled = True
    End Sub

    Public Sub enad()
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub
    Public Sub datashow()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter(search1, conn)
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        conn.Close()
    End Sub
    Public Sub datashow2()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter(search2, conn)
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        conn.Close()
    End Sub
    Sub admins()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        If iwan() Then
            conn.Open()
            Dim cmd As New OleDbCommand("Select * from tblpas where [User] = '" & TextBox5.Text & "'", conn)
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            Dim userfound As Boolean = False
            While dr.Read
                userfound = True
            End While
            '------------------------------------------------

            Dim cmd2 As New OleDbCommand("Select * from tblclinpas where [User] = '" & TextBox5.Text & "'", conn)
            Dim dr2 As OleDbDataReader = cmd2.ExecuteReader

            Dim userfound2 As Boolean = False
            While dr2.Read
                userfound2 = True
            End While
            
            '--------------------------------------------------
            Dim cmd3 As New OleDbCommand("Select * from tbllatecom where [User] = '" & TextBox5.Text & "'", conn)
            Dim dr3 As OleDbDataReader = cmd3.ExecuteReader

            Dim userfound3 As Boolean = False
            While dr3.Read
                userfound3 = True
            End While
            '------------------------------------------------------
            If userfound = True Then
                Dim ako As New OleDbCommand("Delete from tblpas where User = '" & TextBox5.Text & "'", conn)
                ako.ExecuteNonQuery()

                Dim save1 As New OleDb.OleDbCommand("Insert into tblpas values ('" & TextBox5.Text & "','" & TextBox3.Text & "') ", conn)
                save1.ExecuteNonQuery()
                MsgBox("Successfully change your password.")


                Me.Close()
                main.Enabled = True
                main.BringToFront()
                conn.Close()
                '---------------------------------------------------
            ElseIf userfound2 = True Then
                Dim ako2 As New OleDbCommand("Delete from tblclinpas where User = '" & TextBox5.Text & "'", conn)
                ako2.ExecuteNonQuery()

                Dim save2 As New OleDb.OleDbCommand("Insert into tblclinpas values ('" & TextBox5.Text & "','" & TextBox3.Text & "') ", conn)
                save2.ExecuteNonQuery()
                MsgBox("Successfully change your password.")


                Me.Close()
                main.Enabled = True
                main.BringToFront()
                conn.Close()
                '---------------------------------------------------
            ElseIf userfound3 = True Then
                Dim ako3 As New OleDbCommand("Delete from tbllatecom where User = '" & TextBox5.Text & "'", conn)
                ako3.ExecuteNonQuery()

                Dim save3 As New OleDb.OleDbCommand("Insert into tbllatecom values ('" & TextBox5.Text & "','" & TextBox3.Text & "') ", conn)
                save3.ExecuteNonQuery()
                MsgBox("Successfully change your password.")


                Me.Close()
                main.Enabled = True
                main.BringToFront()
                conn.Close()
            Else
                MsgBox("Your Old Password is wrong!", MsgBoxStyle.Information)
            End If
            conn.Close()
        End If
    End Sub

    Public Function iwan() As Boolean
        If TextBox3.Text.Trim = "" Then
            MsgBox("New Password is required.", MsgBoxStyle.Exclamation)
            TextBox3.Focus()
            Return False
        End If
        If TextBox4.Text.Trim = "" Then
            MsgBox("Confirm Password is Required.", MsgBoxStyle.Information)
            TextBox4.Focus()
            Return False
        End If
        If TextBox3.Text.Trim <> TextBox4.Text.Trim Then
            MsgBox("Password do not match")
            TextBox4.Focus()
            Return False
        End If
        If TextBox2.Text.Trim = TextBox4.Text.Trim Then
            MsgBox("Password has already save", MsgBoxStyle.Exclamation)
            TextBox4.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub c2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        main.Enabled = True
        main.BringToFront()
    End Sub

    Private Sub TextBox2_Enter(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.UseSystemPasswordChar = True
    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text < "" Then
            TextBox2.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub TextBox3_Enter(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        TextBox3.UseSystemPasswordChar = True
       
    End Sub

    Private Sub TextBox3_Leave(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text < "" Then
            TextBox3.UseSystemPasswordChar = False
        End If

    End Sub

    Private Sub TextBox4_Enter(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        TextBox4.UseSystemPasswordChar = True
        If TextBox3.Text <> "" And TextBox4.Text <> "" Then
            CheckBox1.Enabled = True
        Else
            CheckBox1.Enabled = False
        End If
    End Sub

    Private Sub TextBox4_Leave(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text < "" Then
            TextBox4.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox3.UseSystemPasswordChar = False
            TextBox4.UseSystemPasswordChar = False
        End If
        If CheckBox1.Checked = False Then
            TextBox3.UseSystemPasswordChar = True
            TextBox4.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub c2_Click_1(sender As Object, e As EventArgs) Handles c2.Click
        main.Enabled = True
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        datashow()
        Label6.Text = "Clinic and  Visitor Pass"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        datashow2()
        Label6.Text = "Latecomers"
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        TextBox5.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        em()
    End Sub
    '        If iwan() Then
    '        conn.Open()
    'Dim cmd1 As New OleDbCommand("Select * from tblpas where [Pass] = '" & TextBox2.Text & "'", conn)

    'Dim dr As OleDbDataReader = cmd1.ExecuteReader

    'Dim userfound As Boolean = False

    '        While dr.Read
    '            userfound = True
    '        End While

    '        If userfound = True Then

    'Dim ako As New OleDbCommand("Delete from tblpas where User = '" & TextBox5.Text & "'", conn)
    '            ako.ExecuteNonQuery()

    'Dim cmd As New OleDb.OleDbCommand("Insert into tblpas values ('" & TextBox5.Text & "','" & TextBox3.Text & "') ", conn)
    '            cmd.ExecuteNonQuery()
    '            MsgBox("Successfully change your password.")


    '            Me.Hide()
    '            main.BringToFront()
    '            main.Enabled = True
    '            conn.Close()
    '        Else
    '            MsgBox("Your Old Password is wrong!", MsgBoxStyle.Information)
    '        End If
    '    End If

    Private Sub c1_Click_1(sender As Object, e As EventArgs) Handles c1.Click
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        admins()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox5.Text = "Admin"
    End Sub

    Private Sub del_Click(sender As Object, e As EventArgs) Handles del.Click
        dep()
    End Sub
    Sub dep()
        conn.Open()
        Dim cmd2 As New OleDbCommand("Select * from tblclinpas where [User] = '" & TextBox5.Text & "'", conn)
        Dim dr2 As OleDbDataReader = cmd2.ExecuteReader

        Dim userfound2 As Boolean = False
        While dr2.Read
            userfound2 = True
        End While
        conn.Close()
        If userfound2 = True Then
            conn.Open()
            Dim ako As New OleDbCommand("Delete from tblclinpas where  User = '" & TextBox5.Text & "'", conn)
            ako.ExecuteNonQuery()
            conn.Close()
            MsgBox("Successfuly Delete")
            datashow()

        End If

        conn.Open()
        Dim cmd3 As New OleDbCommand("Select * from tbllatecom where [User] = '" & TextBox5.Text & "'", conn)
        Dim dr3 As OleDbDataReader = cmd3.ExecuteReader

        Dim userfound3 As Boolean = False
        While dr3.Read
            userfound3 = True
        End While
        conn.Close()
        If userfound3 = True Then
            conn.Open()
            Dim ako As New OleDbCommand("Delete from tbllatecom where User = '" & TextBox5.Text & "'", conn)
            ako.ExecuteNonQuery()
            conn.Close()
            MsgBox("Successfuly Delete")
            datashow2()
        End If
    End Sub
End Class