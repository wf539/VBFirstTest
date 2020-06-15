Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If File.Exists(TextBox1.Text) Then
            MessageBox.Show("File exists: Test passed")
        Else
            MessageBox.Show("File does not exist: Test failed")
        End If
    End Sub
End Class
