using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;






namespace ChangingColor
{
    public partial class Form1 : Form
    {
        private bool fullscreen;

        public Form1()
        {
            InitializeComponent();
           
        }


        private void GoFullscreen()
        {
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            {
                //GoFullscreen();
                //fullscreen = true;
                //
                
            }
            {
                
                Control ctrl = ((Control)sender);
                switch (ctrl.BackColor.Name)
                {
                    case "Red":
                        ctrl.BackColor = Color.Yellow;
                        break;
                    case "Black":
                        ctrl.BackColor = Color.White;
                        break;
                    case "White":
                        ctrl.BackColor = Color.Red;
                        break;
                    case "Yellow":
                        ctrl.BackColor = Color.Purple;
                        break;
                    case "Purple":
                        ctrl.BackColor = Color.Empty;                       
                       break;
                    default:
                        ctrl.BackColor = Color.Red;
                        break;


                }
            }
        
        }


        private void button12_Click(object sender, EventArgs e)
        {
            {
                //GoFullscreen();
                //fullscreen = false;

                Control ctrl = ((Control)sender);
                switch (ctrl.BackColor.Name)
                {
                    case "Red":
                        ctrl.BackColor = Color.Yellow;
                        break;
                    case "Black":
                        ctrl.BackColor = Color.White;
                        break;
                    case "White":
                        ctrl.BackColor = Color.Red;
                        break;
                    case "Yellow":
                        ctrl.BackColor = Color.Purple;
                        break;
                    case "Purple":
                        ctrl.BackColor = Color.Empty;
                        break;
                    default:
                        ctrl.BackColor = Color.Red;
                        break;
                

                }
            }
    }

        private void button13_Click(object sender, EventArgs e)
        {
            {
                Control ctrl = ((Control)sender);
                switch (ctrl.BackColor.Name)
                {
                    case "Red":
                        ctrl.BackColor = Color.Yellow;
                        break;
                    case "Black":
                        ctrl.BackColor = Color.White;
                        break;
                    case "White":
                        ctrl.BackColor = Color.Red;
                        break;
                    case "Yellow":
                        ctrl.BackColor = Color.Purple;
                        break;
                    case "Purple":
                        ctrl.BackColor = Color.Empty;
                        break;
                    default:
                        ctrl.BackColor = Color.Red;
                        break;
                }

                }
            }

