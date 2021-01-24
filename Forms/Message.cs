using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrocodileGame.Forms
{

    [Serializable]
    public class Message
    {
        public string Text { get; set; }
        public Pen pen { get; set; }
        public Point PrevPoint { get; set; }
        public Point CurPoint { get; set; }
        public bool Cleaning { get; set; }


        public Message()
        {
            Text = "";
            pen = null;
            Cleaning = false;
        }

       
    }

    public byte[] Serialize(Message message)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        byte[] buf = formatter.Serializer(message);
    }

    public object[] Deserialize(string filePath)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        object[] transport;
        using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
        {
            transport = (object[])formatter.Deserialize(fs);
        }
        return transport;
    }
}
