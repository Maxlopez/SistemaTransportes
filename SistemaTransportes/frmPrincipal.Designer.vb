<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarPasajerosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GestionarCiudadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GesionarRutasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarHorariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(140, 81)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(581, 295)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(788, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionarUsuariosToolStripMenuItem, Me.GestionarPasajerosToolStripMenuItem, Me.ToolStripSeparator1, Me.GestionarCiudadesToolStripMenuItem, Me.GesionarRutasToolStripMenuItem, Me.GestionarHorariosToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.UsuariosToolStripMenuItem.Text = "Mantenimiento"
        '
        'GestionarUsuariosToolStripMenuItem
        '
        Me.GestionarUsuariosToolStripMenuItem.Name = "GestionarUsuariosToolStripMenuItem"
        Me.GestionarUsuariosToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.GestionarUsuariosToolStripMenuItem.Text = "Gestionar Usuarios"
        '
        'GestionarPasajerosToolStripMenuItem
        '
        Me.GestionarPasajerosToolStripMenuItem.Name = "GestionarPasajerosToolStripMenuItem"
        Me.GestionarPasajerosToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.GestionarPasajerosToolStripMenuItem.Text = "Gestionar Pasajeros"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(173, 6)
        '
        'GestionarCiudadesToolStripMenuItem
        '
        Me.GestionarCiudadesToolStripMenuItem.Name = "GestionarCiudadesToolStripMenuItem"
        Me.GestionarCiudadesToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.GestionarCiudadesToolStripMenuItem.Text = "Gestionar Ciudades"
        '
        'GesionarRutasToolStripMenuItem
        '
        Me.GesionarRutasToolStripMenuItem.Name = "GesionarRutasToolStripMenuItem"
        Me.GesionarRutasToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.GesionarRutasToolStripMenuItem.Text = "Gesionar Rutas"
        '
        'GestionarHorariosToolStripMenuItem
        '
        Me.GestionarHorariosToolStripMenuItem.Name = "GestionarHorariosToolStripMenuItem"
        Me.GestionarHorariosToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.GestionarHorariosToolStripMenuItem.Text = "Gestionar Horarios"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 425)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.Text = "Sistema de Transporte Terrestre - Cruz del Sur"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionarUsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionarCiudadesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionarPasajerosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GesionarRutasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GestionarHorariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
