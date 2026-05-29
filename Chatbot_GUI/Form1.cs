using System;
using System.Drawing;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace Chatbot_GUI
{
    public partial class Form1 : Form
    {
        private ChatBot bot;
        private bool awaitingName = true;

        public Form1()
        {
            InitializeComponent();
            bot = new ChatBot();
            bot.Memory.UserName = "Guest";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // On load, prompt for name
            AddChatBubble(" greeting please enter your name", false);

            // Play greeting audio asynchronously (non-blocking)
            Task.Run(() => bot.VoiceGreeting());

            // Populate the static ASCII art label on the right side
            try
            {
                var art = bot.GetAsciiArt();
                if (!string.IsNullOrEmpty(art) && this.AsciiLabel != null)
                {
                    // Extract only the line that contains the visible title "Cyber Avengers"
                    var lines = art.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    var titleIndex = Array.FindIndex(lines, l => l.IndexOf("Cyber Avengers", StringComparison.OrdinalIgnoreCase) >= 0);
                    if (titleIndex >= 0)
                    {
                        // Keep the original title line in AsciiLabel
                        var titleLine = lines[titleIndex].Trim();
                        this.AsciiLabel.Text = titleLine;

                        // Place a small robot-face snippet to the right in AsciiMini
                        int faceStart = Math.Max(0, titleIndex - 5);
                        int faceEnd = Math.Min(titleIndex, faceStart + 4);
                        var faceLines = lines.Skip(faceStart).Take(faceEnd - faceStart).Select(l => l.Trim());
                        if (this.AsciiMini != null)
                        {
                            this.AsciiMini.Text = string.Join(Environment.NewLine, faceLines);
                        }
                    }
                    else
                    {
                        this.AsciiLabel.Text = "Cyber Avengers";
                    }
                }
            }
            catch { }
        }

        private void AddChatBubble(string text, bool isUser)
        {
            if (this.ChatPanel.InvokeRequired)
            {
                this.ChatPanel.Invoke(new Action(() => AddChatBubble(text, isUser)));
                return;
            }

            var bubble = new ChatBubble()
            {
                Message = text,
                IsUser = isUser,
            };

            // Ensure max width respects panel size
            bubble.Width = Math.Min( (int)(this.ChatPanel.ClientSize.Width * 0.65), 600);
            bubble.Update();

            // Container panel to allow left/right alignment
            var container = new Panel()
            {
                Width = this.ChatPanel.ClientSize.Width - 20,
                Height = bubble.Height + 6,
                Margin = new Padding(0),
            };

            if (isUser)
            {
                bubble.Left = container.Width - bubble.Width - 10;
            }
            else
            {
                bubble.Left = 10;
            }

            bubble.Top = 3;
            container.Controls.Add(bubble);
            this.ChatPanel.Controls.Add(container);
            this.ChatPanel.ScrollControlIntoView(container);
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            var input = this.UserInput.Text?.Trim();
            if (string.IsNullOrEmpty(input)) return;

            if (awaitingName)
            {
                bot.Memory.UserName = input;
                AddChatBubble(input, true);
                awaitingName = false;
                AddChatBubble($"Nice to meet you, {bot.Memory.UserName}! How can I help you today?", false);
                this.UserInput.Clear();
                return;
            }

            AddChatBubble(input, true);
            var resp = bot.GetResponse(input);
            AddChatBubble(resp, false);
            this.UserInput.Clear();
        }

        private void greetButton_Click(object sender, EventArgs e)
        {
            AddChatBubble("Playing greeting audio (if available)...", false);
            Task.Run(() => bot.VoiceGreeting());
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch
            {
                Application.Exit();
            }
        }
    }
}
