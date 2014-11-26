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
        private bool teclaPresionado = false;
        //indica si hay una tecla presionada
        private string teclaPresionada;
        //Que almacena la tecla que fue presionada
        System.Media.SoundPlayer playerc = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac3\Cortados\c.wav");
        System.Media.SoundPlayer playerd = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac3\Cortados\d.wav");
        System.Media.SoundPlayer playere = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac3\Cortados\e.wav");
        System.Media.SoundPlayer playerf = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac3\Cortados\f.wav");
        System.Media.SoundPlayer playerg = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac3\Cortados\g.wav");
        System.Media.SoundPlayer playera = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac3\Cortados\a.wav");
        System.Media.SoundPlayer playerb = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac3\Cortados\b.wav");
        System.Media.SoundPlayer playerc2 = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac4\Cortados\c.wav");
        System.Media.SoundPlayer playerd2= new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac4\Cortados\d.wav");
        System.Media.SoundPlayer playere2 = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac4\Cortados\e.wav");
        System.Media.SoundPlayer playerf2 = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac4\Cortados\f.wav");
        System.Media.SoundPlayer playerg2 = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac4\Cortados\g.wav");
        System.Media.SoundPlayer playera2 = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac4\Cortados\a.wav");
        System.Media.SoundPlayer playerb2 = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac4\Cortados\b.wav");
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
                    if(teclaConfirmado(tecla))
                    {
                         this.btnc1.BackColor = System.Drawing.Color.Cyan;
                        //(Color.Cyan);
                       // System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac3\Cortados\g.wav");
                        /*SoundEffect soundEffect;
                        soundEffect = Content.Load<SoundEffect>(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac3\Cortados\g.wav");
                        SoundEffectInstance instance = soundEffect.CreateInstance();*/
                        //instance.IsLooped = true;
                        //System.Media.SoundPlayer playerc = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac3\Cortados\c.wav");
                        playerc.Play();
                    }
                    else
                    {
                    }
                   
                    break;
                case "Q":
                    if (teclaConfirmado(tecla))
                    {
                        this.btnd1.BackColor = System.Drawing.Color.Cyan;
                        //System.Media.SoundPlayer playerd = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac3\Cortados\d.wav");
                        playerd.Play();
                    }
                    else
                    {
                    }
                    break;
                case "W":
                    if (teclaConfirmado(tecla))
                    {
                        this.btne1.BackColor = System.Drawing.Color.Cyan;
                        //System.Media.SoundPlayer playere = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac3\Cortados\e.wav");
                        playere.Play();
                    }
                    else
                    {
                    }
                    
                    break;
                case "E":
                    if (teclaConfirmado(tecla))
                    {
                        this.btnf1.BackColor = System.Drawing.Color.Cyan;
                        //System.Media.SoundPlayer playerf = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac3\Cortados\f.wav");
                        playerf.Play();
                    }
                    else
                    {
                    }
                    
                    break;
                case "R":
                    if (teclaConfirmado(tecla))
                    {
                        this.btng1.BackColor = System.Drawing.Color.Cyan;
                        //System.Media.SoundPlayer playerg = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac3\Cortados\g.wav");
                        playerg.Play();
                    }
                    else
                    {
                    }
                    
                    break;
                case "T":
                    if (teclaConfirmado(tecla))
                    {
                        this.btna1.BackColor = System.Drawing.Color.Cyan;
                        //System.Media.SoundPlayer playera = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac3\Cortados\a.wav");
                        playera.Play();
                    }
                    else
                    {
                    }
                    
                    break;
                case "Y":
                    if (teclaConfirmado(tecla))
                    {
                        this.btnb1.BackColor = System.Drawing.Color.Cyan;
                        //System.Media.SoundPlayer playerb = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac3\Cortados\b.wav");
                        playerb.Play();
                    }
                    else
                    {
                    }
                    
                    break;
                case "U":
                    if (teclaConfirmado(tecla))
                    {
                        this.btnc2.BackColor = System.Drawing.Color.Cyan;
                        //System.Media.SoundPlayer playerc2 = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac4\Cortados\c.wav");
                        playerc2.Play();
                    }
                    else
                    {
                    }
                    
                    break;
                case "I":
                    if (teclaConfirmado(tecla))
                    {
                        this.btnd2.BackColor = System.Drawing.Color.Cyan;
                        //System.Media.SoundPlayer playerd2 = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac4\Cortados\d.wav");
                        playerd2.Play();
                    }
                    else
                    {
                    }
                    
                    break;
                case "O":
                    if (teclaConfirmado(tecla))
                    {
                        this.btne2.BackColor = System.Drawing.Color.Cyan;
                        //System.Media.SoundPlayer playere2 = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac4\Cortados\e.wav");
                        playere2.Play();
                    }
                    else
                    {
                    }
                    
                    break;
                case "P":
                    if (teclaConfirmado(tecla))
                    {
                        this.btnf2.BackColor = System.Drawing.Color.Cyan;
                        //System.Media.SoundPlayer playerf2 = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac4\Cortados\f.wav");
                        //playerf2.Stop();
                        playerf2.Play();
                    }
                    else
                    {
                    }
                    break;
                case "OemOpenBrackets":
                    if (teclaConfirmado(tecla))
                    {
                        this.btng2.BackColor = System.Drawing.Color.Cyan;
                        //System.Media.SoundPlayer playerg2 = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac4\Cortados\g.wav");
                        playerg2.Play();
                    }
                    else
                    {
                    }
                    
                    break;
                case "Oem6":
                    if (teclaConfirmado(tecla))
                    {
                        this.btna2.BackColor = System.Drawing.Color.Cyan;
                        //System.Media.SoundPlayer playera2 = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac4\Cortados\a.wav");
                        playera2.Play();
                    }
                    else
                    {
                    }
                    break;
                case "Oem5":
                    if (teclaConfirmado(tecla))
                    {
                        this.btnb2.BackColor = System.Drawing.Color.Cyan;
                        //System.Media.SoundPlayer playerb2 = new System.Media.SoundPlayer(@"C:\Users\PeterNíkolas\Documents\Visual Studio 2010\Projects\VirtualPiano\VirtualPiano\media\octavac4\Cortados\b.wav");
                        playerb2.Play();
                    }
                    else
                    {
                    }
                    break;
                    
                default:
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString());
            string tecla = e.KeyCode.ToString();
            soltarTecla(tecla);
            if (soltarTecla(tecla))
            {
                this.btnc1.BackColor = System.Drawing.SystemColors.ControlLightLight;
                this.btnd1.BackColor = System.Drawing.SystemColors.ControlLightLight;
                this.btne1.BackColor = System.Drawing.SystemColors.ControlLightLight;
                this.btnf1.BackColor = System.Drawing.SystemColors.ControlLightLight;
                this.btng1.BackColor = System.Drawing.SystemColors.ControlLightLight;
                this.btna1.BackColor = System.Drawing.SystemColors.ControlLightLight;
                this.btnb1.BackColor = System.Drawing.SystemColors.ControlLightLight;
                this.btnc2.BackColor = System.Drawing.SystemColors.ControlLightLight;
                this.btnd2.BackColor = System.Drawing.SystemColors.ControlLightLight;
                this.btne2.BackColor = System.Drawing.SystemColors.ControlLightLight;
                this.btnf2.BackColor = System.Drawing.SystemColors.ControlLightLight;
                this.btng2.BackColor = System.Drawing.SystemColors.ControlLightLight;
                this.btna2.BackColor = System.Drawing.SystemColors.ControlLightLight;
                this.btnb2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            }
            else
            {
            }
            
        }
        private bool teclaConfirmado(string tecla)
        {
            if (teclaPresionado)
            {
                //nada pasa porque la tecla ya esta apachada
                return false;
            }
            else
            {
                teclaPresionado = true;
                teclaPresionada = tecla;
                return true;
            }
        }
        private bool soltarTecla(string tecla)
        {
            if (tecla == teclaPresionada)
            {
                teclaPresionado = false;
                playerc.Stop();
                return true;
            }
            else
            {
                return false; 
            }
        }
    }
}
