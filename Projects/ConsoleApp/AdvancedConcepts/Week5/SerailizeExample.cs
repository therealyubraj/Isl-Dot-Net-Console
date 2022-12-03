using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using AdvancedConcepts.Week5;

namespace AdvancedConcepts.Week5
{
    public class SerailizeExample
    {
        public static void SerializeJSON()
        {
            SampleModel s = new();
            s.FName = "Ram";
            s.LName = "Bahadur";
            s.Salary = 2000;
            s.Commision_pct = 0.5f;

            string fileName = "serialized.json";

            string jsonString = JsonSerializer.Serialize(s);

            File.WriteAllText(fileName, jsonString);

            Console.WriteLine(jsonString);
        }

        public static void DeSerializeJOSN()
        {

        }
    }
}
