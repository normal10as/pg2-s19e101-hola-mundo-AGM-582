Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Veamos si funciona la idea")
        Dim nuno As Integer = 0
        Dim ndos As Integer = 0
        Dim suma As Integer = nuno + ndos
        Console.WriteLine("A continuación ingrese 1 número")
        Console.ReadLine(nuno)
        Console.WriteLine("Ahora ingrese otro número")
        Console.ReadLine(ndos)
        Console.WriteLine("sumaremos ambos valores")
        If suma = 0 Then
            Console.WriteLine("Hello World!")
        End If
        Console.WriteLine("La suma fue menor a 0, pero va un saludo de consuelo: ")
        Console.WriteLine("Hola Mundo")

    End Sub
End Module
