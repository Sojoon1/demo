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
    public partial class EditForm : Form
    {
        public Model1 db { get; set; }
        public EditForm()
        {
            InitializeComponent();
        }

        private void Сохранить_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" ||
                textBox7.Text == "")
            {
                MessageBox.Show("Не все поля заполнены!");
                return;
            }
            Product lich = new Product();
            lich.ID = Convert.ToInt32(textBox1.Text);
            lich.Title = textBox2.Text;
            lich.Cost = Convert.ToDecimal(textBox3.Text);
            lich.Description = textBox4.Text;
            lich.MainImagePath = textBox5.Text;
            lich.IsActive = Convert.ToBoolean(textBox6.Text);
            lich.ManufacturerID = Convert.ToInt32(textBox7.Text);

            db.Products.Add(lich);
            db.SaveChanges();
            DialogResult = DialogResult.OK;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
