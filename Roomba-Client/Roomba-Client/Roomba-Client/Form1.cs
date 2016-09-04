using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roomba_Client
{
    public partial class Frm_roomba : Form
    {
        public Frm_roomba()
        {
            InitializeComponent();
        }

        private void PB_Roomba_Click(object sender, EventArgs e)
        {
            txt_IP.BackColor = Color.Yellow;
            Browser.Navigate(txt_IP.Text);
            System.Threading.Thread.Sleep(100);
            txt_IP.BackColor = Color.White;
        }

        private void Frm_roomba_KeyDown(object sender, KeyEventArgs e)
        {}

        private void Frm_roomba_KeyPress(object sender, KeyPressEventArgs e)
        {}

        private void Browser_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        Keys keyCode = e.KeyCode;

        Console.Write(keyCode);

        if (keyCode == Keys.W)
        {
            txt_Forward.BackColor = Color.Yellow;
            Browser.Navigate(txt_IP.Text + txt_Forward.Text);
        }
        else
        {
            txt_Forward.BackColor = Color.White;
        }

        if (keyCode == Keys.S)
        {
            txt_backward.BackColor = Color.Yellow;
            Browser.Navigate(txt_IP.Text + txt_backward.Text);
        }
        else
        {
            txt_backward.BackColor = Color.White;
        }

        if (keyCode == Keys.A)
        {
            txt_left.BackColor = Color.Yellow;
            Browser.Navigate(txt_IP.Text + txt_left.Text);
        }
        else
        {
            txt_left.BackColor = Color.White;
        }

        if (keyCode == Keys.D)
        {
            txt_right.BackColor = Color.Yellow;
            Browser.Navigate(txt_IP.Text + txt_right.Text);
        }
        else
        {
            txt_right.BackColor = Color.White;
        }

        if (keyCode != Keys.W && keyCode != Keys.S && keyCode != Keys.A && keyCode != Keys.D)
        {
            txt_quit.BackColor = Color.Yellow;
            Browser.Navigate(txt_IP.Text + txt_quit.Text);
        }
        else
        {
            txt_quit.BackColor = Color.White;
        }
    }
    }
}
