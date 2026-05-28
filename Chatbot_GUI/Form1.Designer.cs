namespace Chatbot_GUI
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
            this.ChatPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.UserInput = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.asciiPanel = new System.Windows.Forms.Panel();
            this.AsciiLabel = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ChatPanel
            // 
            this.ChatPanel.AutoScroll = true;
            this.ChatPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ChatPanel.Name = "ChatPanel";
            this.ChatPanel.TabIndex = 0;
            this.ChatPanel.WrapContents = false;
            this.ChatPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Height = 40;
            this.bottomPanel.Name = "bottomPanel";
            // 
            // UserInput
            // 
            this.UserInput.Name = "UserInput";
            this.UserInput.TabIndex = 1;
            this.UserInput.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // SendButton
            // 
            this.SendButton.Name = "SendButton";
            this.SendButton.TabIndex = 2;
            this.SendButton.Text = "Send";
            this.SendButton.Width = 100;
            this.SendButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.sendButton_Click);

            // CloseButton
            // 
            this.CloseButton = new System.Windows.Forms.Button();
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Close";
            this.CloseButton.Width = 100;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.closeButton_Click);

            // asciiPanel
            // 
            this.asciiPanel.Name = "AsciiPanel";
            this.asciiPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.asciiPanel.Height = 80;
            // 
            // AsciiLabel (Label used to display static ASCII art at top)
            // 
            this.AsciiLabel = new System.Windows.Forms.Label();
            this.AsciiLabel.Name = "AsciiLabel";
            this.AsciiLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AsciiLabel.Font = new System.Drawing.Font("Consolas", 8F);
            this.AsciiLabel.ForeColor = System.Drawing.Color.LightGray;
            this.AsciiLabel.BackColor = System.Drawing.Color.Transparent;
            this.AsciiLabel.AutoSize = false;
            this.AsciiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AsciiLabel.AutoEllipsis = true;
            this.AsciiLabel.Padding = new System.Windows.Forms.Padding(6);
            // ascii panel contains the label
            this.asciiPanel.Controls.Add(this.AsciiLabel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 498);
            this.Controls.Add(this.ChatPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.asciiPanel);

            // put input controls into bottomPanel (Close on left, Send on right, UserInput fills)
            this.bottomPanel.Controls.Add(this.UserInput);
            this.bottomPanel.Controls.Add(this.SendButton);
            this.bottomPanel.Controls.Add(this.CloseButton);
            this.Name = "Form1";
            this.Text = "Cyber Avengers - Chatbot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.FlowLayoutPanel ChatPanel;
        private System.Windows.Forms.TextBox UserInput;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Panel asciiPanel;
        private System.Windows.Forms.Label AsciiLabel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button CloseButton;


        #endregion
    }
}

