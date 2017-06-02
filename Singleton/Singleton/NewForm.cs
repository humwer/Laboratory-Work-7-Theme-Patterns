﻿using System;
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
    public partial class NewForm : Form
    {
        public NewForm()
        {
            InitializeComponent();
        }

        private void NewForm_Load(object sender, EventArgs e)
        {

        }

        private static NewForm n;
        public static NewForm nf
        {
            get
            {
                if (n == null || n.IsDisposed)
                    n = new NewForm();
                return n;
            }
        }
    }
}