        private void button21_Click(object sender, EventArgs e)
        {
            {
                Control ctrl = ((Control)sender);
                switch (ctrl.BackColor.Name)
                {
                    case "Red":
                        ctrl.BackColor = Color.Yellow;
                        break;
                    case "Black":
                        ctrl.BackColor = Color.White;
                        break;
                    case "White":
                        ctrl.BackColor = Color.Red;
                        break;
                    case "Yellow":
                        ctrl.BackColor = Color.Purple;
                        break;
                    case "Purple":
                        ctrl.BackColor = Color.Empty;
                        break;
                    default:
                        ctrl.BackColor = Color.Red;
                        break;
                }

            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            {
                Control ctrl = ((Control)sender);
                switch (ctrl.BackColor.Name)
                {
                    case "Red":
                        ctrl.BackColor = Color.Yellow;
                        break;
                    case "Black":
                        ctrl.BackColor = Color.White;
                        break;
                    case "White":
                        ctrl.BackColor = Color.Red;
                        break;
                    case "Yellow":
                        ctrl.BackColor = Color.Purple;
                        break;
                    case "Purple":
                        ctrl.BackColor = Color.Empty;
                        break;
                    default:
                        ctrl.BackColor = Color.Red;
                        break;
                }

            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            {
                Control ctrl = ((Control)sender);
                switch (ctrl.BackColor.Name)
                {
                    case "Red":
                        ctrl.BackColor = Color.Yellow;
                        break;
                    case "Black":
                        ctrl.BackColor = Color.White;
                        break;
                    case "White":
                        ctrl.BackColor = Color.Red;
                        break;
                    case "Yellow":
                        ctrl.BackColor = Color.Purple;
                        break;
                    case "Purple":
                        ctrl.BackColor = Color.Empty;
                        break;
                    default:
                        ctrl.BackColor = Color.Red;
                        break;
                }

            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            {
                Control ctrl = ((Control)sender);
                switch (ctrl.BackColor.Name)
                {
                    case "Red":
                        ctrl.BackColor = Color.Yellow;
                        break;
                    case "Black":
                        ctrl.BackColor = Color.White;
                        break;
                    case "White":
                        ctrl.BackColor = Color.Red;
                        break;
                    case "Yellow":
                        ctrl.BackColor = Color.Purple;
                        break;
                    case "Purple":
                        ctrl.BackColor = Color.Empty;
                        break;
                    default:
                        ctrl.BackColor = Color.Red;
                        break;
                }

            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            {
                Control ctrl = ((Control)sender);
                switch (ctrl.BackColor.Name)
                {
                    case "Red":
                        ctrl.BackColor = Color.Yellow;
                        break;
                    case "Black":
                        ctrl.BackColor = Color.White;
                        break;
                    case "White":
                        ctrl.BackColor = Color.Red;
                        break;
                    case "Yellow":
                        ctrl.BackColor = Color.Purple;
                        break;
                    case "Purple":
                        ctrl.BackColor = Color.Empty;
                        break;
                    default:
                        ctrl.BackColor = Color.Red;
                        break;
                }

            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            {
                Control ctrl = ((Control)sender);
                switch (ctrl.BackColor.Name)
                {
                    case "Red":
                        ctrl.BackColor = Color.Yellow;
                        break;
                    case "Black":
                        ctrl.BackColor = Color.White;
                        break;
                    case "White":
                        ctrl.BackColor = Color.Red;
                        break;
                    case "Yellow":
                        ctrl.BackColor = Color.Purple;
                        break;
                    case "Purple":
                        ctrl.BackColor = Color.Empty;
                        break;
                    default:
                        ctrl.BackColor = Color.Red;
                        break;
                }

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            {
                Control ctrl = ((Control)sender);
                switch (ctrl.BackColor.Name)
                {
                    case "Red":
                        ctrl.BackColor = Color.Yellow;
                        break;
                    case "Black":
                        ctrl.BackColor = Color.White;
                        break;
                    case "White":
                        ctrl.BackColor = Color.Red;
                        break;
                    case "Yellow":
                        ctrl.BackColor = Color.Purple;
                        break;
                    case "Purple":
                        ctrl.BackColor = Color.Empty;
                        break;
                    default:
                        ctrl.BackColor = Color.Red;
                        break;
                }

            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            {
                Control ctrl = ((Control)sender);
                switch (ctrl.BackColor.Name)
                {
                    case "Red":
                        ctrl.BackColor = Color.Yellow;
                        break;
                    case "Black":
                        ctrl.BackColor = Color.White;
                        break;
                    case "White":
                        ctrl.BackColor = Color.Red;
                        break;
                    case "Yellow":
                        ctrl.BackColor = Color.Purple;
                        break;
                    case "Purple":
                        ctrl.BackColor = Color.Empty;
                        break;
                    default:
                        ctrl.BackColor = Color.Red;
                        break;
                }

            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            {
                Control ctrl = ((Control)sender);
                switch (ctrl.BackColor.Name)
                {
                    case "Red":
                        ctrl.BackColor = Color.Yellow;
                        break;
                    case "Black":
                        ctrl.BackColor = Color.White;
                        break;
                    case "White":
                        ctrl.BackColor = Color.Red;
                        break;
                    case "Yellow":
                        ctrl.BackColor = Color.Purple;
                        break;
                    case "Purple":
                        ctrl.BackColor = Color.Empty;
                        break;
                    default:
                        ctrl.BackColor = Color.Red;
                        break;
                }

            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            {
                Control ctrl = ((Control)sender);
                switch (ctrl.BackColor.Name)
                {
                    case "Red":
                        ctrl.BackColor = Color.Yellow;
                        break;
                    case "Black":
                        ctrl.BackColor = Color.White;
                        break;
                    case "White":
                        ctrl.BackColor = Color.Red;
                        break;
                    case "Yellow":
                        ctrl.BackColor = Color.Purple;
                        break;
                    case "Purple":
                        ctrl.BackColor = Color.Empty;
                        break;
                    default:
                        ctrl.BackColor = Color.Red;
                        break;
                }

            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            {
                Control ctrl = ((Control)sender);
                switch (ctrl.BackColor.Name)
                {
                    case "Red":
                        ctrl.BackColor = Color.Yellow;
                        break;
                    case "Black":
                        ctrl.BackColor = Color.White;
                        break;
                    case "White":
                        ctrl.BackColor = Color.Red;
                        break;
                    case "Yellow":
                        ctrl.BackColor = Color.Purple;
                        break;
                    case "Purple":
                        ctrl.BackColor = Color.Empty;
                        break;
                    default:
                        ctrl.BackColor = Color.Red;
                        break;
                }

            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            {
                Control ctrl = ((Control)sender);
                switch (ctrl.BackColor.Name)
                {
                    case "Red":
                        ctrl.BackColor = Color.Yellow;
                        break;
                    case "Black":
                        ctrl.BackColor = Color.White;
                        break;
                    case "White":
                        ctrl.BackColor = Color.Red;
                        break;
                    case "Yellow":
                        ctrl.BackColor = Color.Purple;
                        break;
                    case "Purple":
                        ctrl.BackColor = Color.Empty;
                        break;
                    default:
                        ctrl.BackColor = Color.Red;
                        break;
                }

            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            {
                Control ctrl = ((Control)sender);
                switch (ctrl.BackColor.Name)
                {
                    case "Red":
                        ctrl.BackColor = Color.Yellow;
                        break;
                    case "Black":
                        ctrl.BackColor = Color.White;
                        break;
                    case "White":
                        ctrl.BackColor = Color.Red;
                        break;
                    case "Yellow":
                        ctrl.BackColor = Color.Purple;
                        break;
                    case "Purple":
                        ctrl.BackColor = Color.Empty;
                        break;
                    default:
                        ctrl.BackColor = Color.Red;
                        break;
                }

            }
        }
    }
    }

