Public Class FrmActividad
    Dim Alumno As New Alumno
    Private Sub BtnAgregarAlumno_Click(sender As Object, e As EventArgs) Handles BtnAgregarAlumno.Click
        Alumno.DatosAlumno(TxtCodigo.Text,
                           TxtNombre.Text,
                           TxtApellido.Text,
                           TxtDireccion.Text,
                           TxtGenero.Text,
                           TxtDui.Text,
                           TxtEdad.Text,
                            TxtCorreo.Text)

        DgbDatos.Rows.Add(TxtCodigo.Text,
                          Alumno.NombreAlumno,
                          Alumno.ApellidoAlumno,
                          Alumno.DireccionAlumno,
                          Alumno.SexoAlumno,
                          Alumno.DuiAlumno,
                          Alumno.EdadAlumno,
                          Alumno.CorreoAlumno)

        If Alumno.DatosAceptados Then
            MsgBox("Alumno " & Alumno.NombreAlumno & "Registrado con exito")
        Else
        End If

        TxtCodigo.Text = ""
        TxtNombre.Text = ""
        TxtApellido.Text = ""
        TxtDireccion.Text = ""
        TxtGenero.Text = ""
        TxtDui.Text = ""
        TxtEdad.Text = ""
        TxtCorreo.Text = ""

    End Sub

    Private Sub BtnGenerarCodigo_Click(sender As Object, e As EventArgs) Handles BtnGenerarCodigo.Click
        If TxtNombre.Text = "" Then
            MsgBox("Debe ingresar su nombre")
        Else
            TxtCodigo.Text = Alumno.GenerarCodigo(TxtNombre.Text)
        End If
    End Sub

End Class
