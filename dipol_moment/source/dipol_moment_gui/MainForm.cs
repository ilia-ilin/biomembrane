using dipol_moment_gui.Resources;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

[assembly: NeutralResourcesLanguageAttribute("en-US")]

namespace dipol_moment_gui
{
    public partial class MainForm : Form
    {
        enum AtomType
        {
            H = 'H',
            C = 'C',
            N = 'N',
            O = 'O',
            P = 'P'
        }

        AtomType GetAtomType(string type)
        {
            switch (type)
            {
                case "H":
                    return AtomType.H;
                case "C":
                    return AtomType.C;
                case "N":
                    return AtomType.N;
                case "O":
                    return AtomType.O;
                case "P":
                    return AtomType.P;
                default:
                    throw new ArgumentException($"{type} is not available name of atom!");
            }
        }

        struct Atom
        {
            public AtomType type;
            public string index;
            public override bool Equals(object b)
            {
                Atom B = (Atom)b;
                return (type == B.type && index == B.index);
            }
            public override string ToString()
            {
                return $"{type}{index}";
            }
        }

        List<Atom> atoms = new List<Atom>();
        Dictionary<(Atom, Atom), (int, double, double)> bonds = new Dictionary<(Atom, Atom), (int, double, double)>();
        Dictionary<(Atom, Atom, Atom), (int, double, double)> angles = new Dictionary<(Atom, Atom, Atom), (int, double, double)>();
        List<(Atom, Atom, Atom)> molecule = new List<(Atom, Atom, Atom)>();

        public MainForm()
        {
            InitializeComponent();
            bondComboBox1.SelectedIndex = 0;
            bondComboBox2.SelectedIndex = 0;
            bondTable.RowStyles[0] = new RowStyle(SizeType.Absolute, 30);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ApplyLanguage(Thread.CurrentThread.CurrentCulture);
            //α
            //μ
        }

        private void ApplyLanguage(CultureInfo cultureInfo)
        {
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
            ResourceManager LocRM = new ResourceManager("dipol_moment_gui.Resources.Strings", typeof(Strings).Assembly);
            CultureInfo currentCulture = Thread.CurrentThread.CurrentUICulture;
            Text = LocRM.GetString("programName", currentCulture);
            fileStrip.Text = LocRM.GetString("fileStip.Text", currentCulture);
            file_createStrip.Text = LocRM.GetString("file_createStrip.Text", currentCulture);
            file_openStrip.Text = LocRM.GetString("file_openStrip.Text", currentCulture);
            file_saveStrip.Text = LocRM.GetString("file_saveStrip.Text", currentCulture);
            langStrip.Text = LocRM.GetString("langStrip.Text", currentCulture);
            bondgroupBox.Text = LocRM.GetString("bondgroupBox.Text", currentCulture);
            bondLabel.Text = LocRM.GetString("bondLabel.Text", currentCulture);
            bond_tableLabel.Text = LocRM.GetString("tableLabel.Text", currentCulture);
            bond_addButton.Text = LocRM.GetString("addButton.Text", currentCulture);

            anglegroupBox.Text = LocRM.GetString("anglegroupBox.Text", currentCulture);
            angleLabel.Text = LocRM.GetString("angleLabel.Text", currentCulture);
            angle_tableLabel.Text = LocRM.GetString("tableLabel.Text", currentCulture);
            angle_addButton.Text = LocRM.GetString("addButton.Text", currentCulture);
        }
        private string GetResource(string name)
        {
            ResourceManager LocRM = new ResourceManager("dipol_moment_gui.Resources.Strings", typeof(Strings).Assembly);
            return LocRM.GetString(name, Thread.CurrentThread.CurrentUICulture);
        }

        private void langStrip_Click(object sender, EventArgs e)
        {
            switch (((ToolStripMenuItem)sender).Name)
            {
                case "lang_enStrip":
                    ApplyLanguage(new CultureInfo("en-US"));
                    break;
                case "lang_ruStrip":
                    ApplyLanguage(new CultureInfo("ru-RU"));
                    break;
            }
        }

