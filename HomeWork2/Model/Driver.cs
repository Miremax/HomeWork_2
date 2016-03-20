using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Driver
    {
        public Driver(DateTime licenceDate, string name)
        {
            LicenceDate = licenceDate;
            Name = name;
        }

        public DateTime LicenceDate { get;  }
        public string Name { get;  }

        public TimeSpan Experience
        {
            get
            {
                return DateTime.Today - LicenceDate;
            }
        }
        public string Category { get; set; }
        public Car Car { get; private set; }
        public void OwnCar(Car car)
        {
            if (!Category.Contains(car.Category))
            {
                throw new NoCategoryException("У водителя нет такой категории");
            }
            else
            {
                Car = car;
            }
        }
    }
}
