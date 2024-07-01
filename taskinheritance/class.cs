using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskinheritance
{
    class cars
    {
        private string make;
        public string Make {  get { return make; } set { make = value; } }

        private int year;
        public int Year { get { return year; } set { year = value; } }
        private string type;
        public string Type { get { return type; } set { type = value; } }

        private double price;
        public double Price { get { return price; } set { price = value; } }

        private string model;
        public string Model { get { return model; } set { model = value; } }
        private int pallet_no;
        public int PalletNo { get { return pallet_no; } set { pallet_no = value; } }
        private string color;
        public string Color { get { return color; } set { color = value; } }
        private bool engineState;
        public bool EngineState { get { return engineState; } set { engineState = value; } }
        public cars(string make1,int year1,string type1, double price1,string model1,int palletno1,string color1,bool engineState1)
        {
            this.make = make1;
            this.year = year1;
            this.type = type1;
            this.price = price1;
            this.model = model1;
            this.pallet_no = palletno1;
            this.color = color1;
            this.engineState = engineState1;
        }
        public void Start()
        {
            Console.WriteLine("Engine started.");
        }

        public void Stop()
        {
            Console.WriteLine("Engine stopped.");
        }
        public string GetFullInfo()
        {
            return $"make:{make},year:{year},type:{type},price:{price},model:{model},palletNo:{pallet_no},color:{color}";
        }


    } 
    class Bmw : cars
    {
        private string series;
        public string Series { get; set; }
        public Bmw(string make1, int year1, string type1, double price1, string model1, int palletno1, string color1, bool engineState1, string series1) 
            :base(make1, year1, type1, price1, model1, palletno1, color1, engineState1)
        {
            series = series1;
        }
        public string Getfullinfo(string Series)
        {

        return $"{base.GetFullInfo()},Series:{Series}"; 
        }

    }

}
