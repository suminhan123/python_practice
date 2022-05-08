﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vet_for_My_Pet
{
    public partial class Incheon : Form
    {
        public Incheon()
        {
            InitializeComponent();
        }

        bool is_move;
        int val_x, val_y;

        private void top_control_mouse_up(object sender, MouseEventArgs e)
        {
            is_move = false;
        }

        private void top_control_mouse_move(object sender, MouseEventArgs e)
        {

        }

        private void top_control_mouse_down(object sender, MouseEventArgs e)
        {
            is_move = true;
            val_x = e.X;
            val_y = e.Y;
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}