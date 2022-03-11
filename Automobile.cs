using System;

namespace Automobile
{
    class Automobile : Object
    {
        private string make;
        private string model;
        private string vin;
        private string color;
        private int year;
        public AutoType type;

        public Automobile(string make, string model, int year, string vin, string color, AutoType type) {
            this.make = make;
            this.model = model;
            this.year = year;
            this.vin = vin;
            this.color = color;
            this.type = type;
        }

        public string getModel()
        {
            return this.model;
        }

        public string getVin()
        {
            return this.vin;
        }

        public string getColor()
        {
            return this.color;
        }

        public void setColor(string newColor)
        {
            this.color = newColor;
        }

        public AutoType getType()
        {
            return this.type;
        }

        public int getYear()
        {
            return this.year;
        }

        public string getMake()
        {
            return this.make;
        }

        public object getAutoAge()
        {
            return (DateTime.Now.Year - this.year);
        }
    }
}