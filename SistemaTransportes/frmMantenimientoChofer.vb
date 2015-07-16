Imports Entidades
Public Class frmMantenimientoChofer

    Private Sub cargarCursos()
        Dim lista As ArrayList
        Dim objADO As New clsChoferADO
        Dim obj As clsChofer
        Dim fila As ListViewItem
        Try
            lista = objADO.listado
            If Not lista Is Nothing Then
                lsvDatos.Items.Clear()
                For Each obj In lista
                    fila = New ListViewItem(obj.dniChofer)
                    fila.SubItems.Add(obj.nombres)
                    fila.SubItems.Add(obj.apellidoPat)
                    fila.SubItems.Add(obj.apellidoPat)
                    fila.SubItems.Add(obj.telefono)
                    fila.SubItems.Add(CInt(obj.estado))
                    lsvDatos.Items.Add(fila)
                Next
            End If
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub btnRegistrar_Click(sender As System.Object, e As System.EventArgs) Handles btnRegistrar.Click
        Dim objADO As New clsChoferADO
        Dim obj As clsChofer

        Try
          
            obj = New clsChofer(txtDNI.Text, txtNombre.Text, txtApellidoPat.Text, txtApellidoMat.Text, txtTelefono.Text, cmbEstado.SelectedIndex)

            objADO.agregar(obj)
            MsgBox("Curso agregado con exito", MsgBoxStyle.Information)
            cargarCursos()

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class