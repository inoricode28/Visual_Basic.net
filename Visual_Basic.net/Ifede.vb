Module Module1

    Sub Main()
        Dim intinter As Integer
        Dim decn1 As Decimal

        System.Console.Write("ingrese numero: ")
        decn1 = System.Console.ReadLine()

        If decn1 > 0 And decn1 <= 9 Then
            System.Console.WriteLine("intervalo correcto")

        Else

            If decn1 > 9 Then
                System.Console.WriteLine("intervalo incorrecto positivo")
            Else
                If decn1 < 0 Then

                    System.Console.WriteLine("intervalo incorrecto negativo")
                Else
                    If decn1 = 0 Then

                        System.Console.WriteLine("intervalo Neutro")

                    End If

                End If
            End If


        End If
        


    End Sub

End Module