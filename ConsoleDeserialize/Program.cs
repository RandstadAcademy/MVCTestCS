using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDeserialize
{
    class Program
    {
        static void Main(string[] args)
        {



            String s = System.IO.File.ReadAllText("C:\\CarDealer\\MVCTestCS\\ConsoleMVC\\bin\\Debug\\JsonProduced.json");

            List<Person> lp = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Person>>(s);


        }
    }
}
