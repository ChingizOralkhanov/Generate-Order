namespace Generate_Order
{
    partial class CreateProductForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProductLabel = new System.Windows.Forms.Label();
            this.ProductDropDown1 = new System.Windows.Forms.ComboBox();
            this.AmountTextBox1 = new System.Windows.Forms.TextBox();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.addToDbButton = new System.Windows.Forms.Button();
            this.ProductDropDown2 = new System.Windows.Forms.ComboBox();
            this.ProductDropDown3 = new System.Windows.Forms.ComboBox();
            this.AmountTextBox2 = new System.Windows.Forms.TextBox();
            this.AmountTextBox3 = new System.Windows.Forms.TextBox();
            this.AmountTextBox4 = new System.Windows.Forms.TextBox();
            this.ProductDropDown4 = new System.Windows.Forms.ComboBox();
            this.ProductDropDown5 = new System.Windows.Forms.ComboBox();
            this.AmountTextBox5 = new System.Windows.Forms.TextBox();
            this.getAllProductsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Location = new System.Drawing.Point(37, 54);
            this.ProductLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(104, 20);
            this.ProductLabel.TabIndex = 0;
            this.ProductLabel.Text = "Select Product";
            // 
            // ProductDropDown1
            // 
            this.ProductDropDown1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductDropDown1.Items.AddRange(new object[] {
            "AllergyScreen Panel 1",
            "AllergyScreen Panel 2",
            "AllergyScreen Panel 3",
            "AllergyScreen Panel 4",
            "Qline Panel 1",
            "Qline Panel 2",
            "Qline Panel 3",
            "Qline Panel 4"});
            this.ProductDropDown1.Location = new System.Drawing.Point(41, 78);
            this.ProductDropDown1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductDropDown1.Name = "ProductDropDown1";
            this.ProductDropDown1.Size = new System.Drawing.Size(255, 28);
            this.ProductDropDown1.TabIndex = 1;
            // 
            // AmountTextBox1
            // 
            this.AmountTextBox1.Location = new System.Drawing.Point(359, 79);
            this.AmountTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AmountTextBox1.Name = "AmountTextBox1";
            this.AmountTextBox1.Size = new System.Drawing.Size(132, 27);
            this.AmountTextBox1.TabIndex = 2;
            this.AmountTextBox1.Text = "0";
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(41, 282);
            this.AddProductButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(255, 35);
            this.AddProductButton.TabIndex = 3;
            this.AddProductButton.Text = "Generate Order";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(355, 55);
            this.AmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(94, 20);
            this.AmountLabel.TabIndex = 4;
            this.AmountLabel.Text = "Add Amount";
            // 
            // addToDbButton
            // 
            this.addToDbButton.Location = new System.Drawing.Point(359, 282);
            this.addToDbButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addToDbButton.Name = "addToDbButton";
            this.addToDbButton.Size = new System.Drawing.Size(132, 35);
            this.addToDbButton.TabIndex = 5;
            this.addToDbButton.Text = "Add to Database";
            this.addToDbButton.UseVisualStyleBackColor = true;
            this.addToDbButton.Click += new System.EventHandler(this.AddToDbButton_Click);
            // 
            // ProductDropDown2
            // 
            this.ProductDropDown2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductDropDown2.Items.AddRange(new object[] {
            "AllergyScreen Panel 1",
            "AllergyScreen Panel 2",
            "AllergyScreen Panel 3",
            "AllergyScreen Panel 4",
            "Qline Panel 1",
            "Qline Panel 2",
            "Qline Panel 3",
            "Qline Panel 4"});
            this.ProductDropDown2.Location = new System.Drawing.Point(41, 116);
            this.ProductDropDown2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductDropDown2.Name = "ProductDropDown2";
            this.ProductDropDown2.Size = new System.Drawing.Size(255, 28);
            this.ProductDropDown2.TabIndex = 6;
            // 
            // ProductDropDown3
            // 
            this.ProductDropDown3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductDropDown3.Items.AddRange(new object[] {
            "AllergyScreen Panel 1",
            "AllergyScreen Panel 2",
            "AllergyScreen Panel 3",
            "AllergyScreen Panel 4",
            "Qline Panel 1",
            "Qline Panel 2",
            "Qline Panel 3",
            "Qline Panel 4"});
            this.ProductDropDown3.Location = new System.Drawing.Point(41, 154);
            this.ProductDropDown3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductDropDown3.Name = "ProductDropDown3";
            this.ProductDropDown3.Size = new System.Drawing.Size(255, 28);
            this.ProductDropDown3.TabIndex = 7;
            // 
            // AmountTextBox2
            // 
            this.AmountTextBox2.Location = new System.Drawing.Point(359, 117);
            this.AmountTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AmountTextBox2.Name = "AmountTextBox2";
            this.AmountTextBox2.Size = new System.Drawing.Size(132, 27);
            this.AmountTextBox2.TabIndex = 8;
            this.AmountTextBox2.Text = "0";
            // 
            // AmountTextBox3
            // 
            this.AmountTextBox3.Location = new System.Drawing.Point(359, 155);
            this.AmountTextBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AmountTextBox3.Name = "AmountTextBox3";
            this.AmountTextBox3.Size = new System.Drawing.Size(132, 27);
            this.AmountTextBox3.TabIndex = 9;
            this.AmountTextBox3.Text = "0";
            // 
            // AmountTextBox4
            // 
            this.AmountTextBox4.Location = new System.Drawing.Point(359, 192);
            this.AmountTextBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AmountTextBox4.Name = "AmountTextBox4";
            this.AmountTextBox4.Size = new System.Drawing.Size(132, 27);
            this.AmountTextBox4.TabIndex = 10;
            this.AmountTextBox4.Text = "0";
            // 
            // ProductDropDown4
            // 
            this.ProductDropDown4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductDropDown4.Items.AddRange(new object[] {
            "AllergyScreen Panel 1",
            "AllergyScreen Panel 2",
            "AllergyScreen Panel 3",
            "AllergyScreen Panel 4",
            "Qline Panel 1",
            "Qline Panel 2",
            "Qline Panel 3",
            "Qline Panel 4"});
            this.ProductDropDown4.Location = new System.Drawing.Point(41, 192);
            this.ProductDropDown4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductDropDown4.Name = "ProductDropDown4";
            this.ProductDropDown4.Size = new System.Drawing.Size(255, 28);
            this.ProductDropDown4.TabIndex = 11;
            // 
            // ProductDropDown5
            // 
            this.ProductDropDown5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductDropDown5.Items.AddRange(new object[] {
            "AllergyScreen Panel 1",
            "AllergyScreen Panel 2",
            "AllergyScreen Panel 3",
            "AllergyScreen Panel 4",
            "Qline Panel 1",
            "Qline Panel 2",
            "Qline Panel 3",
            "Qline Panel 4"});
            this.ProductDropDown5.Location = new System.Drawing.Point(41, 230);
            this.ProductDropDown5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductDropDown5.Name = "ProductDropDown5";
            this.ProductDropDown5.Size = new System.Drawing.Size(255, 28);
            this.ProductDropDown5.TabIndex = 12;
            // 
            // AmountTextBox5
            // 
            this.AmountTextBox5.Location = new System.Drawing.Point(359, 229);
            this.AmountTextBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AmountTextBox5.Name = "AmountTextBox5";
            this.AmountTextBox5.Size = new System.Drawing.Size(132, 27);
            this.AmountTextBox5.TabIndex = 13;
            this.AmountTextBox5.Text = "0";
            // 
            // getAllProductsButton
            // 
            this.getAllProductsButton.Location = new System.Drawing.Point(41, 347);
            this.getAllProductsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.getAllProductsButton.Name = "getAllProductsButton";
            this.getAllProductsButton.Size = new System.Drawing.Size(450, 35);
            this.getAllProductsButton.TabIndex = 14;
            this.getAllProductsButton.Text = "Get All Products";
            this.getAllProductsButton.UseVisualStyleBackColor = true;
            this.getAllProductsButton.Click += new System.EventHandler(this.GetAllProductsButton_Click);
            // 
            // CreateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(561, 456);
            this.Controls.Add(this.getAllProductsButton);
            this.Controls.Add(this.AmountTextBox5);
            this.Controls.Add(this.ProductDropDown5);
            this.Controls.Add(this.ProductDropDown4);
            this.Controls.Add(this.AmountTextBox4);
            this.Controls.Add(this.AmountTextBox3);
            this.Controls.Add(this.AmountTextBox2);
            this.Controls.Add(this.ProductDropDown3);
            this.Controls.Add(this.ProductDropDown2);
            this.Controls.Add(this.addToDbButton);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.AmountTextBox1);
            this.Controls.Add(this.ProductDropDown1);
            this.Controls.Add(this.ProductLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.ComboBox ProductDropDown1;
        private System.Windows.Forms.TextBox AmountTextBox1;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Button addToDbButton;
        private System.Windows.Forms.ComboBox ProductDropDown2;
        private System.Windows.Forms.ComboBox ProductDropDown3;
        private System.Windows.Forms.TextBox AmountTextBox2;
        private System.Windows.Forms.TextBox AmountTextBox3;
        private System.Windows.Forms.TextBox AmountTextBox4;
        private System.Windows.Forms.ComboBox ProductDropDown4;
        private System.Windows.Forms.ComboBox ProductDropDown5;
        private System.Windows.Forms.TextBox AmountTextBox5;
        private System.Windows.Forms.Button getAllProductsButton;
    }
}

