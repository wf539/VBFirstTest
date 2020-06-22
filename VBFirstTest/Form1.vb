Imports System.IO

Public Class Form1

    Dim Writer As StreamWriter

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Static iCount As Int16 = 1
        Dim strCount As String

        If iCount = 1 Then
            Writer = File.CreateText("Test results.log")
            Writer.WriteLine("Test results for Test Run XYZ; " & Now)
        Else
            Writer = File.AppendText("TestResults.log")
        End If

        strCount = Convert.ToString(iCount)

        If File.Exists(TextBox1.Text) Then
            Writer.WriteLine(strCount & " File " & TextBox1.Text & " Exists: Test Passed")
            Label1.Text = "File " & TextBox1.Text & " Exists: Test Passed"
        Else
            Writer.WriteLine(strCount & " File " & TextBox1.Text & " does not exist: Test Failed")
            Label1.Text = "File " & TextBox1.Text & " does not exist: Test Failed"
        End If
        iCount += 1

        Writer.Close()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        Writer = File.AppendText("TestResults.log")
        Writer.WriteLine("Test Completed for Test Run XYZ; " & DateTime.Now)
        Writer.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        System.Diagnostics.Process.Start("Notepad.exe", "TestResults.log")

    End Sub
End Class
