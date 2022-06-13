using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayingCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Deck deck;

        private void Form1_Load(object sender, EventArgs e)
        {
            deck = new Deck();
            pictureBox1.Image = Image.FromFile(@"..\..\back.PNG");
        }

        private void buttonNextCard_Click(object sender, EventArgs e)
        {
            Card a = deck.NextCard();
            pictureBox2.Image = Image.FromFile(a.FileName);
        }

        private void buttonShuffle_Click(object sender, EventArgs e)
        {
            deck.Shuffle();
        }
    }
}
