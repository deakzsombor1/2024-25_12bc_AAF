namespace _2025_02_05_Form
{
    partial class Form1
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
            this.szam1 = new System.Windows.Forms.NumericUpDown();
            this.szam2 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.eredmeny = new System.Windows.Forms.Label();
            this.muveletCombo = new System.Windows.Forms.ComboBox();
            this.megoldasok = new System.Windows.Forms.Label();
            this.eredmenyek = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.szam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szam2)).BeginInit();
            this.SuspendLayout();
            // 
            // szam1
            // 
            this.szam1.Location = new System.Drawing.Point(13, 24);
            this.szam1.Name = "szam1";
            this.szam1.Size = new System.Drawing.Size(39, 20);
            this.szam1.TabIndex = 0;
            // 
            // szam2
            // 
            this.szam2.Location = new System.Drawing.Point(58, 24);
            this.szam2.Name = "szam2";
            this.szam2.Size = new System.Drawing.Size(40, 20);
            this.szam2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Összeadás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // eredmeny
            // 
            this.eredmeny.AutoSize = true;
            this.eredmeny.Location = new System.Drawing.Point(117, 72);
            this.eredmeny.Name = "eredmeny";
            this.eredmeny.Size = new System.Drawing.Size(53, 13);
            this.eredmeny.TabIndex = 3;
            this.eredmeny.Text = "eredmeny";
            // 
            // muveletCombo
            // 
            this.muveletCombo.FormattingEnabled = true;
            this.muveletCombo.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "mardék",
            "hatványozás"});
            this.muveletCombo.Location = new System.Drawing.Point(170, 24);
            this.muveletCombo.Name = "muveletCombo";
            this.muveletCombo.Size = new System.Drawing.Size(121, 21);
            this.muveletCombo.TabIndex = 4;
            this.muveletCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // megoldasok
            // 
            this.megoldasok.AutoSize = true;
            this.megoldasok.Location = new System.Drawing.Point(297, 31);
            this.megoldasok.Name = "megoldasok";
            this.megoldasok.Size = new System.Drawing.Size(0, 13);
            this.megoldasok.TabIndex = 5;
            // 
            // eredmenyek
            // 
            this.eredmenyek.AutoSize = true;
            this.eredmenyek.Location = new System.Drawing.Point(303, 27);
            this.eredmenyek.Name = "eredmenyek";
            this.eredmenyek.Size = new System.Drawing.Size(65, 13);
            this.eredmenyek.TabIndex = 6;
            this.eredmenyek.Text = "eredmenyek";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.eredmenyek);
            this.Controls.Add(this.megoldasok);
            this.Controls.Add(this.muveletCombo);
            this.Controls.Add(this.eredmeny);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.szam2);
            this.Controls.Add(this.szam1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.szam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szam2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown szam1;
        private System.Windows.Forms.NumericUpDown szam2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label eredmeny;
        private System.Windows.Forms.ComboBox muveletCombo;
        private System.Windows.Forms.Label megoldasok;
        private System.Windows.Forms.Label eredmenyek;
    }
}

