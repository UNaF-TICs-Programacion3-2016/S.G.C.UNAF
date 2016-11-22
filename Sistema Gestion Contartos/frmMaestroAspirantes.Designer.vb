<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMaestroAspirantes
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.dgvlistadematerias = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvlistadeaspirantes = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnvermaterias = New System.Windows.Forms.Button()
        Me.dgvmatsaspirante = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvlistadematerias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvlistadeaspirantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvmatsaspirante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.dgvlistadematerias)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dgvlistadeaspirantes)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnvermaterias)
        Me.GroupBox1.Controls.Add(Me.dgvmatsaspirante)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(662, 429)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "AQUI PUEDE VISUALIZAR LOS ASPIRANTES Y LAS MATERIAS ASIGNADAS"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(400, 122)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Cancelar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(165, 397)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(272, 26)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "GENERAR DICTAMEN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 273)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(329, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Clic en ID para seleccionar la materia que desea asignar al aspirante"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(311, 289)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(164, 87)
        Me.btnNuevo.TabIndex = 1
        Me.btnNuevo.Text = "CLICK AQUI para ASIGNAR la materia al aspirante seleccionado"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'dgvlistadematerias
        '
        Me.dgvlistadematerias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvlistadematerias.Location = New System.Drawing.Point(12, 289)
        Me.dgvlistadematerias.Name = "dgvlistadematerias"
        Me.dgvlistadematerias.Size = New System.Drawing.Size(380, 87)
        Me.dgvlistadematerias.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(344, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Seleccione un Aspirante haciendo click en la columna ID_ASPIRANTE"
        '
        'dgvlistadeaspirantes
        '
        Me.dgvlistadeaspirantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvlistadeaspirantes.Location = New System.Drawing.Point(12, 60)
        Me.dgvlistadeaspirantes.Name = "dgvlistadeaspirantes"
        Me.dgvlistadeaspirantes.Size = New System.Drawing.Size(380, 87)
        Me.dgvlistadeaspirantes.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(341, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "El aspirante seleccionado YA TIENE ASIGNADAS ESTAS MATERIAS"
        '
        'btnvermaterias
        '
        Me.btnvermaterias.Location = New System.Drawing.Point(311, 173)
        Me.btnvermaterias.Name = "btnvermaterias"
        Me.btnvermaterias.Size = New System.Drawing.Size(164, 87)
        Me.btnvermaterias.TabIndex = 6
        Me.btnvermaterias.Text = "CLICK AQUI para ver las materias que le fueron asignadas "
        Me.btnvermaterias.UseVisualStyleBackColor = True
        '
        'dgvmatsaspirante
        '
        Me.dgvmatsaspirante.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvmatsaspirante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvmatsaspirante.Location = New System.Drawing.Point(12, 173)
        Me.dgvmatsaspirante.Name = "dgvmatsaspirante"
        Me.dgvmatsaspirante.Size = New System.Drawing.Size(380, 87)
        Me.dgvmatsaspirante.TabIndex = 4
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(400, 60)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Eliminar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(400, 89)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Modificar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmMaestroAspirantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 453)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMaestroAspirantes"
        Me.Text = "Asignar Aspirantes a las Materias"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvlistadematerias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvlistadeaspirantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvmatsaspirante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvmatsaspirante As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnvermaterias As Button
    Friend WithEvents dgvlistadeaspirantes As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents dgvlistadematerias As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
End Class
