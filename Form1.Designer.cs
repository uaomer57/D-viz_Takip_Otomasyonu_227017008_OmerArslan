namespace Döviz_Takip_Otomasyonu_227017008_ÖmerArslan
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Timer timer1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblusd = new System.Windows.Forms.Label();
            this.lblgbp = new System.Windows.Forms.Label();
            this.lbleur = new System.Windows.Forms.Label();
            this.lblalıs = new System.Windows.Forms.Label();
            this.lblsatıs = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblusdalıs = new System.Windows.Forms.Label();
            this.lblusdsatıs = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblgbpsatıs = new System.Windows.Forms.Label();
            this.lblgbpalıs = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbleursatıs = new System.Windows.Forms.Label();
            this.lbleuralıs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblusd
            // 
            this.lblusd.AutoSize = true;
            this.lblusd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblusd.Location = new System.Drawing.Point(49, 81);
            this.lblusd.Name = "lblusd";
            this.lblusd.Size = new System.Drawing.Size(57, 24);
            this.lblusd.TabIndex = 0;
            this.lblusd.Text = "USD:";
            this.lblusd.Click += new System.EventHandler(this.USD_Click);
            // 
            // lblgbp
            // 
            this.lblgbp.AutoSize = true;
            this.lblgbp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgbp.Location = new System.Drawing.Point(49, 130);
            this.lblgbp.Name = "lblgbp";
            this.lblgbp.Size = new System.Drawing.Size(57, 24);
            this.lblgbp.TabIndex = 1;
            this.lblgbp.Text = "GBP:";
            // 
            // lbleur
            // 
            this.lbleur.AutoSize = true;
            this.lbleur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbleur.Location = new System.Drawing.Point(48, 176);
            this.lbleur.Name = "lbleur";
            this.lbleur.Size = new System.Drawing.Size(58, 24);
            this.lbleur.TabIndex = 2;
            this.lbleur.Text = "EUR:";
            // 
            // lblalıs
            // 
            this.lblalıs.AutoSize = true;
            this.lblalıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblalıs.Location = new System.Drawing.Point(190, 37);
            this.lblalıs.Name = "lblalıs";
            this.lblalıs.Size = new System.Drawing.Size(101, 24);
            this.lblalıs.TabIndex = 3;
            this.lblalıs.Text = "Döviz Alış";
            // 
            // lblsatıs
            // 
            this.lblsatıs.AutoSize = true;
            this.lblsatıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsatıs.Location = new System.Drawing.Point(367, 37);
            this.lblsatıs.Name = "lblsatıs";
            this.lblsatıs.Size = new System.Drawing.Size(111, 24);
            this.lblsatıs.TabIndex = 4;
            this.lblsatıs.Text = "Döviz Satış";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.lblusdalıs);
            this.panel1.Controls.Add(this.lblusdsatıs);
            this.panel1.Location = new System.Drawing.Point(174, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 35);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblusdalıs
            // 
            this.lblusdalıs.AutoSize = true;
            this.lblusdalıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblusdalıs.Location = new System.Drawing.Point(39, -2);
            this.lblusdalıs.Name = "lblusdalıs";
            this.lblusdalıs.Size = new System.Drawing.Size(44, 37);
            this.lblusdalıs.TabIndex = 8;
            this.lblusdalıs.Text = "...";
            this.lblusdalıs.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblusdsatıs
            // 
            this.lblusdsatıs.AutoSize = true;
            this.lblusdsatıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblusdsatıs.Location = new System.Drawing.Point(200, -2);
            this.lblusdsatıs.Name = "lblusdsatıs";
            this.lblusdsatıs.Size = new System.Drawing.Size(44, 37);
            this.lblusdsatıs.TabIndex = 9;
            this.lblusdsatıs.Text = "...";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.lblgbpsatıs);
            this.panel2.Controls.Add(this.lblgbpalıs);
            this.panel2.Location = new System.Drawing.Point(174, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 38);
            this.panel2.TabIndex = 6;
            // 
            // lblgbpsatıs
            // 
            this.lblgbpsatıs.AutoSize = true;
            this.lblgbpsatıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgbpsatıs.Location = new System.Drawing.Point(200, 1);
            this.lblgbpsatıs.Name = "lblgbpsatıs";
            this.lblgbpsatıs.Size = new System.Drawing.Size(44, 37);
            this.lblgbpsatıs.TabIndex = 10;
            this.lblgbpsatıs.Text = "...";
            // 
            // lblgbpalıs
            // 
            this.lblgbpalıs.AutoSize = true;
            this.lblgbpalıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgbpalıs.Location = new System.Drawing.Point(39, 0);
            this.lblgbpalıs.Name = "lblgbpalıs";
            this.lblgbpalıs.Size = new System.Drawing.Size(44, 37);
            this.lblgbpalıs.TabIndex = 9;
            this.lblgbpalıs.Text = "...";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.lbleursatıs);
            this.panel3.Controls.Add(this.lbleuralıs);
            this.panel3.Location = new System.Drawing.Point(174, 164);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(335, 36);
            this.panel3.TabIndex = 7;
            // 
            // lbleursatıs
            // 
            this.lbleursatıs.AutoSize = true;
            this.lbleursatıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbleursatıs.Location = new System.Drawing.Point(200, 0);
            this.lbleursatıs.Name = "lbleursatıs";
            this.lbleursatıs.Size = new System.Drawing.Size(44, 37);
            this.lbleursatıs.TabIndex = 11;
            this.lbleursatıs.Text = "...";
            // 
            // lbleuralıs
            // 
            this.lbleuralıs.AutoSize = true;
            this.lbleuralıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbleuralıs.Location = new System.Drawing.Point(39, 2);
            this.lbleuralıs.Name = "lbleuralıs";
            this.lbleuralıs.Size = new System.Drawing.Size(44, 37);
            this.lbleuralıs.TabIndex = 10;
            this.lbleuralıs.Text = "...";
            // 
            // timer1
            // 
            timer1.Interval = 1800;
            timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "ㅤㅤㅤㅤㅤㅤ";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(434, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "Yenile";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(572, 350);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblsatıs);
            this.Controls.Add(this.lblalıs);
            this.Controls.Add(this.lbleur);
            this.Controls.Add(this.lblgbp);
            this.Controls.Add(this.lblusd);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ömer Arslan Döviz Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusd;
        private System.Windows.Forms.Label lblgbp;
        private System.Windows.Forms.Label lbleur;
        private System.Windows.Forms.Label lblalıs;
        private System.Windows.Forms.Label lblsatıs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblusdalıs;
        private System.Windows.Forms.Label lblusdsatıs;
        private System.Windows.Forms.Label lblgbpsatıs;
        private System.Windows.Forms.Label lblgbpalıs;
        private System.Windows.Forms.Label lbleursatıs;
        private System.Windows.Forms.Label lbleuralıs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

