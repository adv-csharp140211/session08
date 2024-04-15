namespace app07.UI
{
    partial class FormPermission
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
            comboBoxRoles = new ComboBox();
            listBoxForms = new ListBox();
            label2 = new Label();
            checkedListBoxButtons = new CheckedListBox();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 29);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "Role";
            // 
            // comboBoxRoles
            // 
            comboBoxRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRoles.FormattingEnabled = true;
            comboBoxRoles.Location = new Point(64, 26);
            comboBoxRoles.Name = "comboBoxRoles";
            comboBoxRoles.Size = new Size(506, 23);
            comboBoxRoles.TabIndex = 1;
            // 
            // listBoxForms
            // 
            listBoxForms.FormattingEnabled = true;
            listBoxForms.ItemHeight = 15;
            listBoxForms.Location = new Point(64, 70);
            listBoxForms.Name = "listBoxForms";
            listBoxForms.Size = new Size(220, 379);
            listBoxForms.TabIndex = 2;
            listBoxForms.SelectedIndexChanged += listBoxForms_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 70);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Forms";
            // 
            // checkedListBoxButtons
            // 
            checkedListBoxButtons.FormattingEnabled = true;
            checkedListBoxButtons.Location = new Point(290, 70);
            checkedListBoxButtons.Name = "checkedListBoxButtons";
            checkedListBoxButtons.Size = new Size(280, 382);
            checkedListBoxButtons.TabIndex = 4;
            checkedListBoxButtons.ItemCheck += checkedListBoxButtons_ItemCheck;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(459, 458);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(111, 23);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // FormPermission
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 505);
            Controls.Add(buttonSave);
            Controls.Add(checkedListBoxButtons);
            Controls.Add(label2);
            Controls.Add(listBoxForms);
            Controls.Add(comboBoxRoles);
            Controls.Add(label1);
            Name = "FormPermission";
            Text = "FormPermission";
            Load += FormPermission_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxRoles;
        private ListBox listBoxForms;
        private Label label2;
        private CheckedListBox checkedListBoxButtons;
        private Button buttonSave;
    }
}