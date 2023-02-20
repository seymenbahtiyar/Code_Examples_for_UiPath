// Nuget package Newtonsoft.Json

using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // JSON ARRAY MERGE //

        string json1 = "[{\"id\": 1, \"name\": \"John\"}, {\"id\": 2, \"name\": \"Jane\"}]";
        string json2 = "[{\"id\": 3, \"name\": \"Bob\"}, {\"id\": 4, \"name\": \"Alice\"}]";

        JArray array1 = JArray.Parse(json1);
        JArray array2 = JArray.Parse(json2);

        JArray outputArray = new JArray(array1); // create a new JArray object and copy array1 into it
        outputArray.Merge(array2); // concatenate array2 into outputArray

        string jsonResult = outputArray.ToString();
        Console.WriteLine(jsonResult);

        // [
        //   {
        //     "id": 1,
        //     "name": "John"
        //   },
        //   {
        //     "id": 2,
        //     "name": "Jane"
        //   },
        //   {
        //     "id": 3,
        //     "name": "Bob"
        //   },
        //   {
        //     "id": 4,
        //     "name": "Alice"
        //   }
        // ]


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


