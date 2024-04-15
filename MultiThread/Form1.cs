namespace MultiThread;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void buttonSendEmail_Click(object sender, EventArgs e)
    {
        var t = new Thread(() => sendEmail());
        t.Start();
        //sendEmail();
    }


    private void sendEmail()
    {
        for (int i = 0; i < 100; i++)
        {
            //
            Thread.Sleep(100); // 100ms => 0.1 sec - 1000ms = 1s
            //progressBar1.Value = i + 1;
            progressBar1.Invoke(() => progressBar1.Value = i + 1); //Safe Cross-Thread
        }
    }

    private void buttonShowMessage_Click(object sender, EventArgs e)
    {
        MessageBox.Show("OK");
    }

    int balance = 100;
    private void buttonRace_Click(object sender, EventArgs e)
    {
        listBoxMsg.Items.Clear();
        balance = 100;
        var rnd = new Random();
        var t1 = new Thread(() => updateBalance(10, rnd.Next(1000)));
        var t2 = new Thread(() => updateBalance(-50, rnd.Next(1000)));
        var t3 = new Thread(() => updateBalance(20, rnd.Next(1000)));
        t1.Start();
        t2.Start();
        t3.Start();
    }


    private void updateBalance(int amount, int delay)
    {
        //

        //Critical region
        var newBalance = balance + amount;
        Thread.Sleep(delay);
        listBoxMsg.Invoke(() => listBoxMsg.Items.Add($"balance: {balance} -> {newBalance}"));
        balance = newBalance;


    }
}
