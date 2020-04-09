using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molina_SportingEventApp
{
    class Child
    {
        private string city;
        private string name;
        private string sport;
        private string state;
        private string street;

        public string Name
        {
            get
            {
                return name;
            }
        }
        public string Sport
        {
            get
            {
                return sport;
            }
        }

        public Child()
        {
        }

        public Child(string city, string name, string sport, string state, string street)
        {
            this.city = city;
            this.name = name;
            this.sport = sport;
            this.state = state;
            this.street = street;
        }
    }
}
