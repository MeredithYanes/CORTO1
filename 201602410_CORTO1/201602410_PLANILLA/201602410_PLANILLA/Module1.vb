Imports System.Windows

Module Module1
    Public SueldoB As Integer
    Public Ventas As Integer
    Public Iggs As Double
    Public Irtra As Double
    Public Bono As Double
    Public Comis As Double
    Public Total As Double
    Sub LIMPIAR_ENTRADAS()
        Form1.RadioButton1.Checked = False
        Form1.RadioButton2.Checked = False
        Form1.RadioButton3.Checked = False
        Form1.RadioButton4.Checked = False
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.TextBox4.Clear()
    End Sub
    Sub Mostrar_Resultados()
        MsgBox(Total)
    End Sub
End Module
