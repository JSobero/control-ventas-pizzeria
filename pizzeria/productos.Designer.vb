<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class productos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Prod__codLabel As System.Windows.Forms.Label
        Dim Prod_nombreLabel As System.Windows.Forms.Label
        Dim Prod_descripcionLabel As System.Windows.Forms.Label
        Dim Prod_precioLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(productos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btngrabar = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PizzeriaDataSet = New pizzeria.pizzeriaDataSet()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosTableAdapter = New pizzeria.pizzeriaDataSetTableAdapters.productosTableAdapter()
        Me.TableAdapterManager = New pizzeria.pizzeriaDataSetTableAdapters.TableAdapterManager()
        Me.ProductosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProductosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Prod__codTextBox = New System.Windows.Forms.TextBox()
        Me.Prod_nombreTextBox = New System.Windows.Forms.TextBox()
        Me.Prod_descripcionTextBox = New System.Windows.Forms.TextBox()
        Me.Prod_precioTextBox = New System.Windows.Forms.TextBox()
        Me.ProductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Prod__codLabel = New System.Windows.Forms.Label()
        Prod_nombreLabel = New System.Windows.Forms.Label()
        Prod_descripcionLabel = New System.Windows.Forms.Label()
        Prod_precioLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PizzeriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductosBindingNavigator.SuspendLayout()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Prod__codLabel
        '
        Prod__codLabel.AutoSize = True
        Prod__codLabel.BackColor = System.Drawing.Color.Transparent
        Prod__codLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Prod__codLabel.Location = New System.Drawing.Point(72, 91)
        Prod__codLabel.Name = "Prod__codLabel"
        Prod__codLabel.Size = New System.Drawing.Size(85, 20)
        Prod__codLabel.TabIndex = 29
        Prod__codLabel.Text = "CODIGO:"
        '
        'Prod_nombreLabel
        '
        Prod_nombreLabel.AutoSize = True
        Prod_nombreLabel.BackColor = System.Drawing.Color.Transparent
        Prod_nombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Prod_nombreLabel.Location = New System.Drawing.Point(67, 135)
        Prod_nombreLabel.Name = "Prod_nombreLabel"
        Prod_nombreLabel.Size = New System.Drawing.Size(90, 20)
        Prod_nombreLabel.TabIndex = 31
        Prod_nombreLabel.Text = "NOMBRE:"
        '
        'Prod_descripcionLabel
        '
        Prod_descripcionLabel.AutoSize = True
        Prod_descripcionLabel.BackColor = System.Drawing.Color.Transparent
        Prod_descripcionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Prod_descripcionLabel.Location = New System.Drawing.Point(21, 179)
        Prod_descripcionLabel.Name = "Prod_descripcionLabel"
        Prod_descripcionLabel.Size = New System.Drawing.Size(136, 20)
        Prod_descripcionLabel.TabIndex = 33
        Prod_descripcionLabel.Text = "DESCRIPCION:"
        '
        'Prod_precioLabel
        '
        Prod_precioLabel.AutoSize = True
        Prod_precioLabel.BackColor = System.Drawing.Color.Transparent
        Prod_precioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Prod_precioLabel.Location = New System.Drawing.Point(76, 287)
        Prod_precioLabel.Name = "Prod_precioLabel"
        Prod_precioLabel.Size = New System.Drawing.Size(81, 20)
        Prod_precioLabel.TabIndex = 35
        Prod_precioLabel.Text = "PRECIO:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnbuscar)
        Me.GroupBox1.Controls.Add(Me.txtbuscar)
        Me.GroupBox1.Location = New System.Drawing.Point(603, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(197, 149)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BUSCAR"
        '
        'btnbuscar
        '
        Me.btnbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscar.Location = New System.Drawing.Point(24, 84)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(148, 41)
        Me.btnbuscar.TabIndex = 19
        Me.btnbuscar.Text = "BUSCAR"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'txtbuscar
        '
        Me.txtbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuscar.Location = New System.Drawing.Point(16, 41)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(159, 24)
        Me.txtbuscar.TabIndex = 0
        '
        'btnagregar
        '
        Me.btnagregar.BackColor = System.Drawing.Color.Lime
        Me.btnagregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagregar.Location = New System.Drawing.Point(415, 78)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(159, 44)
        Me.btnagregar.TabIndex = 25
        Me.btnagregar.Text = "AGREGAR"
        Me.btnagregar.UseVisualStyleBackColor = False
        '
        'btnactualizar
        '
        Me.btnactualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnactualizar.Location = New System.Drawing.Point(415, 245)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(159, 44)
        Me.btnactualizar.TabIndex = 24
        Me.btnactualizar.Text = "ACTUALIZAR"
        Me.btnactualizar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.Red
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.Location = New System.Drawing.Point(415, 77)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(159, 44)
        Me.btncancelar.TabIndex = 23
        Me.btncancelar.Text = "CANCELAR"
        Me.btncancelar.UseVisualStyleBackColor = False
        Me.btncancelar.Visible = False
        '
        'btneliminar
        '
        Me.btneliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminar.Location = New System.Drawing.Point(415, 190)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(159, 44)
        Me.btneliminar.TabIndex = 22
        Me.btneliminar.Text = "ELIMINAR"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btngrabar
        '
        Me.btngrabar.Enabled = False
        Me.btngrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngrabar.Location = New System.Drawing.Point(415, 134)
        Me.btngrabar.Name = "btngrabar"
        Me.btngrabar.Size = New System.Drawing.Size(159, 44)
        Me.btngrabar.TabIndex = 21
        Me.btngrabar.Text = "GRABAR"
        Me.btngrabar.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = Global.pizzeria.My.Resources.Resources.salirr
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Button4.Location = New System.Drawing.Point(614, 393)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(198, 176)
        Me.Button4.TabIndex = 20
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(189, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(467, 37)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "REGISTRO DE PRODUCTOS"
        '
        'PizzeriaDataSet
        '
        Me.PizzeriaDataSet.DataSetName = "pizzeriaDataSet"
        Me.PizzeriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "productos"
        Me.ProductosBindingSource.DataSource = Me.PizzeriaDataSet
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.productosTableAdapter = Me.ProductosTableAdapter
        Me.TableAdapterManager.ticketTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = pizzeria.pizzeriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProductosBindingNavigator
        '
        Me.ProductosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProductosBindingNavigator.BindingSource = Me.ProductosBindingSource
        Me.ProductosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProductosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProductosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProductosBindingNavigatorSaveItem})
        Me.ProductosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProductosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProductosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProductosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProductosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProductosBindingNavigator.Name = "ProductosBindingNavigator"
        Me.ProductosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProductosBindingNavigator.Size = New System.Drawing.Size(824, 25)
        Me.ProductosBindingNavigator.TabIndex = 27
        Me.ProductosBindingNavigator.Text = "BindingNavigator1"
        Me.ProductosBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ProductosBindingNavigatorSaveItem
        '
        Me.ProductosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProductosBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProductosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProductosBindingNavigatorSaveItem.Name = "ProductosBindingNavigatorSaveItem"
        Me.ProductosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ProductosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Prod__codTextBox
        '
        Me.Prod__codTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "prod_ cod", True))
        Me.Prod__codTextBox.Enabled = False
        Me.Prod__codTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prod__codTextBox.Location = New System.Drawing.Point(163, 88)
        Me.Prod__codTextBox.Name = "Prod__codTextBox"
        Me.Prod__codTextBox.Size = New System.Drawing.Size(81, 26)
        Me.Prod__codTextBox.TabIndex = 30
        Me.Prod__codTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Prod_nombreTextBox
        '
        Me.Prod_nombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "prod_nombre", True))
        Me.Prod_nombreTextBox.Enabled = False
        Me.Prod_nombreTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prod_nombreTextBox.Location = New System.Drawing.Point(163, 132)
        Me.Prod_nombreTextBox.Name = "Prod_nombreTextBox"
        Me.Prod_nombreTextBox.Size = New System.Drawing.Size(209, 26)
        Me.Prod_nombreTextBox.TabIndex = 32
        Me.Prod_nombreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Prod_descripcionTextBox
        '
        Me.Prod_descripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "prod_descripcion", True))
        Me.Prod_descripcionTextBox.Enabled = False
        Me.Prod_descripcionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prod_descripcionTextBox.Location = New System.Drawing.Point(163, 176)
        Me.Prod_descripcionTextBox.Multiline = True
        Me.Prod_descripcionTextBox.Name = "Prod_descripcionTextBox"
        Me.Prod_descripcionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Prod_descripcionTextBox.Size = New System.Drawing.Size(209, 86)
        Me.Prod_descripcionTextBox.TabIndex = 34
        '
        'Prod_precioTextBox
        '
        Me.Prod_precioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "prod_precio", True))
        Me.Prod_precioTextBox.Enabled = False
        Me.Prod_precioTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prod_precioTextBox.Location = New System.Drawing.Point(163, 284)
        Me.Prod_precioTextBox.Name = "Prod_precioTextBox"
        Me.Prod_precioTextBox.Size = New System.Drawing.Size(100, 26)
        Me.Prod_precioTextBox.TabIndex = 36
        Me.Prod_precioTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ProductosDataGridView
        '
        Me.ProductosDataGridView.AutoGenerateColumns = False
        Me.ProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.ProductosDataGridView.DataSource = Me.ProductosBindingSource
        Me.ProductosDataGridView.Location = New System.Drawing.Point(25, 346)
        Me.ProductosDataGridView.Name = "ProductosDataGridView"
        Me.ProductosDataGridView.Size = New System.Drawing.Size(538, 220)
        Me.ProductosDataGridView.TabIndex = 36
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "prod_ cod"
        Me.DataGridViewTextBoxColumn2.HeaderText = "prod_ cod"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "prod_nombre"
        Me.DataGridViewTextBoxColumn3.HeaderText = "prod_nombre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "prod_descripcion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "prod_descripcion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "prod_precio"
        Me.DataGridViewTextBoxColumn5.HeaderText = "prod_precio"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.pizzeria.My.Resources.Resources.seamless_texture_color_image_of_a_pizza_slices_with_various_ingredients_vector
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(824, 581)
        Me.ControlBox = False
        Me.Controls.Add(Me.ProductosDataGridView)
        Me.Controls.Add(Prod__codLabel)
        Me.Controls.Add(Me.Prod__codTextBox)
        Me.Controls.Add(Prod_nombreLabel)
        Me.Controls.Add(Me.Prod_nombreTextBox)
        Me.Controls.Add(Prod_descripcionLabel)
        Me.Controls.Add(Me.Prod_descripcionTextBox)
        Me.Controls.Add(Prod_precioLabel)
        Me.Controls.Add(Me.Prod_precioTextBox)
        Me.Controls.Add(Me.ProductosBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.btnactualizar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btngrabar)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "productos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PRODUCTOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PizzeriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductosBindingNavigator.ResumeLayout(False)
        Me.ProductosBindingNavigator.PerformLayout()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnbuscar As Button
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents btnagregar As Button
    Friend WithEvents btnactualizar As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btngrabar As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PizzeriaDataSet As pizzeriaDataSet
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents ProductosTableAdapter As pizzeriaDataSetTableAdapters.productosTableAdapter
    Friend WithEvents TableAdapterManager As pizzeriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ProductosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Prod__codTextBox As TextBox
    Friend WithEvents Prod_nombreTextBox As TextBox
    Friend WithEvents Prod_descripcionTextBox As TextBox
    Friend WithEvents Prod_precioTextBox As TextBox
    Friend WithEvents ProductosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
