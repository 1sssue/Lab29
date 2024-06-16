using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab29
{
    public partial class SettingsForm : Form
    {
        public string ChatAddress { get; private set; }
        public int ChatPort { get; private set; }
        public Font ChatFont { get; private set; }

        public SettingsForm(string currentAddress, int currentPort, Font currentFont)
        {
            InitializeComponent();
            addressTextBox.Text = currentAddress;
            portTextBox.Text = currentPort.ToString();
            fontDialog1.Font = currentFont;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            ChatAddress = addressTextBox.Text;
            ChatFont = fontDialog1.Font;

            if (int.TryParse(portTextBox.Text, out int port))
            {
                ChatPort = port;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Невірний номер порту");
            }
        }

        private void fontButton_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                fontSampleLabel.Font = fontDialog1.Font;
            }
        }
    }
}
