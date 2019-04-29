﻿Public Class Form_destino
    Dim perG As New Buscar_Permisos_generales
    Dim permiso_general, Pnuevo, Peditar, Panular, PBuscar As String
    Dim objConfiguracion As New ConfiguracionGeneral
    Public Function muestraImagen()
        Return PictureBox1.Image
    End Function
    Private Sub Tiposidentificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objConfiguracion.idUsuario = SesionActual.idUsuario
        permiso_general = perG.buscarPermisoGeneral(Name)
        Pnuevo = permiso_general & "pp" & "01"
        Peditar = permiso_general & "pp" & "02"
        Panular = permiso_general & "pp" & "03"
        PBuscar = permiso_general & "pp" & "04"
        General.posLoadForm(Me, ToolStrip1, btnuevo, btbuscar)
        General.cargarCombo(Consultas.ESTADO_SALIDA_LISTAR, "Descripcion_Estado_Salida", "Codigo_Estado_Salida", cbEstadoSalida)
    End Sub
    Private Sub Form__FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If btguardar.Enabled = True Then
            e.Cancel = True
            MsgBox(Mensajes.CAMBIOS_SIN_GUARDAR, MsgBoxStyle.Critical)
            Exit Sub
        End If
        If MsgBox(Mensajes.SALIR, MsgBoxStyle.Question + MsgBoxStyle.YesNo, TitulosForm.SALIR) = MsgBoxResult.Yes Then
            Me.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Cursor = Cursors.WaitCursor
        ManualUsuarioDAL.llamar_archivo(Name)
        Cursor = Cursors.Default
    End Sub

    Private Sub btguardar_Click(sender As Object, e As EventArgs) Handles btguardar.Click
        If String.IsNullOrWhiteSpace(txtnombre.Text) Then
            Exec.SavingMsg("¡ Por favor digite el nombre de la destino !", txtnombre)
        ElseIf cbEstadoSalida.SelectedIndex = 0 Then
            Exec.SavingMsg("¡ Favor seleccionar el estado de salida !", cbEstadoSalida)
        Else
            If MsgBox(Mensajes.GUARDAR, MsgBoxStyle.Question + MsgBoxStyle.YesNo, TitulosForm.GUARDAR) = MsgBoxResult.Yes Then
                Try
                    cargarObjeto()
                    DestinoBLL.guardarDestino(objConfiguracion)
                    txtcodigo.Text = objConfiguracion.codigo
                    General.deshabilitarBotones(ToolStrip1)
                    General.deshabilitarControles(Me)
                    btnuevo.Enabled = True
                    btbuscar.Enabled = True
                    bteditar.Enabled = True
                    btanular.Enabled = True
                    MsgBox(Mensajes.GUARDADO, MsgBoxStyle.Information)
                Catch ex As Exception
                    General.manejoErrores(ex)
                End Try
            End If
        End If
    End Sub
    Private Sub btanular_Click(sender As Object, e As EventArgs) Handles btanular.Click
        If SesionActual.tienePermiso(Panular) Then
            If MsgBox(Mensajes.ANULAR, MsgBoxStyle.Question + MsgBoxStyle.YesNo, TitulosForm.GUARDAR) = MsgBoxResult.Yes Then
                Try
                    If General.anularConValidacion(Consultas.DESTINO_ANULAR &
                                               txtcodigo.Text &
                                               ConstantesHC.NOMBRE_PDF_SEPARADOR3 &
                                               objConfiguracion.idUsuario) = True Then
                        General.deshabilitarBotones(ToolStrip1)
                        General.limpiarControles(Me)
                        General.deshabilitarControles(Me)
                        btnuevo.Enabled = True
                        btbuscar.Enabled = True
                        MsgBox(Mensajes.ANULADO, MsgBoxStyle.Information)
                    Else
                        MsgBox(Mensajes.NO_ANULAR_DESTINO, MsgBoxStyle.Information)
                    End If
                Catch ex As Exception
                    General.manejoErrores(ex)
                End Try
            End If
        Else
           MsgBox(Mensajes.SINPERMISO, MsgBoxStyle.Exclamation)
        End If
    End Sub
    Private Sub btnuevo_Click(sender As Object, e As EventArgs) Handles btnuevo.Click
        If SesionActual.tienePermiso(Pnuevo ) Then
            General.formNuevo(Me, ToolStrip1, btguardar, btcancelar)
            txtnombre.Focus()
        Else
           MsgBox(Mensajes.SINPERMISO, MsgBoxStyle.Exclamation)
        End If
    End Sub
    Private Sub bteditar_Click(sender As Object, e As EventArgs) Handles bteditar.Click
        If SesionActual.tienePermiso(Peditar ) Then
            General.fnFormEditar(Me, ToolStrip1, btguardar, btcancelar)
        Else
           MsgBox(Mensajes.SINPERMISO, MsgBoxStyle.Exclamation)
        End If
    End Sub
    Private Sub btcancelar_Click(sender As Object, e As EventArgs) Handles btcancelar.Click
        General.formCancelar(Me, ToolStrip1, btnuevo, btbuscar)
    End Sub
    Private Sub btbuscar_Click(sender As Object, e As EventArgs) Handles btbuscar.Click
        If SesionActual.tienePermiso(PBuscar ) Then
            General.buscarElemento(Consultas.DESTINO_LISTAR,
                       Nothing,
                       AddressOf cargarDatos,
                       TitulosForm.BUSQUEDA_DESTINO,
                       False, 0, True)
        Else
           MsgBox(Mensajes.SINPERMISO, MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub cargarObjeto()
        objConfiguracion.codigo = txtcodigo.Text
        objConfiguracion.descripcion = txtnombre.Text
        objConfiguracion.codigoComplemento = cbEstadoSalida.SelectedValue
    End Sub

    Private Sub cargarDatos(pCodigo)
        Dim drDestino As DataRow
        Dim params As New List(Of String)
        params.Add(pCodigo)
        drDestino = General.cargarItem(Consultas.DESTINO_CARGAR, params)
        txtcodigo.Text = pCodigo
        txtnombre.Text = drDestino.Item(0)
        cbEstadoSalida.SelectedValue = drDestino.Item(1)
        General.posBuscarForm(Me, ToolStrip1, btnuevo, bteditar, btanular, btbuscar)
    End Sub
End Class