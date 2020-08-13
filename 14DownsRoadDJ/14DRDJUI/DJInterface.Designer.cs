namespace _14DRDJUI
{
    partial class DJInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DJInterface));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.queueOfSongsBtn = new System.Windows.Forms.Button();
            this.queueListCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.previousSongBtn = new System.Windows.Forms.Button();
            this.nextSongBtn = new System.Windows.Forms.Button();
            this.albumIconPic = new System.Windows.Forms.PictureBox();
            this.chinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chinaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.queueListCMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumIconPic)).BeginInit();
            this.SuspendLayout();
            // 
            // queueOfSongsBtn
            // 
            this.queueOfSongsBtn.BackColor = System.Drawing.Color.Black;
            this.queueOfSongsBtn.ContextMenuStrip = this.queueListCMS;
            this.queueOfSongsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.queueOfSongsBtn.FlatAppearance.BorderSize = 0;
            this.queueOfSongsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.queueOfSongsBtn.ForeColor = System.Drawing.Color.White;
            this.queueOfSongsBtn.Location = new System.Drawing.Point(-1, 503);
            this.queueOfSongsBtn.Name = "queueOfSongsBtn";
            this.queueOfSongsBtn.Size = new System.Drawing.Size(119, 61);
            this.queueOfSongsBtn.TabIndex = 5;
            this.queueOfSongsBtn.Text = "Queue";
            this.queueOfSongsBtn.UseVisualStyleBackColor = false;
            this.queueOfSongsBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // queueListCMS
            // 
            this.queueListCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chinaToolStripMenuItem,
            this.chinaToolStripMenuItem1});
            this.queueListCMS.Name = "queueListCMS";
            this.queueListCMS.Size = new System.Drawing.Size(104, 48);
            // 
            // previousSongBtn
            // 
            this.previousSongBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previousSongBtn.FlatAppearance.BorderSize = 0;
            this.previousSongBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousSongBtn.Image = global::_14DRDJUI.Properties.Resources.previousSongIcon;
            this.previousSongBtn.Location = new System.Drawing.Point(234, 230);
            this.previousSongBtn.Name = "previousSongBtn";
            this.previousSongBtn.Size = new System.Drawing.Size(150, 150);
            this.previousSongBtn.TabIndex = 4;
            this.previousSongBtn.UseVisualStyleBackColor = true;
            // 
            // nextSongBtn
            // 
            this.nextSongBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextSongBtn.FlatAppearance.BorderSize = 0;
            this.nextSongBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextSongBtn.Image = global::_14DRDJUI.Properties.Resources.nextSongIcon;
            this.nextSongBtn.Location = new System.Drawing.Point(625, 230);
            this.nextSongBtn.Name = "nextSongBtn";
            this.nextSongBtn.Size = new System.Drawing.Size(150, 150);
            this.nextSongBtn.TabIndex = 3;
            this.nextSongBtn.UseVisualStyleBackColor = true;
            // 
            // albumIconPic
            // 
            this.albumIconPic.Image = global::_14DRDJUI.Properties.Resources.bluej_84_toned;
            this.albumIconPic.InitialImage = ((System.Drawing.Image)(resources.GetObject("albumIconPic.InitialImage")));
            this.albumIconPic.Location = new System.Drawing.Point(406, 202);
            this.albumIconPic.Name = "albumIconPic";
            this.albumIconPic.Size = new System.Drawing.Size(200, 200);
            this.albumIconPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.albumIconPic.TabIndex = 2;
            this.albumIconPic.TabStop = false;
            // 
            // chinaToolStripMenuItem
            // 
            this.chinaToolStripMenuItem.Name = "chinaToolStripMenuItem";
            this.chinaToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.chinaToolStripMenuItem.Text = "china";
            // 
            // chinaToolStripMenuItem1
            // 
            this.chinaToolStripMenuItem1.Name = "chinaToolStripMenuItem1";
            this.chinaToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.chinaToolStripMenuItem1.Text = "china";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(245, 138);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(517, 40);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // DJInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.queueOfSongsBtn);
            this.Controls.Add(this.previousSongBtn);
            this.Controls.Add(this.nextSongBtn);
            this.Controls.Add(this.albumIconPic);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "DJInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "House DJ";
            this.Load += new System.EventHandler(this.DJInterface_Load);
            this.queueListCMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.albumIconPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox albumIconPic;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button nextSongBtn;
        private System.Windows.Forms.Button previousSongBtn;
        private System.Windows.Forms.Button queueOfSongsBtn;
        private System.Windows.Forms.ContextMenuStrip queueListCMS;
        private System.Windows.Forms.ToolStripMenuItem chinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chinaToolStripMenuItem1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

