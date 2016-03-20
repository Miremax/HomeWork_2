using System;
using System.Drawing;


namespace Model
{
    public class Car
    {
        public Car (char category, string model)
        {
            Model = model;
            Category = category;
            CarPassport = new CarPassport(this);
        }

        public CarPassport CarPassport;
        public string CarNumber { get; private set; }
        public string Model { get; }
        public Color Color = Color.Blue;
        public char Category { get; }


        public void ChangeOwner(Driver driver, string carNumber)
        {
            CarPassport.Owner = driver;
            driver.OwnCar(this);           
            CarNumber = carNumber;
        }
    }
}
