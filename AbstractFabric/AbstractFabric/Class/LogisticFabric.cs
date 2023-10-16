using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFabric.Class
{
    public class Car2 : AbstractCar
    {
        public string TypeCar;
        public PictureBox car;
        public string[] ArrayNameCar = new string[5];

        public override Bitmap LoadImage(string path)
        {
            return null;
        }

        public Car2(PictureBox p)
        {
            car = p;
            car.Image = new Bitmap("Car_2.jpg");
        }

    }

    public class Route2 : AbstractRoute
    {
        public string[] ArrayNameRoute = new string[5];
        public PictureBox Route;


        public override Bitmap LoadImage(string path)
        {
            return null;
        }

        public Route2( PictureBox r)
        {
            Route = r;
            Route.Image = new Bitmap("Map_2.png");
        }
    }

    public class Cargo2 : AbstractCargo
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

        public Cargo2(PictureBox p)
        {
            Cargo = p;
            Cargo.Image = new Bitmap("Cargo_2.jpg");
        }
    }

    public class LogisticFabric : AbstractCompanyFabric

    {
        public override AbstractCar CreateCar(PictureBox p)
        {
            return new Car2(p);
        }

        public override AbstractCargo CreateCargo(AbstractCar c,PictureBox h)
        {
            Cargo2 cc = new Cargo2(h);
            cc.Car = c;
            return cc;
        }


        public override AbstractRoute CreateRoute(PictureBox r)
        {
            return new Route2(r);
        }
    }
}
