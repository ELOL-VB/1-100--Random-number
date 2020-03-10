Module Module1

    Sub Main()
        Dim a(100), y, x, i As Integer
        Dim find As Boolean
        Randomize()

        For i = 1 To 100
            a(i) = Int(Rnd() * 100) + 1
            Console.Write(i & "=" & a(i) & ",")
        Next
        Console.Write("請輸入搜尋資料")
        x = Console.ReadLine()
        find = False
        For i = 1 To 100
            y += 1
            If x = a(i) Then
                Console.WriteLine("第" & y & "個為" & a(i))
                Console.WriteLine("共搜尋了" & i & "次")
                find = True
                Exit For
            End If
        Next
        If Not find Then
            Console.WriteLine("沒有搜尋到" & x)
        End If
        Console.Read()
    End Sub

End Module
