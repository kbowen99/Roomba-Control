namespace Roomba_Client
{
    partial class Frm_roomba
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_roomba));
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.lbl_IP = new System.Windows.Forms.Label();
            this.lbl_forward = new System.Windows.Forms.Label();
            this.Browser = new System.Windows.Forms.WebBrowser();
            this.txt_Forward = new System.Windows.Forms.TextBox();
            this.txt_left = new System.Windows.Forms.TextBox();
            this.txt_backward = new System.Windows.Forms.TextBox();
            this.txt_right = new System.Windows.Forms.TextBox();
            this.txt_quit = new System.Windows.Forms.TextBox();
            this.lbl_left = new System.Windows.Forms.Label();
            this.lbl_back = new System.Windows.Forms.Label();
            this.lbl_right = new System.Windows.Forms.Label();
            this.lbl_clear = new System.Windows.Forms.Label();
            this.PB_Roomba = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Roomba)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_IP
            // 
            this.txt_IP.Location = new System.Drawing.Point(78, 6);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(100, 20);
            this.txt_IP.TabIndex = 0;
            this.txt_IP.Text = "localhost";
            // 
            // lbl_IP
            // 
            this.lbl_IP.AutoSize = true;
            this.lbl_IP.Location = new System.Drawing.Point(12, 6);
            this.lbl_IP.Name = "lbl_IP";
            this.lbl_IP.Size = new System.Drawing.Size(60, 13);
            this.lbl_IP.TabIndex = 1;
            this.lbl_IP.Text = "Roomba IP";
            // 
            // lbl_forward
            // 
            this.lbl_forward.AutoSize = true;
            this.lbl_forward.Location = new System.Drawing.Point(12, 32);
            this.lbl_forward.Name = "lbl_forward";
            this.lbl_forward.Size = new System.Drawing.Size(45, 13);
            this.lbl_forward.TabIndex = 2;
            this.lbl_forward.Text = "Forward";
            // 
            // Browser
            // 
            this.Browser.Location = new System.Drawing.Point(12, 162);
            this.Browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.Browser.Name = "Browser";
            this.Browser.Size = new System.Drawing.Size(490, 59);
            this.Browser.TabIndex = 3;
            this.Browser.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Browser_PreviewKeyDown);
            // 
            // txt_Forward
            // 
            this.txt_Forward.Location = new System.Drawing.Point(78, 32);
            this.txt_Forward.Name = "txt_Forward";
            this.txt_Forward.Size = new System.Drawing.Size(100, 20);
            this.txt_Forward.TabIndex = 5;
            this.txt_Forward.Text = "/w";
            // 
            // txt_left
            // 
            this.txt_left.BackColor = System.Drawing.SystemColors.Window;
            this.txt_left.Location = new System.Drawing.Point(78, 58);
            this.txt_left.Name = "txt_left";
            this.txt_left.Size = new System.Drawing.Size(100, 20);
            this.txt_left.TabIndex = 6;
            this.txt_left.Text = "/a";
            // 
            // txt_backward
            // 
            this.txt_backward.BackColor = System.Drawing.SystemColors.Window;
            this.txt_backward.Location = new System.Drawing.Point(78, 84);
            this.txt_backward.Name = "txt_backward";
            this.txt_backward.Size = new System.Drawing.Size(100, 20);
            this.txt_backward.TabIndex = 7;
            this.txt_backward.Text = "/s";
            // 
            // txt_right
            // 
            this.txt_right.BackColor = System.Drawing.SystemColors.Window;
            this.txt_right.Location = new System.Drawing.Point(78, 110);
            this.txt_right.Name = "txt_right";
            this.txt_right.Size = new System.Drawing.Size(100, 20);
            this.txt_right.TabIndex = 8;
            this.txt_right.Text = "/d";
            // 
            // txt_quit
            // 
            this.txt_quit.BackColor = System.Drawing.SystemColors.Window;
            this.txt_quit.Location = new System.Drawing.Point(78, 136);
            this.txt_quit.Name = "txt_quit";
            this.txt_quit.Size = new System.Drawing.Size(100, 20);
            this.txt_quit.TabIndex = 9;
            this.txt_quit.Text = "/q";
            // 
            // lbl_left
            // 
            this.lbl_left.AutoSize = true;
            this.lbl_left.Location = new System.Drawing.Point(12, 58);
            this.lbl_left.Name = "lbl_left";
            this.lbl_left.Size = new System.Drawing.Size(25, 13);
            this.lbl_left.TabIndex = 10;
            this.lbl_left.Text = "Left";
            // 
            // lbl_back
            // 
            this.lbl_back.AutoSize = true;
            this.lbl_back.Location = new System.Drawing.Point(12, 84);
            this.lbl_back.Name = "lbl_back";
            this.lbl_back.Size = new System.Drawing.Size(55, 13);
            this.lbl_back.TabIndex = 11;
            this.lbl_back.Text = "Backward";
            // 
            // lbl_right
            // 
            this.lbl_right.AutoSize = true;
            this.lbl_right.Location = new System.Drawing.Point(12, 110);
            this.lbl_right.Name = "lbl_right";
            this.lbl_right.Size = new System.Drawing.Size(32, 13);
            this.lbl_right.TabIndex = 12;
            this.lbl_right.Text = "Right";
            // 
            // lbl_clear
            // 
            this.lbl_clear.AutoSize = true;
            this.lbl_clear.Location = new System.Drawing.Point(12, 136);
            this.lbl_clear.Name = "lbl_clear";
            this.lbl_clear.Size = new System.Drawing.Size(31, 13);
            this.lbl_clear.TabIndex = 13;
            this.lbl_clear.Text = "Clear";
            // 
            // PB_Roomba
            // 
            this.PB_Roomba.Image = global::Roomba_Client.Properties.Resources.IRobot;
            this.PB_Roomba.Location = new System.Drawing.Point(184, 12);
            this.PB_Roomba.Name = "PB_Roomba";
            this.PB_Roomba.Size = new System.Drawing.Size(318, 137);
            this.PB_Roomba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Roomba.TabIndex = 4;
            this.PB_Roomba.TabStop = false;
            this.PB_Roomba.Click += new System.EventHandler(this.PB_Roomba_Click);
            // 
            // Frm_roomba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 233);
            this.Controls.Add(this.lbl_clear);
            this.Controls.Add(this.lbl_right);
            this.Controls.Add(this.lbl_back);
            this.Controls.Add(this.lbl_left);
            this.Controls.Add(this.txt_quit);
            this.Controls.Add(this.txt_right);
            this.Controls.Add(this.txt_backward);
            this.Controls.Add(this.txt_left);
            this.Controls.Add(this.txt_Forward);
            this.Controls.Add(this.PB_Roomba);
            this.Controls.Add(this.Browser);
            this.Controls.Add(this.lbl_forward);
            this.Controls.Add(this.lbl_IP);
            this.Controls.Add(this.txt_IP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_roomba";
            this.Text = "Roomba Controller";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_roomba_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_roomba_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Roomba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.Label lbl_IP;
        private System.Windows.Forms.Label lbl_forward;
        private System.Windows.Forms.WebBrowser Browser;
        private System.Windows.Forms.PictureBox PB_Roomba;
        private System.Windows.Forms.TextBox txt_Forward;
        private System.Windows.Forms.TextBox txt_left;
        private System.Windows.Forms.TextBox txt_backward;
        private System.Windows.Forms.TextBox txt_right;
        private System.Windows.Forms.TextBox txt_quit;
        private System.Windows.Forms.Label lbl_left;
        private System.Windows.Forms.Label lbl_back;
        private System.Windows.Forms.Label lbl_right;
        private System.Windows.Forms.Label lbl_clear;
    }
}

