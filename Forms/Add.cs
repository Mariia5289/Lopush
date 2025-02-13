﻿using Lopush.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Lopush.Forms
{
    public partial class Add : Form
    {
        private Model1 Model1 = new Model1();

        private string _imagePath;
        public Add()
        {
            InitializeComponent();
            List<ProductType> pt = Model1.ProductType.ToList();
            pt.Add(new ProductType());
            productTypeBindingSource.DataSource = pt;
            comboBoxType.SelectedIndex = 0;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Выберите фото";
            ofd.Filter = "Файлы JPEG,|*.jpeg;|Все файлы (*.*)|*.*";
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _imagePath = ofd.FileName;
                pictureBox1.Image = Image.FromFile(_imagePath);
            }

            ofd.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(comboBoxType.Text) || String.IsNullOrWhiteSpace(titleTextBox.Text) 
                || String.IsNullOrWhiteSpace(articleNumberTextBox.Text) || String.IsNullOrWhiteSpace(minCostForAgentTextBox.Text)
                || String.IsNullOrWhiteSpace(productionPersonCountTextBox.Text) || String.IsNullOrWhiteSpace(productionWorkshopNumberTextBox.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            Model1 model = new Model1();
            Product product = new Product();

            product.Title = titleTextBox.Text;
            product.ProductTypeID = (comboBoxType.SelectedItem as ProductType).ID;
            product.Description = descriptionTextBox.Text;
            product.ArticleNumber = articleNumberTextBox.Text;
            product.MinCostForAgent = Convert.ToDecimal(minCostForAgentTextBox.Text);
            product.ProductionPersonCount = Convert.ToInt32(productionPersonCountTextBox.Text);
            product.ProductionWorkshopNumber = Convert.ToInt32(productionWorkshopNumberTextBox.Text);
            product.Image = _imagePath;
            model.Product.Add(product);

            try 
            { 
                model.SaveChanges(); 
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Сохранено");
            comboBoxType.Text = "";
            titleTextBox.Text = "";
            pictureBox1.Image = null;
            descriptionTextBox.Text = "";
            articleNumberTextBox.Text = "";
            minCostForAgentTextBox.Text = "";
            productionPersonCountTextBox.Text = "";
            productionWorkshopNumberTextBox.Text = "";
            MainForm form1 = new MainForm();
            form1.Show();
            Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
