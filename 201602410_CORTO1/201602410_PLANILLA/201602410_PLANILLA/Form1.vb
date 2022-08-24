Public Class Form1

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub LIMPIARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARToolStripMenuItem.Click
        LIMPIAR_ENTRADAS()
    End Sub

    Private Sub CERRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CERRARToolStripMenuItem.Click
        If MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "salir") = vbYes Then
            End
        Else
            LIMPIAR_ENTRADAS()
        End If
    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            MsgBox("ERROR, NO INGRESÓ NOMBRE DEL PACIENTE")
            TextBox1.Focus()
            Exit Sub
        End If

        SueldoB = TextBox2.Text
        Ventas = TextBox3.Text
        If (RadioButton1.Checked) Then
            Iggs = SueldoB * 0.0483
        Else Iggs = 0
        End If

        If (RadioButton2.Checked) Then
            Irtra = SueldoB * 0.048
        Else Iggs = 0
        End If

        If (RadioButton3.Checked) Then
            Bono = SueldoB * 0.002
        Else Bono = 0
        End If

        If (RadioButton4.Checked) Then
            Comis = SueldoB * 0.025
        Else Comis = 0
        End If

        Total = SueldoB + Ventas + Bono + Comis - Iggs - Irtra
        TextBox4.Text = Total
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class
