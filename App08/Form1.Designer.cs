﻿namespace app07
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
            buttonGenericRepo = new Button();
            buttonGenericRepositoryNew = new Button();
            buttonReflection = new Button();
            buttonRegister = new Button();
            buttonLogin = new Button();
            buttonPermissions = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelUserInfo = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
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
            // buttonGenericRepo
            // 
            buttonGenericRepo.Location = new Point(290, 224);
            buttonGenericRepo.Name = "buttonGenericRepo";
            buttonGenericRepo.Size = new Size(156, 23);
            buttonGenericRepo.TabIndex = 4;
            buttonGenericRepo.Text = " Generic Repo";
            buttonGenericRepo.UseVisualStyleBackColor = true;
            buttonGenericRepo.Click += buttonGenericRepo_Click;
            // 
            // buttonGenericRepositoryNew
            // 
            buttonGenericRepositoryNew.Location = new Point(290, 253);
            buttonGenericRepositoryNew.Name = "buttonGenericRepositoryNew";
            buttonGenericRepositoryNew.Size = new Size(156, 23);
            buttonGenericRepositoryNew.TabIndex = 5;
            buttonGenericRepositoryNew.Text = " Generic Repo New";
            buttonGenericRepositoryNew.UseVisualStyleBackColor = true;
            buttonGenericRepositoryNew.Click += buttonGenericRepositoryNew_Click;
            // 
            // buttonReflection
            // 
            buttonReflection.Location = new Point(290, 295);
            buttonReflection.Name = "buttonReflection";
            buttonReflection.Size = new Size(156, 23);
            buttonReflection.TabIndex = 6;
            buttonReflection.Text = "Reflection 1";
            buttonReflection.UseVisualStyleBackColor = true;
            buttonReflection.Click += buttonReflection_Click;
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(663, 224);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(125, 23);
            buttonRegister.TabIndex = 7;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(663, 253);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(125, 23);
            buttonLogin.TabIndex = 8;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonPermissions
            // 
            buttonPermissions.Location = new Point(663, 282);
            buttonPermissions.Name = "buttonPermissions";
            buttonPermissions.Size = new Size(125, 23);
            buttonPermissions.TabIndex = 9;
            buttonPermissions.Text = "Permissions";
            buttonPermissions.UseVisualStyleBackColor = true;
            buttonPermissions.Click += buttonPermissions_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelUserInfo });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 10;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelUserInfo
            // 
            toolStripStatusLabelUserInfo.Name = "toolStripStatusLabelUserInfo";
            toolStripStatusLabelUserInfo.Size = new Size(156, 17);
            toolStripStatusLabelUserInfo.Text = "toolStripStatusLabelUserInfo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(buttonPermissions);
            Controls.Add(buttonLogin);
            Controls.Add(buttonRegister);
            Controls.Add(buttonReflection);
            Controls.Add(buttonGenericRepositoryNew);
            Controls.Add(buttonGenericRepo);
            Controls.Add(buttonStackGeneric);
            Controls.Add(button1);
            Controls.Add(buttonProductList);
            Controls.Add(buttonCategory);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCategory;
        private Button buttonProductList;
        private Button button1;
        private Button buttonStackGeneric;
        private Button buttonGenericRepo;
        private Button buttonGenericRepositoryNew;
        private Button buttonReflection;
        private Button buttonRegister;
        private Button buttonLogin;
        private Button buttonPermissions;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelUserInfo;
    }
}
