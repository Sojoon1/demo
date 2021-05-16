using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo2
{
    public partial class Form3 : Form
    {
        Model1 db = new Model1();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            productBindingSource.DataSource = db.Products.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditForm form = new EditForm();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditForm add = new EditForm();
            add.db = db;
            DialogResult dr = add.ShowDialog();
            if (dr == DialogResult.OK)
            {
                productBindingSource.DataSource = db.Products.ToList();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
