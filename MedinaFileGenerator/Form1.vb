
Public Class Generate
    Private Generate As String

    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub txt_button_Click(sender As Object, e As EventArgs) Handles txt_button.Click
        Dim textSave As New SaveFileDialog
        textSave.Filter = "txt files (*.txt) | *.txt"
        textSave.FilterIndex = 2
        textSave.RestoreDirectory = False

        If textSave.ShowDialog = DialogResult.OK Then
            IO.File.WriteAllText(textSave.FileName, "Name: " & Name_TextBox.Text + vbNewLine + "Age: " & Age_TextBox.Text + vbNewLine + "Address: " & Address_TextBox.Text)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub xml_button_Click(sender As Object, e As EventArgs) Handles xml_button.Click
        Dim xmlSave As New SaveFileDialog
        xmlSave.Filter = "XML files (*.xml) | *.xml"
        xmlSave.FilterIndex = 2
        xmlSave.RestoreDirectory = False

        If xmlSave.ShowDialog = DialogResult.OK Then
            IO.File.WriteAllText(xmlSave.FileName, "Name: " & Name_TextBox.Text + vbNewLine + "Age: " & Age_TextBox.Text + vbNewLine + "Address: " & Address_TextBox.Text)
        End If
    End Sub

    Private Sub json_button_Click(sender As Object, e As EventArgs) Handles json_button.Click
        Dim jsonSave As New SaveFileDialog
        jsonSave.Filter = "JSON files (*.json) | *.json"
        jsonSave.FilterIndex = 2
        jsonSave.RestoreDirectory = False

        If jsonSave.ShowDialog = DialogResult.OK Then
            IO.File.WriteAllText(jsonSave.FileName, "Name: " & Name_TextBox.Text + vbNewLine + "Age: " & Age_TextBox.Text + vbNewLine + "Address: " & Address_TextBox.Text)
        End If
    End Sub
End Class
