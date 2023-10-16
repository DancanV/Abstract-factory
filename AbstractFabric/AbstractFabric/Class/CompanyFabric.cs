using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFabric.Class
{
    public abstract class AbstractCar
    {
        public string TypeCar;
        
        public abstract Bitmap LoadImage(string path);
    }

   public abstract class AbstractRoute
    {
        public string[] ArrayName;

       public abstract Bitmap LoadImage(string path);
    }

    public abstract class AbstractCargo
    {
        public AbstractCar Car;
        public string name;
        

        abstract public Bitmap LoadImage(string path);
        abstract public bool CheckStatusCar();

    }
    public abstract  class AbstractCompanyFabric
    {
        public abstract  AbstractCargo CreateCargo(AbstractCar c, PictureBox h);
        public abstract AbstractCar CreateCar(PictureBox p);
        public abstract  AbstractRoute CreateRoute(PictureBox r);
    }

    
}
