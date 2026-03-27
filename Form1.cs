using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0327_jótékonykodás {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void készítőkToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Fejéregyházi Attila, Vörös Dávid, Tihanyi Ádám\n2026.03.27. - 11.C", "Készítők", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Biztos ki szeretne lépni?", "Kilépés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                Application.Exit();
            }
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
