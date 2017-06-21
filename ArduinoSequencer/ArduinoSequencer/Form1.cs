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
        List<PulseClass> collection = new List<PulseClass>();
        public Form1()
        {
            InitializeComponent();
        }

        private void RefreshCollection()
        {
            DGV_CollectionViewer.Rows.Clear();
            foreach(PulseClass pulse in collection)
            {
                DGV_CollectionViewer.Rows.Add(pulse.pin, pulse.output, pulse.duration);
            }
        }

        private void BTN_Create_Click(object sender, EventArgs e)
        {
            CRUD_Dialog crud_FormDialog = new CRUD_Dialog();
            if (crud_FormDialog.ShowDialog() == DialogResult.OK)
            {
                collection.Add(crud_FormDialog.GetPulse);
                RefreshCollection();
            }

        }

        private void BTN_Update_Click(object sender, EventArgs e)
        {
            /*PulseClass test = new PulseClass(12,false,666);

            CRUD_Dialog cd = new CRUD_Dialog(test);
            cd.ShowDialog(); //Show dialog pause le code
            PulseClass xebit = cd.GetPulse;
            MessageBox.Show(cd.GetPulse.PulseToCode());*/
        }
    }
}
