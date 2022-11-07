using OCP.ValidateCoffee.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.ValidateCoffee.Concrete
{
    public class Latte : CoffeeBase
    {
        public override double TutarHesapla(double Adet)
        {

            // fiyat bilgilerini db'den cektiniz
            return Adet * 60;
        }
    }
}
