﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_ClasificacionCuentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_ClasificacionCuentas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.gbInformacionCuenta = New System.Windows.Forms.GroupBox()
        Me.btBusquedaCuenta = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbEntorno = New System.Windows.Forms.ComboBox()
        Me.cbMovimiento = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.txtDescripcionCuenta = New System.Windows.Forms.TextBox()
        Me.txtCodigoCuenta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btguardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btbuscar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.bteditar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btcancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.btanular = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.gbInformacionCuenta.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "CLASIFICACIÓN DE CUENTAS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Celer.My.Resources.Resources.chart_search_icon
        Me.PictureBox1.Location = New System.Drawing.Point(12, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label2.Location = New System.Drawing.Point(54, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(492, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "_____________________________________________________________________"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.gbInformacionCuenta)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 54)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(535, 186)
        Me.GroupBox2.TabIndex = 10006
        Me.GroupBox2.TabStop = False
        '
        'gbInformacionCuenta
        '
        Me.gbInformacionCuenta.Controls.Add(Me.btBusquedaCuenta)
        Me.gbInformacionCuenta.Controls.Add(Me.Label4)
        Me.gbInformacionCuenta.Controls.Add(Me.cbEntorno)
        Me.gbInformacionCuenta.Controls.Add(Me.cbMovimiento)
        Me.gbInformacionCuenta.Controls.Add(Me.Label6)
        Me.gbInformacionCuenta.Controls.Add(Me.Label5)
        Me.gbInformacionCuenta.Controls.Add(Me.cbTipo)
        Me.gbInformacionCuenta.Controls.Add(Me.txtDescripcionCuenta)
        Me.gbInformacionCuenta.Controls.Add(Me.txtCodigoCuenta)
        Me.gbInformacionCuenta.Controls.Add(Me.Label3)
        Me.gbInformacionCuenta.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbInformacionCuenta.Location = New System.Drawing.Point(3, 8)
        Me.gbInformacionCuenta.Name = "gbInformacionCuenta"
        Me.gbInformacionCuenta.Size = New System.Drawing.Size(527, 169)
        Me.gbInformacionCuenta.TabIndex = 21
        Me.gbInformacionCuenta.TabStop = False
        Me.gbInformacionCuenta.Text = "Información de la Cuenta"
        '
        'btBusquedaCuenta
        '
        Me.btBusquedaCuenta.Image = Global.Celer.My.Resources.Resources.Zoom_icon1
        Me.btBusquedaCuenta.Location = New System.Drawing.Point(256, 20)
        Me.btBusquedaCuenta.Name = "btBusquedaCuenta"
        Me.btBusquedaCuenta.Size = New System.Drawing.Size(25, 23)
        Me.btBusquedaCuenta.TabIndex = 60014
        Me.btBusquedaCuenta.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 15)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Área de Servicio:"
        '
        'cbEntorno
        '
        Me.cbEntorno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbEntorno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbEntorno.BackColor = System.Drawing.Color.White
        Me.cbEntorno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEntorno.FormattingEnabled = True
        Me.cbEntorno.Location = New System.Drawing.Point(156, 104)
        Me.cbEntorno.Name = "cbEntorno"
        Me.cbEntorno.Size = New System.Drawing.Size(126, 21)
        Me.cbEntorno.TabIndex = 6
        '
        'cbMovimiento
        '
        Me.cbMovimiento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbMovimiento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbMovimiento.BackColor = System.Drawing.Color.White
        Me.cbMovimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMovimiento.FormattingEnabled = True
        Me.cbMovimiento.Location = New System.Drawing.Point(156, 76)
        Me.cbMovimiento.Name = "cbMovimiento"
        Me.cbMovimiento.Size = New System.Drawing.Size(126, 21)
        Me.cbMovimiento.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Movimiento:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Tipo:"
        '
        'cbTipo
        '
        Me.cbTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbTipo.BackColor = System.Drawing.Color.White
        Me.cbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Location = New System.Drawing.Point(156, 49)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(126, 21)
        Me.cbTipo.TabIndex = 4
        '
        'txtDescripcionCuenta
        '
        Me.txtDescripcionCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionCuenta.Location = New System.Drawing.Point(296, 21)
        Me.txtDescripcionCuenta.Name = "txtDescripcionCuenta"
        Me.txtDescripcionCuenta.ReadOnly = True
        Me.txtDescripcionCuenta.Size = New System.Drawing.Size(218, 20)
        Me.txtDescripcionCuenta.TabIndex = 3
        '
        'txtCodigoCuenta
        '
        Me.txtCodigoCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoCuenta.Location = New System.Drawing.Point(156, 21)
        Me.txtCodigoCuenta.Name = "txtCodigoCuenta"
        Me.txtCodigoCuenta.ReadOnly = True
        Me.txtCodigoCuenta.Size = New System.Drawing.Size(96, 20)
        Me.txtCodigoCuenta.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Cuenta:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnuevo, Me.ToolStripSeparator1, Me.btguardar, Me.ToolStripSeparator3, Me.btbuscar, Me.ToolStripSeparator4, Me.bteditar, Me.ToolStripSeparator5, Me.btcancelar, Me.ToolStripSeparator6, Me.btanular, Me.ToolStripSeparator7})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 242)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(559, 54)
        Me.ToolStrip1.TabIndex = 10007
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnuevo
        '
        Me.btnuevo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnuevo.Image = Global.Celer.My.Resources.Resources.Document_Add_icon__1_
        Me.btnuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnuevo.Name = "btnuevo"
        Me.btnuevo.Size = New System.Drawing.Size(46, 51)
        Me.btnuevo.Text = "&Nuevo"
        Me.btnuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 54)
        '
        'btguardar
        '
        Me.btguardar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btguardar.Image = Global.Celer.My.Resources.Resources._04_Save_icon
        Me.btguardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btguardar.Name = "btguardar"
        Me.btguardar.Size = New System.Drawing.Size(53, 51)
        Me.btguardar.Text = "&Guardar"
        Me.btguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 54)
        '
        'btbuscar
        '
        Me.btbuscar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btbuscar.Image = Global.Celer.My.Resources.Resources.Actions_page_zoom_icon__1_
        Me.btbuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btbuscar.Name = "btbuscar"
        Me.btbuscar.Size = New System.Drawing.Size(46, 51)
        Me.btbuscar.Text = "&Buscar"
        Me.btbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 54)
        '
        'bteditar
        '
        Me.bteditar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bteditar.Image = Global.Celer.My.Resources.Resources.edit_file_icon__1_
        Me.bteditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bteditar.Name = "bteditar"
        Me.bteditar.Size = New System.Drawing.Size(41, 51)
        Me.bteditar.Text = "&Editar"
        Me.bteditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 54)
        '
        'btcancelar
        '
        Me.btcancelar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btcancelar.Image = Global.Celer.My.Resources.Resources.Actions_blue_arrow_undo_icon__1_
        Me.btcancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btcancelar.Name = "btcancelar"
        Me.btcancelar.Size = New System.Drawing.Size(56, 51)
        Me.btcancelar.Text = "&Cancelar"
        Me.btcancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 54)
        '
        'btanular
        '
        Me.btanular.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btanular.Image = Global.Celer.My.Resources.Resources.Document_Delete_icon__1_
        Me.btanular.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btanular.Name = "btanular"
        Me.btanular.Size = New System.Drawing.Size(46, 51)
        Me.btanular.Text = "&Anular"
        Me.btanular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 54)
        '
        'Form_ClasificacionCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(559, 296)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(575, 335)
        Me.MinimumSize = New System.Drawing.Size(575, 335)
        Me.Name = "Form_ClasificacionCuentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.gbInformacionCuenta.ResumeLayout(False)
        Me.gbInformacionCuenta.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents Label1 As Label
    Public WithEvents PictureBox1 As PictureBox
    Public WithEvents Label2 As Label
    Public WithEvents GroupBox2 As GroupBox
    Public WithEvents ToolStrip1 As ToolStrip
    Public WithEvents btguardar As ToolStripButton
    Public WithEvents ToolStripSeparator3 As ToolStripSeparator
    Public WithEvents btbuscar As ToolStripButton
    Public WithEvents ToolStripSeparator4 As ToolStripSeparator
    Public WithEvents bteditar As ToolStripButton
    Public WithEvents ToolStripSeparator5 As ToolStripSeparator
    Public WithEvents btcancelar As ToolStripButton
    Public WithEvents ToolStripSeparator6 As ToolStripSeparator
    Public WithEvents btanular As ToolStripButton
    Public WithEvents ToolStripSeparator7 As ToolStripSeparator
    Public WithEvents gbInformacionCuenta As GroupBox
    Public WithEvents txtDescripcionCuenta As TextBox
    Public WithEvents txtCodigoCuenta As TextBox
    Public WithEvents Label3 As Label
    Public WithEvents Label4 As Label
    Public WithEvents cbEntorno As ComboBox
    Public WithEvents cbMovimiento As ComboBox
    Public WithEvents Label6 As Label
    Public WithEvents Label5 As Label
    Public WithEvents cbTipo As ComboBox
    Public WithEvents btBusquedaCuenta As Button
    Public WithEvents btnuevo As ToolStripButton
    Public WithEvents ToolStripSeparator1 As ToolStripSeparator
End Class
