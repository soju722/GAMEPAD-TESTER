using GLFW;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GamepadNameSpace;
using System.Reflection.Emit;
using System.Diagnostics;
 


namespace WinFormsApp10
{
    public partial class Form1 : Form
    {
        private int controller;
        public Form1()
        {
            InitializeComponent();
            buttonIcons();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 5;
            controllerName();
            controllerButtons();
            controllerAxes();
        }
        private void Form1_Load(object sender, EventArgs e)
        {                
            this.Text = "Gamepad Tester";
        }

        private void controllerName()
        {
            Gamepad gp = new(controller);
            foreach (Control control in this.Controls)
            {

                if (gp.Connected)
                {
                    label1.Text = gp.JoystickName;
                    pictureBox18.Show();
                    pictureBox19.Show();
                    pictureBox20.Show();
                    control.Enabled = true;
                    timer1.Start();
                }


                else
                {
                    label1.Text = gp.Disconnected;
                    pictureBox18.Hide();
                    pictureBox19.Hide();
                    pictureBox20.Hide();
                    control.Enabled = false;
                    label1.Enabled = true;
                    timer1.Start();
                }
            }
        }

        private void controllerButtons()
        {
            Gamepad gp = new Gamepad(controller);
            InputState[] button = gp.button;
            for (int i = 0; i < button.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        if (button[i] == InputState.Press)
                        {
                            pictureBox15.Show();
                            button1.BackColor = Color.LightSteelBlue;
                        }
                        else
                        {
                            pictureBox15.Hide();
                            button1.BackColor = Color.White;
                        }
                        break;

                    case 1:
                        if (button[i] == InputState.Press)
                        {
                            pictureBox13.Show();
                            button2.BackColor = Color.LightSteelBlue;
                        }
                        else
                        {
                            pictureBox13.Hide();
                            button2.BackColor = Color.White;
                        }
                        break;

                    case 2:
                        if (button[i] == InputState.Press)
                        {
                            pictureBox11.Show();
                            button3.BackColor = Color.LightSteelBlue;
                        }
                        else
                        {
                            pictureBox11.Hide();
                            button3.BackColor = Color.White;
                        }
                        break;

                    case 3:
                        if (button[i] == InputState.Press)
                        {
                            pictureBox17.Show();
                            button4.BackColor = Color.LightSteelBlue;
                        }
                        else
                        {
                            pictureBox17.Hide();
                            button4.BackColor = Color.White;
                        }
                        break;

                    case 4:
                        if (button[i] == InputState.Press)
                        {
                            pictureBox24.Show();
                            button5.BackColor = Color.LightSteelBlue;
                        }
                        else
                        {
                            pictureBox24.Hide();
                            button5.BackColor = Color.White;
                        }
                        break;

                    case 5:
                        if (button[i] == InputState.Press)
                        {
                            pictureBox28.Show();
                            button6.BackColor = Color.LightSteelBlue;                            
                        }
                        else
                        {
                            button6.BackColor = Color.White;
                            pictureBox28.Hide();
                        }
                        break;

                    case 6:
                        if (button[i] == InputState.Press)
                        {
                            button7.BackColor = Color.LightSteelBlue;
                            pictureBox26.Show();
                        }
                        else
                        {
                            button7.BackColor = Color.White;
                            pictureBox26.Hide();
                        }

                        break;

                    case 7:
                        if (button[i] == InputState.Press)
                        {
                            button8.BackColor = Color.LightSteelBlue;
                            pictureBox30.Show();
                        }
                        else { 
                            button8.BackColor = Color.White;
                            pictureBox30.Hide();
                        }
                        break;

                    case 8:
                        if (button[i] == InputState.Press)
                        {
                            pictureBox3.Show();
                            button9.BackColor = Color.LightSteelBlue;
                        }
                        else
                        {
                            pictureBox3.Hide();
                            button9.BackColor = Color.White;
                        }
                        break;

                    case 9:
                        if (button[i] == InputState.Press)
                        {
                            pictureBox1.Show();
                            button10.BackColor = Color.LightSteelBlue;
                        }
                        else
                        {
                            button10.BackColor = Color.White;
                            pictureBox1.Hide();
                        }
                        break;

                    case 10:
                        if (button[i] == InputState.Press)
                        {
                            button11.BackColor = Color.LightSteelBlue;
                        }
                        else
                            button11.BackColor = Color.White;
                        break;

                    case 11:
                        if (button[i] == InputState.Press) { 
                            button12.BackColor = Color.LightSteelBlue;
                        }
                        else
                            button12.BackColor = Color.White;
                        break;

                    case 12:
                        if (button[i] == InputState.Press)
                        {
                            pictureBox22.Show();
                            button13.BackColor = Color.LightSteelBlue;
                        }
                        else
                        {
                            button13.BackColor = Color.White;
                            pictureBox22.Hide();
                        }

                        break;

                    case 13:
                        if (button[i] == InputState.Press)
                        {
                            button14.BackColor = Color.LightSteelBlue;
                        }
                        else
                            button14.BackColor = Color.White;
                        break;

                    case 14:
                        if (button[i] == InputState.Press)
                        {
                            pictureBox2.Show();
                            button15.BackColor = Color.LightSteelBlue;
                        }
                        else
                        {
                            pictureBox2.Hide();
                            button15.BackColor = Color.White;
                        }
                        break;

                    case 15:
                        if (button[i] == InputState.Press)
                        {
                            pictureBox4.Show();
                            button16.BackColor = Color.LightSteelBlue;
                        }
                        else
                        {
                            pictureBox4.Hide();
                            button16.BackColor = Color.White;
                        }
                        break;

                    case 16:
                        if (button[i] == InputState.Press)
                        {
                            pictureBox6.Show();
                            button17.BackColor = Color.LightSteelBlue;
                        }
                        else
                        {
                            pictureBox6.Hide();
                            button17.BackColor = Color.White;
                        }
                        break;

                    case 17:
                        if (button[i] == InputState.Press)
                        {
                            pictureBox8.Show();
                            button18.BackColor = Color.LightSteelBlue;
                        }
                        else if (button[4] == InputState.Press && button[5] == InputState.Press
                        && button[1] == InputState.Press)
                        {
                            this.Close();
                        }
                        else
                        {
                            pictureBox8.Hide();
                            button18.BackColor = Color.White;
                        }
                        break;

                    default:
                        break;





                }
            }
        }

