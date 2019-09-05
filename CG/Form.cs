using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace CG
{
    public partial class Form : System.Windows.Forms.Form
    {
        public GLClass view;

        public Form()
        {
            InitializeComponent();
            view = new GLClass();
            view.Parent = this;
            view.Dock = DockStyle.Fill;
            view.Show();
            _Form = this;
        }
        public static Form _Form;
        public void update_score_P1(int msg)
        {
            score_p1.Text =Convert.ToString(msg);
        }

        public void update_score_P2(int msg)
        {
            score_p2.Text = Convert.ToString(msg);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        public void score_p1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
