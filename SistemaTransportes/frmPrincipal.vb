Public Class frmPrincipal

 
    Private Sub GestionarUsuariosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GestionarUsuariosToolStripMenuItem.Click
        Dim obj As New frmMantenimientoUsuario
        obj.ShowDialog()

    End Sub

    Private Sub GestionarPasajerosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GestionarPasajerosToolStripMenuItem.Click
        Dim obj As New frmMantenimientoPasajeros
        obj.ShowDialog()
    End Sub

    Private Sub GestionarCiudadesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GestionarCiudadesToolStripMenuItem.Click
        Dim obj As New frmMantenimientoCiudades
        obj.ShowDialog()
    End Sub

    Private Sub GesionarRutasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GesionarRutasToolStripMenuItem.Click

    End Sub

    Private Sub GestionarHorariosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GestionarHorariosToolStripMenuItem.Click

    End Sub

    Private Sub frmPrincipal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    
End Class