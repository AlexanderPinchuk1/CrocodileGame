using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrocodileGame.ConnectionTools;

namespace CrocodileGame.ConnectionTools
{
    class Communication
    {
        public TcpClient Сlient;

        public List<string> ChatHistory = new List<string>();
        public List<LineDots> DrawnLines = new List<LineDots>();
        public List<int> IconsHistory = new List<int>();
        public static bool ServerRun = true;

        public static bool UpdateChatAndPic = false;


        public Communication(TcpClient tcpClient)
        {
            Сlient = tcpClient;
        }

        public void Process()
        {
            NetworkStream stream = null;
            try
            {
                stream = Сlient.GetStream();
                Listner.ClientsThreads.Add(stream);
                Random random = new Random();
                byte[] data = new byte[100000];
                byte[] receivedBytes;
                Thread.Sleep(1000);
                SendHisoty(stream);
                
                while (ServerRun)
                {
                    int numBytes = 0;
                    do
                    {
                        numBytes = stream.Read(data, 0, data.Length);
                        receivedBytes =new byte[numBytes]; 
                        Array.Copy(data, receivedBytes, numBytes);
                    }
                    while (stream.DataAvailable);

                    Message message = Message.Deserialize(receivedBytes);
                    SaveInfo(message);


                    if (message.StartGame)
                    {
                        Listner.DateStartGame = DateTime.Now;
                        Listner.GameRunning = true;
                        message.TimeStart = Listner.DateStartGame;
                        int numPainter = random.Next(0, Listner.ClientsThreads.Count);
                        for (int i = 0; i < Listner.ClientsThreads.Count; i++)
                        {
                            if (i == numPainter)
                                message.UserMode = 1;
                            else
                                message.UserMode = 0;
                            
                            byte[] newData = Message.Serialize(message);
                            Listner.ClientsThreads[i].Write(newData, 0, newData.Length);
                        }
                        continue;
                    }

                    for (int i = 0; i < message.Text.Count; i++)
                    {
                        if ((message.NumsIcons[i] == 2) && (Listner.GameRunning))
                        {
                            message.StartGame = true;
                            message.UserMode = 0;
                            message.TimeStart = Listner.DateStartGame;
                            receivedBytes = Message.Serialize(message);
                        }


                        if (message.NumsIcons[i] == 3)
                            Listner.ClientsThreads.Remove(stream);
                    }

                    foreach (NetworkStream networkStream in Listner.ClientsThreads)
                    {
                        if (message.Everyone == true)
                            networkStream.Write(receivedBytes, 0, receivedBytes.Length);
                        else
                            if ((networkStream != stream) && (stream != null))
                                networkStream.Write(receivedBytes, 0, receivedBytes.Length);
                    }
                }
            }
            catch
            {
            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }
                if (Сlient != null)
                    Сlient.Close();
            }
        }

        private void SendHisoty(NetworkStream networkStream)
        {
            if (DrawnLines.Count != 0)
            {
                int count = 1000;
                int tmp = 0;
                int num = DrawnLines.Count / count;
                int remainder = DrawnLines.Count % count;
                Thread.Sleep(1300);
                for (int i = 0; i < num; i++)
                {
                    Message message = new Message();
                    message.LinesDots.AddRange(DrawnLines.GetRange(tmp,count));
                    tmp += (count - 1);
                    SerializeAndSend(message, networkStream);
                    Thread.Sleep(1100);
                }
                if (remainder != 0)
                {
                    Message message = new Message();
                    message.LinesDots.AddRange(DrawnLines.GetRange(tmp, remainder));
                    SerializeAndSend(message, networkStream);
                }
            }
            Thread.Sleep(1200);
            if ((ChatHistory.Count != 0) && (IconsHistory.Count != 0))
            {
                Message message = new Message();
                message.Text.AddRange(ChatHistory);
                message.NumsIcons.AddRange(IconsHistory);
                
                SerializeAndSend(message, networkStream);
            }
            Thread.Sleep(1200);
            UpdateChatAndPic = true;
        }

        private void SerializeAndSend(Message message, NetworkStream networkStream)
        {
            byte[] data = Message.Serialize(message);
            networkStream.Write(data, 0, data.Length);
        }

        private void SaveInfo(Message message)
        {
            if (message.Cleaning == true)
                Listner.DrawnLines.Clear();
            if (message.Text.Count != 0)
            {
                Listner.MessagesInChat.AddRange(message.Text);
                Listner.NumsIconsInMessages.AddRange(message.NumsIcons);
            }
            if (message.LinesDots.Count != 0)
                Listner.DrawnLines.AddRange(message.LinesDots);
            if (message.NumItemForEdIcon != -1)
                Listner.NumsIconsInMessages[message.NumItemForEdIcon] = message.NumsIcons[0];
        }

    }
}
