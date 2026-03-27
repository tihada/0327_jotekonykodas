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
            this.oldPpl_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.student_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creators_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Nevek = new System.Windows.Forms.Label();
            this.names_listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.actName_textBox = new System.Windows.Forms.TextBox();
            this.addName_button = new System.Windows.Forms.Button();
            this.modifyName_button = new System.Windows.Forms.Button();
            this.delName_button = new System.Windows.Forms.Button();
            this.gen_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emberekToolStripMenuItem,
            this.gen_toolStripMenuItem,
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
            this.oldPpl_ToolStripMenuItem,
            this.student_ToolStripMenuItem});
            this.emberekToolStripMenuItem.Name = "emberekToolStripMenuItem";
            this.emberekToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.emberekToolStripMenuItem.Text = "Emberek";
            // 
            // oldPpl_ToolStripMenuItem
            // 
            this.oldPpl_ToolStripMenuItem.Name = "oldPpl_ToolStripMenuItem";
            this.oldPpl_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oldPpl_ToolStripMenuItem.Text = "Idős";
            this.oldPpl_ToolStripMenuItem.Click += new System.EventHandler(this.oldPpl_ToolStripMenuItem_Click);
            // 
            // student_ToolStripMenuItem
            // 
            this.student_ToolStripMenuItem.Name = "student_ToolStripMenuItem";
            this.student_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.student_ToolStripMenuItem.Text = "Diák";
            this.student_ToolStripMenuItem.Click += new System.EventHandler(this.student_ToolStripMenuItem_Click);
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
            // actName_textBox
            // 
            this.actName_textBox.Location = new System.Drawing.Point(244, 93);
            this.actName_textBox.Name = "actName_textBox";
            this.actName_textBox.Size = new System.Drawing.Size(147, 20);
            this.actName_textBox.TabIndex = 4;
            // 
            // addName_button
            // 
            this.addName_button.BackColor = System.Drawing.Color.Chartreuse;
            this.addName_button.Location = new System.Drawing.Point(244, 164);
            this.addName_button.Name = "addName_button";
            this.addName_button.Size = new System.Drawing.Size(62, 23);
            this.addName_button.TabIndex = 5;
            this.addName_button.Text = "Hozzáad";
            this.addName_button.UseVisualStyleBackColor = false;
            this.addName_button.Click += new System.EventHandler(this.addName_button_Click);
            // 
            // modifyName_button
            // 
            this.modifyName_button.BackColor = System.Drawing.Color.RoyalBlue;
            this.modifyName_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.modifyName_button.Location = new System.Drawing.Point(244, 135);
            this.modifyName_button.Name = "modifyName_button";
            this.modifyName_button.Size = new System.Drawing.Size(147, 23);
            this.modifyName_button.TabIndex = 6;
            this.modifyName_button.Text = "Módosít";
            this.modifyName_button.UseVisualStyleBackColor = false;
            this.modifyName_button.Click += new System.EventHandler(this.modifyName_button_Click);
            // 
            // delName_button
            // 
            this.delName_button.BackColor = System.Drawing.Color.Red;
            this.delName_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.delName_button.Location = new System.Drawing.Point(316, 164);
            this.delName_button.Name = "delName_button";
            this.delName_button.Size = new System.Drawing.Size(75, 23);
            this.delName_button.TabIndex = 7;
            this.delName_button.Text = "Töröl";
            this.delName_button.UseVisualStyleBackColor = false;
            this.delName_button.Click += new System.EventHandler(this.delName_button_Click);
            // 
            // gen_toolStripMenuItem
            // 
            this.gen_toolStripMenuItem.Name = "gen_toolStripMenuItem";
            this.gen_toolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.gen_toolStripMenuItem.Text = "Generálás";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delName_button);
            this.Controls.Add(this.modifyName_button);
            this.Controls.Add(this.addName_button);
            this.Controls.Add(this.actName_textBox);
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
        private System.Windows.Forms.ToolStripMenuItem oldPpl_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem student_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creators_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exit_ToolStripMenuItem;
        private System.Windows.Forms.Label Nevek;
        private System.Windows.Forms.ListBox names_listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addName_button;
        private System.Windows.Forms.Button modifyName_button;
        private System.Windows.Forms.Button delName_button;
        private System.Windows.Forms.TextBox actName_textBox;
        private System.Windows.Forms.ToolStripMenuItem gen_toolStripMenuItem;
    }
}

