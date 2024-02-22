using FlightSimulatorControlCenter.Model.Event;
using FlightSimulatorControlCenter.Service.Int;
using FlightSimulatorControlCenter.Service;
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
    public partial class DbSelection : Form
    {
        public event SceltaSelectedEvent SceltaSelected;
        public DbSelection()
        {
            InitializeComponent();
        }

        private void DbSelection_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dbEsterno_Click(object sender, EventArgs e)
        {
            this.SceltaSelected(1);
            dbEsterno.Enabled = false;
            EnableButtons(FakeDB, MockedDB);
        }

        private void FakeDB_Click(object sender, EventArgs e)
        {
            this.SceltaSelected(2);
            FakeDB.Enabled = false;
            EnableButtons(MockedDB, dbEsterno);
        }

        private void MockedDB_Click(object sender, EventArgs e)
        {
            this.SceltaSelected(3);
            MockedDB.Enabled = false;
            EnableButtons(FakeDB, dbEsterno);
        }

        public void EnableButtons(Button b1, Button b2)
        {
            b1.Enabled = true;
            b2.Enabled = true;
        }
    }
}
