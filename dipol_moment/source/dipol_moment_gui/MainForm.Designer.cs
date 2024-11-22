namespace dipol_moment_gui
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.file_createStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.file_openStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.file_saveStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.langStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.lang_enStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.lang_ruStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.bondgroupBox = new System.Windows.Forms.GroupBox();
            this.bond_dTextBox = new System.Windows.Forms.TextBox();
            this.bond_indexTextBox2 = new System.Windows.Forms.TextBox();
            this.bond_indexTextBox1 = new System.Windows.Forms.TextBox();
            this.bondTable = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bond_tableLabel = new System.Windows.Forms.Label();
            this.bond_addButton = new System.Windows.Forms.Button();
            this.bond_muLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bondComboBox2 = new System.Windows.Forms.ComboBox();
            this.bondComboBox1 = new System.Windows.Forms.ComboBox();
            this.bondLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.bondgroupBox.SuspendLayout();
            this.bondTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileStrip,
            this.langStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(788, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileStrip
            // 
            this.fileStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_createStrip,
            this.file_openStrip,
            this.file_saveStrip});
            this.fileStrip.Name = "fileStrip";
            this.fileStrip.Size = new System.Drawing.Size(37, 20);
            this.fileStrip.Text = "File";
            // 
            // file_createStrip
            // 
            this.file_createStrip.Name = "file_createStrip";
            this.file_createStrip.Size = new System.Drawing.Size(108, 22);
            this.file_createStrip.Text = "Create";
            // 
            // file_openStrip
            // 
            this.file_openStrip.Name = "file_openStrip";
            this.file_openStrip.Size = new System.Drawing.Size(108, 22);
            this.file_openStrip.Text = "Open";
            // 
            // file_saveStrip
            // 
            this.file_saveStrip.Name = "file_saveStrip";
            this.file_saveStrip.Size = new System.Drawing.Size(108, 22);
            this.file_saveStrip.Text = "Save";
            // 
            // langStrip
            // 
            this.langStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lang_enStrip,
            this.lang_ruStrip});
            this.langStrip.Name = "langStrip";
            this.langStrip.Size = new System.Drawing.Size(71, 20);
            this.langStrip.Text = "Language";
            // 
            // lang_enStrip
            // 
            this.lang_enStrip.Name = "lang_enStrip";
            this.lang_enStrip.Size = new System.Drawing.Size(119, 22);
            this.lang_enStrip.Text = "English";
            this.lang_enStrip.Click += new System.EventHandler(this.langStrip_Click);
            // 
            // lang_ruStrip
            // 
            this.lang_ruStrip.Name = "lang_ruStrip";
            this.lang_ruStrip.Size = new System.Drawing.Size(119, 22);
            this.lang_ruStrip.Text = "Русский";
            this.lang_ruStrip.Click += new System.EventHandler(this.langStrip_Click);
            // 
            // bondgroupBox
            // 
            this.bondgroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bondgroupBox.Controls.Add(this.bond_dTextBox);
            this.bondgroupBox.Controls.Add(this.bond_indexTextBox2);
            this.bondgroupBox.Controls.Add(this.bond_indexTextBox1);
            this.bondgroupBox.Controls.Add(this.bondTable);
            this.bondgroupBox.Controls.Add(this.bond_addButton);
            this.bondgroupBox.Controls.Add(this.bond_muLabel);
            this.bondgroupBox.Controls.Add(this.label3);
            this.bondgroupBox.Controls.Add(this.label2);
            this.bondgroupBox.Controls.Add(this.label1);
            this.bondgroupBox.Controls.Add(this.bondComboBox2);
            this.bondgroupBox.Controls.Add(this.bondComboBox1);
            this.bondgroupBox.Controls.Add(this.bondLabel);
            this.bondgroupBox.Location = new System.Drawing.Point(12, 48);
            this.bondgroupBox.Name = "bondgroupBox";
            this.bondgroupBox.Size = new System.Drawing.Size(764, 222);
            this.bondgroupBox.TabIndex = 2;
            this.bondgroupBox.TabStop = false;
            this.bondgroupBox.Text = "Dipole moment of a chemical bond";
            // 
            // bond_dTextBox
            // 
            this.bond_dTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bond_dTextBox.Location = new System.Drawing.Point(658, 29);
            this.bond_dTextBox.Name = "bond_dTextBox";
            this.bond_dTextBox.Size = new System.Drawing.Size(100, 24);
            this.bond_dTextBox.TabIndex = 12;
            this.bond_dTextBox.TextChanged += new System.EventHandler(this.group_dTextBox_TextChanged);
            // 
            // bond_indexTextBox2
            // 
            this.bond_indexTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bond_indexTextBox2.Location = new System.Drawing.Point(567, 29);
            this.bond_indexTextBox2.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.bond_indexTextBox2.MaxLength = 7;
            this.bond_indexTextBox2.Name = "bond_indexTextBox2";
            this.bond_indexTextBox2.Size = new System.Drawing.Size(62, 24);
            this.bond_indexTextBox2.TabIndex = 11;
            // 
            // bond_indexTextBox1
            // 
            this.bond_indexTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bond_indexTextBox1.Location = new System.Drawing.Point(433, 29);
            this.bond_indexTextBox1.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.bond_indexTextBox1.MaxLength = 7;
            this.bond_indexTextBox1.Name = "bond_indexTextBox1";
            this.bond_indexTextBox1.Size = new System.Drawing.Size(62, 24);
            this.bond_indexTextBox1.TabIndex = 10;
            // 
            // bondTable
            // 
            this.bondTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bondTable.AutoScroll = true;
            this.bondTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.bondTable.ColumnCount = 3;
            this.bondTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bondTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.bondTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.bondTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.bondTable.Controls.Add(this.label5, 1, 0);
            this.bondTable.Controls.Add(this.label6, 2, 0);
            this.bondTable.Controls.Add(this.bond_tableLabel, 0, 0);
            this.bondTable.Location = new System.Drawing.Point(9, 70);
            this.bondTable.Name = "bondTable";
            this.bondTable.RowCount = 1;
            this.bondTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.bondTable.Size = new System.Drawing.Size(494, 139);
            this.bondTable.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(294, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "d";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(416, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "μ";
            // 
            // bond_tableLabel
            // 
            this.bond_tableLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bond_tableLabel.AutoSize = true;
            this.bond_tableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bond_tableLabel.Location = new System.Drawing.Point(61, 1);
            this.bond_tableLabel.Name = "bond_tableLabel";
            this.bond_tableLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bond_tableLabel.Size = new System.Drawing.Size(120, 18);
            this.bond_tableLabel.TabIndex = 0;
            this.bond_tableLabel.Text = "Chemical bond";
            // 
            // bond_addButton
            // 
            this.bond_addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bond_addButton.Location = new System.Drawing.Point(658, 190);
            this.bond_addButton.Name = "bond_addButton";
            this.bond_addButton.Size = new System.Drawing.Size(100, 26);
            this.bond_addButton.TabIndex = 8;
            this.bond_addButton.Text = "Add";
            this.bond_addButton.UseVisualStyleBackColor = true;
            this.bond_addButton.Click += new System.EventHandler(this.group_addButton_Click);
            // 
            // bond_muLabel
            // 
            this.bond_muLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bond_muLabel.AutoSize = true;
            this.bond_muLabel.Location = new System.Drawing.Point(552, 70);
            this.bond_muLabel.Name = "bond_muLabel";
            this.bond_muLabel.Size = new System.Drawing.Size(13, 18);
            this.bond_muLabel.TabIndex = 7;
            this.bond_muLabel.Text = "-";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(509, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "μ   =";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(635, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "=";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "-";
            // 
            // bondComboBox2
            // 
            this.bondComboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bondComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bondComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bondComboBox2.FormattingEnabled = true;
            this.bondComboBox2.Items.AddRange(new object[] {
            "H",
            "C",
            "N",
            "O",
            "P"});
            this.bondComboBox2.Location = new System.Drawing.Point(520, 29);
            this.bondComboBox2.Name = "bondComboBox2";
            this.bondComboBox2.Size = new System.Drawing.Size(46, 26);
            this.bondComboBox2.TabIndex = 2;
            this.bondComboBox2.TabStop = false;
            // 
            // bondComboBox1
            // 
            this.bondComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bondComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bondComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bondComboBox1.FormattingEnabled = true;
            this.bondComboBox1.Items.AddRange(new object[] {
            "H",
            "C",
            "N",
            "O",
            "P"});
            this.bondComboBox1.Location = new System.Drawing.Point(386, 29);
            this.bondComboBox1.Name = "bondComboBox1";
            this.bondComboBox1.Size = new System.Drawing.Size(46, 26);
            this.bondComboBox1.TabIndex = 1;
            this.bondComboBox1.TabStop = false;
            // 
            // bondLabel
            // 
            this.bondLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bondLabel.Location = new System.Drawing.Point(9, 32);
            this.bondLabel.Name = "bondLabel";
            this.bondLabel.Size = new System.Drawing.Size(371, 18);
            this.bondLabel.TabIndex = 0;
            this.bondLabel.Text = "Chemical bond length d:";
            this.bondLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 390);
            this.Controls.Add(this.bondgroupBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MainForm";
            this.Text = "Dipole moment calculation";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.bondgroupBox.ResumeLayout(false);
            this.bondgroupBox.PerformLayout();
            this.bondTable.ResumeLayout(false);
            this.bondTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileStrip;
        private System.Windows.Forms.ToolStripMenuItem file_openStrip;
        private System.Windows.Forms.ToolStripMenuItem file_createStrip;
        private System.Windows.Forms.ToolStripMenuItem file_saveStrip;
        private System.Windows.Forms.ToolStripMenuItem langStrip;
        private System.Windows.Forms.ToolStripMenuItem lang_enStrip;
        private System.Windows.Forms.ToolStripMenuItem lang_ruStrip;
        private System.Windows.Forms.GroupBox bondgroupBox;
        private System.Windows.Forms.Label bondLabel;
        private System.Windows.Forms.ComboBox bondComboBox1;
        private System.Windows.Forms.ComboBox bondComboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label bond_muLabel;
        private System.Windows.Forms.Button bond_addButton;
        private System.Windows.Forms.TableLayoutPanel bondTable;
        private System.Windows.Forms.TextBox bond_indexTextBox1;
        private System.Windows.Forms.TextBox bond_indexTextBox2;
        private System.Windows.Forms.TextBox bond_dTextBox;
        private System.Windows.Forms.Label bond_tableLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

