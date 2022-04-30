namespace Vet_for_My_Pet
{
    partial class start_page
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(start_page));
            this.cockatoo = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.top_control = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.top_control.SuspendLayout();
            this.SuspendLayout();
            // 
            // cockatoo
            // 
            this.cockatoo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cockatoo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cockatoo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cockatoo.BackgroundImage")));
            this.cockatoo.Location = new System.Drawing.Point(-7, 23);
            this.cockatoo.Name = "cockatoo";
            this.cockatoo.Size = new System.Drawing.Size(437, 360);
            this.cockatoo.TabIndex = 0;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.SystemColors.Window;
            this.title.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(78, 441);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(247, 42);
            this.title.TabIndex = 1;
            this.title.Text = "Vet for My Pet";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.SystemColors.Info;
            this.btn_start.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn_start.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_start.FlatAppearance.BorderSize = 0;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_start.Location = new System.Drawing.Point(0, 530);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(400, 70);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "시작하기";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.UseWaitCursor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // top_control
            // 
            this.top_control.BackColor = System.Drawing.SystemColors.Info;
            this.top_control.Controls.Add(this.btn_close);
            this.top_control.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top_control.Location = new System.Drawing.Point(-7, 2);
            this.top_control.Name = "top_control";
            this.top_control.Size = new System.Drawing.Size(411, 18);
            this.top_control.TabIndex = 3;
            this.top_control.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_control_mouse_down);
            this.top_control.MouseMove += new System.Windows.Forms.MouseEventHandler(this.top_control_mouse_move);
            this.top_control.MouseUp += new System.Windows.Forms.MouseEventHandler(this.top_control_mouse_up);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.SystemColors.Info;
            this.btn_close.Location = new System.Drawing.Point(382, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(25, 23);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // start_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.top_control);
            this.Controls.Add(this.title);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.cockatoo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "start_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.top_control.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel cockatoo;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Panel top_control;
        private System.Windows.Forms.Button btn_close;
    }
}

