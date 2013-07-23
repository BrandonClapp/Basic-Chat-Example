using System;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Threading;

namespace ChatClient
{
    public partial class ChatForm : Form
    {
        private TcpClient client;

        public ChatForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            string host = this.HostTextBox.Text;
            int port;
            if (int.TryParse(this.PortTextBox.Text, out port))
            {
                try
                {
                    client = new TcpClient(host, port);
                    StreamReader reader = new StreamReader(client.GetStream());
                    new Thread(() =>
                    {
                        while (true)
                        {
                            var line = reader.ReadLine();
                            this.ChatTextBox.Invoke(new MethodInvoker(() =>
                                this.ChatTextBox.Text += line + "\r\n"));
                        }
                    }).Start();
                }
                catch
                {
                    MessageBox.Show("Could not connect.");
                }
            }
        }

        private void SendTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                StreamWriter writer = new StreamWriter(client.GetStream());
                writer.WriteLine(this.UserNameTextBox.Text + ": " + this.SendTextBox.Text);
                this.SendTextBox.Text = "";
                writer.Flush();
            }
        }
    }
}
