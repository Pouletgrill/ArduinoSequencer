using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoSequencer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_Create_Click(object sender, EventArgs e)
        {
            CRUD_Dialog cruddialog = new CRUD_Dialog();
            cruddialog.ShowDialog(); //Show dialog pause le code
            MessageBox.Show(cruddialog.GetPulse.duration.ToString());
        }

        private void BTN_Update_Click(object sender, EventArgs e)
        {
            PulseClass test = new PulseClass(false,666);

            CRUD_Dialog cd = new CRUD_Dialog(test);
            cd.ShowDialog(); //Show dialog pause le code
            PulseClass xebit = cd.GetPulse;
            MessageBox.Show(xebit.duration.ToString());
        }
    }
}
