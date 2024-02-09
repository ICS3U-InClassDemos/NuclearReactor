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

namespace NuclearReactor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.alert);
            alertPlayer.Play();

            reactor1StateLabel.BackColor = Color.Red;
            reactor2StateLabel.BackColor = Color.Red;
            outputLabel.BackColor = Color.Red;
            outputLabel.ForeColor = Color.White;
            outputLabel.Text = "Meltdown Happening";
            //this.Text = "RUN AWAY!!!!!!";
            //this.BackColor = Color.White;

            Refresh();
            Thread.Sleep(1000);

            reactor1StateLabel.BackColor = Color.White;
            reactor2StateLabel.BackColor = Color.White;
            outputLabel.BackColor = Color.White;
            outputLabel.ForeColor = Color.Red;


            Refresh();
            Thread.Sleep(1000);

            reactor1StateLabel.BackColor = Color.Red;
            reactor2StateLabel.BackColor = Color.Red;
            outputLabel.BackColor = Color.Red;
            outputLabel.ForeColor = Color.White;

            Refresh();
            Thread.Sleep(1000);

            reactor1StateLabel.BackColor = Color.White;
            reactor2StateLabel.BackColor = Color.White;
            outputLabel.BackColor = Color.White;
            outputLabel.ForeColor = Color.Red;

        }

    }
}
