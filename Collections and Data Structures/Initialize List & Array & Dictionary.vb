Imports System

Module Program
    Sub Main(args As String())
    
        ' Create a new List of strings
        Dim var_List As List(of String) = New List(Of String)

        ' Add two elements to the list
        var_List.Add("1")
        var_List.Add("2")

        ' Output the first and second elements of the list
        Console.WriteLine(var_List(0))
        Console.WriteLine(var_List(1))

        ' Create a new array of strings
        Dim var_Ary as String() = New String(){}

        ' Append two elements to the array
        var_Ary = var_Ary.Append("1").ToArray
        var_Ary = var_Ary.Append("2").ToArray

        ' Output the first and second elements of the array
        Console.WriteLine(var_Ary(0))
        Console.WriteLine(var_Ary(1))

        ' Create a new Dictionary with string keys and Object values
        Dim var_Dictionary as Dictionary(of String, Object) = New Dictionary(of String, Object)

        ' Add two key-value pairs to the dictionary
        var_Dictionary.Add("key1","value1")
        var_Dictionary.Add("key2","value2")

        ' Output the value associated with "key1" and the value associated with the second key in the dictionary
        Console.WriteLine(var_Dictionary("key1"))
        Console.WriteLine(var_Dictionary(var_Dictionary.Keys(1).ToString))

    End Sub
End Module
