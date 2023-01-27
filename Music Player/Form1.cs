using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player
{
    public partial class MusicPlayer : Form
    {
        public MusicPlayer()
        {
            InitializeComponent();
            track_volume.Value = 50;
        }

        String[] paths, files;

        private void ChooseMusic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;

                for(int i =0; i < files.Length; i++)
                {
                    Music.Items.Add(files[i]);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayerMusic.Ctlcontrols.stop();
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayerMusic.Ctlcontrols.pause();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayerMusic.Ctlcontrols.play();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if(Music.SelectedIndex<Music.Items.Count-1)
            {
                Music.SelectedIndex = Music.SelectedIndex + 1;
            }
        }

        private void track_volume_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayerMusic.settings.volume = track_volume.Value;
        }

        private void Music_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayerMusic.URL = paths[Music.SelectedIndex];
        }
    }
}
