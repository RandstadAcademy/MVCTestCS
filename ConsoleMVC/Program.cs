using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC
{
    class Program
    {
        static void Main(string[] args)
        {

            Car c = new Car();
            c.Name = "Audui";
            c.Year = 2017;



            List<Person> lp = new List<Person>();

            Person p = new Person();
            p.Name = "Tommaso";
            p.Surname = "De Siato";

            p.BirthDate = new DateTime(2016, 10, 30);

            p.Age = 1000;


            c = new Car();
            c.Name = "Fiat";
            c.Year = 2017;

            p.Cars.Add(c);

            c = new Car();
            c.Name = "Land Rover";
            c.Year = 2013;

            p.Cars.Add(c);



            lp.Add(p);


            p = new Person();
            p.Name = "Pos";
            p.Surname = "Pis";

            p.BirthDate = new DateTime(2016, 10, 30);

            p.Age = 1000;


            c = new Car();
            c.Name = "Ford";
            c.Year = 2014;

            p.Cars.Add(c);

            lp.Add(p);

            p = new Person();
            p.Name = "Cas";
            p.Surname = "Senza Macchina";

            p.BirthDate = new DateTime(2016, 10, 30);

            p.Age = 1000;


            lp.Add(p);

            String s = Newtonsoft.Json.JsonConvert.SerializeObject(lp);

            Console.WriteLine(s);





            System.IO.File.WriteAllText("JsonProduced.json", s);





            Console.ReadKey();


        }
    }
}
