using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0327_jótékonykodás {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        void AddName(string filepath, string name) {
            var fw = new StreamWriter(filepath, true);
            fw.Write($"\n{name}");
            fw.Close();
        }

        void RmName(string filepath, string name) {
            var names = GetNames(filepath);
            var fw = new StreamWriter(filepath);
            if (!names.Remove(name)) {
                MessageBox.Show("Nincs ilyen név a listában!", "Figyelem!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                for (Int32 i = 0; i < names.Count; i++) {
                    fw.Write($"{names[i]}");
                    if (i != names.Count - 1) {
                        fw.Write("\n");
                    }
                }
            }
            fw.Close();
        }

        List<string> GetNames(string filepath) {
            var fr = new StreamReader(filepath);
            var names = new List<string>();

            while (!fr.EndOfStream) {
                names.Add(fr.ReadLine());
            }

            fr.Close();
            return names;
        }

        private void creators_ToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Fejéregyházi Attila, Vörös Dávid, Tihanyi Ádám\n2026.03.27. - 11.C", "Készítők", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exit_ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Biztos ki szeretne lépni?", "Kilépés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                Application.Exit();
            }
        }

        private void oldPpl_ToolStripMenuItem_Click(object sender, EventArgs e) {
            names_listBox.Items.Clear();
            foreach (var name in GetNames("./idosNevek.txt")) {
                names_listBox.Items.Add(name);
            }
        }

        private void student_ToolStripMenuItem_Click(object sender, EventArgs e) {
            names_listBox.Items.Clear();
            foreach (var name in GetNames("./diakNevek.txt")) {
                names_listBox.Items.Add(name);
            }
        }

        private void modifyName_button_Click(object sender, EventArgs e) {
            RmName(isStudent ? "./diakNevek.txt" : "./idosNevek.txt", crntName);
            AddName(isStudent ? "./diakNevek.txt" : "./idosNevek.txt", actName_textBox.Text);
        }

        private void delName_button_Click(object sender, EventArgs e) {
            RmName(isStudent ? "./diakNevek.txt" : "./idosNevek.txt", actName_textBox.Text);
        }

        private void addName_button_Click(object sender, EventArgs e) {
            AddName(isStudent ? "./diakNevek.txt" : "./idosNevek.txt", actName_textBox.Text);
        }

        string[] GenStudentNames() {
            var rnd = new Random();
            GetNames("./diakNevek.txt");
        }


        /* feladat:
* 2 fájl
  1.: idős emberek (jelentkeztek agórába hogy szeretnék megtanulni a számítógép használatot)
  nevek
  2.: diákok
  nevek

  menürendszerrel: embereket felviszünk (mindkét fájlba), tudunk törölni, tudunk javítani, generál: 1-2 idős-diák
*/

    }
}
