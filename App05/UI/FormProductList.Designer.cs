namespace App05.UI
{
    partial class FormProductList
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
            dataGridView1 = new DataGridView();
            buttonNew = new Button();
            comboBoxCategories = new ComboBox();
            label1 = new Label();
            textBoxFrom = new TextBox();
            textBoxTo = new TextBox();
            label2 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(881, 349);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonNew
            // 
            buttonNew.Location = new Point(12, 12);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(101, 23);
            buttonNew.TabIndex = 1;
            buttonNew.Text = "New Product";
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += buttonNew_Click;
            // 
            // comboBoxCategories
            // 
            comboBoxCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategories.FormattingEnabled = true;
            comboBoxCategories.Location = new Point(654, 12);
            comboBoxCategories.Name = "comboBoxCategories";
            comboBoxCategories.Size = new Size(239, 23);
            comboBoxCategories.TabIndex = 2;
            comboBoxCategories.SelectedIndexChanged += comboBoxCategories_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(577, 17);
            label1.Name = "label1";
            label1.Size = new Size(15, 15);
            label1.TabIndex = 3;
            label1.Text = "از";
            // 
            // textBoxFrom
            // 
            textBoxFrom.Location = new Point(471, 13);
            textBoxFrom.Name = "textBoxFrom";
            textBoxFrom.Size = new Size(100, 23);
            textBoxFrom.TabIndex = 4;
            textBoxFrom.TextChanged += textBoxFrom_TextChanged;
            // 
            // textBoxTo
            // 
            textBoxTo.Location = new Point(347, 14);
            textBoxTo.Name = "textBoxTo";
            textBoxTo.Size = new Size(100, 23);
            textBoxTo.TabIndex = 6;
            textBoxTo.TextChanged += textBoxTo_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(453, 18);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 5;
            label2.Text = "تا";
            // 
            // button1
            // 
            button1.Location = new Point(266, 14);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox1);
            panel1.Location = new Point(12, 396);
            panel1.Name = "panel1";
            panel1.Size = new Size(881, 52);
            panel1.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(748, 13);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            // 
            // FormProductList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 454);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(textBoxTo);
            Controls.Add(label2);
            Controls.Add(textBoxFrom);
            Controls.Add(label1);
            Controls.Add(comboBoxCategories);
            Controls.Add(buttonNew);
            Controls.Add(dataGridView1);
            Name = "FormProductList";
            Text = "FormProductList";
            Load += FormProductList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonNew;
        private ComboBox comboBoxCategories;
        private Label label1;
        private TextBox textBoxFrom;
        private TextBox textBoxTo;
        private Label label2;
        private Button button1;
        private Panel panel1;
        private ComboBox comboBox1;
    }
}