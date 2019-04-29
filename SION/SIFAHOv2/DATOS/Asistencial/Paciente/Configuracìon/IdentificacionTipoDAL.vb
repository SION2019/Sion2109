﻿Public Class IdentificacionTipoDAL
    Public Shared Function guardarIdentificacion(objConfiguracion As ConfiguracionGeneral)
        Try
            Using comando = New SqlCommand()
                comando.Connection = FormPrincipal.cnxion
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.Clear()
                comando.CommandText = Consultas.TIPOIDENTIFICACION_CREAR
                comando.Parameters.Add(New SqlParameter("@ID", SqlDbType.NVarChar)).Value = objConfiguracion.codigo
                comando.Parameters.Add(New SqlParameter("@Descripcion", SqlDbType.NVarChar)).Value = objConfiguracion.descripcion
                comando.Parameters.Add(New SqlParameter("@Siglas", SqlDbType.NVarChar)).Value = objConfiguracion.siglas
                comando.Parameters.Add(New SqlParameter("@Usuario_Creacion", SqlDbType.Int)).Value = objConfiguracion.idUsuario
                objConfiguracion.codigo = CType(comando.ExecuteScalar, String)
            End Using
        Catch ex As Exception
            Throw
        End Try
        Return objConfiguracion
    End Function

End Class
