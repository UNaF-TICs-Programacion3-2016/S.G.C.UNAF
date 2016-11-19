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
        Me.PersonasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CurriculumVitaeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AspirantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DictamenesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContratosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonasToolStripMenuItem, Me.CurriculumVitaeToolStripMenuItem, Me.AspirantesToolStripMenuItem, Me.ToolStripMenuItem1, Me.DictamenesToolStripMenuItem, Me.ToolStripMenuItem2, Me.ContratosToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(976, 40)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PersonasToolStripMenuItem
        '
        Me.PersonasToolStripMenuItem.Image = Global.Sistema_Gestion_Contartos.My.Resources.Resources.pers32
        Me.PersonasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PersonasToolStripMenuItem.Name = "PersonasToolStripMenuItem"
        Me.PersonasToolStripMenuItem.Size = New System.Drawing.Size(98, 36)
        Me.PersonasToolStripMenuItem.Text = "Personas"
        '
        'CurriculumVitaeToolStripMenuItem
        '
        Me.CurriculumVitaeToolStripMenuItem.Image = Global.Sistema_Gestion_Contartos.My.Resources.Resources.curriculum32
        Me.CurriculumVitaeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CurriculumVitaeToolStripMenuItem.Name = "CurriculumVitaeToolStripMenuItem"
        Me.CurriculumVitaeToolStripMenuItem.Size = New System.Drawing.Size(140, 36)
        Me.CurriculumVitaeToolStripMenuItem.Text = "Curriculum Vitae"
        '
        'AspirantesToolStripMenuItem
        '
        Me.AspirantesToolStripMenuItem.Image = Global.Sistema_Gestion_Contartos.My.Resources.Resources.asignaciones32
        Me.AspirantesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AspirantesToolStripMenuItem.Name = "AspirantesToolStripMenuItem"
        Me.AspirantesToolStripMenuItem.Size = New System.Drawing.Size(121, 36)
        Me.AspirantesToolStripMenuItem.Text = "Asignaciones"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 36)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(12, 36)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = Global.Sistema_Gestion_Contartos.My.Resources.Resources.exit32
        Me.SalirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(73, 36)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'DictamenesToolStripMenuItem
        '
        Me.DictamenesToolStripMenuItem.Image = Global.Sistema_Gestion_Contartos.My.Resources.Resources.dictamen32
        Me.DictamenesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DictamenesToolStripMenuItem.Name = "DictamenesToolStripMenuItem"
        Me.DictamenesToolStripMenuItem.Size = New System.Drawing.Size(113, 36)
        Me.DictamenesToolStripMenuItem.Text = "Dictamenes"
        '
        'ContratosToolStripMenuItem
        '
        Me.ContratosToolStripMenuItem.Image = Global.Sistema_Gestion_Contartos.My.Resources.Resources.contatro32
        Me.ContratosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ContratosToolStripMenuItem.Name = "ContratosToolStripMenuItem"
        Me.ContratosToolStripMenuItem.Size = New System.Drawing.Size(103, 36)
        Me.ContratosToolStripMenuItem.Text = "Contratos"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(976, 475)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmMenu"
        Me.Text = "Sistema Gestion Contratos Docentes Universitarios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CurriculumVitaeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AspirantesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PersonasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DictamenesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContratosToolStripMenuItem As ToolStripMenuItem
End Class
