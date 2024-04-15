namespace MultiThread;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void buttonSendEmail_Click(object sender, EventArgs e)
    {
        sendEmail();
    }


    private void sendEmail()
    {
        for (int i = 0; i < 100; i++)
        {
            //
            Thread.Sleep(100); // 100ms => 0.1 sec - 1000ms = 1s
        }
    }

    private void buttonShowMessage_Click(object sender, EventArgs e)
    {
        MessageBox.Show("OK");
    }
}
