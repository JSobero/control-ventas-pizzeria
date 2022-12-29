Public Class boleta
    Private Sub ticket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PizzeriaDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.PizzeriaDataSet.productos)
        'TODO: esta línea de código carga datos en la tabla 'PizzeriaDataSet.clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.PizzeriaDataSet.clientes)
        'TODO: esta línea de código carga datos en la tabla 'PizzeriaDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.TicketTableAdapter.Fill(Me.PizzeriaDataSet.ticket)
    End Sub
    Private Sub activar()
        Tick_cantidadTextBox.Enabled = True
        TicK_descripcionTextBox.Enabled = True
        btnagregar.Visible = False
        btngrabar.Enabled = True
        btncancelar.Visible = True
        GRUPO1.Enabled = True
        GRUPO2.Enabled = True
        Tick_numeroTextBox.Focus()
    End Sub
    Private Sub desactivar()
        Tick_cantidadTextBox.Enabled = False
        TicK_descripcionTextBox.Enabled = False
        btnagregar.Visible = True
        btngrabar.Enabled = False
        btncancelar.Visible = False
        GRUPO1.Enabled = False
        GRUPO2.Enabled = False
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        activar()
        Me.Validate()
        Me.TicketBindingSource.AddNew()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        desactivar()
        Me.Validate()
        Me.TicketBindingSource.CancelEdit()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.ClientesTableAdapter.Fill(Me.PizzeriaDataSet.clientes)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbdni.SelectedIndexChanged
        Cli_idTextBox.Text = cmbdni.Text
    End Sub

    Private Sub cmbproducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbproducto.SelectedIndexChanged
        Prod_codTextBox.Text = cmbproducto.Text
    End Sub

    Private Sub btngrabar_Click(sender As Object, e As EventArgs) Handles btngrabar.Click
        If Tick_numeroTextBox.Text = "" Then
            MsgBox("INGRESE EL NUMERO", vbExclamation, "SISTEMA PIZZERIA")
            Tick_numeroTextBox.Focus()
        ElseIf Cli_idTextBox.Text = "" Then
            MsgBox("SELECCIONE EL CODIGO DE CLIENTE", vbExclamation, "SISTEMA PIZZERIA")
            cmbdni.Focus()
        ElseIf Prod_codTextBox.Text = "" Then
            MsgBox("SELECCIONE EL CODIGO DEL PRODUCTO", vbExclamation, "SISTEMA PIZZERIA")
            cmbproducto.Focus()
        ElseIf TicK_descripcionTextBox.Text = "" Then
            MsgBox("INGRESE UNA DESCRIPCIÓN", vbExclamation, "SISTEMA PIZZERIA")
            TicK_descripcionTextBox.Focus()
        ElseIf Tick_cantidadTextBox.Text = "" Then
            MsgBox("INGRESE LA CANTIDAD", vbExclamation, "SISTEMA PIZZERIA")
            Tick_cantidadTextBox.Focus()
        ElseIf Tick_totalTextBox.Text = "" Then
            MsgBox("INGRESE EL TOTAL", vbExclamation, "SISTEMA PIZZERIA")
            Tick_totalTextBox.Focus()
        Else
            Me.Validate()
            Me.TicketBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.PizzeriaDataSet)
            Me.TicketTableAdapter.Fill(Me.PizzeriaDataSet.ticket)
            MsgBox("BOLETA AGREGADA", vbInformation, "SISTEMA PIZZERIA")
            desactivar()
        End If
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        Me.TicketTableAdapter.Fill(Me.PizzeriaDataSet.ticket)
        txtbuscar.Text = ""
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim msj As MsgBoxResult
        msj = MsgBox("¿DESEA ELIMINAR EL PRODUCTO?", vbYesNo, "SISTEMA PIZZERIA")
        If msj = MsgBoxResult.Yes Then
            Me.TicketTableAdapter.BORRAR(Tick_numeroTextBox.Text)
            Me.TicketTableAdapter.Fill(Me.PizzeriaDataSet.ticket)
            MsgBox("LOS DATOS DEL PRODUCTO FUERON BORRADOS", vbInformation, "SISTEMA PIZZERIA")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        If txtbuscar.Text = "" Then
            MsgBox("INGRESE El TICKET A BUSCAR", vbExclamation, "SISTEMA PIZZERIA")
            txtbuscar.Focus()
        Else
            Me.TicketTableAdapter.BUSCAR_TICKET(PizzeriaDataSet.ticket, txtbuscar.Text)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.ProductosTableAdapter.Fill(Me.PizzeriaDataSet.productos)
    End Sub

    Private Sub Tick_cantidadTextBox_TextChanged(sender As Object, e As EventArgs) Handles Tick_cantidadTextBox.TextChanged
        Dim precio, total, cantidad As Double
        precio = Val(txtprecio.Text)
        cantidad = Val(Tick_cantidadTextBox.Text)
        total = precio * cantidad
        Tick_totalTextBox.Text = total
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        factura.Show()
    End Sub

    Private Sub Tick_numeroTextBox_TextChanged(sender As Object, e As EventArgs) Handles Tick_numeroTextBox.TextChanged
        Tick_numeroTextBox.Text = Cli_idTextBox.Text + Prod_codTextBox.Text
    End Sub
End Class