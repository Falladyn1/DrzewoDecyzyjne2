namespace DrzewoDecyzyjne2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            btnOpenFile = new Button();
            textBoxLoc = new TextBox();
            labelOpenFile = new Label();
            openFileDialog1 = new OpenFileDialog();
            groupBox1 = new GroupBox();
            radioBtnGini = new RadioButton();
            radioBtnEntropia = new RadioButton();
            labelPartitonWay = new Label();
            numericUpDownDepth = new NumericUpDown();
            labelDepth = new Label();
            numericUpDownPartion = new NumericUpDown();
            labelCVpartition = new Label();
            dataGridView1 = new DataGridView();
            lp = new DataGridViewTextBoxColumn();
            Cecha1 = new DataGridViewTextBoxColumn();
            Cecha2 = new DataGridViewTextBoxColumn();
            Cecha3 = new DataGridViewTextBoxColumn();
            Cecha4 = new DataGridViewTextBoxColumn();
            Gatunek = new DataGridViewTextBoxColumn();
            btnBuildTree = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDepth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPartion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnOpenFile
            // 
            btnOpenFile.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnOpenFile.Location = new Point(30, 409);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(94, 29);
            btnOpenFile.TabIndex = 0;
            btnOpenFile.Text = "Otwórz";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // textBoxLoc
            // 
            textBoxLoc.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxLoc.Location = new Point(130, 411);
            textBoxLoc.Name = "textBoxLoc";
            textBoxLoc.ReadOnly = true;
            textBoxLoc.Size = new Size(188, 27);
            textBoxLoc.TabIndex = 1;
            textBoxLoc.TextChanged += textBoxLoc_TextChanged;
            // 
            // labelOpenFile
            // 
            labelOpenFile.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelOpenFile.AutoSize = true;
            labelOpenFile.Location = new Point(30, 377);
            labelOpenFile.Name = "labelOpenFile";
            labelOpenFile.Size = new Size(87, 20);
            labelOpenFile.TabIndex = 2;
            labelOpenFile.Text = "Załaduj plik";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioBtnGini);
            groupBox1.Controls.Add(radioBtnEntropia);
            groupBox1.Controls.Add(labelPartitonWay);
            groupBox1.Controls.Add(numericUpDownDepth);
            groupBox1.Controls.Add(labelDepth);
            groupBox1.Controls.Add(numericUpDownPartion);
            groupBox1.Controls.Add(labelCVpartition);
            groupBox1.Location = new Point(30, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 223);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ustawienia";
            // 
            // radioBtnGini
            // 
            radioBtnGini.AutoSize = true;
            radioBtnGini.Checked = true;
            radioBtnGini.Location = new Point(6, 185);
            radioBtnGini.Name = "radioBtnGini";
            radioBtnGini.Size = new Size(56, 24);
            radioBtnGini.TabIndex = 6;
            radioBtnGini.TabStop = true;
            radioBtnGini.Text = "Gini";
            radioBtnGini.UseVisualStyleBackColor = true;
            // 
            // radioBtnEntropia
            // 
            radioBtnEntropia.AutoSize = true;
            radioBtnEntropia.Location = new Point(6, 155);
            radioBtnEntropia.Name = "radioBtnEntropia";
            radioBtnEntropia.Size = new Size(90, 24);
            radioBtnEntropia.TabIndex = 5;
            radioBtnEntropia.TabStop = true;
            radioBtnEntropia.Text = "Entriopia";
            radioBtnEntropia.UseVisualStyleBackColor = true;
            // 
            // labelPartitonWay
            // 
            labelPartitonWay.AutoSize = true;
            labelPartitonWay.Location = new Point(6, 132);
            labelPartitonWay.Name = "labelPartitonWay";
            labelPartitonWay.Size = new Size(121, 20);
            labelPartitonWay.TabIndex = 4;
            labelPartitonWay.Text = "Sposób podziału";
            // 
            // numericUpDownDepth
            // 
            numericUpDownDepth.Location = new Point(150, 62);
            numericUpDownDepth.Name = "numericUpDownDepth";
            numericUpDownDepth.Size = new Size(94, 27);
            numericUpDownDepth.TabIndex = 3;
            numericUpDownDepth.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // labelDepth
            // 
            labelDepth.AutoSize = true;
            labelDepth.Location = new Point(6, 62);
            labelDepth.Name = "labelDepth";
            labelDepth.Size = new Size(78, 20);
            labelDepth.TabIndex = 2;
            labelDepth.Text = "Głębokość";
            // 
            // numericUpDownPartion
            // 
            numericUpDownPartion.Location = new Point(150, 21);
            numericUpDownPartion.Name = "numericUpDownPartion";
            numericUpDownPartion.Size = new Size(94, 27);
            numericUpDownPartion.TabIndex = 1;
            numericUpDownPartion.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // labelCVpartition
            // 
            labelCVpartition.AutoSize = true;
            labelCVpartition.Location = new Point(6, 23);
            labelCVpartition.Name = "labelCVpartition";
            labelCVpartition.Size = new Size(113, 20);
            labelCVpartition.TabIndex = 0;
            labelCVpartition.Text = "Ilość podziałów";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { lp, Cecha1, Cecha2, Cecha3, Cecha4, Gatunek });
            dataGridView1.Location = new Point(340, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(503, 375);
            dataGridView1.TabIndex = 4;
            // 
            // lp
            // 
            lp.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            lp.HeaderText = "lp";
            lp.MinimumWidth = 6;
            lp.Name = "lp";
            lp.ReadOnly = true;
            lp.Width = 51;
            // 
            // Cecha1
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Cecha1.DefaultCellStyle = dataGridViewCellStyle2;
            Cecha1.HeaderText = "Cecha1";
            Cecha1.MinimumWidth = 6;
            Cecha1.Name = "Cecha1";
            Cecha1.ReadOnly = true;
            // 
            // Cecha2
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Cecha2.DefaultCellStyle = dataGridViewCellStyle3;
            Cecha2.HeaderText = "Cecha2";
            Cecha2.MinimumWidth = 6;
            Cecha2.Name = "Cecha2";
            Cecha2.ReadOnly = true;
            // 
            // Cecha3
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Cecha3.DefaultCellStyle = dataGridViewCellStyle4;
            Cecha3.HeaderText = "Cecha3";
            Cecha3.MinimumWidth = 6;
            Cecha3.Name = "Cecha3";
            Cecha3.ReadOnly = true;
            // 
            // Cecha4
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Cecha4.DefaultCellStyle = dataGridViewCellStyle5;
            Cecha4.HeaderText = "Cecha4";
            Cecha4.MinimumWidth = 6;
            Cecha4.Name = "Cecha4";
            Cecha4.ReadOnly = true;
            // 
            // Gatunek
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Gatunek.DefaultCellStyle = dataGridViewCellStyle6;
            Gatunek.HeaderText = "Gatunek";
            Gatunek.MinimumWidth = 6;
            Gatunek.Name = "Gatunek";
            Gatunek.ReadOnly = true;
            // 
            // btnBuildTree
            // 
            btnBuildTree.Location = new Point(50, 274);
            btnBuildTree.Name = "btnBuildTree";
            btnBuildTree.Size = new Size(200, 40);
            btnBuildTree.TabIndex = 5;
            btnBuildTree.Text = "BUDUJ DRZEWO";
            btnBuildTree.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 450);
            Controls.Add(btnBuildTree);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(labelOpenFile);
            Controls.Add(textBoxLoc);
            Controls.Add(btnOpenFile);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDepth).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPartion).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOpenFile;
        private TextBox textBoxLoc;
        private Label labelOpenFile;
        private OpenFileDialog openFileDialog1;
        private GroupBox groupBox1;
        private Label labelCVpartition;
        private NumericUpDown numericUpDownDepth;
        private Label labelDepth;
        private NumericUpDown numericUpDownPartion;
        private RadioButton radioBtnGini;
        private RadioButton radioBtnEntropia;
        private Label labelPartitonWay;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn lp;
        private DataGridViewTextBoxColumn Cecha1;
        private DataGridViewTextBoxColumn Cecha2;
        private DataGridViewTextBoxColumn Cecha3;
        private DataGridViewTextBoxColumn Cecha4;
        private DataGridViewTextBoxColumn Gatunek;
        private Button btnBuildTree;
    }
}
