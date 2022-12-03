Public Class FormularioAuto
    Dim Auto As New Auto
    Private Sub BtnAgregarAuto_Click(sender As Object, e As EventArgs) Handles BtnAgregarAuto.Click
        Auto.DatosAuto(TxtPlaca.Text,
                           TxtMarca.Text,
                           TxtModelo.Text,
                           TxtAno.Text,
                           TxtColor.Text,
                           TxtPasajeros.Text,
                           TxtTransmision.Text,
                            TxtTipo.Text)

        DgbDatos.Rows.Add(TxtPlaca.Text,
                          Auto.MarcaAuto,
                          Auto.ModeloAuto,
                          Auto.AnoAuto,
                          Auto.ColorAuto,
                          Auto.PasajerosAuto,
                          Auto.TransmisionAuto,
                          Auto.TipoAuto)

        If Auto.DatosAceptados Then
            MsgBox("Auto " & TxtPlaca.Text & "Registrado con exito")
        Else
        End If

        TxtPlaca.Text = ""
        TxtMarca.Text = ""
        TxtModelo.Text = ""
        TxtAno.Text = ""
        TxtColor.Text = ""
        TxtPasajeros.Text = ""
        TxtTransmision.Text = ""
        TxtTipo.Text = ""

    End Sub

    Private Sub BtnGenerarPlaca_Click(sender As Object, e As EventArgs) Handles BtnGenerarPlaca.Click
        If TxtMarca.Text = "" Then
            MsgBox("Debe ingresar la marca del auto")
        Else
            TxtPlaca.Text = Auto.GenerarCodigo(TxtMarca.Text)
        End If
    End Sub
End Class