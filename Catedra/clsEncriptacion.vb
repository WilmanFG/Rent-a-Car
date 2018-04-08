Public Class clsEncriptacion
    '____________________________
    '|   Atributos de la clase   |
    '|___________________________|
    Private numeros = New String(9) {"e", "l", "a", "y", "A", "L", "F", "R", "o", "p"}
    Private letras = New String(53) {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
    Private espacio = New String(4) {"-", "*", "/", "!", "?"}
    '____________________________
    '|   Metodos de la clase     |
    '|___________________________|
    Private Function verificarNumero(ByVal caracter As String) As String 'Verifica si el parametro pasado es un número
        For i As Long = 0 To (numeros.Length - 1) 'Recorre el atributo arreglo de numeros
            If caracter = CStr(i) Then 'Verifica si son iguales
                Return MyClass.numeros(i) 'Se retorna el número con el índice
            End If
        Next
        Return "-1" 'No cumplio con la condición
    End Function

    Private Function verificarLetra(ByVal caracter As String) As String 'verifica si el parametro pasado es una letra
        For i As Long = 0 To (letras.Length - 1) 'Recorre el atributo arreglo de letras
            If caracter = letras(i) Then 'Verifica si son iguales
                Return CStr(i) 'Se retorna la letra en la iteración
            End If
        Next
        Return "-1" 'No cumplio con la condición
    End Function

    Private Function verificarEspacio(ByVal caracter As String) As Boolean 'Verifica si el paremetro es un espacio
        For i As Long = 0 To (espacio.Length - 1) 'Recorre nuestro arreglo de espacios - contiene signos
            If caracter = espacio(i) Then 'Se verifica
                Return True 'Verdad
            End If
        Next
        Return False 'No cumplio con la condición
    End Function

    Public Function ArmarEncriptacion(ByVal _contrasenna As String) As String 'Encripta el parametro
        Dim _contraEncriptada = ""

        For Each i As String In _contrasenna 'Se recorre el parametro pasado
            Dim _ascciCaracter, _longitudCaracter, _verificarNumero, _verificarLetra As String
            _ascciCaracter = CStr(Asc(i)) 'Se transforma el caracter iterado en código ascci
            _longitudCaracter = CStr(_ascciCaracter.Length) 'Se obtiene la longitud del caracter iterado en código ascci
            _verificarNumero = MyClass.verificarNumero(i) 'Se verifica si el caracter es numero
            _verificarLetra = MyClass.verificarLetra(i) 'Se verifica si el caracter es letra
            Dim _randomEspacio As New Random() 'Se instancia la clase random (Generar números aleatorio)

            'Se verifican los resultados obtenidos
            If _verificarNumero <> "-1" Then
                _contraEncriptada += _ascciCaracter & _verificarNumero & _longitudCaracter & MyClass.espacio(_randomEspacio.Next(0, 5))
            ElseIf _verificarLetra <> "-1" Then
                _contraEncriptada += _ascciCaracter & _verificarLetra & _longitudCaracter & MyClass.espacio(_randomEspacio.Next(0, 5))
            Else
                _contraEncriptada += _ascciCaracter & _longitudCaracter & MyClass.espacio(_randomEspacio.Next(0, 5))
            End If
        Next
        Return _contraEncriptada 'Se retorna parametro encriptado
    End Function

    Public Function DesarmarEncriptacion(ByVal _contrasenna As String) As String 'Función que desencripta al parametro pasado
        Dim _contraDesencriptada = "", palabra As String = ""
        For Each i As String In _contrasenna 'Se recorre al parametro
            If MyClass.verificarEspacio(i) Then 'Se verifica si el codigo ascci es un espacio
                Dim _longitudPalabra, _ascciCaracter As String
                _longitudPalabra = palabra.Substring(palabra.Length - 1) 'Obtiene la longitud caracter a caracter (Pero en ascci)
                _ascciCaracter = palabra.Substring(0, CInt(_longitudPalabra)) 'Se recorta el caracter en ascci
                _contraDesencriptada += Chr(CInt(_ascciCaracter)) 'Se desencrita el caracter
                palabra = ""
            Else
                palabra += i
            End If
        Next
        Return _contraDesencriptada 'Se devuelve parametro desencriptado
    End Function
End Class
