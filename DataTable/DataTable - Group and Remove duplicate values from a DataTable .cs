using System;
using System.Data;


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Group and Remove duplicate values from a DataTable  //

        // Creating a DataTable and adding sample data
        DataTable dt = new DataTable();
        dt.Columns.Add("Name", typeof(string));
        dt.Columns.Add("Surname", typeof(string));

        // Adding sample data
        dt.Rows.Add("Ali", "Kaya");
        dt.Rows.Add("Ayşe", "Yılmaz");
        dt.Rows.Add("Ali", "Gündoğdu");
        dt.Rows.Add("Ahmet", "Eren");
        dt.Rows.Add("Ayşe", "Kılıç");
        dt.Rows.Add("Mehmet", "Demir");

        // Grouping duplicate values and keeping only the first instance
        var groupedTable = dt.AsEnumerable()
            .GroupBy(row => row.Field<string>("Name"))
            .Select(group => group.First())
            .CopyToDataTable();

        // Printing the results
        Console.WriteLine("Original Table");
        Console.WriteLine("-------------");
        foreach (DataRow row in dt.Rows)
        {
            Console.WriteLine(row["Name"] + " " + row["Surname"]);
        }

        Console.WriteLine("\nGrouped Table");
        Console.WriteLine("----------------------");
        foreach (DataRow row in groupedTable.Rows)
        {
            Console.WriteLine(row["Name"] + " " + row["Surname"]);
        }

        // Original Table
        // -------------
        // Ali Kaya
        // Ayşe Yılmaz
        // Ali Gündoğdu
        // Ahmet Eren
        // Ayşe Kılıç
        // Mehmet Demir

        // Grouped Table
        // ----------------------
        // Ali Kaya
        // Ayşe Yılmaz
        // Ahmet Eren
        // Mehmet Demir

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
