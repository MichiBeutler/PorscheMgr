using System;
using System.Collections.Generic;
using System.Text;

namespace CarMgr
{
	public class Car
	{
        private int id;
		private string name;
		private int year;
		private string image;
        private string image2;
		private double price;
		private Engine engine;
		private Body body;
		private ChassisAndSuspension chassisAndSuspension;
		private FuelConsumption fuelConsumption;
		private Brand brand;
		private Performance performance;
		private Transmission transmission;
		private List<Part> parts;

        public Car(int id, string name, int year, string image, string image2, double price, Engine engine, Body body, ChassisAndSuspension chassisAndSuspension, FuelConsumption fuelConsumption, Brand brand, Performance performance, Transmission transmission)
        {
            ID = id;
            Name = name;
            Year = year;
            Image = image;
            Image2 = image2;
            Price = price;
            Engine = engine;
            Body = body;
            ChassisAndSuspension = chassisAndSuspension;
            FuelConsumption = fuelConsumption;
            Brand = brand;
            Performance = performance;
            Transmission = transmission;
            Parts = new List<Part>();
        }

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Year { get => year; set => year = value; }
        public string Image { get => image; set => image = value; }
        public double Price { get => price; set => price = value; }
        public Engine Engine { get => engine; set => engine = value; }
        public Body Body { get => body; set => body = value; }
        public ChassisAndSuspension ChassisAndSuspension { get => chassisAndSuspension; set => chassisAndSuspension = value; }
        public FuelConsumption FuelConsumption { get => fuelConsumption; set => fuelConsumption = value; }
        public Brand Brand { get => brand; set => brand = value; }
        public Performance Performance { get => performance; set => performance = value; }
        public Transmission Transmission { get => transmission; set => transmission = value; }
        public List<Part> Parts { get => parts; set => parts = value; }
        public string Image2 { get => image2; set => image2 = value; }
    }

}
