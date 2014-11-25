using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VirtualPiano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString().Equals("J"))
            {
                MessageBox.Show(e.KeyCode.ToString());
            }
            else
            {
                MessageBox.Show("miau");
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString());
            
            string tecla = e.KeyCode.ToString();
            switch (tecla)
            {
                case "Tab":
                    this.btnc1.BackColor = System.Drawing.Color.Cyan;
                        //(Color.Cyan);
                   // System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac3\Cortados\g.wav");
                    /*SoundEffect soundEffect;
                    soundEffect = Content.Load<SoundEffect>(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac3\Cortados\g.wav");
                    SoundEffectInstance instance = soundEffect.CreateInstance();*/
                    //instance.IsLooped = true;
                    System.Media.SoundPlayer playerc = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac3\Cortados\c.wav");
                    playerc.Play();
                    break;
                case "Q":
                    this.btnd1.BackColor = System.Drawing.Color.Cyan;
                    System.Media.SoundPlayer playerd = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac3\Cortados\d.wav");
                    playerd.Play();
                    break;
                case "W":
                    this.btne1.BackColor = System.Drawing.Color.Cyan;
                    System.Media.SoundPlayer playere = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac3\Cortados\e.wav");
                    playere.Play();
                    break;
                case "E":
                    this.btnf1.BackColor = System.Drawing.Color.Cyan;
                    System.Media.SoundPlayer playerf = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac3\Cortados\f.wav");
                    playerf.Play();
                    break;
                case "R":
                    this.btng1.BackColor = System.Drawing.Color.Cyan;
                    System.Media.SoundPlayer playerg = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac3\Cortados\g.wav");
                    playerg.Play();
                    break;
                case "T":
                    this.btna1.BackColor = System.Drawing.Color.Cyan;
                    System.Media.SoundPlayer playera = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac3\Cortados\a.wav");
                    playera.Play();
                    break;
                case "Y":
                    this.btnb1.BackColor = System.Drawing.Color.Cyan;
                    System.Media.SoundPlayer playerb = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac3\Cortados\b.wav");
                    playerb.Play();
                    break;
                case "U":
                    this.btnc2.BackColor = System.Drawing.Color.Cyan;
                    System.Media.SoundPlayer playerc2 = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac4\Cortados\c.wav");
                    playerc2.Play();
                    break;
                case "I":
                    this.btnd2.BackColor = System.Drawing.Color.Cyan;
                    System.Media.SoundPlayer playerd2 = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac4\Cortados\d.wav");
                    playerd2.Play();
                    break;
                case "O":
                    this.btne2.BackColor = System.Drawing.Color.Cyan;
                    System.Media.SoundPlayer playere2 = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac4\Cortados\e.wav");
                    playere2.Play();
                    break;
                case "P":
                    this.btnf2.BackColor = System.Drawing.Color.Cyan;
                    System.Media.SoundPlayer playerf2 = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac4\Cortados\f.wav");
                    playerf2.Play();
                    break;
                case "OemOpenBrackets":
                    this.btng2.BackColor = System.Drawing.Color.Cyan;
                    System.Media.SoundPlayer playerg2 = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac4\Cortados\g.wav");
                    playerg2.Play();
                    break;
                case "Oem6":
                    this.btna2.BackColor = System.Drawing.Color.Cyan;
                    System.Media.SoundPlayer playera2 = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac4\Cortados\a.wav");
                    playera2.Play();
                    break;
                case "Oem5":
                    this.btnb2.BackColor = System.Drawing.Color.Cyan;
                    System.Media.SoundPlayer playerb2 = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac4\Cortados\b.wav");
                    playerb2.Play();
                    break;
                default:
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            this.btnc1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnd1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btne1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnf1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btng1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btna1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnb1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnc2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnd2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btne2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnf2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btng2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btna2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnb2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
        }


    }
}
