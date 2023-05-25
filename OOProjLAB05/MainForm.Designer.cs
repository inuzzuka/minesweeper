namespace OOProjLAB05
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.novaIgraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zavrsiIgruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniMapuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbTimer = new System.Windows.Forms.Label();
            this.panelMapa = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaIgraToolStripMenuItem,
            this.zavrsiIgruToolStripMenuItem,
            this.izmeniMapuToolStripMenuItem,
            this.izlazToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(579, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novaIgraToolStripMenuItem
            // 
            this.novaIgraToolStripMenuItem.Name = "novaIgraToolStripMenuItem";
            this.novaIgraToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.novaIgraToolStripMenuItem.Text = "Nova igra";
            this.novaIgraToolStripMenuItem.Click += new System.EventHandler(this.novaIgraToolStripMenuItem_Click);
            // 
            // zavrsiIgruToolStripMenuItem
            // 
            this.zavrsiIgruToolStripMenuItem.Name = "zavrsiIgruToolStripMenuItem";
            this.zavrsiIgruToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.zavrsiIgruToolStripMenuItem.Text = "Zavrsi igru";
            this.zavrsiIgruToolStripMenuItem.Click += new System.EventHandler(this.zavrsiIgruToolStripMenuItem_Click);
            // 
            // izmeniMapuToolStripMenuItem
            // 
            this.izmeniMapuToolStripMenuItem.Name = "izmeniMapuToolStripMenuItem";
            this.izmeniMapuToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.izmeniMapuToolStripMenuItem.Text = "Izmeni mapu";
            this.izmeniMapuToolStripMenuItem.Click += new System.EventHandler(this.izmeniMapuToolStripMenuItem_Click);
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // lbTimer
            // 
            this.lbTimer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTimer.AutoSize = true;
            this.lbTimer.Location = new System.Drawing.Point(12, 40);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(49, 13);
            this.lbTimer.TabIndex = 2;
            this.lbTimer.Text = "00:00:00";
            // 
            // panelMapa
            // 
            this.panelMapa.Location = new System.Drawing.Point(12, 74);
            this.panelMapa.Name = "panelMapa";
            this.panelMapa.Size = new System.Drawing.Size(557, 563);
            this.panelMapa.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "bomba.png");
            this.imageList.Images.SetKeyName(1, "tile.png");
            this.imageList.Images.SetKeyName(2, "four.png");
            this.imageList.Images.SetKeyName(3, "one.png");
            this.imageList.Images.SetKeyName(4, "three.png");
            this.imageList.Images.SetKeyName(5, "two.png");
            this.imageList.Images.SetKeyName(6, "red-flag.png");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 649);
            this.ControlBox = false;
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelMapa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novaIgraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmeniMapuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.Panel panelMapa;
        private System.Windows.Forms.Timer timer;
        public System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.ToolStripMenuItem zavrsiIgruToolStripMenuItem;
        public System.Windows.Forms.ImageList imageList;
    }
}

