using AbstractFabric.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFabric
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private AbstractCompanyFabric f;
        private AbstractCar Car;
        private AbstractCargo Cargo;
        private AbstractRoute Route;

        private void BtLevel1_Click(object sender, EventArgs e)
        {
            f = new CompanyFabric1();
            Car = f.CreateCar(PbCars);

            Cargo = f.CreateCargo(Car, PbCargo);
            Route = f.CreateRoute(PbMaps);

        }

        private void BtLevel2_Click(object sender, EventArgs e)
        {
            f = new LogisticFabric();
            Car = f.CreateCar(PbCars);

            Cargo = f.CreateCargo(Car, PbCargo);
            Route = f.CreateRoute(PbMaps);

        }

        private void BtLevel3_Click(object sender, EventArgs e)
        {
            f = new DellaFabric();
            Car = f.CreateCar(PbCars);
            Cargo = f.CreateCargo(Car, PbCargo);
            Route = f.CreateRoute(PbMaps);

        }

      
    }
}
