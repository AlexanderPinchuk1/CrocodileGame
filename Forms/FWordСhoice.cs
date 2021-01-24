using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrocodileGame.Forms
{
    public partial class FWordСhoice : Form
    {

        private int NumFirstVariant = -1;
        private int NumSecondVariant = -1;
        private int NumThirdVariant = -1;

        private String GameWord = "";

        private readonly List<string> AllWords = new List<string>();

        private readonly string FileWithWords = "words.txt";

        public FWordСhoice()
        {
            InitializeComponent();
            LoadFileWithWords();
            RandomNumsWords();
            EditButtons();
        }

        private void EditButtons()
        {
            ButFirstVariant.Text = AllWords[NumFirstVariant];
            ButSecondVariant.Text = AllWords[NumSecondVariant];
            ButThirdVariant.Text = AllWords[NumThirdVariant];
        }

        private void LoadFileWithWords()
        {
            using (StreamReader streamReader = new StreamReader(FileWithWords, System.Text.Encoding.Default))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    AllWords.Add(line);
                }
            }
        }

        private void RandomNumsWords()
        {
            Random random = new Random();
            NumFirstVariant = random.Next(0, AllWords.Count);
            NumSecondVariant = random.Next(0, AllWords.Count);
            while (NumFirstVariant == NumSecondVariant)
            {
                NumSecondVariant = random.Next(0, AllWords.Count);
            }
            NumThirdVariant = random.Next(0, AllWords.Count);
            while ((NumFirstVariant == NumThirdVariant) || (NumSecondVariant == NumThirdVariant))
            {
                NumThirdVariant = random.Next(0, AllWords.Count);
            }
        }

        private void ButFirstVariant_Click(object sender, EventArgs e)
        {
            GameWord = AllWords[NumFirstVariant];
            Close();
        }

        private void ButSecondVariant_Click(object sender, EventArgs e)
        {
            GameWord = AllWords[NumSecondVariant];
            Close();
        }

        private void ButThirdVariant_Click(object sender, EventArgs e)
        {
            GameWord = AllWords[NumThirdVariant];
            Close();
        }

        private void FWordСhoice_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (GameWord == "")
            { 
                int value = NumFirstVariant % 3;
                if (value == 0)
                    GameWord = AllWords[NumFirstVariant];
                else if (value ==1)
                    GameWord = AllWords[NumSecondVariant];
                else
                    GameWord = AllWords[NumThirdVariant];
            }
        }

        public string GetGameWord()
        {
            return GameWord;
        }
    }
}
