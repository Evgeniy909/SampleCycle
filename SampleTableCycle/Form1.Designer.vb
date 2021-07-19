<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.CheckedListBox2 = New System.Windows.Forms.CheckedListBox()
        Me.CheckedListBox3 = New System.Windows.Forms.CheckedListBox()
        Me.CheckedListBox4 = New System.Windows.Forms.CheckedListBox()
        Me.CheckedListBox5 = New System.Windows.Forms.CheckedListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(12, 12)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(120, 364)
        Me.CheckedListBox1.TabIndex = 0
        '
        'CheckedListBox2
        '
        Me.CheckedListBox2.CheckOnClick = True
        Me.CheckedListBox2.FormattingEnabled = True
        Me.CheckedListBox2.Items.AddRange(New Object() {"a", "b", "c", "d", "e", "f"})
        Me.CheckedListBox2.Location = New System.Drawing.Point(138, 12)
        Me.CheckedListBox2.Name = "CheckedListBox2"
        Me.CheckedListBox2.Size = New System.Drawing.Size(120, 364)
        Me.CheckedListBox2.TabIndex = 1
        '
        'CheckedListBox3
        '
        Me.CheckedListBox3.CheckOnClick = True
        Me.CheckedListBox3.FormattingEnabled = True
        Me.CheckedListBox3.Items.AddRange(New Object() {"x", "y", "z"})
        Me.CheckedListBox3.Location = New System.Drawing.Point(264, 12)
        Me.CheckedListBox3.Name = "CheckedListBox3"
        Me.CheckedListBox3.Size = New System.Drawing.Size(120, 364)
        Me.CheckedListBox3.TabIndex = 2
        '
        'CheckedListBox4
        '
        Me.CheckedListBox4.CheckOnClick = True
        Me.CheckedListBox4.FormattingEnabled = True
        Me.CheckedListBox4.Items.AddRange(New Object() {"r", "t", "y", "u"})
        Me.CheckedListBox4.Location = New System.Drawing.Point(390, 12)
        Me.CheckedListBox4.Name = "CheckedListBox4"
        Me.CheckedListBox4.Size = New System.Drawing.Size(120, 364)
        Me.CheckedListBox4.TabIndex = 3
        '
        'CheckedListBox5
        '
        Me.CheckedListBox5.CheckOnClick = True
        Me.CheckedListBox5.FormattingEnabled = True
        Me.CheckedListBox5.Location = New System.Drawing.Point(516, 12)
        Me.CheckedListBox5.Name = "CheckedListBox5"
        Me.CheckedListBox5.Size = New System.Drawing.Size(120, 364)
        Me.CheckedListBox5.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(561, 382)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 418)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckedListBox5)
        Me.Controls.Add(Me.CheckedListBox4)
        Me.Controls.Add(Me.CheckedListBox3)
        Me.Controls.Add(Me.CheckedListBox2)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents CheckedListBox2 As CheckedListBox
    Friend WithEvents CheckedListBox3 As CheckedListBox
    Friend WithEvents CheckedListBox4 As CheckedListBox
    Friend WithEvents CheckedListBox5 As CheckedListBox
    Friend WithEvents Button1 As Button
End Class
