// Nuget package Newtonsoft.Json

using System;
using Newtonsoft.Json;
using System.Text.Json;


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // ESCAPE UNESCAPE //

        string unescapedString = "This is a \"quoted\" string"; // This is a "quoted" string

        string escapedString = JsonConvert.ToString(unescapedString);
        Console.WriteLine(escapedString); // Output: "This is a \"quoted\" string"

        unescapedString = JsonConvert.DeserializeObject<string>(escapedString);
        Console.WriteLine(unescapedString); // Output: This is a "quoted" string

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // JSON ENCODE//

        string myStringForEncode = "Some text with characters like ü ğ ";
        string encodedString = System.Text.Json.JsonSerializer.Serialize(myStringForEncode);
        Console.WriteLine(encodedString); // Output: Some text with characters like \u00FC \u011F 

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
