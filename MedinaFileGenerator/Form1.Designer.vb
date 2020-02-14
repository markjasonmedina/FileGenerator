<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Name = New System.Windows.Forms.Label()
        Me.Age = New System.Windows.Forms.Label()
        Me.Address = New System.Windows.Forms.Label()
        Me.txt_button = New System.Windows.Forms.Button()
        Me.xml_button = New System.Windows.Forms.Button()
        Me.json_button = New System.Windows.Forms.Button()
        Me.generate_file = New System.Windows.Forms.Label()
        Me.Name_TextBox = New System.Windows.Forms.TextBox()
        Me.Age_TextBox = New System.Windows.Forms.TextBox()
        Me.Address_TextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Name
        '
        Me.Name.AutoSize = True
        Me.Name.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name.Location = New System.Drawing.Point(47, 47)
        Me.Name.Name = "Name"
        Me.Name.Size = New System.Drawing.Size(68, 22)
        Me.Name.TabIndex = 0
        Me.Name.Text = "Name:"
        '
        'Age
        '
        Me.Age.AutoSize = True
        Me.Age.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Age.Location = New System.Drawing.Point(47, 88)
        Me.Age.Name = "Age"
        Me.Age.Size = New System.Drawing.Size(50, 22)
        Me.Age.TabIndex = 1
        Me.Age.Text = "Age:"
        '
        'Address
        '
        Me.Address.AutoSize = True
        Me.Address.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address.Location = New System.Drawing.Point(47, 126)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(90, 22)
        Me.Address.TabIndex = 2
        Me.Address.Text = "Address:"
        '
        'txt_button
        '
        Me.txt_button.BackColor = System.Drawing.Color.Black
        Me.txt_button.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_button.ForeColor = System.Drawing.Color.White
        Me.txt_button.Location = New System.Drawing.Point(198, 209)
        Me.txt_button.Name = "txt_button"
        Me.txt_button.Size = New System.Drawing.Size(75, 33)
        Me.txt_button.TabIndex = 3
        Me.txt_button.Text = "TXT"
        Me.txt_button.UseVisualStyleBackColor = False
        '
        'xml_button
        '
        Me.xml_button.BackColor = System.Drawing.Color.Black
        Me.xml_button.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xml_button.ForeColor = System.Drawing.Color.White
        Me.xml_button.Location = New System.Drawing.Point(279, 209)
        Me.xml_button.Name = "xml_button"
        Me.xml_button.Size = New System.Drawing.Size(75, 33)
        Me.xml_button.TabIndex = 4
        Me.xml_button.Text = "XML"
        Me.xml_button.UseVisualStyleBackColor = False
        '
        'json_button
        '
        Me.json_button.BackColor = System.Drawing.Color.Black
        Me.json_button.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.json_button.ForeColor = System.Drawing.Color.White
        Me.json_button.Location = New System.Drawing.Point(360, 209)
        Me.json_button.Name = "json_button"
        Me.json_button.Size = New System.Drawing.Size(75, 33)
        Me.json_button.TabIndex = 5
        Me.json_button.Text = "JSON"
        Me.json_button.UseVisualStyleBackColor = False
        '
        'generate_file
        '
        Me.generate_file.AutoSize = True
        Me.generate_file.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.generate_file.Location = New System.Drawing.Point(47, 214)
        Me.generate_file.Name = "generate_file"
        Me.generate_file.Size = New System.Drawing.Size(136, 22)
        Me.generate_file.TabIndex = 6
        Me.generate_file.Text = "Generate File:"
        '
        'Name_TextBox
        '
        Me.Name_TextBox.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_TextBox.Location = New System.Drawing.Point(161, 39)
        Me.Name_TextBox.Name = "Name_TextBox"
        Me.Name_TextBox.Size = New System.Drawing.Size(274, 30)
        Me.Name_TextBox.TabIndex = 7
        '
        'Age_TextBox
        '
        Me.Age_TextBox.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Age_TextBox.Location = New System.Drawing.Point(161, 80)
        Me.Age_TextBox.Name = "Age_TextBox"
        Me.Age_TextBox.Size = New System.Drawing.Size(274, 30)
        Me.Age_TextBox.TabIndex = 8
        '
        'Address_TextBox
        '
        Me.Address_TextBox.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address_TextBox.Location = New System.Drawing.Point(161, 118)
        Me.Address_TextBox.Name = "Address_TextBox"
        Me.Address_TextBox.Size = New System.Drawing.Size(274, 30)
        Me.Address_TextBox.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 282)
        Me.Controls.Add(Me.Address_TextBox)
        Me.Controls.Add(Me.Age_TextBox)
        Me.Controls.Add(Me.Name_TextBox)
        Me.Controls.Add(Me.generate_file)
        Me.Controls.Add(Me.json_button)
        Me.Controls.Add(Me.xml_button)
        Me.Controls.Add(Me.txt_button)
        Me.Controls.Add(Me.Address)
        Me.Controls.Add(Me.Age)
        Me.Controls.Add(Me.Name)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Name As Label
    Friend WithEvents Age As Label
    Friend WithEvents Address As Label
    Friend WithEvents txt_button As Button
    Friend WithEvents xml_button As Button
    Friend WithEvents json_button As Button
    Friend WithEvents generate_file As Label
    Friend WithEvents Name_TextBox As TextBox
    Friend WithEvents Age_TextBox As TextBox
    Friend WithEvents Address_TextBox As TextBox
End Class
