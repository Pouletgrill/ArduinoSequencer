﻿using System;
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
            InitializeComponent();
        }

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            pulse = new PulseClass(Convert.ToInt32(CB_Pin.Text), (CB_Output.Text == "HIGH" ? true : false), Convert.ToInt32(NUD_Duration.Value));
        }

        public PulseClass GetPulse
        {
            get{ return pulse;}
        }
    }
}
