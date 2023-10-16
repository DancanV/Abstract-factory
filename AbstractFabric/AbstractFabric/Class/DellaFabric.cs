using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFabric.Class
{
    public class Car3 : AbstractCar
    {
        public string TypeCar;
        public PictureBox car;
        public string[] ArrayNameCar = new string[5];

        public override Bitmap LoadImage(string path)
        {
            return null;
        }

        public Car3(PictureBox p)
        {
            car = p;
            car.Image = new Bitmap("Car_3.jpg");
        }

    }

    public class Route3 : AbstractRoute
    {
        public string[] ArrayNameRoute = new string[5];
        public PictureBox Route;


        public override Bitmap LoadImage(string path)
        {
            return null;
        }

        public Route3(PictureBox r)
        {
            Route = r;
            Route.Image = new Bitmap("Map_3.png");
        }
    }

    public class Cargo3 : AbstractCargo
    {
        public AbstractCar Car;
        public string name;
        public string[] ArrayNameCargo = new string[5];
        public PictureBox Cargo;

        public override Bitmap LoadImage(string path)
        {
            return null;
        }

        public override bool CheckStatusCar()
        {
            return false;
        }

        public Cargo3(PictureBox p)
        {
            Cargo = p;
            Cargo.Image = new Bitmap("Cargo_3.jpg");

        }
    }

    public class DellaFabric : AbstractCompanyFabric

    {
        public override AbstractCar CreateCar(PictureBox p)
        {
            return new Car3(p);
        }

        public override AbstractCargo CreateCargo(AbstractCar c, PictureBox h)
        {
            Cargo3 cc = new Cargo3(h);
            cc.Car = c;
            return cc;
        }


        public override AbstractRoute CreateRoute(PictureBox r)
        {
            return new Route3(r);
        }
    }
}
