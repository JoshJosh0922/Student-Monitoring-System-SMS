<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user1
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
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.c2 = New System.Windows.Forms.Button()
        Me.c1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.rb1 = New System.Windows.Forms.RadioButton()
        Me.rb2 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(167, 114)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(94, 17)
        Me.CheckBox1.TabIndex = 23
        Me.CheckBox1.Text = "See Password"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(12, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 20)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Add New User"
        '
        'c2
        '
        Me.c2.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c2.Location = New System.Drawing.Point(267, 148)
        Me.c2.Name = "c2"
        Me.c2.Size = New System.Drawing.Size(75, 29)
        Me.c2.TabIndex = 20
        Me.c2.Text = "Cancel"
        Me.c2.UseVisualStyleBackColor = True
        '
        'c1
        '
        Me.c1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1.Location = New System.Drawing.Point(186, 148)
        Me.c1.Name = "c1"
        Me.c1.Size = New System.Drawing.Size(75, 29)
        Me.c1.TabIndex = 19
        Me.c1.Text = "Save"
        Me.c1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(64, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Password :"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(162, 82)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(174, 24)
        Me.TextBox2.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(59, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Username :"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(162, 46)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(174, 24)
        Me.TextBox1.TabIndex = 13
        '
        'rb1
        '
        Me.rb1.AutoSize = True
        Me.rb1.BackColor = System.Drawing.Color.Transparent
        Me.rb1.ForeColor = System.Drawing.Color.Transparent
        Me.rb1.Location = New System.Drawing.Point(16, 136)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(98, 17)
        Me.rb1.TabIndex = 24
        Me.rb1.TabStop = True
        Me.rb1.Text = "For Latecomers"
        Me.rb1.UseVisualStyleBackColor = False
        '
        'rb2
        '
        Me.rb2.AutoSize = True
        Me.rb2.BackColor = System.Drawing.Color.Transparent
        Me.rb2.ForeColor = System.Drawing.Color.Transparent
        Me.rb2.Location = New System.Drawing.Point(16, 160)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(120, 17)
        Me.rb2.TabIndex = 25
        Me.rb2.TabStop = True
        Me.rb2.Text = "For Clinic and Visitor"
        Me.rb2.UseVisualStyleBackColor = False
        '
        'user1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Student_monitoring_system.My.Resources.Resources.createmonitor
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(354, 189)
        Me.Controls.Add(Me.rb2)
        Me.Controls.Add(Me.rb1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.c2)
        Me.Controls.Add(Me.c1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "user1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "user1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents c2 As System.Windows.Forms.Button
    Friend WithEvents c1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents rb1 As System.Windows.Forms.RadioButton
    Friend WithEvents rb2 As System.Windows.Forms.RadioButton
End Class
