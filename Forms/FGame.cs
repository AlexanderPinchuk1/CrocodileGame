using CrocodileGame.ConnectionTools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrocodileGame.Forms
{
    public partial class FGame : Form
    {
        public string UserName = "";
        public int UserStatus = -1;
        public bool IsPressed = false;
        public string GameWord = "";
        public bool ServerCreator = false;

        public DateTime StartGameTime = new DateTime();

        public bool GameRun = false;

        int X = -1;
        int Y = -1;
        public bool NewMessageSignal = false;
        public Message NewMessege = null;


        private readonly List<LineDots> DrawnLines = new List<LineDots>();
        private readonly List<LineDots> ReceivedLines = new List<LineDots>();
        private readonly List<string> ReceivedMessages = new List<string>();
        private readonly List<int> ReceivedNumsIcons = new List<int>();

        Pen UserPen;

        static Graphics Graph = null;

        public FGame()
        {
            InitializeComponent();
            KeyPreview = true;
            MaximizeBox = false;
            SetButtons();
            SetGraphicsTools();
            SetViewerMode();
            SetTimers();
        }

        private void SetTimers()
        {
            TimerCheckMessage.Interval = 60;    
            TimerCheckMessage.Start();

            TimerCheckNewDots.Interval = 90;  
            TimerCheckNewDots.Start();
        }

        private void SetGameTime()
        {
            TimerGameTime.Interval = 300;
            TimerGameTime.Start();
        }

        private void SetButtons()
        {
            ButClean.FlatAppearance.BorderSize = 0;
            ButClean.FlatStyle = FlatStyle.Flat;
            ButSend.FlatAppearance.BorderSize = 0;
            ButSend.FlatStyle = FlatStyle.Flat;

        }

        private void SetGraphicsTools()
        {
            Graph = PanelForDrawing.CreateGraphics();
            Graph.SmoothingMode = SmoothingMode.AntiAlias;
            UserPen = new Pen(Color.Black, (float)(TrackBarSizePen.Value * 0.4));
            UserPen.StartCap = UserPen.EndCap = LineCap.Round;

        }

        private void SetPainterMode()
        {
            ListViewChat.Enabled = true;
            PanelForDrawing.Enabled = true;
            PanelForTools.Enabled = true;
            TextBoxMessage.Enabled = false;
            RedrawCheckDot(UserPen.Color, UserPen.Width);
        }

        private void SetViewerMode()
        {
            ListViewChat.Enabled = true;
            PanelForDrawing.Enabled = false;
            PanelForTools.Enabled = false;
            TextBoxMessage.Enabled = true;
            RedrawCheckDot(UserPen.Color, UserPen.Width);
        }


        private void RedrawCheckDot(Color color, float penWidth)
        {
            PanelForCheck.Refresh();
            Brush brush = new SolidBrush(color);
            Graphics graphics = PanelForCheck.CreateGraphics();
            float x = (PanelForCheck.Width - penWidth) / 2 - 1;
            float y = (PanelForCheck.Height - penWidth) / 2 - 1;
            graphics.FillEllipse(brush, x, y, penWidth, penWidth);
        }

        private void ButClean_Click(object sender, EventArgs e)
        {
            PanelForDrawing.Refresh();
            Message message = new Message() { Cleaning = true};
            Client.SendInfo = true;
            Client.SendMessage = message;
        }

        private void PanelForDrawing_MouseDown(object sender, MouseEventArgs e)
        {
            IsPressed = true;
            X = e.X;
            Y = e.Y;
        }

        private void PanelForDrawing_MouseMove(object sender, MouseEventArgs e)
        {
            if ((IsPressed) && (X != -1) && (Y != -1))
            {
                LineDots lineDots = new LineDots(X, Y, e.X, e.Y, UserPen.Color, UserPen.Width);
                Drawing(lineDots);
                DrawnLines.Add(lineDots);
                X = e.X;
                Y = e.Y;
            }
        }


        private void CheckAnswer(string messageText)
        {
            string[] words = messageText.Split(new char[] { ':' });
            if (words.Length == 2)
            {
                string answer = words[1];
                answer = answer.Trim();
                answer = answer.ToLower();
                if (answer == GameWord)
                {
                    string userName = words[0];
                    userName = userName.Trim();
                    Message message = new Message()
                    {
                        Everyone = false,
                    };
                    message.Text.Add(userName + " guessed the word!");
                    message.NumsIcons.Add(5);
                    Client.SendInfo = true;
                    Client.SendMessage = message;
                    LabelGameWord.Text = "";
                    ReceivedMessages.AddRange(message.Text);
                    ReceivedNumsIcons.AddRange(message.NumsIcons);
                }
            }
        }

        private void FinishGame()
        {
            RedrawCheckDot(UserPen.Color,UserPen.Width);
            PanelForDrawing.Refresh();
            TimerGameTime.Stop();
            LabelGameWord.Text = "";
            LabTime.Text = "300";
            GameRun = false;
            UserStatus = -1;
            if ((GetUserCount() > 1) && (ServerCreator == true))
                SendMessageAboutStartGame();
        }

        public void AddMessageToChat()
        {
            List<string> messages = ReceivedMessages.GetRange(0, ReceivedMessages.Count);
            List<int> numsIcons = ReceivedNumsIcons.GetRange(0, ReceivedNumsIcons.Count);
            ReceivedMessages.Clear();
            ReceivedNumsIcons.Clear();

            for (int i = 0; i < messages.Count; i++)
            {
                ListViewItem listViewItem = new ListViewItem();
                ListViewItem.ListViewSubItem listViewSubItem = new ListViewItem.ListViewSubItem();

                listViewItem.ImageIndex = numsIcons[i];
                listViewSubItem.Text = messages[i];
                listViewItem.SubItems.Add(listViewSubItem);

                ListViewChat.Items.Add(listViewItem);

                if ((numsIcons[i] == 2) || (numsIcons[i] == 3))
                    ChangeNumUsersOnline(numsIcons[i]);
                if (UserStatus == 1)
                    CheckAnswer(messages[i]);
                if ((numsIcons[i] == 5) || (numsIcons[i] == 6))
                    FinishGame();
            }

            if (ReceivedMessages.Count != 0)
                AddMessageToChat();
        }


        private void SendDrawnLines( )
        {
            Message message = new Message() { LinesDots = DrawnLines.GetRange(0, DrawnLines.Count) };
            Client.SendInfo = true;
            Client.SendMessage = message;
            DrawnLines.Clear();
        }

        public void AddReceivedLines(List<LineDots> linesDots)
        {
            ReceivedLines.AddRange(linesDots);
        }

        public void AddReceivedMessages(List<string> messages, List<int> numsIcons)
        {
            ReceivedMessages.AddRange(messages);
            ReceivedNumsIcons.AddRange(numsIcons);
        }
        private void Drawing(LineDots line)
        {
            Pen pen  = new Pen(line.PenColor, line.PenSize);
            pen.StartCap = pen.EndCap = LineCap.Round;
            Graph.DrawLine(pen, line.PrevX, line.PrevY, line.CurX,line.CurY);
        }

        private void PanelForDrawing_MouseUp(object sender, MouseEventArgs e)
        {
            IsPressed = false;
            X = -1;
            Y = -1;
        }

        private void TrackBarSizePen_Scroll(object sender, EventArgs e)
        {
            UserPen.Width = (float)(TrackBarSizePen.Value * 0.8);
            RedrawCheckDot(UserPen.Color,UserPen.Width);
        }

        private void FGame_Shown(object sender, EventArgs e)
        {
            RedrawCheckDot(UserPen.Color, UserPen.Width);
            LabUser.Text = UserName;
        }

        private void ButSend_Click(object sender, EventArgs e)
        {
            if (TextBoxMessage.Text != "")
            {
                Message message = new Message();
                message.Text.Add(UserName + ": " + TextBoxMessage.Text);
                message.NumsIcons.Add(0);
                message.Everyone = false;
                
                Client.SendInfo = true;
                Client.SendMessage = message;
                ReceivedMessages.AddRange(message.Text);
                ReceivedNumsIcons.AddRange(message.NumsIcons);
                TextBoxMessage.Text = "";
            }
        }


        private void SendMessageAboutWhoPainter()
        {
            Thread.Sleep(1000);  // 2000
            Message message = new Message()
            {
                Everyone = true,
            };

            message.Text.Add(UserName + " is a painter.");
            message.NumsIcons.Add(4);

            Client.SendInfo = true;
            Client.SendMessage = message;
        }
        private void StartGame(int mode, DateTime time)
        {
            StartGameTime = time;
            SetGameTime();
            if (mode == 1)
            {
                UserStatus = 1;
                SetPainterMode();
                SendMessageAboutWhoPainter();
                FWordСhoice fWordСhoice = new FWordСhoice();
                fWordСhoice.ShowDialog();
                GameWord = fWordСhoice.GetGameWord();
                GameWord = GameWord.Trim();
                LabelGameWord.Text = "Word: " + GameWord;
            }
            else
            {
                SetViewerMode();
                UserStatus = 0;
            }
        }

        private void HandleMessage()
        {
            if ((NewMessageSignal) && (NewMessege != null))
            {
                if ((NewMessege.Text.Count != 0) && (NewMessege.NumsIcons.Count != 0))
                    AddReceivedMessages(NewMessege.Text, NewMessege.NumsIcons);
                if (NewMessege.LinesDots.Count != 0)
                    AddReceivedLines(NewMessege.LinesDots);
                if (NewMessege.Cleaning == true)
                    PanelForDrawing.Refresh();
                if (NewMessege.NumItemForEdIcon != -1)
                    ChangeIcon(NewMessege.NumItemForEdIcon,NewMessege.NumsIcons[0]);
                if ((NewMessege.UserMode != -1) && (NewMessege.StartGame) && (UserStatus == -1))
                {
                    int num = NewMessege.UserMode;
                    DateTime time = NewMessege.TimeStart;
                    NewMessageSignal = false;
                    NewMessege = null;
                    StartGame(num,time);
                }
                NewMessageSignal = false;
                NewMessege = null;
            }
        }
        private void TimerCheckMessage_Tick(object sender, EventArgs e)
        {
            HandleMessage();
            if (ReceivedLines.Count != 0)
            {
                TimerCheckMessage.Stop();
                DrawRecivedLines();
                TimerCheckMessage.Start();
            }
            if (ReceivedMessages.Count != 0)
            {
                TimerCheckMessage.Stop();
                AddMessageToChat();
                TimerCheckMessage.Start();
            }
        }

        private void TimerCheckNewDots_Tick(object sender, EventArgs e)
        {
            if (DrawnLines.Count != 0)
                SendDrawnLines();
        }

        private void ChangePenSizeTrackBar(float penSize)
        {
            TrackBarSizePen.Value = Convert.ToInt32(Math.Round((double)(penSize / 0.8)));
        }
        private void DrawRecivedLines()
        {
            List<LineDots> lines = ReceivedLines.GetRange(0, ReceivedLines.Count);
            ReceivedLines.Clear();
            RedrawCheckDot(lines[0].PenColor, lines[0].PenSize);
            ChangePenSizeTrackBar(lines[0].PenSize);
            foreach (LineDots line in lines)
            {
                Drawing(line);
            }
            if (ReceivedLines.Count != 0)
                DrawRecivedLines();
        }

        private void PictureBoxRed_Click(object sender, EventArgs e)
        {
            UserPen.Color = Color.Red;
            RedrawCheckDot(UserPen.Color, UserPen.Width);
        }

        private void PicBoxYellow_Click(object sender, EventArgs e)
        {
            UserPen.Color = Color.Yellow;
            RedrawCheckDot(UserPen.Color, UserPen.Width);
        }

        private void PicBoxGreen_Click(object sender, EventArgs e)
        {
            UserPen.Color = Color.Lime;
            RedrawCheckDot(UserPen.Color, UserPen.Width);
        }

        private void PicBoxBlue_Click(object sender, EventArgs e)
        {
            UserPen.Color = Color.Blue;
            RedrawCheckDot(UserPen.Color, UserPen.Width);
        }

        private void PicBoxPurple_Click(object sender, EventArgs e)
        {
            UserPen.Color = Color.Fuchsia;
            RedrawCheckDot(UserPen.Color, UserPen.Width);
        }

        private void PicBoxBlack_Click(object sender, EventArgs e)
        {
            UserPen.Color = Color.Black;
            RedrawCheckDot(UserPen.Color, UserPen.Width);
        }

        private void PicBoxSilver_Click(object sender, EventArgs e)
        {
            UserPen.Color = Color.Silver;
            RedrawCheckDot(UserPen.Color, UserPen.Width);
        }

        private void PicBoxOrange_Click(object sender, EventArgs e)
        {
            UserPen.Color = Color.Orange;
            RedrawCheckDot(UserPen.Color, UserPen.Width);
        }

        private void PicBoxWhite_Click(object sender, EventArgs e)
        {
            UserPen.Color = Color.White;
            RedrawCheckDot(UserPen.Color, UserPen.Width);
        }

        private void PicBoxBrown_Click(object sender, EventArgs e)
        {
            UserPen.Color = Color.Brown;
            RedrawCheckDot(UserPen.Color, UserPen.Width);
        }

        private void PicBoxAqua_Click(object sender, EventArgs e)
        {
            UserPen.Color = Color.Aqua;
            RedrawCheckDot(UserPen.Color, UserPen.Width);
        }

        private void ChangeIcon(int numItem,int numIcon)
        {
            ListViewChat.Items[numItem].ImageIndex = numIcon;
        }
        private void ListViewChat_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if ((ListViewChat.SelectedItems.Count == 1) && (UserStatus == 1) && 
                ((ListViewChat.SelectedItems[0].ImageIndex == 0) || (ListViewChat.SelectedItems[0].ImageIndex == 1)))
            {
                Message message = new Message() { NumItemForEdIcon = ListViewChat.SelectedIndices[0]};
                
                if (ListViewChat.SelectedItems[0].ImageIndex == 0)
                {
                    message.NumsIcons.Add(1);
                    ChangeIcon(ListViewChat.SelectedIndices[0],1);
                }
                else if ((ListViewChat.SelectedItems[0].ImageIndex == 1))
                {
                    message.NumsIcons.Add(0);
                    ChangeIcon(ListViewChat.SelectedIndices[0],0);
                }
                Client.SendInfo = true;
                Client.SendMessage = message;
            }
            if (ListViewChat.SelectedItems.Count >= 1)
                ListViewChat.Items[ListViewChat.SelectedIndices[0]].Selected = false;
        }

        private void FGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                ButSend.PerformClick();
            }  
        }


        private void TimerGameTime_Tick(object sender, EventArgs e)
        {

            DateTime dateTime = DateTime.Now;
            int sec = dateTime.Subtract(StartGameTime).Seconds;
            int min = dateTime.Subtract(StartGameTime).Minutes;
            int time = sec + 60 * min;
            time = 300 - time;
            if (time == 0)
            { 
                TimerGameTime.Stop();
                if (UserStatus == 1)
                    SendMessageAboutLostGame("Time is up. ");
            }
            else
                LabTime.Text = Convert.ToString(time);
        }


        private void SendMessageAboutStartGame()
        {
            Thread.Sleep(500);
            Message message = new Message()
            { 
                StartGame = true,
                Everyone = true,
            };
            Client.SendInfo = true;
            Client.SendMessage = message;
            GameRun = true;
        }

        private void SendMessageAboutLostGame(string text)
        {
            Message message = new Message()
            {
                Everyone = true,
            };

            message.NumsIcons.Add(6);
            message.Text.Add(text + "Hidden word is " + GameWord + ".");

            Client.SendInfo = true;
            Client.SendMessage = message;
        }

        private int GetUserCount()
        {
            string live = "LIVE:";
            string line = toolStripStatusLabelNumUsers.Text;
            line = line.Replace(live, "");
            line = line.Trim();

            return Convert.ToInt32(line);
        }
        private void ChangeNumUsersOnline(int numIcon)
        {
            string live = "LIVE:";
            int numUsers = GetUserCount();
            if (numIcon == 2)
                numUsers++;
            else
                numUsers--;
            toolStripStatusLabelNumUsers.Text = live + " " + Convert.ToString(numUsers);

            if (numUsers < 2)
            {
                toolStripStatusLabelNotification.Text = "Not enough users online. Expected users ...";
                Image img = Image.FromFile("warning32.png");
                toolStripStatusLabelNotification.Image = img;
                if (GameRun)
                    FinishGame();
            }
            else
            {
                if ((!GameRun) && (ServerCreator))
                {
                    Thread.Sleep(500);//1000
                    SendMessageAboutStartGame();
                }

                toolStripStatusLabelNotification.Text = "";
                Image img = Image.FromFile("none.png");
                toolStripStatusLabelNotification.Image = img;
            }


        }
        private void SendMessageAboutExit()
        {
            Message message = new Message()
            {
                Everyone = true,
            };
            message.NumsIcons.Add(3);
            message.Text.Add(UserName + " out of the game!");
            Client.SendInfo = true;
            Client.SendMessage = message;
        }
        private void FGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            SendMessageAboutExit();
            Thread.Sleep(1200);
            if (UserStatus == 1)
            {
                SendMessageAboutLostGame("");
            }
            Thread.Sleep(1200);
            Client.ClientRun = false;
            TimerCheckMessage.Stop();
            TimerCheckNewDots.Stop();
            TimerGameTime.Stop();
        }
    }
}
