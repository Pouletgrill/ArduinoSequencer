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
    public partial class CRUD_Dialog : Form
    {
        PulseClass pulse;
        public CRUD_Dialog(PulseClass entree)
        {
            pulse = entree;
            InitializeComponent();
        }
        public CRUD_Dialog()
        {
            pulse = new PulseClass(4,true, 400);
            InitializeComponent();
        }

        public PulseClass GetPulse
        {
            get
            {
                return pulse;
            }
        }
    }
}
