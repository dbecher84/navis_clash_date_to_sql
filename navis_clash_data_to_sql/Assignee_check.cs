﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace double_check_form
{
    public partial class Assignee_check : Form
    {

        public Assignee_check(int missingCount)
        {
            InitializeComponent();

            textBox3.Text = missingCount.ToString();
        }

        public string doubleCheckResponse { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            doubleCheckResponse = "Yes";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doubleCheckResponse = "No";
        }
    }
}
