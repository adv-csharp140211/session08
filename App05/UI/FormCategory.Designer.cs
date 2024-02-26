namespace App05.UI
{
    partial class FormCategory
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
            label1 = new Label();
            label2 = new Label();
            textBoxName = new TextBox();
            textBoxDescription = new TextBox();
            buttonSave = new Button();
            checkBoxIsActive = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 47);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "نام";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 76);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 1;
            label2.Text = "شرح";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(140, 44);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(410, 23);
            textBoxName.TabIndex = 2;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(140, 73);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(410, 23);
            textBoxDescription.TabIndex = 3;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(475, 135);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "ذخیره";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // checkBoxIsActive
            // 
            checkBoxIsActive.AutoSize = true;
            checkBoxIsActive.Location = new Point(140, 102);
            checkBoxIsActive.Name = "checkBoxIsActive";
            checkBoxIsActive.Size = new Size(50, 19);
            checkBoxIsActive.TabIndex = 5;
            checkBoxIsActive.Text = "فعال";
            checkBoxIsActive.UseVisualStyleBackColor = true;
            // 
            // FormCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 179);
            Controls.Add(checkBoxIsActive);
            Controls.Add(buttonSave);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCategory";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "FormCategory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxName;
        private TextBox textBoxDescription;
        private Button buttonSave;
        private CheckBox checkBoxIsActive;
    }
}