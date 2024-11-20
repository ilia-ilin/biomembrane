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
        }

        List<(Atom, Atom, double, double)> bonds = new List<(Atom, Atom, double, double)>();
        List<(Atom, Atom, Atom, double)> angles = new List<(Atom, Atom, Atom, double)>();
        List<int> molecule = new List<int>();

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
            bond_tableLabel.Text = LocRM.GetString("bond_tableLabel.Text", currentCulture);
            bond_addButton.Text = LocRM.GetString("bond_addButton.Text", currentCulture);
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

        private void group_dTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double d = Convert.ToDouble(((TextBox)sender).Text.Replace('.', ','));
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

        private void group_addButton_Click(object sender, EventArgs e)
        {
            double d;
            try
            {
                d = Convert.ToDouble(bond_dTextBox.Text.Replace('.', ','));
            }
            catch
            {

                MessageBox.Show(GetResource("bond_error"), GetResource("MessageBox.Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double mu = 000;//FUNC!!!-----------------------------------------
            Atom a1 = new Atom() { type = GetAtomType((string)bondComboBox1.SelectedItem), index = bond_indexTextBox1.Text },
                a2 = new Atom() { type = GetAtomType((string)bondComboBox2.SelectedItem), index = bond_indexTextBox2.Text };

            for(int i = 0; i < bonds.Count; i++)
            {

                if (bonds[i].Item1.Equals(a1) && bonds[i].Item2.Equals(a2) || bonds[i].Item1.Equals(a2) && bonds[i].Item2.Equals(a1))
                {
                    if(MessageBox.Show(GetResource("bond_info"), GetResource("MessageBox.Info"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var dlabel = (Label)bondTable.Controls[$"d{i + 1}"];
                        var mulabel = (Label)bondTable.Controls[$"mu{i + 1}"];
                        bondTable.Controls.Remove(dlabel);
                        bondTable.Controls.Remove(mulabel);
                        dlabel.Text = d.ToString();
                        mulabel.Text = mu.ToString();
                        bondTable.Controls.Add(dlabel, 1, i + 1);
                        bondTable.Controls.Add(mulabel, 2, i + 1);
                    }
                    return;
                }
            }

            bonds.Add((a1, a2, d, mu));

            int n = bondTable.RowCount;
            AnchorStyles anchor = AnchorStyles.Top | AnchorStyles.Right;
            bondTable.RowCount += 1;
            bondTable.Controls.Add(new Label() { Text = $"{a1.type}{a1.index} - {a2.type}{a2.index}", Dock = DockStyle.Fill, Anchor = anchor, TextAlign = ContentAlignment.MiddleRight }, 0, n);
            bondTable.Controls.Add(new Label() { Name = $"d{n}", Text = d.ToString(), Dock = DockStyle.Fill, Anchor = anchor, TextAlign = ContentAlignment.MiddleRight }, 1, n);
            bondTable.Controls.Add(new Label() { Name = $"mu{n}", Text = mu.ToString(), Dock = DockStyle.Fill, Anchor = anchor, TextAlign = ContentAlignment.MiddleRight }, 2, n);
        }
    }
}
