namespace Lab29
{
    partial class SettingsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            addressLabel = new Label();
            addressTextBox = new TextBox();
            portLabel = new Label();
            portTextBox = new TextBox();
            fontLabel = new Label();
            fontButton = new Button();
            saveButton = new Button();
            fontDialog1 = new FontDialog();
            fontSampleLabel = new Label();
            SuspendLayout();
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(14, 10);
            addressLabel.Margin = new Padding(4, 0, 4, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(49, 15);
            addressLabel.TabIndex = 0;
            addressLabel.Text = "Адреса:";
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(74, 7);
            addressTextBox.Margin = new Padding(4, 3, 4, 3);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(243, 23);
            addressTextBox.TabIndex = 1;
            // 
            // portLabel
            // 
            portLabel.AutoSize = true;
            portLabel.Location = new Point(14, 40);
            portLabel.Margin = new Padding(4, 0, 4, 0);
            portLabel.Name = "portLabel";
            portLabel.Size = new Size(38, 15);
            portLabel.TabIndex = 2;
            portLabel.Text = "Порт:";
            // 
            // portTextBox
            // 
            portTextBox.Location = new Point(74, 37);
            portTextBox.Margin = new Padding(4, 3, 4, 3);
            portTextBox.Name = "portTextBox";
            portTextBox.Size = new Size(243, 23);
            portTextBox.TabIndex = 3;
            // 
            // fontLabel
            // 
            fontLabel.AutoSize = true;
            fontLabel.Location = new Point(14, 70);
            fontLabel.Margin = new Padding(4, 0, 4, 0);
            fontLabel.Name = "fontLabel";
            fontLabel.Size = new Size(49, 15);
            fontLabel.TabIndex = 4;
            fontLabel.Text = "Шрифт:";
            // 
            // fontButton
            // 
            fontButton.Location = new Point(74, 65);
            fontButton.Margin = new Padding(4, 3, 4, 3);
            fontButton.Name = "fontButton";
            fontButton.Size = new Size(88, 27);
            fontButton.TabIndex = 5;
            fontButton.Text = "Обрати...";
            fontButton.UseVisualStyleBackColor = true;
            fontButton.Click += fontButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(229, 94);
            saveButton.Margin = new Padding(4, 3, 4, 3);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(88, 27);
            saveButton.TabIndex = 6;
            saveButton.Text = "Зберегти";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // fontSampleLabel
            // 
            fontSampleLabel.AutoSize = true;
            fontSampleLabel.Location = new Point(168, 70);
            fontSampleLabel.Margin = new Padding(4, 0, 4, 0);
            fontSampleLabel.Name = "fontSampleLabel";
            fontSampleLabel.Size = new Size(0, 15);
            fontSampleLabel.TabIndex = 7;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 133);
            Controls.Add(fontSampleLabel);
            Controls.Add(saveButton);
            Controls.Add(fontButton);
            Controls.Add(fontLabel);
            Controls.Add(portTextBox);
            Controls.Add(portLabel);
            Controls.Add(addressTextBox);
            Controls.Add(addressLabel);
            Margin = new Padding(4, 3, 4, 3);
            Name = "SettingsForm";
            Text = "Налаштування";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label fontLabel;
        private System.Windows.Forms.Button fontButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label fontSampleLabel;
    }
}
