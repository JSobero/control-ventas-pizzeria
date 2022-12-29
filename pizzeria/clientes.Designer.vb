<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clientes
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
        Dim Cli_dniLabel As System.Windows.Forms.Label
        Dim Cli_nombresLabel As System.Windows.Forms.Label
        Dim Cli_celLabel As System.Windows.Forms.Label
        Dim Cli_emailLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(clientes))
        Me.PizzeriaDataSet = New pizzeria.pizzeriaDataSet()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New pizzeria.pizzeriaDataSetTableAdapters.clientesTableAdapter()
        Me.TableAdapterManager = New pizzeria.pizzeriaDataSetTableAdapters.TableAdapterManager()
        Me.ClientesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ClientesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Cli_dniTextBox = New System.Windows.Forms.TextBox()
        Me.Cli_nombresTextBox = New System.Windows.Forms.TextBox()
        Me.Cli_celTextBox = New System.Windows.Forms.TextBox()
        Me.Cli_emailTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClientesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btngrabar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Cli_dniLabel = New System.Windows.Forms.Label()
        Cli_nombresLabel = New System.Windows.Forms.Label()
        Cli_celLabel = New System.Windows.Forms.Label()
        Cli_emailLabel = New System.Windows.Forms.Label()
        CType(Me.PizzeriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClientesBindingNavigator.SuspendLayout()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cli_dniLabel
        '
        Cli_dniLabel.AutoSize = True
        Cli_dniLabel.BackColor = System.Drawing.Color.Transparent
        Cli_dniLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cli_dniLabel.Location = New System.Drawing.Point(112, 101)
        Cli_dniLabel.Name = "Cli_dniLabel"
        Cli_dniLabel.Size = New System.Drawing.Size(45, 20)
        Cli_dniLabel.TabIndex = 3
        Cli_dniLabel.Text = "DNI:"
        '
        'Cli_nombresLabel
        '
        Cli_nombresLabel.AutoSize = True
        Cli_nombresLabel.BackColor = System.Drawing.Color.Transparent
        Cli_nombresLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cli_nombresLabel.Location = New System.Drawing.Point(59, 152)
        Cli_nombresLabel.Name = "Cli_nombresLabel"
        Cli_nombresLabel.Size = New System.Drawing.Size(102, 20)
        Cli_nombresLabel.TabIndex = 5
        Cli_nombresLabel.Text = "NOMBRES:"
        '
        'Cli_celLabel
        '
        Cli_celLabel.AutoSize = True
        Cli_celLabel.BackColor = System.Drawing.Color.Transparent
        Cli_celLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cli_celLabel.Location = New System.Drawing.Point(65, 203)
        Cli_celLabel.Name = "Cli_celLabel"
        Cli_celLabel.Size = New System.Drawing.Size(96, 20)
        Cli_celLabel.TabIndex = 7
        Cli_celLabel.Text = "CELULAR:"
        '
        'Cli_emailLabel
        '
        Cli_emailLabel.AutoSize = True
        Cli_emailLabel.BackColor = System.Drawing.Color.Transparent
        Cli_emailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cli_emailLabel.Location = New System.Drawing.Point(91, 259)
        Cli_emailLabel.Name = "Cli_emailLabel"
        Cli_emailLabel.Size = New System.Drawing.Size(68, 20)
        Cli_emailLabel.TabIndex = 9
        Cli_emailLabel.Text = "EMAIL:"
        '
        'PizzeriaDataSet
        '
        Me.PizzeriaDataSet.DataSetName = "pizzeriaDataSet"
        Me.PizzeriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.PizzeriaDataSet
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.productosTableAdapter = Nothing
        Me.TableAdapterManager.ticketTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = pizzeria.pizzeriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ClientesBindingNavigator
        '
        Me.ClientesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ClientesBindingNavigator.BindingSource = Me.ClientesBindingSource
        Me.ClientesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClientesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ClientesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ClientesBindingNavigatorSaveItem})
        Me.ClientesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ClientesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClientesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClientesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClientesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClientesBindingNavigator.Name = "ClientesBindingNavigator"
        Me.ClientesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClientesBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.ClientesBindingNavigator.TabIndex = 0
        Me.ClientesBindingNavigator.Text = "BindingNavigator1"
        Me.ClientesBindingNavigator.Visible = False
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
        'ClientesBindingNavigatorSaveItem
        '
        Me.ClientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClientesBindingNavigatorSaveItem.Image = CType(resources.GetObject("ClientesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ClientesBindingNavigatorSaveItem.Name = "ClientesBindingNavigatorSaveItem"
        Me.ClientesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ClientesBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Cli_dniTextBox
        '
        Me.Cli_dniTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "cli_dni", True))
        Me.Cli_dniTextBox.Enabled = False
        Me.Cli_dniTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cli_dniTextBox.Location = New System.Drawing.Point(159, 98)
        Me.Cli_dniTextBox.MaxLength = 8
        Me.Cli_dniTextBox.Name = "Cli_dniTextBox"
        Me.Cli_dniTextBox.Size = New System.Drawing.Size(100, 26)
        Me.Cli_dniTextBox.TabIndex = 4
        Me.Cli_dniTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cli_nombresTextBox
        '
        Me.Cli_nombresTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "cli_nombres", True))
        Me.Cli_nombresTextBox.Enabled = False
        Me.Cli_nombresTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cli_nombresTextBox.Location = New System.Drawing.Point(159, 149)
        Me.Cli_nombresTextBox.Name = "Cli_nombresTextBox"
        Me.Cli_nombresTextBox.Size = New System.Drawing.Size(203, 26)
        Me.Cli_nombresTextBox.TabIndex = 6
        Me.Cli_nombresTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cli_celTextBox
        '
        Me.Cli_celTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "cli_cel", True))
        Me.Cli_celTextBox.Enabled = False
        Me.Cli_celTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cli_celTextBox.Location = New System.Drawing.Point(159, 200)
        Me.Cli_celTextBox.MaxLength = 9
        Me.Cli_celTextBox.Name = "Cli_celTextBox"
        Me.Cli_celTextBox.Size = New System.Drawing.Size(115, 26)
        Me.Cli_celTextBox.TabIndex = 8
        Me.Cli_celTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cli_emailTextBox
        '
        Me.Cli_emailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "cli_email", True))
        Me.Cli_emailTextBox.Enabled = False
        Me.Cli_emailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cli_emailTextBox.Location = New System.Drawing.Point(159, 253)
        Me.Cli_emailTextBox.Name = "Cli_emailTextBox"
        Me.Cli_emailTextBox.Size = New System.Drawing.Size(203, 26)
        Me.Cli_emailTextBox.TabIndex = 10
        Me.Cli_emailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(217, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(419, 37)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "REGISTRO DE CLIENTES"
        '
        'ClientesDataGridView
        '
        Me.ClientesDataGridView.AutoGenerateColumns = False
        Me.ClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.ClientesDataGridView.DataSource = Me.ClientesBindingSource
        Me.ClientesDataGridView.Location = New System.Drawing.Point(43, 317)
        Me.ClientesDataGridView.Name = "ClientesDataGridView"
        Me.ClientesDataGridView.Size = New System.Drawing.Size(540, 220)
        Me.ClientesDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "cli_dni"
        Me.DataGridViewTextBoxColumn2.HeaderText = "cli_dni"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "cli_nombres"
        Me.DataGridViewTextBoxColumn3.HeaderText = "cli_nombres"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "cli_cel"
        Me.DataGridViewTextBoxColumn4.HeaderText = "cli_cel"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "cli_email"
        Me.DataGridViewTextBoxColumn5.HeaderText = "cli_email"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = Global.pizzeria.My.Resources.Resources.salirr
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Button4.Location = New System.Drawing.Point(624, 370)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(198, 176)
        Me.Button4.TabIndex = 12
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = False
        '
        'btngrabar
        '
        Me.btngrabar.Enabled = False
        Me.btngrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngrabar.Location = New System.Drawing.Point(424, 134)
        Me.btngrabar.Name = "btngrabar"
        Me.btngrabar.Size = New System.Drawing.Size(159, 44)
        Me.btngrabar.TabIndex = 13
        Me.btngrabar.Text = "GRABAR"
        Me.btngrabar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminar.Location = New System.Drawing.Point(424, 190)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(159, 44)
        Me.btneliminar.TabIndex = 14
        Me.btneliminar.Text = "ELIMINAR"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.Red
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.Location = New System.Drawing.Point(424, 77)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(159, 44)
        Me.btncancelar.TabIndex = 15
        Me.btncancelar.Text = "CANCELAR"
        Me.btncancelar.UseVisualStyleBackColor = False
        Me.btncancelar.Visible = False
        '
        'btnactualizar
        '
        Me.btnactualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnactualizar.Location = New System.Drawing.Point(424, 245)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(159, 44)
        Me.btnactualizar.TabIndex = 16
        Me.btnactualizar.Text = "ACTUALIZAR"
        Me.btnactualizar.UseVisualStyleBackColor = True
        '
        'btnagregar
        '
        Me.btnagregar.BackColor = System.Drawing.Color.Lime
        Me.btnagregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagregar.Location = New System.Drawing.Point(424, 77)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(159, 44)
        Me.btnagregar.TabIndex = 17
        Me.btnagregar.Text = "AGREGAR"
        Me.btnagregar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnbuscar)
        Me.GroupBox1.Controls.Add(Me.txtbuscar)
        Me.GroupBox1.Location = New System.Drawing.Point(612, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(197, 149)
        Me.GroupBox1.TabIndex = 18
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
        Me.txtbuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.pizzeria.My.Resources.Resources.seamless_texture_color_image_of_a_pizza_slices_with_various_ingredients_vector
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(834, 558)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.btnactualizar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btngrabar)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ClientesDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Cli_dniLabel)
        Me.Controls.Add(Me.Cli_dniTextBox)
        Me.Controls.Add(Cli_nombresLabel)
        Me.Controls.Add(Me.Cli_nombresTextBox)
        Me.Controls.Add(Cli_celLabel)
        Me.Controls.Add(Me.Cli_celTextBox)
        Me.Controls.Add(Cli_emailLabel)
        Me.Controls.Add(Me.Cli_emailTextBox)
        Me.Controls.Add(Me.ClientesBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CLIENTES"
        CType(Me.PizzeriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClientesBindingNavigator.ResumeLayout(False)
        Me.ClientesBindingNavigator.PerformLayout()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PizzeriaDataSet As pizzeriaDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As pizzeriaDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents TableAdapterManager As pizzeriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClientesBindingNavigator As BindingNavigator
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
    Friend WithEvents ClientesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Cli_dniTextBox As TextBox
    Friend WithEvents Cli_nombresTextBox As TextBox
    Friend WithEvents Cli_celTextBox As TextBox
    Friend WithEvents Cli_emailTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ClientesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Button4 As Button
    Friend WithEvents btngrabar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnactualizar As Button
    Friend WithEvents btnagregar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnbuscar As Button
    Friend WithEvents txtbuscar As TextBox
End Class