        private void controllerAxes()
        {
            System.Drawing.Drawing2D.GraphicsPath grp = new System.Drawing.Drawing2D.GraphicsPath();
            grp.AddEllipse(0, 0, pictureBox19.Width - 1, pictureBox19.Height - 1);
            Region rg = new Region(grp);
            pictureBox19.Region = rg;

            System.Drawing.Drawing2D.GraphicsPath grp1 = new System.Drawing.Drawing2D.GraphicsPath();
            grp1.AddEllipse(0, 0, pictureBox20.Width - 1, pictureBox20.Height - 1);
            Region rg1 = new Region(grp1);
            pictureBox20.Region = rg1;

            Gamepad gp = new Gamepad(controller);
            float[] Axes = gp.Axes;
            for (int i = 0; i < Axes.Length; i++)
            {

                if (Axes.Length == 6)
                {
                    label2.Text = "X Axis: " + Axes[0].ToString("0.000");
                    label4.Text = "Y Axis: " + Axes[1].ToString("0.000");
                    label8.Text = "X Axis: " + Axes[2].ToString("0.000");
                    label10.Text = "X Rotation: " + Axes[3].ToString("0.000");
                    label9.Text = "Y Axis: " + Axes[5].ToString("0.000");
                    label11.Text = "Y Rotation: " + Axes[4].ToString("0.000");

                    radioButton2.Location = new Point((int)(45 + Axes[2] * 30), (int)(40 + Axes[5] * 30));
                    radioButton1.Location = new Point((int)(45 + Axes[0] * 30), (int)(40 + Axes[1] * 30));
                    pictureBox21.Controls.Add(pictureBox19);
                    pictureBox19.Location = new Point((int)(170 + Axes[0] * 15), (int)(186 + Axes[1] * 15));
                    pictureBox19.BackColor = Color.Transparent;

                    pictureBox21.Controls.Add(pictureBox20);
                    pictureBox20.Location = new Point((int)(344 + Axes[2] * 15), (int)(186 + Axes[5] * 15));
                    pictureBox20.BackColor = Color.Transparent;
                    radioButton3.Location = new Point((int)(35 + Axes[3] * 35), (int)(30 + Axes[4] * 35));

                }

                else if (Axes.Length == 4)
                {
                    label2.Text = "X Axis: " + Axes[0].ToString("0.000");
                    label4.Text = "Y Axis: " + Axes[1].ToString("0.000");
                    label8.Text = "X Axis: " + Axes[2].ToString("0.000");
                    label10.Text = "X Rotation: " + Axes[3].ToString("0.000");
                    pictureBox21.Controls.Add(pictureBox19);
                    pictureBox19.Location = new Point((int)(170 + Axes[0] * 15), (int)(186 + Axes[1] * 15));
                    pictureBox19.BackColor = Color.Transparent;
                    pictureBox21.Controls.Add(pictureBox20);
                    pictureBox20.Location = new Point((int)(344 + Axes[2] * 15), 186);
                    pictureBox20.BackColor = Color.Transparent;


                }

            }
        }
 
        private void buttonIcons()
        {
            pictureBox21.Controls.Add(pictureBox17);
            pictureBox17.Location = new Point(456, 77);
            pictureBox17.BackColor = Color.Transparent;

            pictureBox21.Controls.Add(pictureBox15);
            pictureBox15.Location = new Point(413, 121);
            pictureBox15.BackColor = Color.Transparent;

            pictureBox21.Controls.Add(pictureBox11);
            pictureBox11.Location = new Point(501, 121);
            pictureBox11.BackColor = Color.Transparent;

            pictureBox21.Controls.Add(pictureBox13);
            pictureBox13.Location = new Point(456, 165);
            pictureBox13.BackColor = Color.Transparent;

            pictureBox21.Controls.Add(pictureBox22);
            pictureBox22.Location = new Point(280, 178);
            pictureBox22.BackColor = Color.Transparent;

            pictureBox21.Controls.Add(pictureBox4);
            pictureBox4.Location = new Point(135, 126);
            pictureBox4.BackColor = Color.Transparent;

            pictureBox21.Controls.Add(pictureBox8);
            pictureBox8.Location = new Point(79, 126);
            pictureBox8.BackColor = Color.Transparent;

            pictureBox21.Controls.Add(pictureBox2);
            pictureBox2.Location = new Point(107, 99);
            pictureBox2.BackColor = Color.Transparent;

            pictureBox21.Controls.Add(pictureBox6);
            pictureBox6.Location = new Point(107, 153);
            pictureBox6.BackColor = Color.Transparent;

            pictureBox21.Controls.Add(pictureBox1);
            pictureBox1.Location = new Point(340, 143);
            pictureBox1.BackColor = Color.Transparent;

            pictureBox21.Controls.Add(pictureBox3);
            pictureBox3.Location = new Point(232, 142);
            pictureBox3.BackColor = Color.Transparent;











        }

    }
}