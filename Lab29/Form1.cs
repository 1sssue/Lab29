using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab29
{
    public partial class Form1 : Form
    {
        bool alive = false;
        UdpClient client;
        int LOCALPORT = 8001;
        int REMOTEPORT = 8001;
        int TTL = 20;
        string HOST = "235.5.5.1";
        IPAddress groupAddress;
        string? userName;

        public Form1()
        {
            InitializeComponent();
            loginButton.Enabled = true;
            logoutButton.Enabled = false;
            sendButton.Enabled = false;
            chatTextBox.ReadOnly = true;
            groupAddress = IPAddress.Parse(HOST);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            using (var settingsForm = new SettingsForm(HOST, REMOTEPORT, chatTextBox.Font))
            {
                if (settingsForm.ShowDialog() == DialogResult.OK)
                {
                    HOST = settingsForm.ChatAddress;
                    REMOTEPORT = settingsForm.ChatPort;
                    chatTextBox.Font = settingsForm.ChatFont;
                    groupAddress = IPAddress.Parse(HOST);
                }
            }
        }

        private void saveLogButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Текстові файли (*.txt)|*.txt|Всі файли (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, chatTextBox.Text);
                }
            }
        }

        private void ReceiveMessages()
        {
            alive = true;
            try
            {
                while (alive)
                {
                    IPEndPoint remoteIp = null;
                    byte[] data = client.Receive(ref remoteIp);
                    string message = Encoding.Unicode.GetString(data);
                    this.Invoke(new MethodInvoker(() =>
                    {
                        string time = DateTime.Now.ToShortTimeString();
                        chatTextBox.AppendText($"{time} {message}\r\n");
                    }));
                }
            }
            catch (ObjectDisposedException)
            {
                if (!alive)
                    return;
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExitChat()
        {
            if (userName != null)
            {
                string message = userName + " вийшов з чату";
                byte[] data = Encoding.Unicode.GetBytes(message);
                client.Send(data, data.Length, HOST, REMOTEPORT);
                client.DropMulticastGroup(groupAddress);
                alive = false;
                client.Close();
                loginButton.Enabled = true;
                logoutButton.Enabled = false;
                sendButton.Enabled = false;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (alive)
                ExitChat();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            userName = userNameTextBox.Text;
            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Введіть ім'я!");
                return;
            }

            userNameTextBox.ReadOnly = true;
            try
            {
                client = new UdpClient(LOCALPORT);
                client.JoinMulticastGroup(groupAddress, TTL);

                Task receiveTask = new Task(ReceiveMessages);
                receiveTask.Start();

                string message = userName + " приєднався до чату";
                byte[] data = Encoding.Unicode.GetBytes(message);
                client.Send(data, data.Length, HOST, REMOTEPORT);
                loginButton.Enabled = false;
                logoutButton.Enabled = true;
                sendButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void logoutButton_Click_1(object sender, EventArgs e)
        {
            ExitChat();
        }

        private void sendButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (userName != null)
                {
                    string message = String.Format("{0}: {1}", userName, messageTextBox.Text);
                    byte[] data = Encoding.Unicode.GetBytes(message);
                    client.Send(data, data.Length, HOST, REMOTEPORT);
                    messageTextBox.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
