<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GbxDatosBusqueda = New System.Windows.Forms.GroupBox()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.CbxCampo = New System.Windows.Forms.ComboBox()
        Me.LblFiltrar = New System.Windows.Forms.Label()
        Me.GbxRegistros = New System.Windows.Forms.GroupBox()
        Me.DgvRegistrosEmpleado = New System.Windows.Forms.DataGridView()
        Me.GbxDatosBusqueda.SuspendLayout()
        Me.GbxRegistros.SuspendLayout()
        CType(Me.DgvRegistrosEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbxDatosBusqueda
        '
        Me.GbxDatosBusqueda.Controls.Add(Me.BtnImprimir)
        Me.GbxDatosBusqueda.Controls.Add(Me.TxtBuscar)
        Me.GbxDatosBusqueda.Controls.Add(Me.CbxCampo)
        Me.GbxDatosBusqueda.Controls.Add(Me.LblFiltrar)
        Me.GbxDatosBusqueda.Location = New System.Drawing.Point(14, 12)
        Me.GbxDatosBusqueda.Name = "GbxDatosBusqueda"
        Me.GbxDatosBusqueda.Size = New System.Drawing.Size(776, 75)
        Me.GbxDatosBusqueda.TabIndex = 0
        Me.GbxDatosBusqueda.TabStop = False
        Me.GbxDatosBusqueda.Text = "Seleccione por que campo desea buscar "
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImprimir.Location = New System.Drawing.Point(670, 26)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(94, 36)
        Me.BtnImprimir.TabIndex = 3
        Me.BtnImprimir.Text = "Imprimir"
        Me.BtnImprimir.UseVisualStyleBackColor = True
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscar.Location = New System.Drawing.Point(288, 33)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(271, 26)
        Me.TxtBuscar.TabIndex = 2
        '
        'CbxCampo
        '
        Me.CbxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxCampo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxCampo.FormattingEnabled = True
        Me.CbxCampo.Items.AddRange(New Object() {"Profesión", "Nombres", "Apellidos"})
        Me.CbxCampo.Location = New System.Drawing.Point(114, 31)
        Me.CbxCampo.Name = "CbxCampo"
        Me.CbxCampo.Size = New System.Drawing.Size(150, 28)
        Me.CbxCampo.TabIndex = 1
        '
        'LblFiltrar
        '
        Me.LblFiltrar.AutoSize = True
        Me.LblFiltrar.Location = New System.Drawing.Point(18, 36)
        Me.LblFiltrar.Name = "LblFiltrar"
        Me.LblFiltrar.Size = New System.Drawing.Size(85, 17)
        Me.LblFiltrar.TabIndex = 0
        Me.LblFiltrar.Text = "Filtrar por:"
        '
        'GbxRegistros
        '
        Me.GbxRegistros.Controls.Add(Me.DgvRegistrosEmpleado)
        Me.GbxRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbxRegistros.Location = New System.Drawing.Point(14, 106)
        Me.GbxRegistros.Name = "GbxRegistros"
        Me.GbxRegistros.Size = New System.Drawing.Size(776, 332)
        Me.GbxRegistros.TabIndex = 1
        Me.GbxRegistros.TabStop = False
        Me.GbxRegistros.Text = "Registros Encontrados: 0"
        '
        'DgvRegistrosEmpleado
        '
        Me.DgvRegistrosEmpleado.AllowUserToAddRows = False
        Me.DgvRegistrosEmpleado.AllowUserToDeleteRows = False
        Me.DgvRegistrosEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRegistrosEmpleado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvRegistrosEmpleado.Location = New System.Drawing.Point(3, 22)
        Me.DgvRegistrosEmpleado.MultiSelect = False
        Me.DgvRegistrosEmpleado.Name = "DgvRegistrosEmpleado"
        Me.DgvRegistrosEmpleado.ReadOnly = True
        Me.DgvRegistrosEmpleado.RowHeadersWidth = 51
        Me.DgvRegistrosEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvRegistrosEmpleado.Size = New System.Drawing.Size(770, 307)
        Me.DgvRegistrosEmpleado.TabIndex = 0
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 458)
        Me.Controls.Add(Me.GbxRegistros)
        Me.Controls.Add(Me.GbxDatosBusqueda)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Empleado por Profesion"
        Me.GbxDatosBusqueda.ResumeLayout(False)
        Me.GbxDatosBusqueda.PerformLayout()
        Me.GbxRegistros.ResumeLayout(False)
        CType(Me.DgvRegistrosEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GbxDatosBusqueda As GroupBox
    Friend WithEvents LblFiltrar As Label
    Friend WithEvents CbxCampo As ComboBox
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents GbxRegistros As GroupBox
    Friend WithEvents DgvRegistrosEmpleado As DataGridView
    Friend WithEvents BtnImprimir As Button
End Class
