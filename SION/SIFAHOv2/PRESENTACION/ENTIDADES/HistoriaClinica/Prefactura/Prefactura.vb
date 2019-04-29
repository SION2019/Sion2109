﻿Public Class Prefactura
    Public Property nRegistro As Integer
    Public Property codigoMenu As String
    Public Property usuario As Integer
    Public Property nombrePaciente As String
    Public Property direccion As String
    Public Property consultaCrear As String
    Public Property nombreReporte As String
    Public Property vistaReporte As String
    Public Property objReporte As Object
    Public Property moduloReporte As Integer

    Public Sub New()
        codigoMenu = Constantes.CODIGO_MENU_HISTC
        consultaCrear = ConsultasHC.PREFACTURA_CREAR
        nombreReporte = ConstantesHC.NOMBRE_PDF_PREFACTURA
        vistaReporte = "VISTA_PREFACTURA"
        objReporte = New rptPrefactura
        moduloReporte = Constantes.REPORTE_HC
    End Sub
    Public Sub cargarPdf()
        Try
            Dim params As New List(Of String)
            params.Add(nRegistro)
            params.Add(codigoMenu)
            params.Add(usuario)
            General.ejecutarSQL(consultaCrear, params)
            generarReporte()
            params.Clear()
            params.Add(nRegistro)
            params.Add(codigoMenu)
            params.Add(usuario)
            General.ejecutarSQL(ConsultasHC.PREFACTURA_ACTUALIZAR, params)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Public Sub generarReporte()
        Try
            Dim nombreArchivo, ruta, formula As String
            Dim reporte As New ftp_reportes

            nombreArchivo = nombreReporte & ConstantesHC.NOMBRE_PDF_SEPARADOR & nRegistro & ConstantesHC.EXTENSION_ARCHIVO_PDF
            formula = "{" & vistaReporte & ".N_Registro} = " & nRegistro & " 
                                            AND {" & vistaReporte & ".Modulo}=" & moduloReporte & ""
            ruta = Path.GetTempPath() & nombreArchivo
            reporte.crearYGuardarReporte(nombreReporte, nRegistro, objReporte,
                              nRegistro, formula,
                              nombreReporte, IO.Path.GetTempPath,, True)

            Process.Start(ruta)
        Catch ex As Exception
            MsgBox(ex.Message & "Error en imprimirPrefactura ")
        End Try
    End Sub
End Class
