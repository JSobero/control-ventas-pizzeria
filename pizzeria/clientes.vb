Public Class clientes
    'Private Sub ClientesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MyBaseBindingNavigatorSaveItem.Click, MyBaseBindingNavigatorSaveItem.Click, MyBaseBindingNavigatorSaveItem.Click, MyBaseBindingNavigatorSaveItem.Click
    'Me.Validate()
    'Me.ClientesBindingSource.EndEdit()
    'Me.TableAdapterManager.UpdateAll(Me.PizzeriaDataSet)

    'End Sub

    Private Sub clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PizzeriaDataSet.clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.PizzeriaDataSet.clientes)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim msj As MsgBoxResult
        msj = MsgBox("¿DESEA REGRESAR AL MENU?", vbYesNo, "SISTEMA PIZZERIA")
        If msj = MsgBoxResult.Yes Then
            Me.Hide()
            main.Show()
        Else
            Exit Sub
        End If
    End Sub


    Private Sub activar()
        Cli_celTextBox.Enabled = True
        Cli_dniTextBox.Enabled = True
        Cli_emailTextBox.Enabled = True
        Cli_nombresTextBox.Enabled = True
        btnagregar.Visible = False
        btngrabar.Enabled = True
        btncancelar.Visible = True
        Cli_dniTextBox.Focus()
    End Sub
    Private Sub desactivar()
        Cli_celTextBox.Enabled = False
        Cli_dniTextBox.Enabled = False
        Cli_emailTextBox.Enabled = False
        Cli_nombresTextBox.Enabled = False
        btnagregar.Visible = True
        btngrabar.Enabled = False
        btncancelar.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        activar()
        Me.Validate()
        Me.ClientesBindingSource.AddNew()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        desactivar()
        Me.Validate()
        Me.ClientesBindingSource.CancelEdit()
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        Me.ClientesTableAdapter.Fill(Me.PizzeriaDataSet.clientes)
        txtbuscar.Text = ""
    End Sub

    Private Sub btngrabar_Click(sender As Object, e As EventArgs) Handles btngrabar.Click
        If Cli_dniTextBox.Text = "" Then
            MsgBox("INGRESE EL DNI", vbExclamation, "SISTEMA PIZZERIA")
            Cli_dniTextBox.Focus()
        ElseIf Cli_nombresTextBox.Text = "" Then
            MsgBox("INGRESE EL NOMBRE", vbExclamation, "SISTEMA PIZZERIA")
            Cli_nombresTextBox.Focus()
        ElseIf Cli_celTextBox.Text = "" Then
            MsgBox("INGRESE EL CELULAR", vbExclamation, "SISTEMA PIZZERIA")
            Cli_celTextBox.Focus()
        ElseIf Cli_emailTextBox.Text = "" Then
            MsgBox("INGRESE EL EMAIL", vbExclamation, "SISTEMA PIZZERIA")
            Cli_emailTextBox.Focus()
        Else
            Me.Validate()
            Me.ClientesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.PizzeriaDataSet)
            Me.ClientesTableAdapter.Fill(Me.PizzeriaDataSet.clientes)
            MsgBox("CLIENTE AGREGADO", vbInformation, "SISTEMA PIZZERIA")
            desactivar()
        End If
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim msj As MsgBoxResult
        msj = MsgBox("¿DESEA ELIMINAR AL CLIENTE?", vbYesNo, "SISTEMA PIZZERIA")
        If msj = MsgBoxResult.Yes Then
            Me.ClientesTableAdapter.BORRAR(Cli_dniTextBox.Text)
            Me.ClientesTableAdapter.Fill(Me.PizzeriaDataSet.clientes)
            MsgBox("LOS DATOS DEL CLIENTE FUERON BORRADOS", vbInformation, "SISTEMA PIZZERIA")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        If txtbuscar.Text = "" Then
            MsgBox("INGRESE EL CLIENTE A BUSCAR", vbExclamation, "SISTEMA PIZZERIA")
            txtbuscar.Focus()
        Else
            Me.ClientesTableAdapter.BUSCAR_CLIENTE(PizzeriaDataSet.clientes, txtbuscar.Text)
        End If
    End Sub
End Class