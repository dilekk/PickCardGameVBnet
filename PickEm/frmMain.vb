Public Class frmMain


    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        'Call abc()
        abc()
        Me.Close()
    End Sub

    Sub abc()
        Dim firstnum As Double = 6.5
        Dim secondnum As Double
        secondnum = 2.5
        'Const PI As Double = 3.14159

        'MessageBox.Show(AddTwo(PI, secondnum))
    End Sub

    Function AddTwo(num1 As Double, num2 As Double) As Double
        ' Takes two numbers and retunrns the sum
        REM this is an obsolete way to comment
        Return num1 + num2 ' added in one line!
    End Function

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        ' ListBox1.Items.Add(5)

        For idx = 2 To 10 Step 2
            If idx <> 6 Then
                ListBox1.Items.Add(idx)
            End If

        Next
    End Sub
End Class
