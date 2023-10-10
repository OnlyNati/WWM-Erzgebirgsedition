namespace WWM
{
    partial class hilfe
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spielfeldErklärungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datenimportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spielfelderkärungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_erklaerung = new System.Windows.Forms.Label();
            this.bt_back = new System.Windows.Forms.Button();
            this.bt_1 = new System.Windows.Forms.Button();
            this.lb_erlaeuterung = new System.Windows.Forms.Label();
            this.bt_2 = new System.Windows.Forms.Button();
            this.bt_3 = new System.Windows.Forms.Button();
            this.pb_erklarung = new System.Windows.Forms.PictureBox();
            this.bt_4 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_erklarung)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1024, 38);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spielfeldErklärungToolStripMenuItem,
            this.datenimportToolStripMenuItem,
            this.spielfelderkärungToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(82, 34);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // spielfeldErklärungToolStripMenuItem
            // 
            this.spielfeldErklärungToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spielfeldErklärungToolStripMenuItem.Name = "spielfeldErklärungToolStripMenuItem";
            this.spielfeldErklärungToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.spielfeldErklärungToolStripMenuItem.Text = "Fragen und Antworten eingeben";
            this.spielfeldErklärungToolStripMenuItem.Click += new System.EventHandler(this.spielfeldErklärungToolStripMenuItem_Click);
            // 
            // datenimportToolStripMenuItem
            // 
            this.datenimportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datenimportToolStripMenuItem.Name = "datenimportToolStripMenuItem";
            this.datenimportToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.datenimportToolStripMenuItem.Text = "Datenimport";
            this.datenimportToolStripMenuItem.Click += new System.EventHandler(this.datenimportToolStripMenuItem_Click);
            // 
            // spielfelderkärungToolStripMenuItem
            // 
            this.spielfelderkärungToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spielfelderkärungToolStripMenuItem.Name = "spielfelderkärungToolStripMenuItem";
            this.spielfelderkärungToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.spielfelderkärungToolStripMenuItem.Text = "Spielfelderkärung";
            this.spielfelderkärungToolStripMenuItem.Click += new System.EventHandler(this.spielfelderkärungToolStripMenuItem_Click);
            // 
            // lb_erklaerung
            // 
            this.lb_erklaerung.AutoSize = true;
            this.lb_erklaerung.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_erklaerung.Location = new System.Drawing.Point(12, 54);
            this.lb_erklaerung.MaximumSize = new System.Drawing.Size(300, 0);
            this.lb_erklaerung.Name = "lb_erklaerung";
            this.lb_erklaerung.Size = new System.Drawing.Size(0, 14);
            this.lb_erklaerung.TabIndex = 8;
            // 
            // bt_back
            // 
            this.bt_back.Location = new System.Drawing.Point(918, 631);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(94, 37);
            this.bt_back.TabIndex = 9;
            this.bt_back.Text = "Zurück zum Start";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // bt_1
            // 
            this.bt_1.Location = new System.Drawing.Point(372, 631);
            this.bt_1.Name = "bt_1";
            this.bt_1.Size = new System.Drawing.Size(94, 37);
            this.bt_1.TabIndex = 10;
            this.bt_1.UseVisualStyleBackColor = true;
            this.bt_1.Visible = false;
            this.bt_1.Click += new System.EventHandler(this.bt_1_Click);
            // 
            // lb_erlaeuterung
            // 
            this.lb_erlaeuterung.AutoSize = true;
            this.lb_erlaeuterung.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_erlaeuterung.Location = new System.Drawing.Point(369, 429);
            this.lb_erlaeuterung.MaximumSize = new System.Drawing.Size(300, 0);
            this.lb_erlaeuterung.Name = "lb_erlaeuterung";
            this.lb_erlaeuterung.Size = new System.Drawing.Size(0, 14);
            this.lb_erlaeuterung.TabIndex = 12;
            // 
            // bt_2
            // 
            this.bt_2.Location = new System.Drawing.Point(472, 631);
            this.bt_2.Name = "bt_2";
            this.bt_2.Size = new System.Drawing.Size(94, 37);
            this.bt_2.TabIndex = 13;
            this.bt_2.UseVisualStyleBackColor = true;
            this.bt_2.Visible = false;
            this.bt_2.Click += new System.EventHandler(this.bt_2_Click);
            // 
            // bt_3
            // 
            this.bt_3.Location = new System.Drawing.Point(572, 631);
            this.bt_3.Name = "bt_3";
            this.bt_3.Size = new System.Drawing.Size(94, 37);
            this.bt_3.TabIndex = 14;
            this.bt_3.UseVisualStyleBackColor = true;
            this.bt_3.Visible = false;
            this.bt_3.Click += new System.EventHandler(this.bt_3_Click);
            // 
            // pb_erklarung
            // 
            this.pb_erklarung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_erklarung.Location = new System.Drawing.Point(372, 54);
            this.pb_erklarung.Name = "pb_erklarung";
            this.pb_erklarung.Size = new System.Drawing.Size(640, 360);
            this.pb_erklarung.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_erklarung.TabIndex = 7;
            this.pb_erklarung.TabStop = false;
            // 
            // bt_4
            // 
            this.bt_4.Location = new System.Drawing.Point(672, 631);
            this.bt_4.Name = "bt_4";
            this.bt_4.Size = new System.Drawing.Size(94, 37);
            this.bt_4.TabIndex = 15;
            this.bt_4.UseVisualStyleBackColor = true;
            this.bt_4.Visible = false;
            this.bt_4.Click += new System.EventHandler(this.bt_4_Click);
            // 
            // hilfe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 680);
            this.Controls.Add(this.bt_4);
            this.Controls.Add(this.bt_3);
            this.Controls.Add(this.bt_2);
            this.Controls.Add(this.lb_erlaeuterung);
            this.Controls.Add(this.bt_1);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.lb_erklaerung);
            this.Controls.Add(this.pb_erklarung);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "hilfe";
            this.Text = "Hilfen und Anleitungen";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_erklarung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spielfeldErklärungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datenimportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spielfelderkärungToolStripMenuItem;
        private System.Windows.Forms.PictureBox pb_erklarung;
        private System.Windows.Forms.Label lb_erklaerung;
        private System.Windows.Forms.Button bt_back;
        private System.Windows.Forms.Button bt_1;
        private System.Windows.Forms.Label lb_erlaeuterung;
        private System.Windows.Forms.Button bt_2;
        private System.Windows.Forms.Button bt_3;
        private System.Windows.Forms.Button bt_4;
    }
}