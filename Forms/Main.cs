using Lopush.DataModel;
using Lopush.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lopush.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            products = Model1.Product.ToList();
    }

        private Model1 Model1 = new Model1();
        private List<Product> products = new List<Product>();
        private void Form1_Load(object sender, EventArgs e)
        {
            List<ProductType> producttypes = Model1.ProductType.ToList();
            producttypes.Add(new ProductType(6, "Все типы"));
            productTypeBindingSource.DataSource = producttypes;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 5;
            FillPanel();
        }
        private void FillPanel()
        {
            flowLayoutPanel2.Controls.Clear();
            foreach (Product prod in products)
            {
                UserControl1 userControl1 = new UserControl1(prod, Model1);
                flowLayoutPanel2.Controls.Add(userControl1);
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void FiltrAndSorting()
        {
            Filtr();
            Sort();
        }
        private void Sort()
        {
            if (comboBox1.SelectedItem.ToString() == "ID")
            {
                products = products.OrderBy(x => x.ID).ToList();
            }
            if (comboBox1.SelectedItem.ToString() == "Title")
            {
                products = products.OrderBy(x => x.Title).ToList();

            }
            if (comboBox1.SelectedItem.ToString() == "MinCostForAgent")
            {
                products = products.OrderBy(x => x.MinCostForAgent).ToList();

            }
            FillPanel();
        }

        private void Filtr()
        {
            if (comboBox2.SelectedItem == null)
                return;


            if (String.IsNullOrWhiteSpace(TextBoxSearch.Text))
            {
                products = Model1.Product.ToList();
            }
            else
            {
                products = Model1.Product.Where(x => x.Title.ToLower().Replace(" ", "").Contains(TextBoxSearch.Text.ToLower().Replace(" ", ""))).ToList();
            }

            if ((comboBox2.SelectedItem as ProductType).Title != "Все типы")
            {
                products = products.Where(x => x.ProductType.ID == (comboBox2.SelectedItem as ProductType).ID).ToList();
            }

            if (products.Count == 0)
            {
                LabelProduct.Visible = true;
            }
            else
            {
                LabelProduct.Visible = false;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrAndSorting();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrAndSorting();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FiltrAndSorting();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Add().ShowDialog();
            Hide();
        }
    }
}
