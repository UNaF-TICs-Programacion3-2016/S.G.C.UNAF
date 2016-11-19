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
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.btnCancelarPub = New System.Windows.Forms.Button()
        Me.btnAceptarPub = New System.Windows.Forms.Button()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.txtDescripcionPub = New System.Windows.Forms.TextBox()
        Me.dgvPublicaciones = New System.Windows.Forms.DataGridView()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.btnCancelarAnt = New System.Windows.Forms.Button()
        Me.btnAceptarAnt = New System.Windows.Forms.Button()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboTipoAnt = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCargo = New System.Windows.Forms.TextBox()
        Me.txtOrganizacion = New System.Windows.Forms.TextBox()
        Me.txtHastaAnt = New System.Windows.Forms.TextBox()
        Me.txtDesdeAnt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.dgvAntLab = New System.Windows.Forms.DataGridView()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUniversidad = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtHasta = New System.Windows.Forms.TextBox()
        Me.txtDesde = New System.Windows.Forms.TextBox()
        Me.dgvTitulos = New System.Windows.Forms.DataGridView()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtIdPersona = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage6.SuspendLayout()
        CType(Me.dgvPublicaciones, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnAceptar.Location = New System.Drawing.Point(470, 297)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 7
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(436, 436)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(104, 23)
        Me.btnImprimir.TabIndex = 24
        Me.btnImprimir.Text = "Imprimir Curriculum"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.btnCancelarPub)
        Me.TabPage6.Controls.Add(Me.btnAceptarPub)
        Me.TabPage6.Controls.Add(Me.txtAño)
        Me.TabPage6.Controls.Add(Me.txtDescripcionPub)
        Me.TabPage6.Controls.Add(Me.dgvPublicaciones)
        Me.TabPage6.Controls.Add(Me.Label31)
        Me.TabPage6.Controls.Add(Me.Label33)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(654, 333)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Publicaciones"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'btnCancelarPub
        '
        Me.btnCancelarPub.Location = New System.Drawing.Point(557, 290)
        Me.btnCancelarPub.Name = "btnCancelarPub"
        Me.btnCancelarPub.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarPub.TabIndex = 23
        Me.btnCancelarPub.Text = "Cancelar"
        Me.btnCancelarPub.UseVisualStyleBackColor = True
        '
        'btnAceptarPub
        '
        Me.btnAceptarPub.Location = New System.Drawing.Point(451, 290)
        Me.btnAceptarPub.Name = "btnAceptarPub"
        Me.btnAceptarPub.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptarPub.TabIndex = 22
        Me.btnAceptarPub.Text = "Aceptar"
        Me.btnAceptarPub.UseVisualStyleBackColor = True
        '
        'txtAño
        '
        Me.txtAño.Location = New System.Drawing.Point(114, 21)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(80, 20)
        Me.txtAño.TabIndex = 19
        '
        'txtDescripcionPub
        '
        Me.txtDescripcionPub.Location = New System.Drawing.Point(114, 63)
        Me.txtDescripcionPub.Name = "txtDescripcionPub"
        Me.txtDescripcionPub.Size = New System.Drawing.Size(518, 20)
        Me.txtDescripcionPub.TabIndex = 20
        '
        'dgvPublicaciones
        '
        Me.dgvPublicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPublicaciones.Location = New System.Drawing.Point(16, 114)
        Me.dgvPublicaciones.Name = "dgvPublicaciones"
        Me.dgvPublicaciones.Size = New System.Drawing.Size(623, 143)
        Me.dgvPublicaciones.TabIndex = 21
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(12, 70)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(63, 13)
        Me.Label31.TabIndex = 62
        Me.Label31.Text = "Descripcion"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(12, 28)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(26, 13)
        Me.Label33.TabIndex = 60
        Me.Label33.Text = "Año"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.btnCancelarAnt)
        Me.TabPage5.Controls.Add(Me.btnAceptarAnt)
        Me.TabPage5.Controls.Add(Me.txtDescripcion)
        Me.TabPage5.Controls.Add(Me.Label6)
        Me.TabPage5.Controls.Add(Me.cboTipoAnt)
        Me.TabPage5.Controls.Add(Me.Label4)
        Me.TabPage5.Controls.Add(Me.txtCargo)
        Me.TabPage5.Controls.Add(Me.txtOrganizacion)
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
        'btnCancelarAnt
        '
        Me.btnCancelarAnt.Location = New System.Drawing.Point(563, 298)
        Me.btnCancelarAnt.Name = "btnCancelarAnt"
        Me.btnCancelarAnt.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarAnt.TabIndex = 18
        Me.btnCancelarAnt.Text = "Cancelar"
        Me.btnCancelarAnt.UseVisualStyleBackColor = True
        '
        'btnAceptarAnt
        '
        Me.btnAceptarAnt.Location = New System.Drawing.Point(470, 298)
        Me.btnAceptarAnt.Name = "btnAceptarAnt"
        Me.btnAceptarAnt.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptarAnt.TabIndex = 17
        Me.btnAceptarAnt.Text = "Aceptar"
        Me.btnAceptarAnt.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(98, 97)
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
        'cboTipoAnt
        '
        Me.cboTipoAnt.FormattingEnabled = True
        Me.cboTipoAnt.Location = New System.Drawing.Point(481, 17)
        Me.cboTipoAnt.Name = "cboTipoAnt"
        Me.cboTipoAnt.Size = New System.Drawing.Size(160, 21)
        Me.cboTipoAnt.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(402, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Tipo"
        '
        'txtCargo
        '
        Me.txtCargo.Location = New System.Drawing.Point(482, 57)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(159, 20)
        Me.txtCargo.TabIndex = 14
        '
        'txtOrganizacion
        '
        Me.txtOrganizacion.Location = New System.Drawing.Point(98, 57)
        Me.txtOrganizacion.Name = "txtOrganizacion"
        Me.txtOrganizacion.Size = New System.Drawing.Size(280, 20)
        Me.txtOrganizacion.TabIndex = 13
        '
        'txtHastaAnt
        '
        Me.txtHastaAnt.Location = New System.Drawing.Point(298, 18)
        Me.txtHastaAnt.Name = "txtHastaAnt"
        Me.txtHastaAnt.Size = New System.Drawing.Size(80, 20)
        Me.txtHastaAnt.TabIndex = 10
        '
        'txtDesdeAnt
        '
        Me.txtDesdeAnt.Location = New System.Drawing.Point(98, 18)
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
        Me.TabPage4.Controls.Add(Me.txtTitulo)
        Me.TabPage4.Controls.Add(Me.cboTipo)
        Me.TabPage4.Controls.Add(Me.Label1)
        Me.TabPage4.Controls.Add(Me.txtUniversidad)
        Me.TabPage4.Controls.Add(Me.btnCancelar)
        Me.TabPage4.Controls.Add(Me.btnAceptar)
        Me.TabPage4.Controls.Add(Me.txtHasta)
        Me.TabPage4.Controls.Add(Me.txtDesde)
        Me.TabPage4.Controls.Add(Me.dgvTitulos)
        Me.TabPage4.Controls.Add(Me.Label23)
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
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(107, 21)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(310, 20)
        Me.txtTitulo.TabIndex = 1
        '
        'cboTipo
        '
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Location = New System.Drawing.Point(499, 20)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(135, 21)
        Me.cboTipo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(436, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Tipo"
        '
        'txtUniversidad
        '
        Me.txtUniversidad.Location = New System.Drawing.Point(108, 99)
        Me.txtUniversidad.Name = "txtUniversidad"
        Me.txtUniversidad.Size = New System.Drawing.Size(309, 20)
        Me.txtUniversidad.TabIndex = 5
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(563, 297)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
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
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(13, 106)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(63, 13)
        Me.Label23.TabIndex = 42
        Me.Label23.Text = "Universidad"
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
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Location = New System.Drawing.Point(10, 66)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(662, 359)
        Me.TabControl1.TabIndex = 0
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(574, 436)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 25
        Me.Button5.Text = "Salir"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtIdPersona)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(654, 53)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        '
        'txtIdPersona
        '
        Me.txtIdPersona.Location = New System.Drawing.Point(555, 19)
        Me.txtIdPersona.Name = "txtIdPersona"
        Me.txtIdPersona.Size = New System.Drawing.Size(80, 20)
        Me.txtIdPersona.TabIndex = 71
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(96, 19)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(322, 20)
        Me.txtNombre.TabIndex = 90
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Nombre"
        '
        'frmDatosCV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 472)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmDatosCV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos CV"
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.dgvPublicaciones, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents txtDescripcionPub As TextBox
    Friend WithEvents dgvPublicaciones As DataGridView
    Friend WithEvents Label31 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Label27 As Label
    Friend WithEvents dgvAntLab As DataGridView
    Friend WithEvents Label24 As Label
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents dgvTitulos As DataGridView
    Friend WithEvents Label23 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents cboTipo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUniversidad As TextBox
    Friend WithEvents txtHasta As TextBox
    Friend WithEvents txtDesde As TextBox
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtCargo As TextBox
    Friend WithEvents txtOrganizacion As TextBox
    Friend WithEvents txtHastaAnt As TextBox
    Friend WithEvents txtDesdeAnt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCancelarAnt As Button
    Friend WithEvents btnAceptarAnt As Button
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cboTipoAnt As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCancelarPub As Button
    Friend WithEvents btnAceptarPub As Button
    Friend WithEvents txtAño As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtIdPersona As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label5 As Label
End Class
