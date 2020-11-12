namespace JogaStudio
{
    partial class FrmMain
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOktatok = new System.Windows.Forms.Button();
            this.btnProgramok = new System.Windows.Forms.Button();
            this.btnJelentkezes = new System.Windows.Forms.Button();
            this.btnKilepes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JogaStudio.Properties.Resources.joga_BG;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(476, 343);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnOktatok
            // 
            this.btnOktatok.BackColor = System.Drawing.Color.White;
            this.btnOktatok.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOktatok.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnOktatok.Location = new System.Drawing.Point(12, 377);
            this.btnOktatok.Name = "btnOktatok";
            this.btnOktatok.Size = new System.Drawing.Size(476, 63);
            this.btnOktatok.TabIndex = 1;
            this.btnOktatok.Text = "Oktatok";
            this.btnOktatok.UseVisualStyleBackColor = false;
            this.btnOktatok.Click += new System.EventHandler(this.btnOktatok_Click);
            // 
            // btnProgramok
            // 
            this.btnProgramok.BackColor = System.Drawing.Color.White;
            this.btnProgramok.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProgramok.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnProgramok.Location = new System.Drawing.Point(12, 452);
            this.btnProgramok.Name = "btnProgramok";
            this.btnProgramok.Size = new System.Drawing.Size(476, 63);
            this.btnProgramok.TabIndex = 2;
            this.btnProgramok.Text = "Programok";
            this.btnProgramok.UseVisualStyleBackColor = false;
            // 
            // btnJelentkezes
            // 
            this.btnJelentkezes.BackColor = System.Drawing.Color.White;
            this.btnJelentkezes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnJelentkezes.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnJelentkezes.Location = new System.Drawing.Point(12, 521);
            this.btnJelentkezes.Name = "btnJelentkezes";
            this.btnJelentkezes.Size = new System.Drawing.Size(476, 63);
            this.btnJelentkezes.TabIndex = 3;
            this.btnJelentkezes.Text = "Jelentkezes";
            this.btnJelentkezes.UseVisualStyleBackColor = false;
            // 
            // btnKilepes
            // 
            this.btnKilepes.BackColor = System.Drawing.Color.White;
            this.btnKilepes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKilepes.ForeColor = System.Drawing.Color.Red;
            this.btnKilepes.Location = new System.Drawing.Point(12, 590);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(476, 63);
            this.btnKilepes.TabIndex = 4;
            this.btnKilepes.Text = "Kilepes";
            this.btnKilepes.UseVisualStyleBackColor = false;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 700);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.btnJelentkezes);
            this.Controls.Add(this.btnProgramok);
            this.Controls.Add(this.btnOktatok);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.Text = "JogaStudio";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOktatok;
        private System.Windows.Forms.Button btnProgramok;
        private System.Windows.Forms.Button btnJelentkezes;
        private System.Windows.Forms.Button btnKilepes;
    }
}

