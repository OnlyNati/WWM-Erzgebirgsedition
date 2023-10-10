namespace WWM
{
    partial class import
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
            this.bt_import = new System.Windows.Forms.Button();
            this.tb_source = new System.Windows.Forms.TextBox();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.lb_erklaerung = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_del = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_import
            // 
            this.bt_import.Location = new System.Drawing.Point(15, 160);
            this.bt_import.Name = "bt_import";
            this.bt_import.Size = new System.Drawing.Size(97, 23);
            this.bt_import.TabIndex = 0;
            this.bt_import.Text = "Import";
            this.bt_import.UseVisualStyleBackColor = true;
            this.bt_import.Click += new System.EventHandler(this.bt_import_Click);
            // 
            // tb_source
            // 
            this.tb_source.Location = new System.Drawing.Point(15, 134);
            this.tb_source.Name = "tb_source";
            this.tb_source.Size = new System.Drawing.Size(263, 20);
            this.tb_source.TabIndex = 1;
            this.tb_source.Text = "C:\\%Userprofile%\\Downloads";
            this.tb_source.Click += new System.EventHandler(this.tb_source_Click);
            // 
            // lb_erklaerung
            // 
            this.lb_erklaerung.AutoSize = true;
            this.lb_erklaerung.Location = new System.Drawing.Point(12, 37);
            this.lb_erklaerung.MaximumSize = new System.Drawing.Size(250, 0);
            this.lb_erklaerung.Name = "lb_erklaerung";
            this.lb_erklaerung.Size = new System.Drawing.Size(248, 52);
            this.lb_erklaerung.TabIndex = 2;
            this.lb_erklaerung.Text = "Bitte auf das leere Feld klicken und Ordner mit den \r\nbenötigten Datein auswählen" +
    ".\r\nFalls Sie den Config Ordner in Ihrem Downloads Ordner haben müssen Sie nur au" +
    "f Import klicken.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Es wird der Ordner mit den Fragen und Musik benötigt. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Anschließend auf Import klicken.";
            // 
            // bt_del
            // 
            this.bt_del.Location = new System.Drawing.Point(181, 160);
            this.bt_del.Name = "bt_del";
            this.bt_del.Size = new System.Drawing.Size(97, 23);
            this.bt_del.TabIndex = 5;
            this.bt_del.Text = "Config leeren";
            this.bt_del.UseVisualStyleBackColor = true;
            this.bt_del.Click += new System.EventHandler(this.bt_del_Click);
            // 
            // import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 192);
            this.Controls.Add(this.bt_del);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_erklaerung);
            this.Controls.Add(this.tb_source);
            this.Controls.Add(this.bt_import);
            this.Name = "import";
            this.Text = "Datenimport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_import;
        private System.Windows.Forms.TextBox tb_source;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Label lb_erklaerung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_del;
    }
}