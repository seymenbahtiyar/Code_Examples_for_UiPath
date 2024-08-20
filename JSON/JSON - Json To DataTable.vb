Imports System
Imports Newtonsoft.Json
Imports System.Data

Module Module1
    Sub Main()
        ' JSON formatındaki bir string örneği
        Dim jsonStr As String = "[{'ID':1,'Name':'John Doe','Age':30},{'ID':2,'Name':'Jane Smith','Age':25}]"

        ' JSON stringini DataTable'a dönüştürme
        Dim table As DataTable = JsonConvert.DeserializeObject(Of DataTable)(jsonStr)

        ' DataTable verilerini yazdır
        For Each row As DataRow In table.Rows
            Console.WriteLine("ID: " & row("ID") & ", Name: " & row("Name") & ", Age: " & row("Age"))
        Next
	
		'ID: 1, Name: John Doe, Age: 30
		'ID: 2, Name: Jane Smith, Age: 25

        ' Konsol ekranında kalması için bekleyin
        Console.ReadLine()
    End Sub
End Module
