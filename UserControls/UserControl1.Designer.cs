namespace Lopush.UserControls
{
    partial class UserControl1
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDLabel2;
            System.Windows.Forms.Label minCostForAgentLabel2;
            System.Windows.Forms.Label titleLabel2;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iDLabel3 = new System.Windows.Forms.Label();
            this.minCostForAgentLabel3 = new System.Windows.Forms.Label();
            this.titleLabel3 = new System.Windows.Forms.Label();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            iDLabel2 = new System.Windows.Forms.Label();
            minCostForAgentLabel2 = new System.Windows.Forms.Label();
            titleLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel2
            // 
            iDLabel2.AutoSize = true;
            iDLabel2.Location = new System.Drawing.Point(248, 20);
            iDLabel2.Name = "iDLabel2";
            iDLabel2.Size = new System.Drawing.Size(48, 50);
            iDLabel2.TabIndex = 7;
            iDLabel2.Text = "ID:";
            // 
            // minCostForAgentLabel2
            // 
            minCostForAgentLabel2.AutoSize = true;
            minCostForAgentLabel2.Location = new System.Drawing.Point(248, 81);
            minCostForAgentLabel2.Name = "minCostForAgentLabel2";
            minCostForAgentLabel2.Size = new System.Drawing.Size(192, 50);
            minCostForAgentLabel2.TabIndex = 9;
            minCostForAgentLabel2.Text = "Min Cost For Agent:";
            // 
            // titleLabel2
            // 
            titleLabel2.AutoSize = true;
            titleLabel2.Location = new System.Drawing.Point(248, 142);
            titleLabel2.Name = "titleLabel2";
            titleLabel2.Size = new System.Drawing.Size(63, 50);
            titleLabel2.TabIndex = 11;
            titleLabel2.Text = "Title:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lopush.Properties.Resources.Лопушок;
            this.pictureBox1.Location = new System.Drawing.Point(30, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // iDLabel3
            // 
            this.iDLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ID", true));
            this.iDLabel3.Location = new System.Drawing.Point(437, 20);
            this.iDLabel3.Name = "iDLabel3";
            this.iDLabel3.Size = new System.Drawing.Size(100, 39);
            this.iDLabel3.TabIndex = 8;
            this.iDLabel3.Text = "label1";
            // 
            // minCostForAgentLabel3
            // 
            this.minCostForAgentLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "MinCostForAgent", true));
            this.minCostForAgentLabel3.Location = new System.Drawing.Point(437, 81);
            this.minCostForAgentLabel3.Name = "minCostForAgentLabel3";
            this.minCostForAgentLabel3.Size = new System.Drawing.Size(100, 39);
            this.minCostForAgentLabel3.TabIndex = 10;
            this.minCostForAgentLabel3.Text = "label1";
            // 
            // titleLabel3
            // 
            this.titleLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Title", true));
            this.titleLabel3.Location = new System.Drawing.Point(437, 142);
            this.titleLabel3.Name = "titleLabel3";
            this.titleLabel3.Size = new System.Drawing.Size(100, 40);
            this.titleLabel3.TabIndex = 12;
            this.titleLabel3.Text = "label1";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Lopush.DataModel.Product);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Controls.Add(iDLabel2);
            this.Controls.Add(this.iDLabel3);
            this.Controls.Add(minCostForAgentLabel2);
            this.Controls.Add(this.minCostForAgentLabel3);
            this.Controls.Add(titleLabel2);
            this.Controls.Add(this.titleLabel3);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(615, 198);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.Click += new System.EventHandler(this.UserControl1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label iDLabel3;
        private System.Windows.Forms.Label minCostForAgentLabel3;
        private System.Windows.Forms.Label titleLabel3;
    }
}
