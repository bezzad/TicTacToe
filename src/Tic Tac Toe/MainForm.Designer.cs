namespace Tic_Tac_Toe
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.picBtnClose = new System.Windows.Forms.PictureBox();
            this.picBtnMinimize = new System.Windows.Forms.PictureBox();
            this.picBtnPlayGame = new System.Windows.Forms.PictureBox();
            this.toolTip3Three = new System.Windows.Forms.ToolTip(this.components);
            this.picBtnAbout = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.picBtnMove = new System.Windows.Forms.PictureBox();
            this.picAbout = new System.Windows.Forms.PictureBox();
            this.chkFirstPc = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picEmail = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnPlayGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // picBtnClose
            // 
            this.picBtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBtnClose.Image = global::Tic_Tac_Toe.Properties.Resources.Normal;
            this.picBtnClose.Location = new System.Drawing.Point(306, 0);
            this.picBtnClose.Name = "picBtnClose";
            this.picBtnClose.Size = new System.Drawing.Size(27, 27);
            this.picBtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBtnClose.TabIndex = 0;
            this.picBtnClose.TabStop = false;
            this.toolTip3Three.SetToolTip(this.picBtnClose, "Close Window");
            this.picBtnClose.MouseLeave += new System.EventHandler(this.picBtnClose_MouseLeave);
            this.picBtnClose.Click += new System.EventHandler(this.picBtnClose_Click);
            this.picBtnClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBtnClose_MouseDown);
            this.picBtnClose.MouseEnter += new System.EventHandler(this.picBtnClose_MouseEnter);
            // 
            // picBtnMinimize
            // 
            this.picBtnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBtnMinimize.Image = global::Tic_Tac_Toe.Properties.Resources.Normal1;
            this.picBtnMinimize.Location = new System.Drawing.Point(275, 0);
            this.picBtnMinimize.Name = "picBtnMinimize";
            this.picBtnMinimize.Size = new System.Drawing.Size(27, 27);
            this.picBtnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBtnMinimize.TabIndex = 1;
            this.picBtnMinimize.TabStop = false;
            this.toolTip3Three.SetToolTip(this.picBtnMinimize, "Minimize");
            this.picBtnMinimize.MouseLeave += new System.EventHandler(this.picBtnMinimize_MouseLeave);
            this.picBtnMinimize.Click += new System.EventHandler(this.picBtnMinimize_Click);
            this.picBtnMinimize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBtnMinimize_MouseDown);
            this.picBtnMinimize.MouseEnter += new System.EventHandler(this.picBtnMinimize_MouseEnter);
            // 
            // picBtnPlayGame
            // 
            this.picBtnPlayGame.BackColor = System.Drawing.Color.Transparent;
            this.picBtnPlayGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBtnPlayGame.Image = global::Tic_Tac_Toe.Properties.Resources.Normal2;
            this.picBtnPlayGame.Location = new System.Drawing.Point(62, 325);
            this.picBtnPlayGame.Name = "picBtnPlayGame";
            this.picBtnPlayGame.Size = new System.Drawing.Size(209, 41);
            this.picBtnPlayGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBtnPlayGame.TabIndex = 2;
            this.picBtnPlayGame.TabStop = false;
            this.picBtnPlayGame.MouseLeave += new System.EventHandler(this.picBtnPlayGame_MouseLeave);
            this.picBtnPlayGame.Click += new System.EventHandler(this.picBtnPlayGame_Click);
            this.picBtnPlayGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBtnPlayGame_MouseDown);
            this.picBtnPlayGame.MouseEnter += new System.EventHandler(this.picBtnPlayGame_MouseEnter);
            // 
            // picBtnAbout
            // 
            this.picBtnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBtnAbout.Image = global::Tic_Tac_Toe.Properties.Resources.Normal3;
            this.picBtnAbout.Location = new System.Drawing.Point(244, 0);
            this.picBtnAbout.Name = "picBtnAbout";
            this.picBtnAbout.Size = new System.Drawing.Size(27, 27);
            this.picBtnAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBtnAbout.TabIndex = 5;
            this.picBtnAbout.TabStop = false;
            this.toolTip3Three.SetToolTip(this.picBtnAbout, "About");
            this.picBtnAbout.MouseLeave += new System.EventHandler(this.picBtnAbout_MouseLeave);
            this.picBtnAbout.Click += new System.EventHandler(this.picBtnAbout_Click);
            this.picBtnAbout.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBtnAbout_MouseDown);
            this.picBtnAbout.MouseEnter += new System.EventHandler(this.picBtnAbout_MouseEnter);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(95, 369);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(142, 20);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.Azerbaycan.ir";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip3Three.SetToolTip(this.linkLabel1, "Goto Site: Azerbaycan.ir");
            this.linkLabel1.Visible = false;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // picBtnMove
            // 
            this.picBtnMove.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.picBtnMove.Image = global::Tic_Tac_Toe.Properties.Resources.Move;
            this.picBtnMove.Location = new System.Drawing.Point(-1, 0);
            this.picBtnMove.Name = "picBtnMove";
            this.picBtnMove.Size = new System.Drawing.Size(334, 33);
            this.picBtnMove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBtnMove.TabIndex = 3;
            this.picBtnMove.TabStop = false;
            this.picBtnMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBtnMove_MouseMove);
            this.picBtnMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBtnMove_MouseDown);
            this.picBtnMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBtnMove_MouseUp);
            // 
            // picAbout
            // 
            this.picAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picAbout.Image = global::Tic_Tac_Toe.Properties.Resources.Table;
            this.picAbout.Location = new System.Drawing.Point(0, 0);
            this.picAbout.Name = "picAbout";
            this.picAbout.Size = new System.Drawing.Size(333, 400);
            this.picAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAbout.TabIndex = 6;
            this.picAbout.TabStop = false;
            this.picAbout.Visible = false;
            this.picAbout.Click += new System.EventHandler(this.picAbout_Click);
            // 
            // chkFirstPc
            // 
            this.chkFirstPc.AutoSize = true;
            this.chkFirstPc.BackColor = System.Drawing.Color.Transparent;
            this.chkFirstPc.Checked = true;
            this.chkFirstPc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFirstPc.Cursor = System.Windows.Forms.Cursors.Cross;
            this.chkFirstPc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFirstPc.ForeColor = System.Drawing.Color.DarkBlue;
            this.chkFirstPc.Location = new System.Drawing.Point(78, 26);
            this.chkFirstPc.Name = "chkFirstPc";
            this.chkFirstPc.Size = new System.Drawing.Size(176, 20);
            this.chkFirstPc.TabIndex = 7;
            this.chkFirstPc.Text = "Computer First Player";
            this.chkFirstPc.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(229, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Creator: \r\nBehzad Khosravifar";
            this.label1.Visible = false;
            // 
            // picEmail
            // 
            this.picEmail.BackColor = System.Drawing.Color.White;
            this.picEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEmail.Image = global::Tic_Tac_Toe.Properties.Resources.Email;
            this.picEmail.Location = new System.Drawing.Point(3, 267);
            this.picEmail.Name = "picEmail";
            this.picEmail.Size = new System.Drawing.Size(102, 103);
            this.picEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEmail.TabIndex = 10;
            this.picEmail.TabStop = false;
            this.toolTip3Three.SetToolTip(this.picEmail, "Send Email to: Behzad.kh.2006@gmail.com");
            this.picEmail.Visible = false;
            this.picEmail.Click += new System.EventHandler(this.picEmail_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "2010";
            this.label2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.Texture_Table;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(333, 400);
            this.ControlBox = false;
            this.Controls.Add(this.picEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.picAbout);
            this.Controls.Add(this.picBtnAbout);
            this.Controls.Add(this.chkFirstPc);
            this.Controls.Add(this.picBtnPlayGame);
            this.Controls.Add(this.picBtnMinimize);
            this.Controls.Add(this.picBtnClose);
            this.Controls.Add(this.picBtnMove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnPlayGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBtnClose;
        private System.Windows.Forms.PictureBox picBtnMinimize;
        private System.Windows.Forms.PictureBox picBtnPlayGame;
        private System.Windows.Forms.ToolTip toolTip3Three;
        private System.Windows.Forms.PictureBox picBtnMove;
        private System.Windows.Forms.PictureBox picBtnAbout;
        private System.Windows.Forms.PictureBox picAbout;
        private System.Windows.Forms.CheckBox chkFirstPc;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picEmail;
        private System.Windows.Forms.Label label2;
    }
}

