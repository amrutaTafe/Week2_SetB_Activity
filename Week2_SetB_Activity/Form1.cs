using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2_SetB_Activity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            rtb_name.Text = rtb_name.Text + "Your name is " + "\"David\"";

        }  

        private void Show_btn_Click(object sender, EventArgs e)
        {
            Txt_Fullname.Text = Txt_Gname.Text  + " " +  Txt_Familyname.Text;

        }
        private void Clear_btn_Click(object sender, EventArgs e)
        {
            Txt_Gname.Clear();
            Txt_Familyname.Clear();
            Txt_Fullname.Clear();
        }

        private void Txt_Gname_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
