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
    public partial class AddBus : Form
    {
        internal  Buses bus { get; set; }
        public AddBus()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
      
       bus = new Buses(tbName.Text, tbDestination.Text, cbLocal.Checked);
       DialogResult = System.Windows.Forms.DialogResult.OK;
            MessageBox.Show("Автобусот е успешно додаден.", "Успех!",MessageBoxButtons.OK);
         
        }

        private void AddBus_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Дали сте сигурни дека сакате да излезете?", "?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void tbDestination_Validating(object sender, CancelEventArgs e)
        {
            if (tbDestination.Text.Trim().Length != 4)
            {
                epRegistration.SetError(tbDestination, "Регистрацијата треба да има точно 4 цифри");
                e.Cancel = true;
            }
            else {
                epRegistration.SetError(tbDestination, "");
                e.Cancel = false;

            }
        }
    }
}
