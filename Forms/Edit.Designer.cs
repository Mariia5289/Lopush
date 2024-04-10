namespace Lopush.Forms
{
    partial class Edit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label minCostForAgentLabel;
            System.Windows.Forms.Label productionPersonCountLabel;
            System.Windows.Forms.Label productionWorkshopNumberLabel;
            System.Windows.Forms.Label productTypeIDLabel;
            System.Windows.Forms.Label titleLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.minCostForAgentTextBox = new System.Windows.Forms.TextBox();
            this.productionPersonCountTextBox = new System.Windows.Forms.TextBox();
            this.productionWorkshopNumberTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.buttonCh = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.productTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            descriptionLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            minCostForAgentLabel = new System.Windows.Forms.Label();
            productionPersonCountLabel = new System.Windows.Forms.Label();
            productionWorkshopNumberLabel = new System.Windows.Forms.Label();
            productTypeIDLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Gabriola", 15.75F);
            descriptionLabel.Location = new System.Drawing.Point(49, 295);
            descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(124, 50);
            descriptionLabel.TabIndex = 1;
            descriptionLabel.Text = "Description:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Gabriola", 15.75F);
            iDLabel.Location = new System.Drawing.Point(49, 73);
            iDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(48, 50);
            iDLabel.TabIndex = 3;
            iDLabel.Text = "ID:";
            // 
            // minCostForAgentLabel
            // 
            minCostForAgentLabel.AutoSize = true;
            minCostForAgentLabel.Font = new System.Drawing.Font("Gabriola", 15.75F);
            minCostForAgentLabel.Location = new System.Drawing.Point(49, 130);
            minCostForAgentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            minCostForAgentLabel.Name = "minCostForAgentLabel";
            minCostForAgentLabel.Size = new System.Drawing.Size(192, 50);
            minCostForAgentLabel.TabIndex = 7;
            minCostForAgentLabel.Text = "Min Cost For Agent:";
            // 
            // productionPersonCountLabel
            // 
            productionPersonCountLabel.AutoSize = true;
            productionPersonCountLabel.Font = new System.Drawing.Font("Gabriola", 15.75F);
            productionPersonCountLabel.Location = new System.Drawing.Point(440, 69);
            productionPersonCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            productionPersonCountLabel.Name = "productionPersonCountLabel";
            productionPersonCountLabel.Size = new System.Drawing.Size(239, 50);
            productionPersonCountLabel.TabIndex = 9;
            productionPersonCountLabel.Text = "Production Person Count:";
            // 
            // productionWorkshopNumberLabel
            // 
            productionWorkshopNumberLabel.AutoSize = true;
            productionWorkshopNumberLabel.Font = new System.Drawing.Font("Gabriola", 15.75F);
            productionWorkshopNumberLabel.Location = new System.Drawing.Point(440, 126);
            productionWorkshopNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            productionWorkshopNumberLabel.Name = "productionWorkshopNumberLabel";
            productionWorkshopNumberLabel.Size = new System.Drawing.Size(285, 50);
            productionWorkshopNumberLabel.TabIndex = 11;
            productionWorkshopNumberLabel.Text = "Production Workshop Number:";
            // 
            // productTypeIDLabel
            // 
            productTypeIDLabel.AutoSize = true;
            productTypeIDLabel.Font = new System.Drawing.Font("Gabriola", 15.75F);
            productTypeIDLabel.Location = new System.Drawing.Point(49, 356);
            productTypeIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            productTypeIDLabel.Name = "productTypeIDLabel";
            productTypeIDLabel.Size = new System.Drawing.Size(161, 50);
            productTypeIDLabel.TabIndex = 13;
            productTypeIDLabel.Text = "Product Type ID:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Gabriola", 15.75F);
            titleLabel.Location = new System.Drawing.Point(49, 235);
            titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(63, 50);
            titleLabel.TabIndex = 15;
            titleLabel.Text = "Title:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Description", true));
            this.descriptionTextBox.Font = new System.Drawing.Font("Gabriola", 15.75F);
            this.descriptionTextBox.Location = new System.Drawing.Point(271, 290);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(324, 52);
            this.descriptionTextBox.TabIndex = 2;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Lopush.DataModel.Product);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ID", true));
            this.iDTextBox.Font = new System.Drawing.Font("Gabriola", 15.75F);
            this.iDTextBox.Location = new System.Drawing.Point(271, 68);
            this.iDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(140, 52);
            this.iDTextBox.TabIndex = 4;
            // 
            // minCostForAgentTextBox
            // 
            this.minCostForAgentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "MinCostForAgent", true));
            this.minCostForAgentTextBox.Font = new System.Drawing.Font("Gabriola", 15.75F);
            this.minCostForAgentTextBox.Location = new System.Drawing.Point(271, 126);
            this.minCostForAgentTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.minCostForAgentTextBox.Name = "minCostForAgentTextBox";
            this.minCostForAgentTextBox.Size = new System.Drawing.Size(140, 52);
            this.minCostForAgentTextBox.TabIndex = 8;
            // 
            // productionPersonCountTextBox
            // 
            this.productionPersonCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductionPersonCount", true));
            this.productionPersonCountTextBox.Font = new System.Drawing.Font("Gabriola", 15.75F);
            this.productionPersonCountTextBox.Location = new System.Drawing.Point(759, 64);
            this.productionPersonCountTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.productionPersonCountTextBox.Name = "productionPersonCountTextBox";
            this.productionPersonCountTextBox.Size = new System.Drawing.Size(140, 52);
            this.productionPersonCountTextBox.TabIndex = 10;
            // 
            // productionWorkshopNumberTextBox
            // 
            this.productionWorkshopNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductionWorkshopNumber", true));
            this.productionWorkshopNumberTextBox.Font = new System.Drawing.Font("Gabriola", 15.75F);
            this.productionWorkshopNumberTextBox.Location = new System.Drawing.Point(759, 121);
            this.productionWorkshopNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.productionWorkshopNumberTextBox.Name = "productionWorkshopNumberTextBox";
            this.productionWorkshopNumberTextBox.Size = new System.Drawing.Size(140, 52);
            this.productionWorkshopNumberTextBox.TabIndex = 12;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Title", true));
            this.titleTextBox.Font = new System.Drawing.Font("Gabriola", 15.75F);
            this.titleTextBox.Location = new System.Drawing.Point(271, 230);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(324, 52);
            this.titleTextBox.TabIndex = 16;
            // 
            // buttonCh
            // 
            this.buttonCh.Font = new System.Drawing.Font("Gabriola", 15.75F);
            this.buttonCh.Location = new System.Drawing.Point(638, 350);
            this.buttonCh.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCh.Name = "buttonCh";
            this.buttonCh.Size = new System.Drawing.Size(181, 53);
            this.buttonCh.TabIndex = 17;
            this.buttonCh.Text = "Изменить";
            this.buttonCh.UseVisualStyleBackColor = true;
            this.buttonCh.Click += new System.EventHandler(this.buttonCh_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Font = new System.Drawing.Font("Gabriola", 15.75F);
            this.buttonDel.Location = new System.Drawing.Point(827, 350);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(181, 53);
            this.buttonDel.TabIndex = 18;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lopush.Properties.Resources.Лопушок;
            this.pictureBox1.Location = new System.Drawing.Point(638, 217);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.DataSource = this.productTypeBindingSource;
            this.comboBoxType.DisplayMember = "Title";
            this.comboBoxType.Font = new System.Drawing.Font("Gabriola", 15.75F);
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(271, 356);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(324, 56);
            this.comboBoxType.TabIndex = 20;
            this.comboBoxType.ValueMember = "ID";
            // 
            // productTypeBindingSource
            // 
            this.productTypeBindingSource.DataSource = typeof(Lopush.DataModel.ProductType);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1021, 447);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonCh);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(minCostForAgentLabel);
            this.Controls.Add(this.minCostForAgentTextBox);
            this.Controls.Add(productionPersonCountLabel);
            this.Controls.Add(this.productionPersonCountTextBox);
            this.Controls.Add(productionWorkshopNumberLabel);
            this.Controls.Add(this.productionWorkshopNumberTextBox);
            this.Controls.Add(productTypeIDLabel);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Edit";
            this.Text = "Форма редактирования";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox minCostForAgentTextBox;
        private System.Windows.Forms.TextBox productionPersonCountTextBox;
        private System.Windows.Forms.TextBox productionWorkshopNumberTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button buttonCh;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.BindingSource productTypeBindingSource;
    }
}