Imports System
Imports System.Data

Module Program2

    Sub Main(args As String())

        ' Create Order Information datatable
        Dim orderDt As New DataTable("Order Information")

        ' Add columns to the datatable
        orderDt.Columns.Add("Order ID", GetType(Integer))
        orderDt.Columns.Add("Customer ID", GetType(String))
        orderDt.Columns.Add("Order Date", GetType(Date))
        orderDt.Columns.Add("Total Amount", GetType(String))

        ' Add rows to the datatable
        orderDt.Rows.Add(201, "101", Date.Parse("2022-01-01"), "$150.00")
        orderDt.Rows.Add(201, "101", Date.Parse("2022-01-01"), "$150.00")
        orderDt.Rows.Add(202, "102", Date.Parse("2022-02-15"), "$200.00")
        orderDt.Rows.Add(203, "103", Date.Parse("2022-03-30"), "$100.00")
        orderDt.Rows.Add(202, "104", Date.Parse("2022-02-15"), "$200.00")
        orderDt.Rows.Add(203, "105", Date.Parse("2022-03-30"), "$100.00")

        ' Create Customer Information datatable
        Dim customerDt As New DataTable("Customer Information")

        ' Add columns to the datatable
        customerDt.Columns.Add("Customer ID Revise", GetType(String))
        customerDt.Columns.Add("First Name", GetType(String))
        customerDt.Columns.Add("Last Name", GetType(String))
        customerDt.Columns.Add("Email", GetType(String))

        ' Add rows to the datatable
        customerDt.Rows.Add("101", "John", "Smith", "john.smith@example.com")
        customerDt.Rows.Add("102", "Sarah", "Johnson", "sarah.johnson@example.com")
        customerDt.Rows.Add("109", "David", "Lee", "david.lee@example.com")

        ' Print original Order Information table
        Console.WriteLine()
        Console.WriteLine("Original Order Information table:")
        For Each row In orderDt.AsEnumerable()
            For Each col In orderDt.Columns
                Console.Write(row(col) & vbTab)
            Next

            Console.WriteLine()
        Next

        ' Print Customer Information table
        Console.WriteLine()
        Console.WriteLine("Customer Information table:")
        For Each row In customerDt.AsEnumerable()
            For Each col In customerDt.Columns
                Console.Write(row(col) & vbTab)
            Next

            Console.WriteLine()
        Next
        Console.WriteLine()

        ' Filter Order Information table based on Customer ID
        Dim query =
            From orderRow In orderDt.AsEnumerable()
            Join customerRow In customerDt.AsEnumerable()
            On orderRow.Item("Customer ID").ToString.Trim Equals customerRow.Item("Customer ID Revise").ToString.Trim
            Select orderRow

        If query.Any() Then
            orderDt = query.CopyToDataTable()
        Else
            orderDt = orderDt.Clone()
        End If

        ' Print filtered Order Information table
        Console.WriteLine("Filtered Order Information table:")
        For Each row In orderDt.AsEnumerable()
            For Each col In orderDt.Columns
                Console.Write(row(col) & vbTab)
            Next

            Console.WriteLine()
        Next
        Console.WriteLine()

	' Original Order Information table:
	' 201     101     1/1/2022        $150.00
	' 201     101     1/1/2022        $150.00
	' 202     102     2/15/2022       $200.00
	' 203     103     3/30/2022       $100.00
	' 202     104     2/15/2022       $200.00
	' 203     105     3/30/2022       $100.00

	' Customer Information table:
	' 101     John    Smith   john.smith@example.com
	' 102     Sarah   Johnson sarah.johnson@example.com
	' 109     David   Lee     david.lee@example.com
	
	' Filtered Order Information table:
	' 201     101     1/1/2022        $150.00
	' 201     101     1/1/2022        $150.00
	' 202     102     2/15/2022       $200.00
    
	End Sub
End Module
