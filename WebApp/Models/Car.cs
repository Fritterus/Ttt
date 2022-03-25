using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Interfaces;

namespace WebApp.Model
{
    internal class Car : ICar
    {
        public string Model { get; set; }
        public string Mark { get; set; }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
