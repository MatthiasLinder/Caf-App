﻿using Cafe_App_01._02._2018.Code_Assets;
using Cafe_App_01._02._2018.Code_Assets.Coffee_Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_App_01._02._2018
{
    public partial class PurchaseScreen : Form
    {
        private List<Regular> coffelist;

        public PurchaseScreen()
        {
            InitializeComponent();

        }
        private void RegularCoffee_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            coffelist = new List<Regular>();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
