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
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.készítőkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emberekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idősToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diákToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emberekToolStripMenuItem,
            this.készítőkToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            // 
            // készítőkToolStripMenuItem
            // 
            this.készítőkToolStripMenuItem.Name = "készítőkToolStripMenuItem";
            this.készítőkToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.készítőkToolStripMenuItem.Text = "Készítők";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.ToolStripMenuItem készítőkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
    }
}

