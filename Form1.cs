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
        Random rnd = new Random();


        public Form1() {
            InitializeComponent();
        }

        void GenPairFile() {
            var fw = new StreamWriter("./random_parok.txt");

            foreach (var name in GetNames("idosNevek.txt")) {
                string[] pairs = GenStudentNames();
                fw.WriteLine($"{name};{pairs[0]};{pairs[1]}");
            }

            fw.Close();
        }

        void AddName(string filepath, string name) {
            var fw = new StreamWriter(filepath, true);
            fw.Write($"\n{name}");
            fw.Close();
        }

        bool RmName(string filepath, string name) {
            var names = GetNames(filepath);
            var fw = new StreamWriter(filepath);
            if (!names.Remove(name)) {
                MessageBox.Show("Nincs ilyen név a listában!", "Figyelem!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fw.Close();
                return false;
            }

            for (Int32 i = 0; i < names.Count; i++) {
                fw.Write($"{names[i]}");
                if (i != names.Count - 1) {
                    fw.Write("\n");
                }
            }
            fw.Close();
            return true;
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

        private void EnaDef() {
            actName_textBox.Enabled = true;
            addName_button.Enabled = true;
        }

        private void oldPpl_ToolStripMenuItem_Click(object sender, EventArgs e) {
            isStudent = false;
            state_label.Text = "Idősek";
            UpdateNames_listBox();
            EnaDef();
        }

        private void student_ToolStripMenuItem_Click(object sender, EventArgs e) {
            isStudent = true;
            state_label.Text = "Diákok";
            UpdateNames_listBox();
            EnaDef();
        }

        private void UpdateNames_listBox() {
            names_listBox.Items.Clear();
            foreach (var name in GetNames(isStudent ? "./diakNevek.txt" : "./idosNevek.txt")) {
                names_listBox.Items.Add(name);
            }
        }

        private void names_listBox_DBLClick(object sender, EventArgs e) {
            if(names_listBox.SelectedIndex >= 0) {
                crntName = names_listBox.SelectedItem.ToString();
                actName_textBox.Text = crntName;
                ChangeButtonState(true);
            }
        }

        private void modifyName_button_Click(object sender, EventArgs e) {
            if (!RmName(isStudent ? "./diakNevek.txt" : "./idosNevek.txt", crntName)) { return; }
            crntName = actName_textBox.Text;
            AddName(isStudent ? "./diakNevek.txt" : "./idosNevek.txt", crntName);
            ChangeButtonState(false);
            UpdateNames_listBox();
            actName_textBox.Text = "";
            MessageBox.Show($"{crntName} neve sikeresen módosítva", "Név módosítva", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void delName_button_Click(object sender, EventArgs e) {
            string name2del = actName_textBox.Text;
            RmName(isStudent ? "./diakNevek.txt" : "./idosNevek.txt", name2del);
            crntName = "";
            ChangeButtonState(false);
            UpdateNames_listBox();
            actName_textBox.Text = "";
            MessageBox.Show($"{name2del} neve sikeresen eltávolítva", "Név törölve", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddName_button_Click(object sender, EventArgs e) {
            crntName = actName_textBox.Text;
            if (crntName.Length <= 0) {
                MessageBox.Show($"Kérem írjon be egy nevet!", "Név hozzáadás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AddName(isStudent ? "./diakNevek.txt" : "./idosNevek.txt", crntName);
            ChangeButtonState(false);
            UpdateNames_listBox();
            actName_textBox.Text = "";
            MessageBox.Show($"{crntName} neve sikeresen hozzáadva", "Név hozzáadás", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        string[] GenStudentNames() {
            var names = GetNames("./diakNevek.txt");
            string[] choosenNames = new string[2];
            choosenNames[0] = names[rnd.Next(names.Count)];
            choosenNames[1] = choosenNames[0];

            do {
                choosenNames[1] = names[rnd.Next(names.Count)];
            }
            while (choosenNames[0] == choosenNames[1]);

            return choosenNames;
        }

        private void gen_toolStripMenuItem_Click(object sender, EventArgs e) {
            GenPairFile();
            MessageBox.Show("Párosítás sikeresen legenerálva." , "Párosítás generálása", MessageBoxButtons.OK, MessageBoxIcon.Information );
        }

        private void ChangeButtonState(bool ena) {
            delName_button.Enabled = ena;
            modifyName_button.Enabled = ena;
        }

        private void hozzárendelésToolStripMenuItem_Click(object sender, EventArgs e) {
            listBox1.Visible = true;
            listBox2.Visible = true;
            button1.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            List<string> nevek = GetNames("./idosNevek.txt");
            string[] nevekTomb = new string[nevek.Count];
            for (int i = 0; i < nevekTomb.Length; i++) {
                nevekTomb[i] = nevek[i];
            }
            listBox1.Items.Clear();
            listBox1.Items.AddRange(nevekTomb);
            listBox1.SelectedIndex = 0;

            List<string> diakok = GetNames("./diakNevek.txt");
            string[] diakokTomb = new string[diakok.Count];
            for (int i = 0; i < diakokTomb.Length; i++) {
                diakokTomb[i] = diakok[i];
            }
            listBox2.Items.Clear();
            listBox2.Items.AddRange(diakokTomb);
            button1.Enabled = true;
        }

        private void listBox2_DoubleClick(object sender, EventArgs e) {
            if (listBox1.SelectedIndex == -1 || listBox2.SelectedIndex == -1) return;
            string idos;
            string select = listBox1.SelectedItem.ToString();
            string[] idk = select.Split('-');
            for (int i = 0; i < idk.Length; i++) {
                idk[i] = idk[i].Trim(); }
            string diak = listBox2.SelectedItem.ToString();
            if (idk.Contains(diak)) {
                MessageBox.Show("Egy időshőz 2 különböző diákot kell rendelni.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string[] ujidos = new string[3];
            ujidos[0] = idk[0];
            if(idk.Length == 1 ) {
                ujidos[1] = diak;
                ujidos[2] = "";
            } else if(idk.Length == 2 || idk[2] == "") {
                ujidos[1] = idk[1];
                ujidos[2] = diak;
            } else {
                ujidos[1] = diak;
                ujidos[2] = "";
            }
            idos = $"{ujidos[0]} - {ujidos[1]} - {ujidos[2]}";
            listBox1.Items[listBox1.SelectedIndex] = idos;
            if (ujidos[1] != "" && ujidos[2] != "") {
                if(listBox1.SelectedIndex == listBox1.Items.Count - 1) {
                    MessageBox.Show("Végigértünk az idősök során. Valószínűleg kész a hozzárendelés.", "Lista vége", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else {
                    listBox1.SelectedIndex += 1;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            List<string[]> rendelesek = new List<string[]>();
            foreach(var item in listBox1.Items) {
                string[] add = item.ToString().Split('-');
                if(add.Length < 3) {
                    MessageBox.Show("A hozzárendelést nem lehet elmenteni mert nincs mindegyik időshöz 2 diák hozzárendelve.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                for(int i = 0; i < add.Length; i++) {
                    add[i] = add[i].Trim();
                    if (add[i] == "") {
                        MessageBox.Show("A hozzárendelést nem lehet elmenteni mert nincs mindegyik időshöz 2 diák hozzárendelve.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                rendelesek.Add(add);
            }

            var fw = new StreamWriter("./hozzarendeles_parok.txt");
            foreach (var item in rendelesek) {
                fw.WriteLine($"{item[0]};{item[1]};{item[2]}");
            }
            fw.Close();
            listBox1.Visible = false;
            listBox2.Visible = false;
            button1.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            MessageBox.Show("A hozzárendelés sikeresen elmentve.", "Hozzárendelés elmentve", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
