using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adding_Sound_CSharp
{
    public partial class FormSound : Form
    {
        SoundPlayer sound;
        public FormSound()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            sound.Play();
        }

        private void FormSound_Load(object sender, EventArgs e)
        {
            sound = new SoundPlayer(Properties.Resources.Terminator);
            
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            sound.PlayLooping();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            sound.Stop();
        }
    }
}
