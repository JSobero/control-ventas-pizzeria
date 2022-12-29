Public Class main
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim msj As MsgBoxResult
        msj = MsgBox("¿DESEA SALIR DEL SISTEMA?", vbYesNo, "SISTEMA PIZZERIA")
        If msj = MsgBoxResult.Yes Then
            Application.Exit()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        clientes.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        productos.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        boleta.Show()
    End Sub
End Class