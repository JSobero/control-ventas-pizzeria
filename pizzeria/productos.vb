Public Class productos
    'Private Sub ProductosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MyBaseBindingNavigatorSaveItem.Click, MyBaseBindingNavigatorSaveItem.Click, MyBaseBindingNavigatorSaveItem.Click
    'Me.Validate()
    'Me.ProductosBindingSource.EndEdit()
    'Me.TableAdapterManager.UpdateAll(Me.PizzeriaDataSet)

    'End Sub

    Private Sub productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PizzeriaDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.PizzeriaDataSet.productos)

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
        Prod_descripcionTextBox.Enabled = True
        Prod_nombreTextBox.Enabled = True
        Prod_precioTextBox.Enabled = True
        Prod__codTextBox.Enabled = True
        btnagregar.Visible = False
        btngrabar.Enabled = True
        btncancelar.Visible = True
        Prod__codTextBox.Focus()
    End Sub
    Private Sub desactivar()
        Prod_descripcionTextBox.Enabled = False
        Prod_nombreTextBox.Enabled = False
        Prod_precioTextBox.Enabled = False
        Prod__codTextBox.Enabled = False
        btnagregar.Visible = True
        btngrabar.Enabled = False
        btncancelar.Visible = False
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        activar()
        Me.Validate()
        Me.ProductosBindingSource.AddNew()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        desactivar()
        Me.Validate()
        Me.ProductosBindingSource.CancelEdit()
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        If txtbuscar.Text = "" Then
            MsgBox("INGRESE EL PRODUCTO A BUSCAR", vbExclamation, "SISTEMA PIZZERIA")
            txtbuscar.Focus()
        Else
            Me.ProductosTableAdapter.BUSCAR_PRODUCTO(PizzeriaDataSet.productos, txtbuscar.Text)
        End If
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        Me.ProductosTableAdapter.Fill(Me.PizzeriaDataSet.productos)
        txtbuscar.Text = ""
    End Sub

    Private Sub btngrabar_Click(sender As Object, e As EventArgs) Handles btngrabar.Click
        If Prod__codTextBox.Text = "" Then
            MsgBox("INGRESE EL CODIGO", vbExclamation, "SISTEMA PIZZERIA")
            Prod__codTextBox.Focus()
        ElseIf Prod_nombreTextBox.Text = "" Then
            MsgBox("INGRESE EL NOMBRE", vbExclamation, "SISTEMA PIZZERIA")
            Prod_nombreTextBox.Focus()
        ElseIf Prod_descripcionTextBox.Text = "" Then
            MsgBox("INGRESE LA DESCRIPCION", vbExclamation, "SISTEMA PIZZERIA")
            Prod_descripcionTextBox.Focus()
        ElseIf Prod_precioTextBox.Text = "" Then
            MsgBox("INGRESE EL PRECIO", vbExclamation, "SISTEMA PIZZERIA")
            Prod_precioTextBox.Focus()
        Else
            Me.Validate()
            Me.ProductosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.PizzeriaDataSet)
            Me.ProductosTableAdapter.Fill(Me.PizzeriaDataSet.productos)
            MsgBox("PRODUCTO AGREGADO", vbInformation, "SISTEMA PIZZERIA")
            desactivar()
        End If
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim msj As MsgBoxResult
        msj = MsgBox("¿DESEA ELIMINAR EL PRODUCTO?", vbYesNo, "SISTEMA PIZZERIA")
        If msj = MsgBoxResult.Yes Then
            Me.ProductosTableAdapter.BORRAR(Prod__codTextBox.Text)
            Me.ProductosTableAdapter.Fill(Me.PizzeriaDataSet.productos)
            MsgBox("LOS DATOS DEL PRODUCTO FUERON BORRADOS", vbInformation, "SISTEMA PIZZERIA")
        Else
            Exit Sub
        End If
    End Sub
End Class