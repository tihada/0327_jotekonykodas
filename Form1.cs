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
        public bool isStudent = false;
        public string crntName;
        public Form1() {
            InitializeComponent();
        }
        Random rnd = new Random();

        void GenPairFile() {
            List<string> oldNames = GetNames("idosNevek.txt");
            List<string> youngNames = GetNames("diakNevek.txt");
            StreamWriter fw = new StreamWriter("parok.txt");
            for (int i = 0; i < oldNames.Count; i++) {

            }
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
            isStudent = false;
            state_label.Text = "Idősek";
            UpdateNames_listBox();
        }

        private void student_ToolStripMenuItem_Click(object sender, EventArgs e) {
            isStudent = true;
            state_label.Text = "Diákok";
            UpdateNames_listBox();
        }

        private void UpdateNames_listBox() {
            names_listBox.Items.Clear();
            foreach (var name in GetNames(isStudent ? "./diakNevek.txt" : "./idosNevek.txt")) {
                names_listBox.Items.Add(name);
            }
        }

        private void names_listBox_DBLClick(object sender, EventArgs e) {
            try {
                crntName = names_listBox.SelectedItem.ToString();
            }
            catch {
                return;
            }

            actName_textBox.Text = crntName;
        }

        private void modifyName_button_Click(object sender, EventArgs e) {
            RmName(isStudent ? "./diakNevek.txt" : "./idosNevek.txt", crntName);
            crntName = actName_textBox.Text;
            AddName(isStudent ? "./diakNevek.txt" : "./idosNevek.txt", actName_textBox.Text);
            UpdateNames_listBox();
            MessageBox.Show($"{crntName} neve sikeresen módosítva", "Név módosítva", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void delName_button_Click(object sender, EventArgs e) {
            RmName(isStudent ? "./diakNevek.txt" : "./idosNevek.txt", actName_textBox.Text);
            crntName = "";
            UpdateNames_listBox();
            MessageBox.Show($"{crntName} neve sikeresen eltávolítva", "Név törölve", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddName_button_Click(object sender, EventArgs e) {
            AddName(isStudent ? "./diakNevek.txt" : "./idosNevek.txt", actName_textBox.Text);
            UpdateNames_listBox();
        }

        string[] GenStudentNames() {
            var rnd = new Random();
            var names = GetNames("./diakNevek.txt");
            var choosenNames = new string[2];
            choosenNames[0] = names[rnd.Next(names.Count)];
            choosenNames[1] = choosenNames[0];

            do {
                choosenNames[1] = names[rnd.Next(names.Count)];
            }
            while (choosenNames[0] == choosenNames[1]);

            return choosenNames;
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
