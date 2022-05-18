namespace Vet_for_My_Pet
{
    partial class Vet_royal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vet_royal));
            this.top_control = new System.Windows.Forms.Panel();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.img_royal = new System.Windows.Forms.Panel();
            this.lbl_royal = new System.Windows.Forms.Label();
            this.info_royal = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
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
            this.top_control.TabIndex = 6;
            this.top_control.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_control_mouse_down);
            this.top_control.MouseMove += new System.Windows.Forms.MouseEventHandler(this.top_control_mouse_move);
            this.top_control.MouseUp += new System.Windows.Forms.MouseEventHandler(this.top_control_mouse_up);
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
            // img_royal
            // 
            this.img_royal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("img_royal.BackgroundImage")));
            this.img_royal.Location = new System.Drawing.Point(0, 30);
            this.img_royal.Name = "img_royal";
            this.img_royal.Size = new System.Drawing.Size(400, 300);
            this.img_royal.TabIndex = 7;
            // 
            // lbl_royal
            // 
            this.lbl_royal.AutoSize = true;
            this.lbl_royal.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_royal.Location = new System.Drawing.Point(10, 350);
            this.lbl_royal.Name = "lbl_royal";
            this.lbl_royal.Size = new System.Drawing.Size(258, 42);
            this.lbl_royal.TabIndex = 8;
            this.lbl_royal.Text = "로얄종합동물병원";
            // 
            // info_royal
            // 
            this.info_royal.AutoSize = true;
            this.info_royal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_royal.Location = new System.Drawing.Point(10, 400);
            this.info_royal.Name = "info_royal";
            this.info_royal.Size = new System.Drawing.Size(296, 162);
            this.info_royal.TabIndex = 9;
            this.info_royal.Text = "033-766-7230\r\n주소: 강원 원주시 남원로 655\r\n진료 가능한 특수동물: 조류, 소형포유류\r\n운영시간:\r\n평일 09:00~19:30\r\n" +
    "토요일 09:30~17:00\r\n공휴일 09:00~17:00\r\n일요일 휴무\r\n알림: 명륜 1동 행정복지센터 바로 옆에 있습니다.";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.Info;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_back.Location = new System.Drawing.Point(0, 600);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(403, 70);
            this.btn_back.TabIndex = 26;
            this.btn_back.Text = "뒤로 가기";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Vet_royal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.info_royal);
            this.Controls.Add(this.lbl_royal);
            this.Controls.Add(this.img_royal);
            this.Controls.Add(this.top_control);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vet_royal";
            this.Text = "Vet_royal";
            this.top_control.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel top_control;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel img_royal;
        private System.Windows.Forms.Label lbl_royal;
        private System.Windows.Forms.Label info_royal;
        private System.Windows.Forms.Button btn_back;
    }
}