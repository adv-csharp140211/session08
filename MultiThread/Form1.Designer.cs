namespace MultiThread;

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
        buttonSendEmail = new Button();
        buttonShowMessage = new Button();
        SuspendLayout();
        // 
        // buttonSendEmail
        // 
        buttonSendEmail.Location = new Point(164, 49);
        buttonSendEmail.Name = "buttonSendEmail";
        buttonSendEmail.Size = new Size(116, 34);
        buttonSendEmail.TabIndex = 0;
        buttonSendEmail.Text = "Send Email";
        buttonSendEmail.UseVisualStyleBackColor = true;
        buttonSendEmail.Click += buttonSendEmail_Click;
        // 
        // buttonShowMessage
        // 
        buttonShowMessage.Location = new Point(164, 89);
        buttonShowMessage.Name = "buttonShowMessage";
        buttonShowMessage.Size = new Size(116, 34);
        buttonShowMessage.TabIndex = 1;
        buttonShowMessage.Text = "ShowMessage";
        buttonShowMessage.UseVisualStyleBackColor = true;
        buttonShowMessage.Click += buttonShowMessage_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(782, 412);
        Controls.Add(buttonShowMessage);
        Controls.Add(buttonSendEmail);
        Name = "Form1";
        Text = "Multi Thread";
        ResumeLayout(false);
    }

    #endregion

    private Button buttonSendEmail;
    private Button buttonShowMessage;
}
