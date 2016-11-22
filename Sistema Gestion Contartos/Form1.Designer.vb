<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CurriculumVitaeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoCVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AspirantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DictamenesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContratosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CurriculumVitaeToolStripMenuItem, Me.AspirantesToolStripMenuItem, Me.ToolStripMenuItem1, Me.DictamenesToolStripMenuItem, Me.ToolStripMenuItem2, Me.ContratosToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(976, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CurriculumVitaeToolStripMenuItem
        '
        Me.CurriculumVitaeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoCVToolStripMenuItem})
        Me.CurriculumVitaeToolStripMenuItem.Name = "CurriculumVitaeToolStripMenuItem"
        Me.CurriculumVitaeToolStripMenuItem.Size = New System.Drawing.Size(108, 20)
        Me.CurriculumVitaeToolStripMenuItem.Text = "Curriculum Vitae"
        '
        'NuevoCVToolStripMenuItem
        '
        Me.NuevoCVToolStripMenuItem.Name = "NuevoCVToolStripMenuItem"
        Me.NuevoCVToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.NuevoCVToolStripMenuItem.Text = "Nuevo CV"
        '
        'AspirantesToolStripMenuItem
        '
        Me.AspirantesToolStripMenuItem.Name = "AspirantesToolStripMenuItem"
        Me.AspirantesToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.AspirantesToolStripMenuItem.Text = "Aspirantes"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 20)
        '
        'DictamenesToolStripMenuItem
        '
        Me.DictamenesToolStripMenuItem.Name = "DictamenesToolStripMenuItem"
        Me.DictamenesToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.DictamenesToolStripMenuItem.Text = "Dictamenes"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(12, 20)
        '
        'ContratosToolStripMenuItem
        '
        Me.ContratosToolStripMenuItem.Name = "ContratosToolStripMenuItem"
        Me.ContratosToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ContratosToolStripMenuItem.Text = "Contratos"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Sistema_Gestion_Contartos.My.Resources.Resources.unaf
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(976, 475)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmMenu"
        Me.Text = "Sistema Gestion Contratos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CurriculumVitaeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoCVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AspirantesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DictamenesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ContratosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
