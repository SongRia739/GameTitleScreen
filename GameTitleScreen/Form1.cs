using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;


//created by SongRia739 (not finished)


namespace GameTitleScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LoadingLabel.Hide();
            Number3Label.Hide();
            Number2Label.Hide();
            Number1Label.Hide();
            BeginLabel.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           //start button is hidden once clicked
            StartButton.Hide();

            //loading sign along with the numbers appear
            LoadingLabel.Show();
            Number3Label.Show();
            Refresh();
            Thread.Sleep(1000);
            Number2Label.Show();
            Refresh();
            Thread.Sleep(1000);
            Number1Label.Show();
            Refresh();
            Thread.Sleep(1000);

            //hide numbers and show "begin!"
            Number3Label.Hide();
            Number2Label.Hide();
            Number1Label.Hide();
            BeginLabel.Show();

        }
    }
}
