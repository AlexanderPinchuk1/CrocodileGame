using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CrocodileGame
{
    [Serializable]
    public class Message
    {
        public List<string> Text { get; set; }
        public bool Everyone { get; set; }
        public bool StartGame { get; set; }
        public List<int > NumsIcons { get; set; }
        public int NumItemForEdIcon { get; set; }
        public bool Cleaning { get; set; }
        public DateTime TimeStart { get; set; }
        public int UserMode { get; set; }
        public List<LineDots> LinesDots {get; set; }


        public Message()
        {
            Text = new List<string>(); 
            Cleaning = false;
            LinesDots = new List<LineDots>();
            Everyone = false;
            NumItemForEdIcon = -1;
            NumsIcons = new List<int>();
            UserMode = -1;
            TimeStart = new DateTime();
            StartGame = false;
        }

        public static byte[] Serialize(Message message)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (MemoryStream memoryStream = new MemoryStream())
            {
                formatter.Serialize(memoryStream, message);
                return memoryStream.ToArray();
            }
        }

        public static Message Deserialize(byte[] bytes)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Message message;
            using (MemoryStream memoryStream = new MemoryStream(bytes))
            {
                message = (Message)formatter.Deserialize(memoryStream);
            }
            
            return message;
        }

    }
    
}
