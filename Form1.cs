using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BlessedExchequer
{
    
     
    public partial class Form1 : Form
    {


        public accountClass aclass = new accountClass(1, "Wells Fargo", "4803509", 23.34, true, true, 6.75, true);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void updateBalls(string aName)
        {
            aclass.setName(aName);
        }

        private void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            MessageBox.Show(aclass.getName());
        }

        private void editAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //editAccountForm eaf = new editAccountForm(1, "Wells Fargo", "4803509", 23.34, true, true, 6.75, true);
            editAccountForm eaf = new editAccountForm(aclass.getID(), aclass.getName(), aclass.getNumber(), aclass.getBalance(), aclass.getAsset(), aclass.getInterestOption(), aclass.getInterestRate(),aclass.getActive());
            //editAccountForm eaf = new editAccountForm();
            eaf.Visible = true;

        }
    }
}
