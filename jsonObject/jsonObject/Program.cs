using System;
using Newtonsoft.Json;

namespace jsonObject
{
    class Program
    {
        public static int? name = null;
        static void Main(string[] args)
        {
            var jsonProva = @"{ ""ScreenMessage"" : ""print""}";//, ""Clock"" : 3000}";
            Console.WriteLine(" ");
            Console.WriteLine(" Json contenent: " + jsonProva);
            Console.WriteLine(" ");

            dynamic provaConvert = JsonConvert.DeserializeObject(jsonProva);
            object o = provaConvert;
            Console.WriteLine(" Json object: " + o);
            Console.WriteLine(" ");

            string s = o.ToString();
            Console.WriteLine(" Json object casting in string : " + s);
            Console.WriteLine(" ");

            var value1 = provaConvert.ScreenMessage;
            Console.WriteLine(" Value ScreenMessage is : " + value1);
            Console.WriteLine(" ");

            string[] jsonName = new string[] {"Clock","stopTemperature","stopHumidity","stopPressure","stopAccelerometer",
                                              "stopTemperature","stopHumidity","stopPressure","stopAccelerometer","STOP","ScreenMessage","START"};
            int count = jsonName.Length;
            Console.WriteLine(" Array string contain: " + count);
            Console.WriteLine(" ");
            int i = 0;

            foreach (string stringArray in jsonName)
            {
                i = i + 1;

                if (jsonProva.Contains(stringArray) == true)
                {
                    name = i - 1;
                    Console.WriteLine(" Correct Json name " + jsonName[(int)name] + " find at array number " + name);
                }
                else
                {
                    Console.WriteLine(" No correct Json ");
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Press key to exit ");
            Console.ReadKey();
        }
    }
}
