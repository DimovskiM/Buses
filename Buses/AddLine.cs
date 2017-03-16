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
    public partial class AddLine : Form
    {
        internal Lines line;
        public AddLine()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbDestination.Text != "")
            {
                int p;
                int.TryParse(nUDPrice.Value.ToString(), out p);
                line = new Lines(nUDTime.Value.ToString() + ":" + nUDMinute.Value.ToString(), tbDestination.Text, p);
                DialogResult = System.Windows.Forms.DialogResult.OK;
                MessageBox.Show(line.ToString());
                MessageBox.Show("Линијата е успешно додадена!", "Успех!", MessageBoxButtons.OK);

            }
            else {
                MessageBox.Show("Дестинацијата не смее да е празна", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Дали сте сигурни дека сакате да излезете?", "?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
