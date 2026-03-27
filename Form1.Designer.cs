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
            this.Nevek = new System.Windows.Forms.Label();
            this.names_listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.idősToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.idősToolStripMenuItem.Text = "Idős";
            // 
            // diákToolStripMenuItem
            // 
            this.diákToolStripMenuItem.Name = "diákToolStripMenuItem";
            this.diákToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
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
            // Nevek
            // 
            this.Nevek.AutoSize = true;
            this.Nevek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Nevek.Location = new System.Drawing.Point(12, 48);
            this.Nevek.Name = "Nevek";
            this.Nevek.Size = new System.Drawing.Size(53, 20);
            this.Nevek.TabIndex = 1;
            this.Nevek.Text = "Nevek";
            // 
            // names_listBox
            // 
            this.names_listBox.FormattingEnabled = true;
            this.names_listBox.Location = new System.Drawing.Point(12, 77);
            this.names_listBox.Name = "names_listBox";
            this.names_listBox.Size = new System.Drawing.Size(188, 355);
            this.names_listBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aktuális név";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(244, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chartreuse;
            this.button1.Location = new System.Drawing.Point(244, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Hozzáad";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(244, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Módosít";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(316, 164);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Töröl";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.names_listBox);
            this.Controls.Add(this.Nevek);
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
        private System.Windows.Forms.Label Nevek;
        private System.Windows.Forms.ListBox names_listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

