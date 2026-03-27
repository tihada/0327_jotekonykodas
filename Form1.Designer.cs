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
            this.gen_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generálásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hozzárendelésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creators_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Nevek = new System.Windows.Forms.Label();
            this.names_listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.actName_textBox = new System.Windows.Forms.TextBox();
            this.addName_button = new System.Windows.Forms.Button();
            this.modifyName_button = new System.Windows.Forms.Button();
            this.delName_button = new System.Windows.Forms.Button();
            this.state_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.menuStrip1.Size = new System.Drawing.Size(1023, 24);
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
            this.oldPpl_ToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.oldPpl_ToolStripMenuItem.Text = "Idős";
            this.oldPpl_ToolStripMenuItem.Click += new System.EventHandler(this.oldPpl_ToolStripMenuItem_Click);
            // 
            // student_ToolStripMenuItem
            // 
            this.student_ToolStripMenuItem.Name = "student_ToolStripMenuItem";
            this.student_ToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.student_ToolStripMenuItem.Text = "Diák";
            this.student_ToolStripMenuItem.Click += new System.EventHandler(this.student_ToolStripMenuItem_Click);
            // 
            // gen_toolStripMenuItem
            // 
            this.gen_toolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generálásToolStripMenuItem,
            this.hozzárendelésToolStripMenuItem});
            this.gen_toolStripMenuItem.Name = "gen_toolStripMenuItem";
            this.gen_toolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.gen_toolStripMenuItem.Text = "Párok";
            // 
            // generálásToolStripMenuItem
            // 
            this.generálásToolStripMenuItem.Name = "generálásToolStripMenuItem";
            this.generálásToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.generálásToolStripMenuItem.Text = "Generálás";
            this.generálásToolStripMenuItem.Click += new System.EventHandler(this.gen_toolStripMenuItem_Click);
            // 
            // hozzárendelésToolStripMenuItem
            // 
            this.hozzárendelésToolStripMenuItem.Name = "hozzárendelésToolStripMenuItem";
            this.hozzárendelésToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.hozzárendelésToolStripMenuItem.Text = "Hozzárendelés";
            this.hozzárendelésToolStripMenuItem.Click += new System.EventHandler(this.hozzárendelésToolStripMenuItem_Click);
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
            this.names_listBox.DoubleClick += new System.EventHandler(this.names_listBox_DBLClick);
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
            this.actName_textBox.Enabled = false;
            this.actName_textBox.Location = new System.Drawing.Point(244, 93);
            this.actName_textBox.Name = "actName_textBox";
            this.actName_textBox.Size = new System.Drawing.Size(147, 20);
            this.actName_textBox.TabIndex = 4;
            // 
            // addName_button
            // 
            this.addName_button.BackColor = System.Drawing.Color.Chartreuse;
            this.addName_button.Enabled = false;
            this.addName_button.Location = new System.Drawing.Point(244, 164);
            this.addName_button.Name = "addName_button";
            this.addName_button.Size = new System.Drawing.Size(62, 23);
            this.addName_button.TabIndex = 5;
            this.addName_button.Text = "Hozzáad";
            this.addName_button.UseVisualStyleBackColor = false;
            this.addName_button.Click += new System.EventHandler(this.AddName_button_Click);
            // 
            // modifyName_button
            // 
            this.modifyName_button.BackColor = System.Drawing.Color.RoyalBlue;
            this.modifyName_button.Enabled = false;
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
            this.delName_button.Enabled = false;
            this.delName_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.delName_button.Location = new System.Drawing.Point(316, 164);
            this.delName_button.Name = "delName_button";
            this.delName_button.Size = new System.Drawing.Size(75, 23);
            this.delName_button.TabIndex = 7;
            this.delName_button.Text = "Töröl";
            this.delName_button.UseVisualStyleBackColor = false;
            this.delName_button.Click += new System.EventHandler(this.delName_button_Click);
            // 
            // state_label
            // 
            this.state_label.AutoSize = true;
            this.state_label.Location = new System.Drawing.Point(82, 54);
            this.state_label.Name = "state_label";
            this.state_label.Size = new System.Drawing.Size(10, 13);
            this.state_label.TabIndex = 8;
            this.state_label.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(714, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hozzárendelés";
            this.label2.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(414, 109);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(416, 290);
            this.listBox1.TabIndex = 10;
            this.listBox1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(549, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Idős neve - diák1 - diák2";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(567, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Hozzárendelések";
            this.label4.Visible = false;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(847, 96);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(164, 303);
            this.listBox2.TabIndex = 14;
            this.listBox2.Visible = false;
            this.listBox2.DoubleClick += new System.EventHandler(this.listBox2_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(896, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Diákok";
            this.label5.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Enabled = false;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(700, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Hozzárendelés mentése";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.state_label);
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
        private System.Windows.Forms.Label state_label;
        private System.Windows.Forms.ToolStripMenuItem generálásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hozzárendelésToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

