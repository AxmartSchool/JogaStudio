
namespace JogaStudio
{
    partial class FrmProgramok
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbGyakorlat = new System.Windows.Forms.ComboBox();
            this.cbOktato = new System.Windows.Forms.ComboBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.tbPerc = new System.Windows.Forms.TextBox();
            this.tbOra = new System.Windows.Forms.TextBox();
            this.dgvProgramok = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUjEsemeny = new System.Windows.Forms.Button();
            this.btnFrissites = new System.Windows.Forms.Button();
            this.btnTorles = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgramok)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbGyakorlat);
            this.groupBox1.Controls.Add(this.cbOktato);
            this.groupBox1.Controls.Add(this.dtpDatum);
            this.groupBox1.Controls.Add(this.tbPerc);
            this.groupBox1.Controls.Add(this.tbOra);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(22, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 216);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uj esemeny felvetele/kijelolt esemeny szerkesztese";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Datum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kezdes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gyakorlat:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Oktato:";
            // 
            // cbGyakorlat
            // 
            this.cbGyakorlat.FormattingEnabled = true;
            this.cbGyakorlat.Location = new System.Drawing.Point(530, 107);
            this.cbGyakorlat.Name = "cbGyakorlat";
            this.cbGyakorlat.Size = new System.Drawing.Size(121, 28);
            this.cbGyakorlat.TabIndex = 3;
            // 
            // cbOktato
            // 
            this.cbOktato.FormattingEnabled = true;
            this.cbOktato.Location = new System.Drawing.Point(530, 36);
            this.cbOktato.Name = "cbOktato";
            this.cbOktato.Size = new System.Drawing.Size(121, 28);
            this.cbOktato.TabIndex = 3;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(132, 39);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(143, 26);
            this.dtpDatum.TabIndex = 1;
            // 
            // tbPerc
            // 
            this.tbPerc.Location = new System.Drawing.Point(218, 107);
            this.tbPerc.Name = "tbPerc";
            this.tbPerc.Size = new System.Drawing.Size(57, 26);
            this.tbPerc.TabIndex = 2;
            // 
            // tbOra
            // 
            this.tbOra.Location = new System.Drawing.Point(132, 107);
            this.tbOra.Name = "tbOra";
            this.tbOra.Size = new System.Drawing.Size(61, 26);
            this.tbOra.TabIndex = 2;
            // 
            // dgvProgramok
            // 
            this.dgvProgramok.AllowUserToAddRows = false;
            this.dgvProgramok.AllowUserToDeleteRows = false;
            this.dgvProgramok.AllowUserToResizeColumns = false;
            this.dgvProgramok.AllowUserToResizeRows = false;
            this.dgvProgramok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProgramok.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProgramok.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProgramok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProgramok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProgramok.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProgramok.Location = new System.Drawing.Point(12, 12);
            this.dgvProgramok.Name = "dgvProgramok";
            this.dgvProgramok.RowHeadersVisible = false;
            this.dgvProgramok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProgramok.Size = new System.Drawing.Size(787, 150);
            this.dgvProgramok.TabIndex = 4;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ID";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Datum";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "Kezdes";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Oktato";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Gyakorlat";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column5.HeaderText = "Letszam";
            this.Column5.Name = "Column5";
            // 
            // btnUjEsemeny
            // 
            this.btnUjEsemeny.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUjEsemeny.Location = new System.Drawing.Point(22, 400);
            this.btnUjEsemeny.Name = "btnUjEsemeny";
            this.btnUjEsemeny.Size = new System.Drawing.Size(246, 61);
            this.btnUjEsemeny.TabIndex = 5;
            this.btnUjEsemeny.Text = "Uj esemeny felvetele";
            this.btnUjEsemeny.UseVisualStyleBackColor = true;
            // 
            // btnFrissites
            // 
            this.btnFrissites.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFrissites.Location = new System.Drawing.Point(274, 400);
            this.btnFrissites.Name = "btnFrissites";
            this.btnFrissites.Size = new System.Drawing.Size(266, 61);
            this.btnFrissites.TabIndex = 5;
            this.btnFrissites.Text = "Kijelolt esemeny firssitese";
            this.btnFrissites.UseVisualStyleBackColor = true;
            // 
            // btnTorles
            // 
            this.btnTorles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTorles.Location = new System.Drawing.Point(546, 400);
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.Size = new System.Drawing.Size(253, 61);
            this.btnTorles.TabIndex = 5;
            this.btnTorles.Text = "Kijelolt esemeny torlese";
            this.btnTorles.UseVisualStyleBackColor = true;
            // 
            // FrmProgramok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 488);
            this.Controls.Add(this.btnTorles);
            this.Controls.Add(this.btnFrissites);
            this.Controls.Add(this.btnUjEsemeny);
            this.Controls.Add(this.dgvProgramok);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmProgramok";
            this.Text = "FrmProgramok";
            this.Load += new System.EventHandler(this.FrmProgramok_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgramok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.TextBox tbOra;
        private System.Windows.Forms.ComboBox cbOktato;
        private System.Windows.Forms.DataGridView dgvProgramok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGyakorlat;
        private System.Windows.Forms.TextBox tbPerc;
        private System.Windows.Forms.Button btnUjEsemeny;
        private System.Windows.Forms.Button btnFrissites;
        private System.Windows.Forms.Button btnTorles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}