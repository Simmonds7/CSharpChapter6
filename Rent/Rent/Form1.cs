using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace Rent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int[,] rents =
                {{400, 450, 510 },
                {500, 560, 630},
                {625, 676, 740},
                {1000, 1250, 1600} };
            int floor;
            int bedrooms;

            floor = Convert.ToInt32(txtFloor.Text);
            bedrooms = Convert.ToInt32(txtRooms.Text);
            lblOutput.Text = "The rent on that room is $" + rents[floor, bedrooms];
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";
        }
    }
}
