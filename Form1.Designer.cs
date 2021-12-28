
namespace WindowsFormsAppBMI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWzrost = new System.Windows.Forms.TextBox();
            this.txtWaga = new System.Windows.Forms.TextBox();
            this.txtWynik = new System.Windows.Forms.TextBox();
            this.radKg = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnWyjscie = new System.Windows.Forms.Button();
            this.radLb = new System.Windows.Forms.RadioButton();
            this.btnResult = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.kolorWyniku = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(53, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wzrost (cm)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(53, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Waga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Wynik";
            // 
            // txtWzrost
            // 
            this.txtWzrost.Location = new System.Drawing.Point(153, 55);
            this.txtWzrost.Name = "txtWzrost";
            this.txtWzrost.Size = new System.Drawing.Size(139, 20);
            this.txtWzrost.TabIndex = 2;
            this.txtWzrost.TextChanged += new System.EventHandler(this.txtWzrost_TextChanged);
            // 
            // txtWaga
            // 
            this.txtWaga.Location = new System.Drawing.Point(153, 81);
            this.txtWaga.Name = "txtWaga";
            this.txtWaga.Size = new System.Drawing.Size(139, 20);
            this.txtWaga.TabIndex = 1;
            this.txtWaga.TextChanged += new System.EventHandler(this.txtWaga_TextChanged);
            // 
            // txtWynik
            // 
            this.txtWynik.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtWynik.Location = new System.Drawing.Point(53, 178);
            this.txtWynik.Multiline = true;
            this.txtWynik.Name = "txtWynik";
            this.txtWynik.ReadOnly = true;
            this.txtWynik.ShortcutsEnabled = false;
            this.txtWynik.Size = new System.Drawing.Size(237, 83);
            this.txtWynik.TabIndex = 0;
            this.txtWynik.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // radKg
            // 
            this.radKg.AutoSize = true;
            this.radKg.Location = new System.Drawing.Point(56, 121);
            this.radKg.Name = "radKg";
            this.radKg.Size = new System.Drawing.Size(92, 17);
            this.radKg.TabIndex = 3;
            this.radKg.TabStop = true;
            this.radKg.Text = "Kilogramy (Kg)";
            this.radKg.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(54, 390);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(102, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Zresetuj";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnWyjscie
            // 
            this.btnWyjscie.Location = new System.Drawing.Point(185, 390);
            this.btnWyjscie.Name = "btnWyjscie";
            this.btnWyjscie.Size = new System.Drawing.Size(106, 23);
            this.btnWyjscie.TabIndex = 7;
            this.btnWyjscie.Text = "Wyjście";
            this.btnWyjscie.UseVisualStyleBackColor = true;
            this.btnWyjscie.Click += new System.EventHandler(this.btnWyjscie_Click);
            // 
            // radLb
            // 
            this.radLb.AutoSize = true;
            this.radLb.Location = new System.Drawing.Point(171, 121);
            this.radLb.Name = "radLb";
            this.radLb.Size = new System.Drawing.Size(77, 17);
            this.radLb.TabIndex = 4;
            this.radLb.TabStop = true;
            this.radLb.Text = "Funty (Lbs)";
            this.radLb.UseVisualStyleBackColor = true;
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResult.ForeColor = System.Drawing.SystemColors.Control;
            this.btnResult.Location = new System.Drawing.Point(53, 283);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(237, 86);
            this.btnResult.TabIndex = 5;
            this.btnResult.Text = "Oblicz BMI";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 46);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(83, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kalkulator BMI";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(182, 70);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(152, 56);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // kolorWyniku
            // 
            this.kolorWyniku.Location = new System.Drawing.Point(376, 363);
            this.kolorWyniku.Name = "kolorWyniku";
            this.kolorWyniku.Size = new System.Drawing.Size(259, 50);
            this.kolorWyniku.TabIndex = 13;
            this.kolorWyniku.Paint += new System.Windows.Forms.PaintEventHandler(this.kolorWyniku_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Twój Kolor";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "img1.png");
            this.imageList1.Images.SetKeyName(1, "img2.png");
            this.imageList1.Images.SetKeyName(2, "img3.png");
            this.imageList1.Images.SetKeyName(3, "img4.png");
            this.imageList1.Images.SetKeyName(4, "img5.png");
            this.imageList1.Images.SetKeyName(5, "pyt.png");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(395, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "TWOJA SYLWETKA";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(379, 63);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(669, 465);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kolorWyniku);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.radLb);
            this.Controls.Add(this.btnWyjscie);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.radKg);
            this.Controls.Add(this.txtWynik);
            this.Controls.Add(this.txtWaga);
            this.Controls.Add(this.txtWzrost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWzrost;
        private System.Windows.Forms.TextBox txtWaga;
        private System.Windows.Forms.TextBox txtWynik;
        private System.Windows.Forms.RadioButton radKg;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnWyjscie;
        private System.Windows.Forms.RadioButton radLb;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel kolorWyniku;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
    }
}

