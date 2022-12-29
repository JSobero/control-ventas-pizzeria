Public Class login
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim msj As MsgBoxResult
        msj = MsgBox("¿DESEA SALIR DEL SISTEMA?", vbYesNo, "SISTEMA PIZZERIA")
        If msj = MsgBoxResult.Yes Then
            Application.Exit()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtusuario.Text = "" Then
            MsgBox("INGRESE SU USUARIO", vbExclamation, "SISTEMA PIZZERIA")
        ElseIf txtclave.Text = "" Then
            MsgBox("INGRESE SU CONTRASEÑA", vbExclamation, "SISTEMA PIZZERIA")
        ElseIf txtusuario.Text = "admin" And txtclave.Text = "123" Then
            MsgBox("INICIO DE SESIÓN EXITOSA", vbInformation, "SISTEMA PIZZERIA")
            Me.Hide()
            main.Show()
        Else
            MsgBox("DATOS INCORRECTOS, VUELVA A INGRESAR SUS DATOS", vbExclamation, "SISTEMA PIZZERIA")
            limpiar()
        End If
    End Sub
    Private Sub limpiar()
        txtusuario.Text = ""
        txtclave.Text = ""
        txtusuario.Focus()
    End Sub
End Class
