using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newton
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person() { Navn = "Mathias", Tlf = 12345678, Email = "Mig@mig.mig" };
            string jsonText = JsonConvert.SerializeObject(person1);
            Console.WriteLine(jsonText);
            Console.ReadLine();
        }
    }
}
