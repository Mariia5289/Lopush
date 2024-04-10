using Lopush.DataModel;
using Lopush.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lopush.UserControls
{
    public partial class UserControl1 : UserControl
    {
        private Product _product;
        private Model1 _model;
        public UserControl1(Product product, Model1 model)
        {
            InitializeComponent();
            Fill( product);
            _model = model;
        }

        private void Fill(Product product)
        {
            _product = product;
                        iDLabel3.Text = product.ID.ToString();
            titleLabel3.Text = product.Title.ToString();
            minCostForAgentLabel3.Text = product.MinCostForAgent.ToString();
            try
            {
                pictureBox1.Image = Image.FromFile(product.Image);

            }
            catch 
            {
                pictureBox1.Image = Properties.Resources.Лопушок;
            }

        }
       

        private void iDLabel1_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_Click(object sender, EventArgs e)
        {
            Edit form2 = new Edit(_product, _model);
                form2.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
