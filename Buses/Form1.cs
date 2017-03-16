using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        internal List<Buses> busLines;
        public Form1()
        {
            InitializeComponent();
            busLines = new List<Buses>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Buses a = new Buses("Transkop", "OH213BT", true);
               a.addLine(new Lines("4:20","Jamaica",500));
            Buses b =new Buses("Galeb", "OH111VG", false);
            b.addLine(new Lines("15:20","Bitola",150));
            busLines.Add(a);
            busLines.Add(b);

            btnRemoveBus.Enabled = false;

            loadBuses();
            
        }
        internal void addAndLoad(Buses bus) {
            busLines.Add(bus);
            loadBuses();
           
        }
        public void loadBuses() {
            lbBuses.Items.Clear();
            foreach (Buses b in busLines)
            {

                lbBuses.Items.Add(b);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Дали сте сигурни дека сакате да го избришете автобусот?","??",MessageBoxButtons.YesNo)==System.Windows.Forms.DialogResult.Yes)
            if (lbBuses.SelectedIndex != -1) {
                busLines.RemoveAt(lbBuses.SelectedIndex);
                lbBuses.Items.RemoveAt(lbBuses.SelectedIndex);
                lbLines.Items.Clear();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lbLines_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }
        private void AverageAndMostExpensiveRoutes(Buses bus) {
            tbAveragePerLine.Text = bus.averagePriceOfLines().ToString();
            tbMostExpensiveLine.Text = bus.mostExpensiveLine().ToString();
        
        
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AddLine form = new AddLine();
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK) {

                Buses bus = busLines.ElementAt(lbBuses.SelectedIndex);
                bus.addLine(form.line);
                loadLines(bus);
                AverageAndMostExpensiveRoutes(bus);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddBus form = new AddBus();
           // form.Show();
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                addAndLoad(form.bus);
            }
        }
        private void loadLines(Buses bus) {
            lbLines.Items.Clear();
            foreach (Lines l in bus.listLines)
            {
                lbLines.Items.Add(l);
            }
        }
        private void lbBuses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbBuses.SelectedIndex != -1)
            {
                btnRemoveBus.Enabled = true;
                btnAddLine.Enabled = true;
                lbLines.Items.Clear();
                Buses bus = busLines.ElementAt(lbBuses.SelectedIndex);
                loadLines(bus);
                tbAveragePerLine.Text = bus.averagePriceOfLines().ToString();
                tbMostExpensiveLine.Text = bus.mostExpensiveLine().ToString();

            }
            else {
                btnRemoveBus.Enabled = false;

            }
        }
    }
}
