using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFabric.Class
{
    

    public class Car1:AbstractCar
    {
        public string TypeCar;
        public PictureBox car;
        public string[] ArrayNameCar = new string[5];

        public override  Bitmap LoadImage(string path)
        {
            return null;
        }

        public Car1(PictureBox p)
        {
            car = p;
            car.Image = new Bitmap("Car_1.jpg");
        }

    }

    public class Route1: AbstractRoute
    {
        public string[] ArrayNameRoute = new string[5];
        public PictureBox Route;


        public override  Bitmap LoadImage(string path)
        {
            return null;
        }

        public Route1(PictureBox r)
        {
            Route = r;
            Route.Image = new Bitmap("Map_1.png");
        }
    }

    public class Cargo1: AbstractCargo
    {
        public AbstractCar Car;
        public string name;
        public string[] ArrayNameCargo = new string[5];
        public PictureBox Cargo;

        public override  Bitmap LoadImage(string path)
        {
            return null;
        }

        public override bool CheckStatusCar()
       {
           return false;
       }

        public Cargo1(PictureBox h)
        {
            Cargo = h;
            Cargo.Image = new Bitmap("Cargo_1.jpg");
        }
    }

    public class CompanyFabric1 : AbstractCompanyFabric

    {
        public override AbstractCar CreateCar(PictureBox p)
        {
            return new Car1(p);
        }

        public override AbstractCargo CreateCargo(AbstractCar c, PictureBox h)
        {
            Cargo1 cc = new Cargo1(h);
            cc.Car = c;
            return cc;
        }


        public override AbstractRoute CreateRoute(PictureBox r)
        {
            return new Route1(r);
        }
    }
}