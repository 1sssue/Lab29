namespace Lab29
{
    partial class Form1
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
            userNameTextBox = new TextBox();
            loginButton = new Button();
            logoutButton = new Button();
            sendButton = new Button();
            chatTextBox = new TextBox();
            messageTextBox = new TextBox();
            label1 = new Label();
            settingsButton = new Button();
            saveLogButton = new Button();
            SuspendLayout();
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(91, 40);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(115, 23);
            userNameTextBox.TabIndex = 0;
            userNameTextBox.TextChanged += userNameTextBox_TextChanged;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(212, 40);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(87, 23);
            loginButton.TabIndex = 1;
            loginButton.Text = "Вхід";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(212, 68);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(87, 23);
            logoutButton.TabIndex = 2;
            logoutButton.Text = "Вихід";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click_1;
            // 
            // sendButton
            // 
            sendButton.Location = new Point(212, 289);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(87, 23);
            sendButton.TabIndex = 3;
            sendButton.Text = "Відправити";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click_1;
            // 
            // chatTextBox
            // 
            chatTextBox.Location = new Point(14, 97);
            chatTextBox.Multiline = true;
            chatTextBox.Name = "chatTextBox";
            chatTextBox.Size = new Size(285, 186);
            chatTextBox.TabIndex = 4;
            // 
            // messageTextBox
            // 
            messageTextBox.Location = new Point(12, 289);
            messageTextBox.Name = "messageTextBox";
            messageTextBox.Size = new Size(194, 23);
            messageTextBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 6;
            label1.Text = "Введіть ім'я:";
            label1.Click += label1_Click;
            // 
            // settingsButton
            // 
            settingsButton.BackColor = SystemColors.ActiveBorder;
            settingsButton.Location = new Point(10, 11);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(196, 23);
            settingsButton.TabIndex = 7;
            settingsButton.Text = "Налаштування";
            settingsButton.UseVisualStyleBackColor = false;
            settingsButton.Click += settingsButton_Click;
            // 
            // saveLogButton
            // 
            saveLogButton.BackColor = SystemColors.ActiveBorder;
            saveLogButton.Location = new Point(212, 11);
            saveLogButton.Name = "saveLogButton";
            saveLogButton.Size = new Size(87, 23);
            saveLogButton.TabIndex = 8;
            saveLogButton.Text = "Зберегти";
            saveLogButton.UseVisualStyleBackColor = false;
            saveLogButton.Click += saveLogButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 322);
            Controls.Add(saveLogButton);
            Controls.Add(settingsButton);
            Controls.Add(label1);
            Controls.Add(messageTextBox);
            Controls.Add(chatTextBox);
            Controls.Add(sendButton);
            Controls.Add(logoutButton);
            Controls.Add(loginButton);
            Controls.Add(userNameTextBox);
            Name = "Form1";
            Text = "UDP чат";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userNameTextBox;
        private Button loginButton;
        private Button logoutButton;
        private Button sendButton;
        private TextBox chatTextBox;
        private TextBox messageTextBox;
        private Label label1;
        private Button settingsButton;
        private Button saveLogButton;
    }
}