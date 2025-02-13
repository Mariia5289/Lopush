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

namespace Lopush.Forms
{
    public partial class Edit : Form
    {
        private Product _product;

        private Model1 _model;

        private string _imagePath;
        public Edit(Product product, Model1 model)
        {
            InitializeComponent();
            _product = product;
            _model = model;
            List<ProductType> pt = _model.ProductType.ToList();
            productTypeBindingSource.DataSource = pt;
            comboBoxType.SelectedIndex = 0;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            productBindingSource.DataSource = _product;
        }

        private void pictureBox1_Click(object sender, EventArgs e)//изображение
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

        private void buttonCh_Click(object sender, EventArgs e)//Изменение
        {
            if (String.IsNullOrWhiteSpace(comboBoxType.Text) || String.IsNullOrWhiteSpace(titleTextBox.Text)
               || String.IsNullOrWhiteSpace(iDTextBox.Text) || String.IsNullOrWhiteSpace(minCostForAgentTextBox.Text)
               || String.IsNullOrWhiteSpace(productionPersonCountTextBox.Text) || String.IsNullOrWhiteSpace(productionWorkshopNumberTextBox.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            _product.Title = titleTextBox.Text;
            _product.ProductTypeID = (comboBoxType.SelectedItem as ProductType).ID;
            _product.Description = descriptionTextBox.Text;
            _product.MinCostForAgent = Convert.ToDecimal(minCostForAgentTextBox.Text);
            _product.ProductionPersonCount = Convert.ToInt32(productionPersonCountTextBox.Text);
            _product.ProductionWorkshopNumber = Convert.ToInt32(productionWorkshopNumberTextBox.Text);
            _product.Image = _imagePath;

            _model.SaveChanges();
            MessageBox.Show("Данные успешно изменены!");
            this.Close();
        }

        private void buttonDel_Click(object sender, EventArgs e)//Удаление
        {
            _model.Product.Remove(_product);
            MessageBox.Show($"Продукт {titleTextBox.Text} успешно удален!");
            _model.SaveChanges();
            this.Close();
        }
    }
}
