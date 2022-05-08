using System;
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
    public partial class main_page : Form
    {

        public main_page()
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
            if (is_move == true)
            {
                this.SetDesktopLocation(MousePosition.X - val_x, MousePosition.Y - val_y);
            }
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

        private void btn_region_Click(object sender, EventArgs e)
        {
            var clickOption = sender as Button;

            if (clickOption != null)
            {
                if(clickOption == btn_seoul)
                {
                    this.Visible = false;
                    Seoul frm = new Seoul();
                    frm.Owner = this;
                    frm.Show();
                }

                else if (clickOption == btn_gyeonggi)
                {
                    this.Visible = false;
                    Gyeonggi frm = new Gyeonggi();
                    frm.Owner = this;
                    frm.Show();
                }

                else if (clickOption == btn_incheon)
                {
                    this.Visible = false;
                    Incheon frm = new Incheon();
                    frm.Owner = this;
                    frm.Show();
                }

                else if (clickOption == btn_gangwon)
                {
                    this.Visible = false;
                    Gangwon frm = new Gangwon();
                    frm.Owner = this;
                    frm.Show();
                }

                else if (clickOption == btn_choongchung)
                {
                    this.Visible = false;
                    Choongchung frm = new Choongchung();
                    frm.Owner = this;
                    frm.Show();
                }

                else if (clickOption == btn_gyeongsang)
                {
                    this.Visible = false;
                    Gyeongsang frm = new Gyeongsang();
                    frm.Owner = this;
                    frm.Show();
                }

                else if (clickOption == btn_jeonra)
                {
                    this.Visible = false;
                    Jeonra frm = new Jeonra();
                    frm.Owner = this;
                    frm.Show();
                }

                else if (clickOption == btn_daejeon)
                {
                    this.Visible = false;
                    Daejeon frm = new Daejeon();
                    frm.Owner = this;
                    frm.Show();
                }

                else if (clickOption == btn_sejong)
                {
                    this.Visible = false;
                    Sejong frm = new Sejong();
                    frm.Owner = this;
                    frm.Show();
                }

                else if (clickOption == btn_daegu)
                {
                    this.Visible = false;
                    Daegu frm = new Daegu();
                    frm.Owner = this;
                    frm.Show();
                }

                else if (clickOption == btn_busan)
                {
                    this.Visible = false;
                    Busan frm = new Busan();
                    frm.Owner = this;
                    frm.Show();
                }

                else if (clickOption == btn_ulsan)
                {
                    this.Visible = false;
                    Ulsan frm = new Ulsan();
                    frm.Owner = this;
                    frm.Show();
                }

                else if (clickOption == btn_gwangju)
                {
                    this.Visible = false;
                    Gwangju frm = new Gwangju();
                    frm.Owner = this;
                    frm.Show();
                }

                else
                {
                    this.Visible = false;
                    Jeju frm = new Jeju();
                    frm.Owner = this;
                    frm.Show();
                }
            }
        }
    }
}
