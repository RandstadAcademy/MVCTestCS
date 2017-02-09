using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DataModel
{
    public class Person
    {
        public string Name { get; set; }

        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        [JsonIgnore]
        public int Age { get; set; }


        private List<Car> _Cars;

        [JsonIgnore]
        public List<Car> Cars
        {
            get
            {

                if (_Cars == null) _Cars = new List<Car>();

                return _Cars;

            }
            set { _Cars = value; }
        }



    }
}