        private void bond_dTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double d = Convert.ToDouble(bond_dTextBox.Text.Replace('.', ','));
            }
            catch
            {
                bond_dTextBox.ForeColor = Color.Red;
                bond_muLabel.Text = "-";
                return;
            }
            bond_dTextBox.ForeColor = Color.Black;
            bond_muLabel.Text = "0";//FUNC!!!-----------------------------------------
        }

        private void bond_addButton_Click(object sender, EventArgs e)
        {
            double d;
            try
            {
                d = Convert.ToDouble(bond_dTextBox.Text.Replace('.', ','));
            }
            catch
            {

                MessageBox.Show(string.Format(GetResource("value_error"), "d"), GetResource("MessageBox.Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            Atom a1 = new Atom() { type = GetAtomType((string)bondComboBox1.SelectedItem), index = bond_indexTextBox1.Text },
                a2 = new Atom() { type = GetAtomType((string)bondComboBox2.SelectedItem), index = bond_indexTextBox2.Text };

            double mu = 000;//FUNC!!!-----------------------------------------

            if (atoms.Contains(a1))
                a1 = atoms[atoms.IndexOf(a1)];
            else
            {
                atoms.Add(a1);
                anglecomboBox1.Items.Add(a1.ToString());
                anglecomboBox2.Items.Add(a1.ToString());
                anglecomboBox3.Items.Add(a1.ToString());
            }
            if (atoms.Contains(a2))
                a2 = atoms[atoms.IndexOf(a2)];
            else
            {
                atoms.Add(a2);
                anglecomboBox1.Items.Add(a2.ToString());
                anglecomboBox2.Items.Add(a2.ToString());
                anglecomboBox3.Items.Add(a2.ToString());
            }

            if (bonds.ContainsKey((a1, a2)) || bonds.ContainsKey((a2, a1)))
            {
                if (MessageBox.Show(GetResource("value_info"), GetResource("MessageBox.Info"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    (Atom, Atom) idx;
                    if (bonds.ContainsKey((a1, a2)))
                        idx = (a1, a2);
                    else
                        idx = (a2, a1);

                    int i = bonds[idx].Item1;

                    var dlabel = (Label)bondTable.Controls[$"d{i + 1}"];
                    var mulabel = (Label)bondTable.Controls[$"mu{i + 1}"];
                    bondTable.Controls.Remove(dlabel);
                    bondTable.Controls.Remove(mulabel);
                    bonds[idx] = (i, d, mu);
                    dlabel.Text = d.ToString();
                    mulabel.Text = mu.ToString();
                    bondTable.Controls.Add(dlabel, 1, i + 1);
                    bondTable.Controls.Add(mulabel, 2, i + 1);
                }
                return;
            }

            bonds.Add((a1, a2), (bonds.Count, d, mu));

            int n = bondTable.RowCount;
            AnchorStyles anchor = AnchorStyles.Top | AnchorStyles.Right;
            bondTable.RowCount += 1;
            bondTable.Controls.Add(new Label() { Text = $"{a1} - {a2}", Dock = DockStyle.Fill, Anchor = anchor, TextAlign = ContentAlignment.MiddleRight, AutoSize = true }, 0, n);
            bondTable.Controls.Add(new Label() { Name = $"d{n}", Text = d.ToString(), Dock = DockStyle.Fill, Anchor = anchor, TextAlign = ContentAlignment.MiddleRight }, 1, n);
            bondTable.Controls.Add(new Label() { Name = $"mu{n}", Text = mu.ToString(), Dock = DockStyle.Fill, Anchor = anchor, TextAlign = ContentAlignment.MiddleRight }, 2, n);

            if (!anglegroupBox.Enabled)
            {
                anglegroupBox.Enabled = true;
                anglecomboBox1.SelectedIndex = 0;
                anglecomboBox2.SelectedIndex = 0;
                anglecomboBox3.SelectedIndex = 0;
            }
        }

        private void angle_aTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double d = Convert.ToDouble(angle_aTextBox.Text.Replace('.', ','));
            }
            catch
            {
                angle_aTextBox.ForeColor = Color.Red;
                angle_muLabel.Text = "-";
                return;
            }
            angle_aTextBox.ForeColor = Color.Black;

            Atom a1 = atoms[anglecomboBox1.SelectedIndex],
                a2 = atoms[anglecomboBox2.SelectedIndex],
                a3 = atoms[anglecomboBox3.SelectedIndex];

            if ((bonds.ContainsKey((a1, a2)) || bonds.ContainsKey((a2, a1))) && (bonds.ContainsKey((a2, a3)) || bonds.ContainsKey((a3, a2))))
                angle_muLabel.Text = "0";//FUNC!!!-----------------------------------------
            else
                angle_muLabel.Text = "-";
        }

        private void angle_addButton_Click(object sender, EventArgs e)
        {
            double angle;
            try
            {
                angle = Convert.ToDouble(angle_aTextBox.Text.Replace('.', ','));
            }
            catch
            {

                MessageBox.Show(string.Format(GetResource("value_error"), "α"), GetResource("MessageBox.Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Atom a1 = atoms[anglecomboBox1.SelectedIndex],
                a2 = atoms[anglecomboBox2.SelectedIndex],
                a3 = atoms[anglecomboBox3.SelectedIndex];

            if (!(bonds.ContainsKey((a1, a2)) || bonds.ContainsKey((a2, a1)))) 
            {
                MessageBox.Show(string.Format(GetResource("bond_error"), $"{a1} - {a2}"), GetResource("MessageBox.Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!(bonds.ContainsKey((a2, a3)) || bonds.ContainsKey((a3, a2))))
            {
                MessageBox.Show(string.Format(GetResource("bond_error"), $"{a2} - {a3}"), GetResource("MessageBox.Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double mu = 000;//FUNC!!!-----------------------------------------

            if(angles.ContainsKey((a1, a2, a3)) || angles.ContainsKey((a3, a2, a1)))
            {
                if (MessageBox.Show(GetResource("value_info"), GetResource("MessageBox.Info"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    (Atom, Atom, Atom) idx;
                    if (angles.ContainsKey((a1, a2, a3)))
                        idx = (a1, a2, a3);
                    else
                        idx = (a3, a2, a1);

                    int i = angles[idx].Item1;

                    var dlabel = (Label)angleTable.Controls[$"angle{i + 1}"];
                    var mulabel = (Label)angleTable.Controls[$"mu{i + 1}"];
                    angleTable.Controls.Remove(dlabel);
                    angleTable.Controls.Remove(mulabel);
                    angles[idx] = (i, angle, mu);
                    dlabel.Text = angle.ToString();
                    mulabel.Text = mu.ToString();
                    angleTable.Controls.Add(dlabel, 1, i + 1);
                    angleTable.Controls.Add(mulabel, 2, i + 1);
                }
                return;
            }

            angles.Add((a1, a2, a3), (angles.Count, angle, mu));

            int n = angleTable.RowCount;
            AnchorStyles anchor = AnchorStyles.Top | AnchorStyles.Right;
            angleTable.RowCount += 1;
            angleTable.Controls.Add(new Label() { Text = $"{a1} - {a2} - {a3}", Dock = DockStyle.Fill, Anchor = anchor, TextAlign = ContentAlignment.MiddleRight, AutoSize = true }, 0, n);
            angleTable.Controls.Add(new Label() { Name = $"angle{n}", Text = angle.ToString(), Dock = DockStyle.Fill, Anchor = anchor, TextAlign = ContentAlignment.MiddleRight }, 1, n);
            angleTable.Controls.Add(new Label() { Name = $"mu{n}", Text = mu.ToString(), Dock = DockStyle.Fill, Anchor = anchor, TextAlign = ContentAlignment.MiddleRight }, 2, n);
        }
    }
}
