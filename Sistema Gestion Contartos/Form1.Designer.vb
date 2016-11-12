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
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CurriculumVitaeToolStripMenuItem})
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
        Me.NuevoCVToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NuevoCVToolStripMenuItem.Text = "Nuevo CV"
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
End Class
