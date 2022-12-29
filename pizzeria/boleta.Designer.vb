<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class boleta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Tick_numeroLabel As System.Windows.Forms.Label
        Dim Cli_idLabel As System.Windows.Forms.Label
        Dim Prod_codLabel As System.Windows.Forms.Label
        Dim TicK_descripcionLabel As System.Windows.Forms.Label
        Dim Tick_cantidadLabel As System.Windows.Forms.Label
        Dim Tick_totalLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(boleta))
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
        Me.TicketBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PizzeriaDataSet = New pizzeria.pizzeriaDataSet()
        Me.TicketTableAdapter = New pizzeria.pizzeriaDataSetTableAdapters.ticketTableAdapter()
        Me.TableAdapterManager = New pizzeria.pizzeriaDataSetTableAdapters.TableAdapterManager()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.TicketBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TicketBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.TicketDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tick_numeroTextBox = New System.Windows.Forms.TextBox()
        Me.Cli_idTextBox = New System.Windows.Forms.TextBox()
        Me.Prod_codTextBox = New System.Windows.Forms.TextBox()
        Me.TicK_descripcionTextBox = New System.Windows.Forms.TextBox()
        Me.Tick_cantidadTextBox = New System.Windows.Forms.TextBox()
        Me.Tick_totalTextBox = New System.Windows.Forms.TextBox()
        Me.GRUPO1 = New System.Windows.Forms.GroupBox()
        Me.cmbdni = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcliente = New System.Windows.Forms.TextBox()
        Me.GRUPO2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbproducto = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtproducto = New System.Windows.Forms.TextBox()
        Me.ClientesTableAdapter = New pizzeria.pizzeriaDataSetTableAdapters.clientesTableAdapter()
        Me.ProductosTableAdapter = New pizzeria.pizzeriaDataSetTableAdapters.productosTableAdapter()
        Me.Button3 = New System.Windows.Forms.Button()
        Tick_numeroLabel = New System.Windows.Forms.Label()
        Cli_idLabel = New System.Windows.Forms.Label()
        Prod_codLabel = New System.Windows.Forms.Label()
        TicK_descripcionLabel = New System.Windows.Forms.Label()
        Tick_cantidadLabel = New System.Windows.Forms.Label()
        Tick_totalLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TicketBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PizzeriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TicketBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TicketBindingNavigator.SuspendLayout()
        CType(Me.TicketDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRUPO1.SuspendLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRUPO2.SuspendLayout()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tick_numeroLabel
        '
        Tick_numeroLabel.AutoSize = True
        Tick_numeroLabel.BackColor = System.Drawing.Color.Transparent
        Tick_numeroLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Tick_numeroLabel.Location = New System.Drawing.Point(34, 82)
        Tick_numeroLabel.Name = "Tick_numeroLabel"
        Tick_numeroLabel.Size = New System.Drawing.Size(187, 20)
        Tick_numeroLabel.TabIndex = 29
        Tick_numeroLabel.Text = "NUMERO DE TICKET:"
        '
        'Cli_idLabel
        '
        Cli_idLabel.AutoSize = True
        Cli_idLabel.BackColor = System.Drawing.Color.Transparent
        Cli_idLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cli_idLabel.Location = New System.Drawing.Point(128, 129)
        Cli_idLabel.Name = "Cli_idLabel"
        Cli_idLabel.Size = New System.Drawing.Size(88, 20)
        Cli_idLabel.TabIndex = 31
        Cli_idLabel.Text = "CLIENTE:"
        '
        'Prod_codLabel
        '
        Prod_codLabel.AutoSize = True
        Prod_codLabel.BackColor = System.Drawing.Color.Transparent
        Prod_codLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Prod_codLabel.Location = New System.Drawing.Point(104, 178)
        Prod_codLabel.Name = "Prod_codLabel"
        Prod_codLabel.Size = New System.Drawing.Size(112, 20)
        Prod_codLabel.TabIndex = 33
        Prod_codLabel.Text = "PRODUCTO:"
        '
        'TicK_descripcionLabel
        '
        TicK_descripcionLabel.AutoSize = True
        TicK_descripcionLabel.BackColor = System.Drawing.Color.Transparent
        TicK_descripcionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TicK_descripcionLabel.Location = New System.Drawing.Point(93, 226)
        TicK_descripcionLabel.Name = "TicK_descripcionLabel"
        TicK_descripcionLabel.Size = New System.Drawing.Size(124, 20)
        TicK_descripcionLabel.TabIndex = 35
        TicK_descripcionLabel.Text = "DESRIPCION:"
        '
        'Tick_cantidadLabel
        '
        Tick_cantidadLabel.AutoSize = True
        Tick_cantidadLabel.BackColor = System.Drawing.Color.Transparent
        Tick_cantidadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Tick_cantidadLabel.Location = New System.Drawing.Point(112, 360)
        Tick_cantidadLabel.Name = "Tick_cantidadLabel"
        Tick_cantidadLabel.Size = New System.Drawing.Size(104, 20)
        Tick_cantidadLabel.TabIndex = 37
        Tick_cantidadLabel.Text = "CANTIDAD:"
        '
        'Tick_totalLabel
        '
        Tick_totalLabel.AutoSize = True
        Tick_totalLabel.BackColor = System.Drawing.Color.Transparent
        Tick_totalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Tick_totalLabel.Location = New System.Drawing.Point(147, 410)
        Tick_totalLabel.Name = "Tick_totalLabel"
        Tick_totalLabel.Size = New System.Drawing.Size(69, 20)
        Tick_totalLabel.TabIndex = 39
        Tick_totalLabel.Text = "TOTAL:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnbuscar)
        Me.GroupBox1.Controls.Add(Me.txtbuscar)
        Me.GroupBox1.Location = New System.Drawing.Point(501, 345)
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
        Me.btnagregar.Location = New System.Drawing.Point(522, 110)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(159, 44)
        Me.btnagregar.TabIndex = 25
        Me.btnagregar.Text = "AGREGAR"
        Me.btnagregar.UseVisualStyleBackColor = False
        '
        'btnactualizar
        '
        Me.btnactualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnactualizar.Location = New System.Drawing.Point(522, 286)
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
        Me.btncancelar.Location = New System.Drawing.Point(522, 110)
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
        Me.btneliminar.Location = New System.Drawing.Point(522, 223)
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
        Me.btngrabar.Location = New System.Drawing.Point(522, 167)
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
        Me.Button4.Location = New System.Drawing.Point(802, 502)
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
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(333, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(388, 37)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "REGISTRO DE BOLETA"
        '
        'TicketBindingSource
        '
        Me.TicketBindingSource.DataMember = "ticket"
        Me.TicketBindingSource.DataSource = Me.PizzeriaDataSet
        '
        'PizzeriaDataSet
        '
        Me.PizzeriaDataSet.DataSetName = "pizzeriaDataSet"
        Me.PizzeriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TicketTableAdapter
        '
        Me.TicketTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.productosTableAdapter = Nothing
        Me.TableAdapterManager.ticketTableAdapter = Me.TicketTableAdapter
        Me.TableAdapterManager.UpdateOrder = pizzeria.pizzeriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
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
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
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
        'TicketBindingNavigatorSaveItem
        '
        Me.TicketBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TicketBindingNavigatorSaveItem.Image = CType(resources.GetObject("TicketBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TicketBindingNavigatorSaveItem.Name = "TicketBindingNavigatorSaveItem"
        Me.TicketBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TicketBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'TicketBindingNavigator
        '
        Me.TicketBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TicketBindingNavigator.BindingSource = Me.TicketBindingSource
        Me.TicketBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TicketBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TicketBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TicketBindingNavigatorSaveItem})
        Me.TicketBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TicketBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TicketBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TicketBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TicketBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TicketBindingNavigator.Name = "TicketBindingNavigator"
        Me.TicketBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TicketBindingNavigator.Size = New System.Drawing.Size(997, 25)
        Me.TicketBindingNavigator.TabIndex = 27
        Me.TicketBindingNavigator.Text = "BindingNavigator1"
        Me.TicketBindingNavigator.Visible = False
        '
        'TicketDataGridView
        '
        Me.TicketDataGridView.AutoGenerateColumns = False
        Me.TicketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TicketDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.TicketDataGridView.DataSource = Me.TicketBindingSource
        Me.TicketDataGridView.Location = New System.Drawing.Point(12, 515)
        Me.TicketDataGridView.Name = "TicketDataGridView"
        Me.TicketDataGridView.Size = New System.Drawing.Size(742, 163)
        Me.TicketDataGridView.TabIndex = 27
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "tick_numero"
        Me.DataGridViewTextBoxColumn2.HeaderText = "tick_numero"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "cli_id"
        Me.DataGridViewTextBoxColumn3.HeaderText = "cli_id"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "prod_cod"
        Me.DataGridViewTextBoxColumn4.HeaderText = "prod_cod"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ticK_descripcion"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ticK_descripcion"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "tick_cantidad"
        Me.DataGridViewTextBoxColumn6.HeaderText = "tick_cantidad"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "tick_total"
        Me.DataGridViewTextBoxColumn7.HeaderText = "tick_total"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Tick_numeroTextBox
        '
        Me.Tick_numeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TicketBindingSource, "tick_numero", True))
        Me.Tick_numeroTextBox.Enabled = False
        Me.Tick_numeroTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tick_numeroTextBox.Location = New System.Drawing.Point(227, 79)
        Me.Tick_numeroTextBox.Name = "Tick_numeroTextBox"
        Me.Tick_numeroTextBox.Size = New System.Drawing.Size(192, 26)
        Me.Tick_numeroTextBox.TabIndex = 30
        Me.Tick_numeroTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cli_idTextBox
        '
        Me.Cli_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TicketBindingSource, "cli_id", True))
        Me.Cli_idTextBox.Enabled = False
        Me.Cli_idTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cli_idTextBox.Location = New System.Drawing.Point(227, 126)
        Me.Cli_idTextBox.Name = "Cli_idTextBox"
        Me.Cli_idTextBox.Size = New System.Drawing.Size(236, 26)
        Me.Cli_idTextBox.TabIndex = 32
        Me.Cli_idTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Prod_codTextBox
        '
        Me.Prod_codTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TicketBindingSource, "prod_cod", True))
        Me.Prod_codTextBox.Enabled = False
        Me.Prod_codTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prod_codTextBox.Location = New System.Drawing.Point(227, 175)
        Me.Prod_codTextBox.Name = "Prod_codTextBox"
        Me.Prod_codTextBox.Size = New System.Drawing.Size(236, 26)
        Me.Prod_codTextBox.TabIndex = 34
        Me.Prod_codTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TicK_descripcionTextBox
        '
        Me.TicK_descripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TicketBindingSource, "ticK_descripcion", True))
        Me.TicK_descripcionTextBox.Enabled = False
        Me.TicK_descripcionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TicK_descripcionTextBox.Location = New System.Drawing.Point(227, 223)
        Me.TicK_descripcionTextBox.Multiline = True
        Me.TicK_descripcionTextBox.Name = "TicK_descripcionTextBox"
        Me.TicK_descripcionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TicK_descripcionTextBox.Size = New System.Drawing.Size(236, 109)
        Me.TicK_descripcionTextBox.TabIndex = 36
        '
        'Tick_cantidadTextBox
        '
        Me.Tick_cantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TicketBindingSource, "tick_cantidad", True))
        Me.Tick_cantidadTextBox.Enabled = False
        Me.Tick_cantidadTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tick_cantidadTextBox.Location = New System.Drawing.Point(227, 357)
        Me.Tick_cantidadTextBox.Name = "Tick_cantidadTextBox"
        Me.Tick_cantidadTextBox.Size = New System.Drawing.Size(100, 26)
        Me.Tick_cantidadTextBox.TabIndex = 38
        Me.Tick_cantidadTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tick_totalTextBox
        '
        Me.Tick_totalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TicketBindingSource, "tick_total", True))
        Me.Tick_totalTextBox.Enabled = False
        Me.Tick_totalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tick_totalTextBox.Location = New System.Drawing.Point(227, 407)
        Me.Tick_totalTextBox.Name = "Tick_totalTextBox"
        Me.Tick_totalTextBox.Size = New System.Drawing.Size(100, 26)
        Me.Tick_totalTextBox.TabIndex = 40
        Me.Tick_totalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GRUPO1
        '
        Me.GRUPO1.Controls.Add(Me.cmbdni)
        Me.GRUPO1.Controls.Add(Me.Button1)
        Me.GRUPO1.Controls.Add(Me.Label3)
        Me.GRUPO1.Controls.Add(Me.Label2)
        Me.GRUPO1.Controls.Add(Me.txtcliente)
        Me.GRUPO1.Enabled = False
        Me.GRUPO1.Location = New System.Drawing.Point(729, 82)
        Me.GRUPO1.Name = "GRUPO1"
        Me.GRUPO1.Size = New System.Drawing.Size(289, 145)
        Me.GRUPO1.TabIndex = 41
        Me.GRUPO1.TabStop = False
        Me.GRUPO1.Text = "SELECCIONE CLIENTE:"
        '
        'cmbdni
        '
        Me.cmbdni.DataSource = Me.ClientesBindingSource
        Me.cmbdni.DisplayMember = "cli_dni"
        Me.cmbdni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdni.FormattingEnabled = True
        Me.cmbdni.Location = New System.Drawing.Point(99, 26)
        Me.cmbdni.Name = "cmbdni"
        Me.cmbdni.Size = New System.Drawing.Size(138, 24)
        Me.cmbdni.TabIndex = 5
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.PizzeriaDataSet
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(13, 104)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(258, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "ACTUALIZAR CLIENTES"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "CLIENTE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "DNI:"
        '
        'txtcliente
        '
        Me.txtcliente.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.ClientesBindingSource, "cli_nombres", True))
        Me.txtcliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "cli_nombres", True))
        Me.txtcliente.Enabled = False
        Me.txtcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcliente.Location = New System.Drawing.Point(99, 63)
        Me.txtcliente.Name = "txtcliente"
        Me.txtcliente.Size = New System.Drawing.Size(172, 22)
        Me.txtcliente.TabIndex = 1
        Me.txtcliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GRUPO2
        '
        Me.GRUPO2.Controls.Add(Me.Label6)
        Me.GRUPO2.Controls.Add(Me.txtprecio)
        Me.GRUPO2.Controls.Add(Me.cmbproducto)
        Me.GRUPO2.Controls.Add(Me.Button2)
        Me.GRUPO2.Controls.Add(Me.Label4)
        Me.GRUPO2.Controls.Add(Me.Label5)
        Me.GRUPO2.Controls.Add(Me.txtproducto)
        Me.GRUPO2.Enabled = False
        Me.GRUPO2.Location = New System.Drawing.Point(718, 268)
        Me.GRUPO2.Name = "GRUPO2"
        Me.GRUPO2.Size = New System.Drawing.Size(309, 162)
        Me.GRUPO2.TabIndex = 42
        Me.GRUPO2.TabStop = False
        Me.GRUPO2.Text = "SELECCIONE PRODUCTO:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(40, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 16)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "PRECIO:"
        '
        'txtprecio
        '
        Me.txtprecio.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.ProductosBindingSource, "prod_precio", True))
        Me.txtprecio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "prod_precio", True))
        Me.txtprecio.Enabled = False
        Me.txtprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecio.Location = New System.Drawing.Point(122, 100)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(100, 22)
        Me.txtprecio.TabIndex = 43
        Me.txtprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "productos"
        Me.ProductosBindingSource.DataSource = Me.PizzeriaDataSet
        '
        'cmbproducto
        '
        Me.cmbproducto.DataSource = Me.ProductosBindingSource
        Me.cmbproducto.DisplayMember = "prod_ cod"
        Me.cmbproducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbproducto.FormattingEnabled = True
        Me.cmbproducto.Location = New System.Drawing.Point(122, 31)
        Me.cmbproducto.Name = "cmbproducto"
        Me.cmbproducto.Size = New System.Drawing.Size(110, 24)
        Me.cmbproducto.TabIndex = 10
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(36, 130)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(258, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "ACTUALIZAR PRODUCTOS"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "PRODUCTO:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "CODIGO:"
        '
        'txtproducto
        '
        Me.txtproducto.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.ProductosBindingSource, "prod_nombre", True))
        Me.txtproducto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "prod_nombre", True))
        Me.txtproducto.Enabled = False
        Me.txtproducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtproducto.Location = New System.Drawing.Point(122, 68)
        Me.txtproducto.Name = "txtproducto"
        Me.txtproducto.Size = New System.Drawing.Size(172, 22)
        Me.txtproducto.TabIndex = 6
        Me.txtproducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(12, 453)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(148, 41)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "FACTURA"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'boleta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.pizzeria.My.Resources.Resources.seamless_texture_color_image_of_a_pizza_slices_with_various_ingredients_vector
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1040, 689)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GRUPO2)
        Me.Controls.Add(Me.GRUPO1)
        Me.Controls.Add(Tick_numeroLabel)
        Me.Controls.Add(Me.Tick_numeroTextBox)
        Me.Controls.Add(Cli_idLabel)
        Me.Controls.Add(Me.Cli_idTextBox)
        Me.Controls.Add(Prod_codLabel)
        Me.Controls.Add(Me.Prod_codTextBox)
        Me.Controls.Add(TicK_descripcionLabel)
        Me.Controls.Add(Me.TicK_descripcionTextBox)
        Me.Controls.Add(Tick_cantidadLabel)
        Me.Controls.Add(Me.Tick_cantidadTextBox)
        Me.Controls.Add(Tick_totalLabel)
        Me.Controls.Add(Me.Tick_totalTextBox)
        Me.Controls.Add(Me.TicketDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.btnactualizar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btngrabar)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TicketBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "boleta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BOLETA DE PAGO"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TicketBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PizzeriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TicketBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TicketBindingNavigator.ResumeLayout(False)
        Me.TicketBindingNavigator.PerformLayout()
        CType(Me.TicketDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRUPO1.ResumeLayout(False)
        Me.GRUPO1.PerformLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRUPO2.ResumeLayout(False)
        Me.GRUPO2.PerformLayout()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TicketBindingSource As BindingSource
    Friend WithEvents PizzeriaDataSet As pizzeriaDataSet
    Friend WithEvents TicketTableAdapter As pizzeriaDataSetTableAdapters.ticketTableAdapter
    Friend WithEvents TableAdapterManager As pizzeriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents TicketBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TicketBindingNavigator As BindingNavigator
    Friend WithEvents TicketDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Tick_numeroTextBox As TextBox
    Friend WithEvents Cli_idTextBox As TextBox
    Friend WithEvents Prod_codTextBox As TextBox
    Friend WithEvents TicK_descripcionTextBox As TextBox
    Friend WithEvents Tick_cantidadTextBox As TextBox
    Friend WithEvents Tick_totalTextBox As TextBox
    Friend WithEvents GRUPO1 As GroupBox
    Friend WithEvents GRUPO2 As GroupBox
    Friend WithEvents cmbdni As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcliente As TextBox
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As pizzeriaDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents cmbproducto As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtproducto As TextBox
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents ProductosTableAdapter As pizzeriaDataSetTableAdapters.productosTableAdapter
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button3 As Button
End Class
