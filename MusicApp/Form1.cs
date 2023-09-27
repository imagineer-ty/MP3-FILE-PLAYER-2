using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp
{
    public partial class MusicPlayerApp : Form
    {
        public MusicPlayerApp()
        {
            InitializeComponent();
        }

        //global variables of String Array to save name of songs
        String[] paths, files;

        private void btnPickSong_Click(object sender, EventArgs e)
        {
            //selects a song 
            OpenFileDialog ofd = new OpenFileDialog();

            //select multiple songs at once
            ofd.Multiselect = true;

            if(ofd.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                //saves name of track in files array
                files = ofd.SafeFileNames;
                //saves path of track in path array
                paths = ofd.FileNames;

                //display music titles in listbox
                for(int i = 0; i < files.Length; i++)
                {
                    listBoxSongs.Items.Add(files[i]); //displays songs
                }
            }
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //plays music by selecting in list 
            axWindowsMediaPlayerMusic.URL = paths[listBoxSongs.SelectedIndex];
        }

        private void axWindowsMediaPlayerMusic_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //closes app using x button icon top right
            this.Close();
        }
    }
}
