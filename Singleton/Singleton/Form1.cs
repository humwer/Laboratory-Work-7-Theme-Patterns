using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Singleton
{
    public partial class FormOne : Form
    {
        public FormOne()
        {
            InitializeComponent();
        }

        private void buttonNewForm_Click(object sender, EventArgs e)
        {
            NewForm.nf.Show();
        }

        private void buttonMessage_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Закрыть форму?", "Вы уверены, что хотите закрыть форму?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
                Close();
        }

        private void FormOne_FormClosing(object sender, FormClosingEventArgs e)
        {
        
        }
    }
}
