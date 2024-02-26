namespace App05.UI
{
    partial class FormProduct
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
            buttonSave = new Button();
            textBoxDescription = new TextBox();
            textBoxName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            comboBoxCategory = new ComboBox();
            label3 = new Label();
            textBoxPrice = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(435, 132);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "ذخیره";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(100, 41);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(410, 23);
            textBoxDescription.TabIndex = 9;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(100, 12);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(410, 23);
            textBoxName.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 44);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 7;
            label2.Text = "شرح";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 15);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 6;
            label1.Text = "نام";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(100, 99);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(410, 23);
            comboBoxCategory.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 107);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 12;
            label3.Text = "دسته";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(100, 70);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(410, 23);
            textBoxPrice.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 73);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 13;
            label4.Text = "قیمت";
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 182);
            Controls.Add(textBoxPrice);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBoxCategory);
            Controls.Add(buttonSave);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormProduct";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "FormProduct";
            Load += FormProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private TextBox textBoxDescription;
        private TextBox textBoxName;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxCategory;
        private Label label3;
        private TextBox textBoxPrice;
        private Label label4;
    }
}