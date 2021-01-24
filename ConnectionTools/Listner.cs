using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrocodileGame.ConnectionTools
{
    class Listner
    {
        public const int Port = 8888;
        public static string IP = "127.0.0.1";
        public static TcpListener Listener = null;

        public static bool FailCreatingMainServer = false;

        public static List<string> MessagesInChat = new List<string>();
        public static List<int> NumsIconsInMessages = new List<int>();
        public static List<LineDots> DrawnLines = new List<LineDots>();
        public static bool Listening = true;

        public static List<NetworkStream> ClientsThreads = new List<NetworkStream>();

        public static bool GameRunning = false;
        public static DateTime DateStartGame = new DateTime();

        public static void ListenConnection()
        {
            try
            {
                Listener = new TcpListener(IPAddress.Any, Port);
                Listener.Start();


                while (Listening)
                {
                    TcpClient client = Listener.AcceptTcpClient();
                    if (!Listening)
                        break;
                    Communication communication = new Communication(client);

                    if ((MessagesInChat.Count != 0) && (NumsIconsInMessages.Count != 0))
                    {
                        communication.ChatHistory.AddRange(MessagesInChat);
                        communication.IconsHistory.AddRange(NumsIconsInMessages);
                    }
                    if (DrawnLines.Count != 0)
                        communication.DrawnLines.AddRange(DrawnLines);

                    Thread clientThread = new Thread(new ThreadStart(communication.Process));
                    clientThread.Start();
                }

            }
            catch
            {
               FailCreatingMainServer = true;
            }
            finally
            {
                if (Listener != null)
                {
                    Listener.Stop(); 
                    Listener = null;
                }
            }
        }

    }
}
