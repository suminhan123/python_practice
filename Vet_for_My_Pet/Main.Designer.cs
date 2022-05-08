namespace Vet_for_My_Pet
{
    partial class main_page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.top_control = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_jeju = new System.Windows.Forms.Button();
            this.btn_gwangju = new System.Windows.Forms.Button();
            this.btn_ulsan = new System.Windows.Forms.Button();
            this.btn_busan = new System.Windows.Forms.Button();
            this.btn_daegu = new System.Windows.Forms.Button();
            this.btn_sejong = new System.Windows.Forms.Button();
            this.btn_daejeon = new System.Windows.Forms.Button();
            this.btn_jeonra = new System.Windows.Forms.Button();
            this.btn_gyeongsang = new System.Windows.Forms.Button();
            this.btn_choongchung = new System.Windows.Forms.Button();
            this.btn_gangwon = new System.Windows.Forms.Button();
            this.btn_incheon = new System.Windows.Forms.Button();
            this.btn_gyeonggi = new System.Windows.Forms.Button();
            this.btn_seoul = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.top_control.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_control
            // 
            this.top_control.BackColor = System.Drawing.SystemColors.Info;
            this.top_control.Controls.Add(this.btn_minimize);
            this.top_control.Controls.Add(this.btn_close);
            this.top_control.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top_control.Location = new System.Drawing.Point(-7, 2);
            this.top_control.Name = "top_control";
            this.top_control.Size = new System.Drawing.Size(410, 18);
            this.top_control.TabIndex = 4;
            this.top_control.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_control_mouse_down);
            this.top_control.MouseMove += new System.Windows.Forms.MouseEventHandler(this.top_control_mouse_move);
            this.top_control.MouseUp += new System.Windows.Forms.MouseEventHandler(this.top_control_mouse_up);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.SystemColors.Info;
            this.btn_close.Location = new System.Drawing.Point(382, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(20, 20);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_jeju
            // 
            this.btn_jeju.BackColor = System.Drawing.SystemColors.Info;
            this.btn_jeju.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_jeju.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_jeju.FlatAppearance.BorderSize = 0;
            this.btn_jeju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_jeju.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_jeju.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_jeju.Location = new System.Drawing.Point(0, 930);
            this.btn_jeju.Name = "btn_jeju";
            this.btn_jeju.Size = new System.Drawing.Size(403, 70);
            this.btn_jeju.TabIndex = 5;
            this.btn_jeju.Text = "제주";
            this.btn_jeju.UseVisualStyleBackColor = true;
            this.btn_jeju.Click += new System.EventHandler(this.btn_region_Click);
            // 
            // btn_gwangju
            // 
            this.btn_gwangju.BackColor = System.Drawing.SystemColors.Info;
            this.btn_gwangju.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_gwangju.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_gwangju.FlatAppearance.BorderSize = 0;
            this.btn_gwangju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gwangju.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gwangju.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_gwangju.Location = new System.Drawing.Point(0, 860);
            this.btn_gwangju.Name = "btn_gwangju";
            this.btn_gwangju.Size = new System.Drawing.Size(403, 70);
            this.btn_gwangju.TabIndex = 6;
            this.btn_gwangju.Text = "광주";
            this.btn_gwangju.UseVisualStyleBackColor = true;
            this.btn_gwangju.Click += new System.EventHandler(this.btn_region_Click);
            // 
            // btn_ulsan
            // 
            this.btn_ulsan.BackColor = System.Drawing.SystemColors.Info;
            this.btn_ulsan.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_ulsan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_ulsan.FlatAppearance.BorderSize = 0;
            this.btn_ulsan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ulsan.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ulsan.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_ulsan.Location = new System.Drawing.Point(0, 790);
            this.btn_ulsan.Name = "btn_ulsan";
            this.btn_ulsan.Size = new System.Drawing.Size(403, 70);
            this.btn_ulsan.TabIndex = 7;
            this.btn_ulsan.Text = "울산";
            this.btn_ulsan.UseVisualStyleBackColor = true;
            this.btn_ulsan.Click += new System.EventHandler(this.btn_region_Click);
            // 
            // btn_busan
            // 
            this.btn_busan.BackColor = System.Drawing.SystemColors.Info;
            this.btn_busan.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_busan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_busan.FlatAppearance.BorderSize = 0;
            this.btn_busan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_busan.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busan.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_busan.Location = new System.Drawing.Point(0, 720);
            this.btn_busan.Name = "btn_busan";
            this.btn_busan.Size = new System.Drawing.Size(403, 70);
            this.btn_busan.TabIndex = 8;
            this.btn_busan.Text = "부산";
            this.btn_busan.UseVisualStyleBackColor = true;
            this.btn_busan.Click += new System.EventHandler(this.btn_region_Click);
            // 
            // btn_daegu
            // 
            this.btn_daegu.BackColor = System.Drawing.SystemColors.Info;
            this.btn_daegu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_daegu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_daegu.FlatAppearance.BorderSize = 0;
            this.btn_daegu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_daegu.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_daegu.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_daegu.Location = new System.Drawing.Point(0, 650);
            this.btn_daegu.Name = "btn_daegu";
            this.btn_daegu.Size = new System.Drawing.Size(403, 70);
            this.btn_daegu.TabIndex = 9;
            this.btn_daegu.Text = "대구";
            this.btn_daegu.UseVisualStyleBackColor = true;
            this.btn_daegu.Click += new System.EventHandler(this.btn_region_Click);
            // 
            // btn_sejong
            // 
            this.btn_sejong.BackColor = System.Drawing.SystemColors.Info;
            this.btn_sejong.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_sejong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_sejong.FlatAppearance.BorderSize = 0;
            this.btn_sejong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sejong.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sejong.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_sejong.Location = new System.Drawing.Point(0, 580);
            this.btn_sejong.Name = "btn_sejong";
            this.btn_sejong.Size = new System.Drawing.Size(403, 70);
            this.btn_sejong.TabIndex = 10;
            this.btn_sejong.Text = "세종";
            this.btn_sejong.UseVisualStyleBackColor = true;
            this.btn_sejong.Click += new System.EventHandler(this.btn_region_Click);
            // 
            // btn_daejeon
            // 
            this.btn_daejeon.BackColor = System.Drawing.SystemColors.Info;
            this.btn_daejeon.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_daejeon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_daejeon.FlatAppearance.BorderSize = 0;
            this.btn_daejeon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_daejeon.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_daejeon.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_daejeon.Location = new System.Drawing.Point(0, 510);
            this.btn_daejeon.Name = "btn_daejeon";
            this.btn_daejeon.Size = new System.Drawing.Size(403, 70);
            this.btn_daejeon.TabIndex = 11;
            this.btn_daejeon.Text = "대전";
            this.btn_daejeon.UseVisualStyleBackColor = true;
            this.btn_daejeon.Click += new System.EventHandler(this.btn_region_Click);
            // 
            // btn_jeonra
            // 
            this.btn_jeonra.BackColor = System.Drawing.SystemColors.Info;
            this.btn_jeonra.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_jeonra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_jeonra.FlatAppearance.BorderSize = 0;
            this.btn_jeonra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_jeonra.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_jeonra.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_jeonra.Location = new System.Drawing.Point(0, 440);
            this.btn_jeonra.Name = "btn_jeonra";
            this.btn_jeonra.Size = new System.Drawing.Size(403, 70);
            this.btn_jeonra.TabIndex = 12;
            this.btn_jeonra.Text = "전라";
            this.btn_jeonra.UseVisualStyleBackColor = true;
            this.btn_jeonra.Click += new System.EventHandler(this.btn_region_Click);
            // 
            // btn_gyeongsang
            // 
            this.btn_gyeongsang.BackColor = System.Drawing.SystemColors.Info;
            this.btn_gyeongsang.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_gyeongsang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_gyeongsang.FlatAppearance.BorderSize = 0;
            this.btn_gyeongsang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gyeongsang.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gyeongsang.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_gyeongsang.Location = new System.Drawing.Point(0, 370);
            this.btn_gyeongsang.Name = "btn_gyeongsang";
            this.btn_gyeongsang.Size = new System.Drawing.Size(403, 70);
            this.btn_gyeongsang.TabIndex = 13;
            this.btn_gyeongsang.Text = "경상";
            this.btn_gyeongsang.UseVisualStyleBackColor = true;
            this.btn_gyeongsang.Click += new System.EventHandler(this.btn_region_Click);
            // 
            // btn_choongchung
            // 
            this.btn_choongchung.BackColor = System.Drawing.SystemColors.Info;
            this.btn_choongchung.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_choongchung.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_choongchung.FlatAppearance.BorderSize = 0;
            this.btn_choongchung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_choongchung.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_choongchung.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_choongchung.Location = new System.Drawing.Point(0, 300);
            this.btn_choongchung.Name = "btn_choongchung";
            this.btn_choongchung.Size = new System.Drawing.Size(403, 70);
            this.btn_choongchung.TabIndex = 14;
            this.btn_choongchung.Text = "충청";
            this.btn_choongchung.UseVisualStyleBackColor = true;
            this.btn_choongchung.Click += new System.EventHandler(this.btn_region_Click);
            // 
            // btn_gangwon
            // 
            this.btn_gangwon.BackColor = System.Drawing.SystemColors.Info;
            this.btn_gangwon.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_gangwon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_gangwon.FlatAppearance.BorderSize = 0;
            this.btn_gangwon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gangwon.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gangwon.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_gangwon.Location = new System.Drawing.Point(0, 230);
            this.btn_gangwon.Name = "btn_gangwon";
            this.btn_gangwon.Size = new System.Drawing.Size(403, 70);
            this.btn_gangwon.TabIndex = 15;
            this.btn_gangwon.Text = "강원";
            this.btn_gangwon.UseVisualStyleBackColor = true;
            this.btn_gangwon.Click += new System.EventHandler(this.btn_region_Click);
            // 
            // btn_incheon
            // 
            this.btn_incheon.BackColor = System.Drawing.SystemColors.Info;
            this.btn_incheon.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_incheon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_incheon.FlatAppearance.BorderSize = 0;
            this.btn_incheon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_incheon.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_incheon.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_incheon.Location = new System.Drawing.Point(0, 160);
            this.btn_incheon.Name = "btn_incheon";
            this.btn_incheon.Size = new System.Drawing.Size(403, 70);
            this.btn_incheon.TabIndex = 16;
            this.btn_incheon.Text = "인천";
            this.btn_incheon.UseVisualStyleBackColor = true;
            this.btn_incheon.Click += new System.EventHandler(this.btn_region_Click);
            // 
            // btn_gyeonggi
            // 
            this.btn_gyeonggi.BackColor = System.Drawing.SystemColors.Info;
            this.btn_gyeonggi.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_gyeonggi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_gyeonggi.FlatAppearance.BorderSize = 0;
            this.btn_gyeonggi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gyeonggi.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gyeonggi.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_gyeonggi.Location = new System.Drawing.Point(0, 90);
            this.btn_gyeonggi.Name = "btn_gyeonggi";
            this.btn_gyeonggi.Size = new System.Drawing.Size(403, 70);
            this.btn_gyeonggi.TabIndex = 17;
            this.btn_gyeonggi.Text = "경기";
            this.btn_gyeonggi.UseVisualStyleBackColor = true;
            this.btn_gyeonggi.Click += new System.EventHandler(this.btn_region_Click);
            // 
            // btn_seoul
            // 
            this.btn_seoul.BackColor = System.Drawing.SystemColors.Info;
            this.btn_seoul.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_seoul.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_seoul.FlatAppearance.BorderSize = 0;
            this.btn_seoul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_seoul.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seoul.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_seoul.Location = new System.Drawing.Point(0, 20);
            this.btn_seoul.Name = "btn_seoul";
            this.btn_seoul.Size = new System.Drawing.Size(403, 70);
            this.btn_seoul.TabIndex = 18;
            this.btn_seoul.Text = "서울";
            this.btn_seoul.UseVisualStyleBackColor = true;
            this.btn_seoul.Click += new System.EventHandler(this.btn_region_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.SystemColors.Info;
            this.btn_minimize.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimize.Location = new System.Drawing.Point(356, 0);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(20, 20);
            this.btn_minimize.TabIndex = 0;
            this.btn_minimize.Text = "ㅡ";
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // main_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.btn_seoul);
            this.Controls.Add(this.btn_gyeonggi);
            this.Controls.Add(this.btn_incheon);
            this.Controls.Add(this.btn_gangwon);
            this.Controls.Add(this.btn_choongchung);
            this.Controls.Add(this.btn_gyeongsang);
            this.Controls.Add(this.btn_jeonra);
            this.Controls.Add(this.btn_daejeon);
            this.Controls.Add(this.btn_sejong);
            this.Controls.Add(this.btn_daegu);
            this.Controls.Add(this.btn_busan);
            this.Controls.Add(this.btn_ulsan);
            this.Controls.Add(this.btn_gwangju);
            this.Controls.Add(this.btn_jeju);
            this.Controls.Add(this.top_control);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main_page";
            this.Text = "Main";
            this.top_control.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top_control;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_jeju;
        private System.Windows.Forms.Button btn_gwangju;
        private System.Windows.Forms.Button btn_ulsan;
        private System.Windows.Forms.Button btn_busan;
        private System.Windows.Forms.Button btn_daegu;
        private System.Windows.Forms.Button btn_sejong;
        private System.Windows.Forms.Button btn_daejeon;
        private System.Windows.Forms.Button btn_jeonra;
        private System.Windows.Forms.Button btn_gyeongsang;
        private System.Windows.Forms.Button btn_choongchung;
        private System.Windows.Forms.Button btn_gangwon;
        private System.Windows.Forms.Button btn_incheon;
        private System.Windows.Forms.Button btn_gyeonggi;
        private System.Windows.Forms.Button btn_seoul;
        private System.Windows.Forms.Button btn_minimize;
    }
}