using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpawnCreator
{
    public partial class Form_MainMenu : Form
    {
        public Form_MainMenu()
        {
            InitializeComponent();
        }

        private bool mouseDown;
        private Point lastLocation;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Firebrick;
            label2.ForeColor = Color.White;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Gainsboro;
            label2.ForeColor = Color.Black;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Form_ItemCreator form2 = new Form_ItemCreator();
            form2.Show();
            this.Hide();
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Firebrick;
            label5.ForeColor = Color.White;
            label5.Text = "working..";
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Gainsboro;
            label5.ForeColor = Color.Black;
            label5.Text = "Unit Creator";
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Firebrick;
            label6.ForeColor = Color.White;
            label6.Text = "working..";
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Gainsboro;
            label6.ForeColor = Color.Black;
            label6.Text = "Object Creator";
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            label7.BackColor = Color.Firebrick;
            label7.ForeColor = Color.White;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.BackColor = Color.IndianRed;
            label7.ForeColor = Color.Black;
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            label8.BackColor = Color.Firebrick;
            label8.ForeColor = Color.White;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.BackColor = Color.IndianRed;
            label8.ForeColor = Color.Black;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
