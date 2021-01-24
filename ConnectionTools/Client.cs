using CrocodileGame.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrocodileGame.ConnectionTools
{
    public class Client
    {
        public const int Port = 8888;
        public static string IP = "127.0.0.1";
        public static bool SendInfo = false;
        public static Message SendMessage = null;
        public static FGame FGame = null;
        public static NetworkStream Stream = null;
        public static bool ServerRun = true;
        public static bool ClientRun = true;

        public  static void  CommunicateWithServer()
        {
            TcpClient client = null;
            try
            {
                client = new TcpClient(IP, Port);
                Stream = client.GetStream();  

                Thread threadForSendingMessage = new Thread(SendMessageThread);
                threadForSendingMessage.Start();

                Thread threadForReceiveMessage = new Thread(ReceiveMessageThread);
                threadForReceiveMessage.Start();

                while (ClientRun)
                { 
                }
                threadForSendingMessage.Abort();
                threadForReceiveMessage.Abort();
            }
            catch
            {
                ClientRun = false;
            }
            finally
            {
                if (client != null)
                    client.Close();
            }
        }

        private static void SendMessageThread()
        {
            while (true)
            {
                if (SendInfo == true)
                {
                    byte[] data = Message.Serialize(SendMessage);
                    Stream.Write(data, 0, data.Length);
                    SendInfo = false;
                }
                if (ClientRun == false)
                {
                    break;
                }
            }
        }

        private static void ReceiveMessageThread()
        {
            while (true)
            {
                byte[] data = new byte[100000];
                byte[] receivedBytes;
                do 
                {
                   int numBytes =  Stream.Read(data, 0, data.Length);
                   receivedBytes = new byte[numBytes];
                   Array.Copy(data, receivedBytes, numBytes);
                }
                while ((Stream.DataAvailable) && (!SendInfo));
                CreateSignal(receivedBytes);
            }
        }

        public static void Reset()
        {
            SendMessage = null;
            SendInfo = false;
            FGame = null;
        }
        public  static void CreateSignal(byte[] data)
        {
            Message message = Message.Deserialize(data);
            if ((FGame == null) && (message!=null))
                return;
            FGame.NewMessageSignal = true;
            FGame.NewMessege = message;
        }

    }
}
