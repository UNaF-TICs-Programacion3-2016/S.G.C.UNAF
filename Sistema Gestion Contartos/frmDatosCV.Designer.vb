<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDatosCV
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
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.cboOrganizacion = New System.Windows.Forms.ComboBox()
        Me.btnAceptarAnt = New System.Windows.Forms.Button()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCargo = New System.Windows.Forms.TextBox()
        Me.txtHastaAnt = New System.Windows.Forms.TextBox()
        Me.txtDesdeAnt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.dgvAntLab = New System.Windows.Forms.DataGridView()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.cmbtitulos = New System.Windows.Forms.ComboBox()
        Me.txtHasta = New System.Windows.Forms.TextBox()
        Me.txtDesde = New System.Windows.Forms.TextBox()
        Me.dgvTitulos = New System.Windows.Forms.DataGridView()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnver = New System.Windows.Forms.Button()
        Me.cmbPersona = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage5.SuspendLayout()
        CType(Me.dgvAntLab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.dgvTitulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(563, 97)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 7
        Me.btnAceptar.Text = "Agregar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(484, 437)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprimir.TabIndex = 24
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.cboOrganizacion)
        Me.TabPage5.Controls.Add(Me.btnAceptarAnt)
        Me.TabPage5.Controls.Add(Me.txtDescripcion)
        Me.TabPage5.Controls.Add(Me.Label6)
        Me.TabPage5.Controls.Add(Me.txtCargo)
        Me.TabPage5.Controls.Add(Me.txtHastaAnt)
        Me.TabPage5.Controls.Add(Me.txtDesdeAnt)
        Me.TabPage5.Controls.Add(Me.Label2)
        Me.TabPage5.Controls.Add(Me.Label3)
        Me.TabPage5.Controls.Add(Me.Label27)
        Me.TabPage5.Controls.Add(Me.dgvAntLab)
        Me.TabPage5.Controls.Add(Me.Label24)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(654, 333)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Antecedentes Laborales"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'cboOrganizacion
        '
        Me.cboOrganizacion.FormattingEnabled = True
        Me.cboOrganizacion.Location = New System.Drawing.Point(95, 56)
        Me.cboOrganizacion.Name = "cboOrganizacion"
        Me.cboOrganizacion.Size = New System.Drawing.Size(280, 21)
        Me.cboOrganizacion.TabIndex = 74
        '
        'btnAceptarAnt
        '
        Me.btnAceptarAnt.Location = New System.Drawing.Point(563, 297)
        Me.btnAceptarAnt.Name = "btnAceptarAnt"
        Me.btnAceptarAnt.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptarAnt.TabIndex = 17
        Me.btnAceptarAnt.Text = "Agregar"
        Me.btnAceptarAnt.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(95, 97)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(543, 20)
        Me.txtDescripcion.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Descripcion"
        '
        'txtCargo
        '
        Me.txtCargo.Location = New System.Drawing.Point(479, 57)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(159, 20)
        Me.txtCargo.TabIndex = 14
        '
        'txtHastaAnt
        '
        Me.txtHastaAnt.Location = New System.Drawing.Point(295, 18)
        Me.txtHastaAnt.Name = "txtHastaAnt"
        Me.txtHastaAnt.Size = New System.Drawing.Size(80, 20)
        Me.txtHastaAnt.TabIndex = 10
        '
        'txtDesdeAnt
        '
        Me.txtDesdeAnt.Location = New System.Drawing.Point(95, 18)
        Me.txtDesdeAnt.Name = "txtDesdeAnt"
        Me.txtDesdeAnt.Size = New System.Drawing.Size(80, 20)
        Me.txtDesdeAnt.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(221, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Hasta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Desde"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(402, 64)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(35, 13)
        Me.Label27.TabIndex = 56
        Me.Label27.Text = "Cargo"
        '
        'dgvAntLab
        '
        Me.dgvAntLab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAntLab.Location = New System.Drawing.Point(15, 138)
        Me.dgvAntLab.Name = "dgvAntLab"
        Me.dgvAntLab.Size = New System.Drawing.Size(623, 143)
        Me.dgvAntLab.TabIndex = 16
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(10, 64)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(69, 13)
        Me.Label24.TabIndex = 51
        Me.Label24.Text = "Organizacion"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.cmbtitulos)
        Me.TabPage4.Controls.Add(Me.btnAceptar)
        Me.TabPage4.Controls.Add(Me.txtHasta)
        Me.TabPage4.Controls.Add(Me.txtDesde)
        Me.TabPage4.Controls.Add(Me.dgvTitulos)
        Me.TabPage4.Controls.Add(Me.Label21)
        Me.TabPage4.Controls.Add(Me.Label22)
        Me.TabPage4.Controls.Add(Me.Label20)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(654, 333)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Estudios Cursados"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'cmbtitulos
        '
        Me.cmbtitulos.FormattingEnabled = True
        Me.cmbtitulos.Location = New System.Drawing.Point(107, 25)
        Me.cmbtitulos.Name = "cmbtitulos"
        Me.cmbtitulos.Size = New System.Drawing.Size(438, 21)
        Me.cmbtitulos.TabIndex = 2
        '
        'txtHasta
        '
        Me.txtHasta.Location = New System.Drawing.Point(337, 58)
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.Size = New System.Drawing.Size(80, 20)
        Me.txtHasta.TabIndex = 4
        '
        'txtDesde
        '
        Me.txtDesde.Location = New System.Drawing.Point(107, 59)
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.Size = New System.Drawing.Size(80, 20)
        Me.txtDesde.TabIndex = 3
        '
        'dgvTitulos
        '
        Me.dgvTitulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTitulos.Location = New System.Drawing.Point(15, 138)
        Me.dgvTitulos.Name = "dgvTitulos"
        Me.dgvTitulos.Size = New System.Drawing.Size(623, 143)
        Me.dgvTitulos.TabIndex = 6
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(266, 65)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(35, 13)
        Me.Label21.TabIndex = 41
        Me.Label21.Text = "Hasta"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(12, 65)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(38, 13)
        Me.Label22.TabIndex = 40
        Me.Label22.Text = "Desde"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(13, 28)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(33, 13)
        Me.Label20.TabIndex = 38
        Me.Label20.Text = "Titulo"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(10, 66)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(662, 359)
        Me.TabControl1.TabIndex = 0
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(577, 436)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 25
        Me.Button5.Text = "Salir"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnver)
        Me.GroupBox1.Controls.Add(Me.cmbPersona)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(654, 53)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        '
        'btnver
        '
        Me.btnver.Location = New System.Drawing.Point(563, 17)
        Me.btnver.Name = "btnver"
        Me.btnver.Size = New System.Drawing.Size(75, 23)
        Me.btnver.TabIndex = 92
        Me.btnver.Text = "Buscar"
        Me.btnver.UseVisualStyleBackColor = True
        '
        'cmbPersona
        '
        Me.cmbPersona.FormattingEnabled = True
        Me.cmbPersona.Location = New System.Drawing.Point(107, 19)
        Me.cmbPersona.Name = "cmbPersona"
        Me.cmbPersona.Size = New System.Drawing.Size(310, 21)
        Me.cmbPersona.TabIndex = 91
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Apellido y Nombre"
        '
        'frmDatosCV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 472)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmDatosCV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos CV"
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.dgvAntLab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.dgvTitulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnImprimir As Button
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Label27 As Label
    Friend WithEvents dgvAntLab As DataGridView
    Friend WithEvents Label24 As Label
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents dgvTitulos As DataGridView
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents cmbtitulos As ComboBox
    Friend WithEvents txtHasta As TextBox
    Friend WithEvents txtDesde As TextBox
    Friend WithEvents txtCargo As TextBox
    Friend WithEvents txtHastaAnt As TextBox
    Friend WithEvents txtDesdeAnt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAceptarAnt As Button
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbPersona As ComboBox
    Friend WithEvents btnver As Button
    Friend WithEvents cboOrganizacion As ComboBox
End Class
