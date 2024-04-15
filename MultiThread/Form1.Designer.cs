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
        progressBar1 = new ProgressBar();
        buttonRace = new Button();
        listBoxMsg = new ListBox();
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
        // progressBar1
        // 
        progressBar1.Location = new Point(286, 60);
        progressBar1.Name = "progressBar1";
        progressBar1.Size = new Size(484, 23);
        progressBar1.TabIndex = 2;
        // 
        // buttonRace
        // 
        buttonRace.Location = new Point(164, 201);
        buttonRace.Name = "buttonRace";
        buttonRace.Size = new Size(116, 40);
        buttonRace.TabIndex = 3;
        buttonRace.Text = "Race Condition";
        buttonRace.UseVisualStyleBackColor = true;
        buttonRace.Click += buttonRace_Click;
        // 
        // listBoxMsg
        // 
        listBoxMsg.FormattingEnabled = true;
        listBoxMsg.ItemHeight = 15;
        listBoxMsg.Location = new Point(286, 201);
        listBoxMsg.Name = "listBoxMsg";
        listBoxMsg.Size = new Size(239, 169);
        listBoxMsg.TabIndex = 4;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(782, 412);
        Controls.Add(listBoxMsg);
        Controls.Add(buttonRace);
        Controls.Add(progressBar1);
        Controls.Add(buttonShowMessage);
        Controls.Add(buttonSendEmail);
        Name = "Form1";
        Text = "Multi Thread";
        ResumeLayout(false);
    }

    #endregion

    private Button buttonSendEmail;
    private Button buttonShowMessage;
    private ProgressBar progressBar1;
    private Button buttonRace;
    private ListBox listBoxMsg;
}
