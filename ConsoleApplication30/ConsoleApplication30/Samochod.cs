using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication30
{
    class Samochod
    {
        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private double cena;

        public double Cena
        {
            get { return cena; }
            set { cena = value; }
        }

        public string Marka { get; set; }


        public void SetModel(string model)
        {
            this.model=model;
        }

        public string GetModel()
        {
            return model;
        }
    }
}
