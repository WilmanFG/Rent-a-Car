Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Module mdlValidaciones
    Dim Conexion As clsConexion = New clsConexion() 'Conexión a la clase para realizar consultas a la BDD
    Function _rutaDeArchivoValida(ByVal ruta As String) As Boolean 'Verifica si la ruta proporcionada es válida
        If ruta Is Nothing Then
            Return False
        End If

        For Each badChar As Char In System.IO.Path.GetInvalidPathChars
            If InStr(ruta, badChar) > 0 Then
                Return False
            End If
        Next

        Return True
    End Function

    Function _esImagen(ByVal ruta As String) As Boolean 'Verifica si la ruta es la de una imagen válida
        Try
            Dim img As System.Drawing.Image = System.Drawing.Image.FromFile(ruta)
        Catch generatedExceptionName As OutOfMemoryException
            Return False
        End Try
        Return True
    End Function

    Function _buscarRegistro(ByVal tabla As String, ByVal campo As String, ByVal valor As String) As Boolean 'Función que regresa el valor si en dado caso el select encuentra filas diferentes a ceros afectadas
        Dim query As String = "SELECT * FROM " & tabla & " WHERE " & campo & " = '" & valor & "';"
        Dim dataReader As MySqlDataReader

        Conexion.obtenerDatos(query, dataReader)
        Return dataReader.HasRows
    End Function

    Function _noCoincide(ByVal pattern As String, ByVal value As String) As Boolean 'Función que verifica el cumplimiento de un patrón en un texto
        Return Not Regex.IsMatch(value, pattern)
    End Function
End Module
