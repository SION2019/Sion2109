﻿Public Class HojaRutaRR
    Inherits HojaRuta
    Public Sub New()
        sqlCargarHojaRuta = Consultas.CARGAR_HOJA_RUTA_RR
        sqlGuardarHojaRuta = Consultas.GUARDAR_HOJA_RUTA_RR
        sqlcargarDiagnostico = Consultas.CARGAR_DIAGNOTICO_HOJA_RUTA_RR
        sqlCargarManejo = Consultas.CARGAR_MANEJO_HOJA_RUTA_RR
        sqlGuardarTareasProgram = Consultas.GUARDAR_TAREAS_HOJA_RUTA_RR
        sqlCargarTareaProgram = Consultas.CARGAR_HOJA_RUTA_TAREA_RR
        editado = Constantes.EDITADO
        vista = Constantes.REPORTE_AF
        titulo = TitulosForm.TITULO_HOJA_RUTA_AF
        nombrePdf = ConstantesHC.NOMBRE_PDF_HOJA_RUTA_RR
    End Sub

End Class
