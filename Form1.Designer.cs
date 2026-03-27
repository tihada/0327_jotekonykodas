namespace _0327_jótékonykodás {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.emberekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idősToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diákToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creators_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emberekToolStripMenuItem,
            this.creators_ToolStripMenuItem,
            this.exit_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // emberekToolStripMenuItem
            // 
            this.emberekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idősToolStripMenuItem,
            this.diákToolStripMenuItem});
            this.emberekToolStripMenuItem.Name = "emberekToolStripMenuItem";
            this.emberekToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.emberekToolStripMenuItem.Text = "Emberek";
            // 
            // idősToolStripMenuItem
            // 
            this.idősToolStripMenuItem.Name = "idősToolStripMenuItem";
            this.idősToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.idősToolStripMenuItem.Text = "Idős";
            // 
            // diákToolStripMenuItem
            // 
            this.diákToolStripMenuItem.Name = "diákToolStripMenuItem";
            this.diákToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.diákToolStripMenuItem.Text = "Diák";
            // 
            // creators_ToolStripMenuItem
            // 
            this.creators_ToolStripMenuItem.Name = "creators_ToolStripMenuItem";
            this.creators_ToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.creators_ToolStripMenuItem.Text = "Készítők";
            this.creators_ToolStripMenuItem.Click += new System.EventHandler(this.creators_ToolStripMenuItem_Click);
            // 
            // exit_ToolStripMenuItem
            // 
            this.exit_ToolStripMenuItem.Name = "exit_ToolStripMenuItem";
            this.exit_ToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.exit_ToolStripMenuItem.Text = "Kilépés";
            this.exit_ToolStripMenuItem.Click += new System.EventHandler(this.exit_ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Agóra jótékonykodás";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem emberekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idősToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diákToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creators_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exit_ToolStripMenuItem;
    }
}

