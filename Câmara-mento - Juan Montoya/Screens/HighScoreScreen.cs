using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Câmara_mento___Juan_Montoya
{
    public partial class HighScoreScreen : UserControl
    {
        public HighScoreScreen()
        {
            loadHighScore();
            label1.Text = GameMenuScreen.SurviorTimer.ToString();
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveHighScore();
        }

        public void loadHighScore()
        {
            XmlReader reader = XmlReader.Create("Resources/XMLFile1.xml");

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    string player = reader.ReadString();

                    reader.ReadToNextSibling("time");
                    int time = reader.ReadContentAsInt();

                }
            }
            reader.Close();
        }


        public void SaveHighScore()
        {
            XmlWriter writer = XmlWriter.Create("Resources/XMLFile1.xml", null);

            writer.WriteStartElement("player", textBox1.Text);
                writer.WriteElementString("time", GameMenuScreen.SurviorTimer.ToString());
                writer.WriteEndElement();

            writer.WriteEndElement();
            writer.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new MenuScreen());
        }
    }
}
