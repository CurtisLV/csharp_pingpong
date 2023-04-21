using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_pingpong
{
    public partial class CharacterForm : Form
    {
        public CharacterForm()
        {
            InitializeComponent();
        }

        private void someFaceCharacter_Click(object sender, EventArgs e)
        {
            (Owner as Pong).pongBall.Image = Image.FromFile(
                @"C:\Users\karli\Desktop\GitHub\csharp_pingpong\MOG.png"
            );
            (Owner as Pong).pongTimer.Start();
            this.Hide();
        }

        private void secondFace_Click(object sender, EventArgs e)
        {
            //
        }

        private void thirdFace_Click(object sender, EventArgs e)
        {
            //
        }

        private void fourthFace_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
