using Cafe_App_01._02._2018.Code_Assets;
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
    public partial class FirstScreen : Form
    {
        private List<Coffee> coffelist;

        public FirstScreen()
        {
            InitializeComponent();
            coffelist = new List<Coffee>();
           var esime = coffelist[0];
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            coffelist.Add(new Regular());
            
            this.Close();
        }
    }
}
