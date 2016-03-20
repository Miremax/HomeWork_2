using Model;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car('D',"Лада") { Color = Color.DarkViolet };

            try
            {
                Console.WriteLine("Владелец Лады " + car1.CarPassport.Owner.Name);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Невозможно вывести имя владельца " + exception.Message + '\n');
            }

            var instructor = new Driver(new DateTime(2005, 01, 01), "Вольдемар") { Category = "BC" };

            try
            {
                car1.ChangeOwner(instructor, "о777оо");
            }
            catch (NoCategoryException exception)
            {
                Console.WriteLine(exception.Message);
            }

            instructor.Category += "D";
            car1.ChangeOwner(instructor, "o777oo");

            Console.WriteLine("Номер машины " + instructor.Car.CarNumber + '\n');

            Console.WriteLine("Владелец Лады " + car1.CarPassport.Owner.Name + '\n');

            Console.ReadKey();
        }
    }
}
