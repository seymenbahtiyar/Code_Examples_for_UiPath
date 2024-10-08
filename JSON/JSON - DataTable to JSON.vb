Imports System
Imports System.Data
Imports Newtonsoft.Json


Module Module1
    Sub Main()
        ' Örnek bir DataTable oluşturma
        Dim table As New DataTable("ExampleTable")

        ' Sütunlar ekle
        table.Columns.Add("ID", GetType(Integer))
        table.Columns.Add("Name", GetType(String))
        table.Columns.Add("Age", GetType(Integer))

        ' Satırlar ekle
        table.Rows.Add(1, "John Doe", 30)
        table.Rows.Add(2, "Jane Smith", 25)

        ' DataTable'ı JSON formatına dönüştürme
        Dim jsonResult As String = JsonConvert.SerializeObject(table)

        ' JSON çıktısını yazdır
        Console.WriteLine(jsonResult)

        ' [{"ID":1,"Name":"John Doe","Age":30},{"ID":2,"Name":"Jane Smith","Age":25}]

        ' Konsol ekranında kalması için bekleyin
        Console.ReadLine()
    End Sub
End Module
