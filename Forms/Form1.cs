using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace QSKY2020
{
    public partial class Form1 : Form
    {
        private IconButton currbutton;
        private Panel leftborBut;
        private Form currentChildForm;
        public Form1()
        {
            InitializeComponent();
            leftborBut = new Panel();
            leftborBut.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftborBut);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(179, 179, 255);
        }

        private void ActiveButton(object senderbtn, Color color)
        {
            if (senderbtn != null)
            {
                DisableButton();
                currbutton = (IconButton)senderbtn;
                currbutton.BackColor = Color.FromArgb(37, 36, 81);
                currbutton.ForeColor = color;
                currbutton.TextAlign = ContentAlignment.MiddleCenter;
                currbutton.IconColor = color;
                currbutton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currbutton.ImageAlign = ContentAlignment.MiddleRight;

                leftborBut.BackColor = color;
                leftborBut.Location = new Point(0, currbutton.Location.Y);
                leftborBut.Visible = true;
                leftborBut.BringToFront();

                iconCurrChildForm.IconChar = currbutton.IconChar;
                iconCurrChildForm.ForeColor = currbutton.ForeColor;
                lblTitleChildForm.Text = currbutton.Text;

            }
        }
        private void DisableButton()
        {
            if(currbutton != null)
            {
                currbutton.BackColor = Color.FromArgb(2, 27, 49);
                currbutton.ForeColor = Color.Gainsboro;
                currbutton.TextAlign = ContentAlignment.MiddleLeft;
                currbutton.IconColor = Color.Gainsboro;
                currbutton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currbutton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChilForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void cmd_dashboard_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            //OpenChilForm(new DashBoard());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color2);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color3);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color4);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color5);
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color6);
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color7);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftborBut.Visible = false;
            iconCurrChildForm.IconChar = IconChar.Home;
            iconCurrChildForm.ForeColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void iconButton8_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }
    }
}
