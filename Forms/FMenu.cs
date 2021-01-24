using CrocodileGame.ConnectionTools;
using CrocodileGame.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrocodileGame
{
    public partial class FMenu : Form
    {

        public string UserName = "";
        public Client NewClient;
        public FGame fGame = null;
        public bool ServerCreator = false;
        public Thread ServerThread;

        public FMenu()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void ButConnect_Click(object sender, EventArgs e)
        {
            TextBoxIP.Text = TextBoxIP.Text.Trim();
            if (!CheckIP(TextBoxIP.Text))
                MessageBox.Show("Invalid IP", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                ConnectToServer();
        }

        private bool CheckIP(string ip)
        {
            string tmp = "";
            int countDot = 0;
            for (int i = 0; i< ip.Length;i++)
                if (ip[i] == '.')
                {
                    countDot++;
                    if ((tmp!= "") &&(Convert.ToInt32(tmp) < 255) && (Convert.ToInt32(tmp) >= 0))
                        tmp = "";
                    else
                        return false;
                }
                else if ((ip[i] >= '0') && (ip[i] <= '9'))
                {
                    tmp += ip[i];
                }
                else
                    return false;

            if ((countDot == 3) && (tmp != "") && (Convert.ToInt32(tmp) <= 255) && (Convert.ToInt32(tmp) >= 0))
                return true;

            return false;
        }

        private bool CreateServer()
        {
            ServerThread = new Thread(Listner.ListenConnection);
            ServerThread.Start();
            ServerCreator = true;
            if (Listner.FailCreatingMainServer == true)
                return false;
            else
                return true;
        }

        private void ConnectToServer()
        {
            fGame = new FGame() { UserName = UserName};
            Client.FGame = fGame;
            Client.ClientRun = true;
            Client.IP = TextBoxIP.Text;
            Thread thread = new Thread(Client.CommunicateWithServer);
            thread.Start();
            Thread.Sleep(2000);
            if (Client.ClientRun == false)
                return;
            SendMessageAboutConnectedUser();
            if (ServerCreator)
                fGame.ServerCreator = true;
            
            Hide();
            fGame.ShowDialog();
            Show();
        }

        private void SendMessageAboutConnectedUser()
        {
            Message message = new Message()
            {
                Everyone = true,
            };

            message.Text.Add(UserName + " connected to the game!");
            message.NumsIcons.Add(2);

            Client.SendInfo = true;
            Client.SendMessage = message;
        }

        private void ButCreateServer_Click(object sender, EventArgs e)
        {
            TextBoxIP.Text = TextBoxIP.Text.Trim();
            if (!CheckIP(TextBoxIP.Text))
                MessageBox.Show("Invalid IP", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (CreateServer())
                {
                    ConnectToServer();
                }
                else
                    MessageBox.Show("Server creation error. This IP address may already be taken.","Error",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if ((Listner.FailCreatingMainServer == false) && (ServerCreator == true))
            {
                Listner.Listening = false;
                if (Listner.Listener != null)
                    Listner.Listener.Stop();
            }
            
        }
    }
}
