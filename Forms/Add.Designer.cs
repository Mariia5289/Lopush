namespace Lopush.Forms
{
    partial class Add
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
            System.Windows.Forms.Label articleNumberLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label minCostForAgentLabel;
            System.Windows.Forms.Label productionPersonCountLabel;
            System.Windows.Forms.Label productionWorkshopNumberLabel;
            System.Windows.Forms.Label productTypeIDLabel;
            System.Windows.Forms.Label titleLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articleNumberTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.minCostForAgentTextBox = new System.Windows.Forms.TextBox();
            this.productionPersonCountTextBox = new System.Windows.Forms.TextBox();
            this.productionWorkshopNumberTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.productTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            articleNumberLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
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
            // articleNumberLabel
            // 
            articleNumberLabel.AutoSize = true;
            articleNumberLabel.Font = new System.Drawing.Font("Gabriola", 15.75F);
            articleNumberLabel.Location = new System.Drawing.Point(389, 32);
            articleNumberLabel.Name = "articleNumberLabel";
            articleNumberLabel.Size = new System.Drawing.Size(106, 50);
            articleNumberLabel.TabIndex = 1;
            articleNumberLabel.Text = "Артикул:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Gabriola", 15.75F);
            descriptionLabel.Location = new System.Drawing.Point(39, 98);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(113, 50);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Описание:";
            // 
            // minCostForAgentLabel
            // 
            minCostForAgentLabel.AutoSize = true;
            minCostForAgentLabel.Font = new System.Drawing.Font("Gabriola", 15.75F);
            minCostForAgentLabel.Location = new System.Drawing.Point(412, 204);
            minCostForAgentLabel.Name = "minCostForAgentLabel";
            minCostForAgentLabel.Size = new System.Drawing.Size(352, 50);
            minCostForAgentLabel.TabIndex = 7;
            minCostForAgentLabel.Text = "Минимальная стоимость для агента";
            // 
            // productionPersonCountLabel
            // 
            productionPersonCountLabel.AutoSize = true;
            productionPersonCountLabel.Font = new System.Drawing.Font("Gabriola", 15.75F);
            productionPersonCountLabel.Location = new System.Drawing.Point(412, 277);
            productionPersonCountLabel.Name = "productionPersonCountLabel";
            productionPersonCountLabel.Size = new System.Drawing.Size(367, 50);
            productionPersonCountLabel.TabIndex = 9;
            productionPersonCountLabel.Text = "Количество человек для производства:";
            // 
            // productionWorkshopNumberLabel
            // 
            productionWorkshopNumberLabel.AutoSize = true;
            productionWorkshopNumberLabel.Font = new System.Drawing.Font("Gabriola", 15.75F);
            productionWorkshopNumberLabel.Location = new System.Drawing.Point(412, 350);
            productionWorkshopNumberLabel.Name = "productionWorkshopNumberLabel";
            productionWorkshopNumberLabel.Size = new System.Drawing.Size(293, 50);
            productionWorkshopNumberLabel.TabIndex = 11;
            productionWorkshopNumberLabel.Text = "Номер цеха для производства:";
            // 
            // productTypeIDLabel
            // 
            productTypeIDLabel.AutoSize = true;
            productTypeIDLabel.Font = new System.Drawing.Font("Gabriola", 15.75F);
            productTypeIDLabel.Location = new System.Drawing.Point(733, 32);
            productTypeIDLabel.Name = "productTypeIDLabel";
            productTypeIDLabel.Size = new System.Drawing.Size(85, 50);
            productTypeIDLabel.TabIndex = 13;
            productTypeIDLabel.Text = "Тип ID:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Gabriola", 15.75F);
            titleLabel.Location = new System.Drawing.Point(44, 32);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(112, 50);
            titleLabel.TabIndex = 15;
            titleLabel.Text = "Название:";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Lopush.DataModel.Product);
            // 
            // articleNumberTextBox
            // 
            this.articleNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ArticleNumber", true));
            this.articleNumberTextBox.Font = new System.Drawing.Font("Gabriola", 15.75F);
            this.articleNumberTextBox.Location = new System.Drawing.Point(501, 29);
            this.articleNumberTextBox.Name = "articleNumberTextBox";
            this.articleNumberTextBox.Size = new System.Drawing.Size(215, 52);
            this.articleNumberTextBox.TabIndex = 2;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Description", true));
            this.descriptionTextBox.Font = new System.Drawing.Font("Gabriola", 15.75F);
            this.descriptionTextBox.Location = new System.Drawing.Point(204, 95);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(512, 52);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // minCostForAgentTextBox
            // 
            this.minCostForAgentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "MinCostForAgent", true));
            this.minCostForAgentTextBox.Font = new System.Drawing.Font("Gabriola", 15.75F);
            this.minCostForAgentTextBox.Location = new System.Drawing.Point(785, 209);
            this.minCostForAgentTextBox.Name = "minCostForAgentTextBox";
            this.minCostForAgentTextBox.Size = new System.Drawing.Size(224, 52);
            this.minCostForAgentTextBox.TabIndex = 8;
            // 
            // productionPersonCountTextBox
            // 
            this.productionPersonCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductionPersonCount", true));
            this.productionPersonCountTextBox.Font = new System.Drawing.Font("Gabriola", 15.75F);
            this.productionPersonCountTextBox.Location = new System.Drawing.Point(785, 284);
            this.productionPersonCountTextBox.Name = "productionPersonCountTextBox";
            this.productionPersonCountTextBox.Size = new System.Drawing.Size(224, 52);
            this.productionPersonCountTextBox.TabIndex = 10;
            // 
            // productionWorkshopNumberTextBox
            // 
            this.productionWorkshopNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductionWorkshopNumber", true));
            this.productionWorkshopNumberTextBox.Font = new System.Drawing.Font("Gabriola", 15.75F);
            this.productionWorkshopNumberTextBox.Location = new System.Drawing.Point(785, 359);
            this.productionWorkshopNumberTextBox.Name = "productionWorkshopNumberTextBox";
            this.productionWorkshopNumberTextBox.Size = new System.Drawing.Size(224, 52);
            this.productionWorkshopNumberTextBox.TabIndex = 12;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Title", true));
            this.titleTextBox.Font = new System.Drawing.Font("Gabriola", 15.75F);
            this.titleTextBox.Location = new System.Drawing.Point(204, 29);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(170, 52);
            this.titleTextBox.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Lopush.Properties.Resources.Лопушок;
            this.pictureBox1.Location = new System.Drawing.Point(48, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(48, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 56);
            this.button1.TabIndex = 18;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.DataSource = this.productTypeBindingSource;
            this.comboBoxType.DisplayMember = "Title";
            this.comboBoxType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxType.Font = new System.Drawing.Font("Gabriola", 15.75F);
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(824, 29);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(185, 56);
            this.comboBoxType.TabIndex = 19;
            this.comboBoxType.ValueMember = "ID";
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // productTypeBindingSource
            // 
            this.productTypeBindingSource.DataSource = typeof(Lopush.DataModel.ProductType);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1054, 483);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(articleNumberLabel);
            this.Controls.Add(this.articleNumberTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
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
            this.Name = "Add";
            this.Text = "Форма добавления";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.TextBox articleNumberTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox minCostForAgentTextBox;
        private System.Windows.Forms.TextBox productionPersonCountTextBox;
        private System.Windows.Forms.TextBox productionWorkshopNumberTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.BindingSource productTypeBindingSource;
    }
}