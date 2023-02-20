using System;
using System.Data;
using System.Linq;

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Remove matching values from a specific column in a DataTable  //

        // Creating and adding data to dt1
        DataTable dt1 = new DataTable("dt1");
        dt1.Columns.Add("ID", typeof(string));
        dt1.Columns.Add("Name", typeof(string));
        dt1.Columns.Add("Score", typeof(int));

        dt1.Rows.Add("1", "Alice", 100);
        dt1.Rows.Add("2", "Bob", 80);
        dt1.Rows.Add("3", "Charlie", 90);

        // Creating and adding data to dt2
        DataTable dt2 = new DataTable("dt2");
        dt2.Columns.Add("ID", typeof(string));
        dt2.Columns.Add("Name", typeof(string));
        dt2.Columns.Add("Score", typeof(int));

        dt2.Rows.Add("2", "Bob", 80);
        dt2.Rows.Add("3", "Charlie", 90);

        // Writing the initial state of dt1 to the console
        Console.WriteLine("dt1 Initial State:");
        foreach (DataRow row in dt1.Rows)
        {
            Console.WriteLine("{0} {1} {2}", row["ID"], row["Name"], row["Score"]);
        }
        Console.WriteLine();

        // Matching IDs in dt2 with IDs in dt1 and removing the corresponding rows from dt1
        var query = from row1 in dt1.AsEnumerable()
                    join row2 in dt2.AsEnumerable() on (string)row1["ID"] equals (string)row2["ID"]
                    select row1;

        dt1 = dt1.AsEnumerable()
            .Except(query)
            .CopyToDataTable();


        // Writing the initial state of dt2 to the console
        Console.WriteLine("dt2 Initial State:");
        foreach (DataRow row in dt2.Rows)
        {
            Console.WriteLine("{0} {1} {2}", row["ID"], row["Name"], row["Score"]);
        }
        Console.WriteLine();


        // Writing the final state of dt1 to the console
        Console.WriteLine("dt1 Final State:");
        foreach (DataRow row in dt1.Rows)
        {
            Console.WriteLine("{0} {1} {2}", row["ID"], row["Name"], row["Score"]);
        }
        Console.WriteLine();

        // dt1 Initial State:"
        // 1 Alice 100
        // 2 Bob 80
        // 3 Charlie 90

        // dt2 Initial State:
        // 2 Bob 80
        // 3 Charlie 90

        // dt1 Final State:
        // 1 Alice 100

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
