namespace MusicPlayer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mpPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.list = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picPrev = new System.Windows.Forms.PictureBox();
            this.picNxt = new System.Windows.Forms.PictureBox();
            this.picPnP = new System.Windows.Forms.PictureBox();
            this.piclogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mpPlayer)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPrev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPnP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mpPlayer
            // 
            this.mpPlayer.Enabled = true;
            this.mpPlayer.Location = new System.Drawing.Point(12, 353);
            this.mpPlayer.Name = "mpPlayer";
            this.mpPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mpPlayer.OcxState")));
            this.mpPlayer.Size = new System.Drawing.Size(240, 245);
            this.mpPlayer.TabIndex = 0;
            // 
            // list
            // 
            this.list.BackColor = System.Drawing.Color.Black;
            this.list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list.Cursor = System.Windows.Forms.Cursors.Cross;
            this.list.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list.ForeColor = System.Drawing.Color.White;
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 16;
            this.list.Location = new System.Drawing.Point(4, 38);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(195, 192);
            this.list.TabIndex = 4;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picPrev);
            this.panel1.Controls.Add(this.picNxt);
            this.panel1.Controls.Add(this.picPnP);
            this.panel1.Location = new System.Drawing.Point(28, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 71);
            this.panel1.TabIndex = 8;
            // 
            // picPrev
            // 
            this.picPrev.Image = global::MusicPlayer.Properties.Resources.previous;
            this.picPrev.Location = new System.Drawing.Point(12, 22);
            this.picPrev.Name = "picPrev";
            this.picPrev.Size = new System.Drawing.Size(30, 30);
            this.picPrev.TabIndex = 6;
            this.picPrev.TabStop = false;
            this.picPrev.Click += new System.EventHandler(this.picPrev_Click);
            // 
            // picNxt
            // 
            this.picNxt.Image = global::MusicPlayer.Properties.Resources.next;
            this.picNxt.Location = new System.Drawing.Point(104, 21);
            this.picNxt.Name = "picNxt";
            this.picNxt.Size = new System.Drawing.Size(30, 30);
            this.picNxt.TabIndex = 7;
            this.picNxt.TabStop = false;
            this.picNxt.Click += new System.EventHandler(this.picNxt_Click);
            // 
            // picPnP
            // 
            this.picPnP.Image = global::MusicPlayer.Properties.Resources.pause;
            this.picPnP.Location = new System.Drawing.Point(48, 11);
            this.picPnP.Name = "picPnP";
            this.picPnP.Size = new System.Drawing.Size(50, 50);
            this.picPnP.TabIndex = 5;
            this.picPnP.TabStop = false;
            this.picPnP.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // piclogo
            // 
            this.piclogo.Image = global::MusicPlayer.Properties.Resources.vox2;
            this.piclogo.Location = new System.Drawing.Point(84, 2);
            this.piclogo.Name = "piclogo";
            this.piclogo.Size = new System.Drawing.Size(30, 30);
            this.piclogo.TabIndex = 10;
            this.piclogo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MusicPlayer.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(178, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(211, 338);
            this.Controls.Add(this.piclogo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.list);
            this.Controls.Add(this.mpPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown_1);
            ((System.ComponentModel.ISupportInitialize)(this.mpPlayer)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPrev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPnP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer mpPlayer;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.PictureBox picPnP;
        private System.Windows.Forms.PictureBox picPrev;
        private System.Windows.Forms.PictureBox picNxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox piclogo;
    }
}

