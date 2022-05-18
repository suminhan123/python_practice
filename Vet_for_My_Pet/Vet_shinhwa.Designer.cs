namespace Vet_for_My_Pet
{
    partial class Vet_shinhwa
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
            this.top_control.TabIndex = 7;
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
            // Vet_shinhwa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.top_control);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vet_shinhwa";
            this.Text = "Vet_shinhwa";
            this.top_control.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top_control;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_close;
    }
}