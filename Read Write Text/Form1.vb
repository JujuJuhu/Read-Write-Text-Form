Imports System.IO
Imports System.Text

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newfile As String = "C:\TEXT FILE\MyFile.txt"
        Dim fs As FileStream = File.Create(newfile)
        MessageBox.Show("Successfully Created File.")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim text As New StringBuilder
        text.AppendLine(TextBox1.Text)
        Dim filepath As String = "C:\TEXT FILE\MyFile.txt"
        File.AppendAllText(filepath, text.ToString())
        MessageBox.Show("Success.")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim gettext As String = My.Computer.FileSystem.ReadAllText("C:\TEXT FILE\MyFile.txt")
        TextBox1.Text = gettext
    End Sub
End Class
