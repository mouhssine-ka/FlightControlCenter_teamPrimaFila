﻿using FlightSimulatorControlCenter.Model.Event;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightSimulatorControlCenter
{
    public partial class Scelta : Form
    {
        public event SceltaSelectedEvent ScletaSelected;
        public Scelta()
        {
            InitializeComponent();
        }
    }
}
