namespace App05
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonCategory = new Button();
            buttonProductList = new Button();
            button1 = new Button();
            buttonStackGeneric = new Button();
            SuspendLayout();
            // 
            // buttonCategory
            // 
            buttonCategory.Location = new Point(12, 12);
            buttonCategory.Name = "buttonCategory";
            buttonCategory.Size = new Size(194, 23);
            buttonCategory.TabIndex = 0;
            buttonCategory.Text = "Category List";
            buttonCategory.UseVisualStyleBackColor = true;
            buttonCategory.Click += buttonCategory_Click;
            // 
            // buttonProductList
            // 
            buttonProductList.Location = new Point(12, 41);
            buttonProductList.Name = "buttonProductList";
            buttonProductList.Size = new Size(194, 23);
            buttonProductList.TabIndex = 1;
            buttonProductList.Text = "Product List";
            buttonProductList.UseVisualStyleBackColor = true;
            buttonProductList.Click += buttonProductList_Click;
            // 
            // button1
            // 
            button1.Location = new Point(663, 12);
            button1.Name = "button1";
            button1.Size = new Size(125, 23);
            button1.TabIndex = 2;
            button1.Text = "Stack Int";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonStackGeneric
            // 
            buttonStackGeneric.Location = new Point(663, 41);
            buttonStackGeneric.Name = "buttonStackGeneric";
            buttonStackGeneric.Size = new Size(125, 23);
            buttonStackGeneric.TabIndex = 3;
            buttonStackGeneric.Text = "Stack Generic";
            buttonStackGeneric.UseVisualStyleBackColor = true;
            buttonStackGeneric.Click += buttonStackGeneric_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonStackGeneric);
            Controls.Add(button1);
            Controls.Add(buttonProductList);
            Controls.Add(buttonCategory);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCategory;
        private Button buttonProductList;
        private Button button1;
        private Button buttonStackGeneric;
    }
}
