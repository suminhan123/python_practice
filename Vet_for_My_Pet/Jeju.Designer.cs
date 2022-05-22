namespace Vet_for_My_Pet
{
    partial class Jeju
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
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.Jejuh = new System.Windows.Forms.Label();
            this.btn_kium = new System.Windows.Forms.Button();
            this.lbl_kium = new System.Windows.Forms.Label();
            this.btn_tt = new System.Windows.Forms.Button();
            this.lbl_tt = new System.Windows.Forms.Label();
            this.btn_hanra = new System.Windows.Forms.Button();
            this.lbl_hanra = new System.Windows.Forms.Label();
            this.top_control.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_control
            // 
            this.top_control.BackColor = System.Drawing.SystemColors.Info;
            this.top_control.Controls.Add(this.btn_minimize);
            this.top_control.Controls.Add(this.btn_close);
            this.top_control.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top_control.Location = new System.Drawing.Point(-8, 2);
            this.top_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.top_control.Name = "top_control";
            this.top_control.Size = new System.Drawing.Size(469, 22);
            this.top_control.TabIndex = 6;
            this.top_control.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_control_mouse_down);
            this.top_control.MouseMove += new System.Windows.Forms.MouseEventHandler(this.top_control_mouse_move);
            this.top_control.MouseUp += new System.Windows.Forms.MouseEventHandler(this.top_control_mouse_up);
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.SystemColors.Info;
            this.btn_minimize.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimize.Location = new System.Drawing.Point(407, 0);
            this.btn_minimize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(23, 25);
            this.btn_minimize.TabIndex = 0;
            this.btn_minimize.Text = "ㅡ";
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.SystemColors.Info;
            this.btn_close.Location = new System.Drawing.Point(437, 0);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(23, 25);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.Info;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_back.Location = new System.Drawing.Point(3, 2056);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(461, 88);
            this.btn_back.TabIndex = 25;
            this.btn_back.Text = "뒤로 가기";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Jejuh
            // 
            this.Jejuh.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jejuh.Location = new System.Drawing.Point(0, 25);
            this.Jejuh.Name = "Jejuh";
            this.Jejuh.Size = new System.Drawing.Size(457, 62);
            this.Jejuh.TabIndex = 20;
            this.Jejuh.Text = "제주시";
            // 
            // btn_kium
            // 
            this.btn_kium.BackColor = System.Drawing.SystemColors.Info;
            this.btn_kium.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_kium.FlatAppearance.BorderSize = 0;
            this.btn_kium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kium.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kium.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_kium.Location = new System.Drawing.Point(0, 92);
            this.btn_kium.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_kium.Name = "btn_kium";
            this.btn_kium.Size = new System.Drawing.Size(461, 92);
            this.btn_kium.TabIndex = 21;
            this.btn_kium.Text = "제주키움동물병원";
            this.btn_kium.UseVisualStyleBackColor = true;
            this.btn_kium.Click += new System.EventHandler(this.btn_vet_Click);
            // 
            // lbl_kium
            // 
            this.lbl_kium.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kium.Location = new System.Drawing.Point(0, 210);
            this.lbl_kium.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_kium.Name = "lbl_kium";
            this.lbl_kium.Size = new System.Drawing.Size(457, 62);
            this.lbl_kium.TabIndex = 28;
            this.lbl_kium.Text = "제주 제주시 중앙로 273 나라키움 복합관사 106호";
            // 
            // btn_tt
            // 
            this.btn_tt.BackColor = System.Drawing.SystemColors.Info;
            this.btn_tt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_tt.FlatAppearance.BorderSize = 0;
            this.btn_tt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tt.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_tt.Location = new System.Drawing.Point(0, 269);
            this.btn_tt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_tt.Name = "btn_tt";
            this.btn_tt.Size = new System.Drawing.Size(461, 94);
            this.btn_tt.TabIndex = 22;
            this.btn_tt.Text = "튼튼동물병원";
            this.btn_tt.UseVisualStyleBackColor = true;
            this.btn_tt.Click += new System.EventHandler(this.btn_vet_Click);
            // 
            // lbl_tt
            // 
            this.lbl_tt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tt.Location = new System.Drawing.Point(4, 368);
            this.lbl_tt.Name = "lbl_tt";
            this.lbl_tt.Size = new System.Drawing.Size(457, 62);
            this.lbl_tt.TabIndex = 28;
            this.lbl_tt.Text = "제주 제주시 중앙로 351";
            // 
            // btn_hanra
            // 
            this.btn_hanra.BackColor = System.Drawing.SystemColors.Info;
            this.btn_hanra.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_hanra.FlatAppearance.BorderSize = 0;
            this.btn_hanra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hanra.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hanra.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_hanra.Location = new System.Drawing.Point(4, 423);
            this.btn_hanra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_hanra.Name = "btn_hanra";
            this.btn_hanra.Size = new System.Drawing.Size(453, 89);
            this.btn_hanra.TabIndex = 23;
            this.btn_hanra.Text = "한라동물의료센터";
            this.btn_hanra.UseVisualStyleBackColor = true;
            this.btn_hanra.Click += new System.EventHandler(this.btn_vet_Click);
            // 
            // lbl_hanra
            // 
            this.lbl_hanra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hanra.Location = new System.Drawing.Point(4, 517);
            this.lbl_hanra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_hanra.Name = "lbl_hanra";
            this.lbl_hanra.Size = new System.Drawing.Size(457, 62);
            this.lbl_hanra.TabIndex = 28;
            this.lbl_hanra.Text = "제주 제주시 남광로 20 한라동물의료 센터";
            // 
            // Jeju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(487, 667);
            this.Controls.Add(this.top_control);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.Jejuh);
            this.Controls.Add(this.btn_kium);
            this.Controls.Add(this.btn_tt);
            this.Controls.Add(this.btn_hanra);
            this.Controls.Add(this.lbl_kium);
            this.Controls.Add(this.lbl_tt);
            this.Controls.Add(this.lbl_hanra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Jeju";
            this.Text = "제주";
            this.top_control.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion


        private System.Windows.Forms.Panel top_control;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label Jejuh;
        private System.Windows.Forms.Button btn_kium;
        private System.Windows.Forms.Button btn_tt;
        private System.Windows.Forms.Button btn_hanra;
        private System.Windows.Forms.Label lbl_kium;
        private System.Windows.Forms.Label lbl_tt;
        private System.Windows.Forms.Label lbl_hanra;

    }
}