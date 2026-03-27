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
    }
}
