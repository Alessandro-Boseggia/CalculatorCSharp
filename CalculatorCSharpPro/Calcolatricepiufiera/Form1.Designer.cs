namespace Calcolatricepiufiera
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.due = new System.Windows.Forms.Button();
            this.ris = new System.Windows.Forms.Label();
            this.uno = new System.Windows.Forms.Button();
            this.piu = new System.Windows.Forms.Button();
            this.uguale = new System.Windows.Forms.Button();
            this.diviso = new System.Windows.Forms.Button();
            this.per = new System.Windows.Forms.Button();
            this.meno = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.nove = new System.Windows.Forms.Button();
            this.otto = new System.Windows.Forms.Button();
            this.sette = new System.Windows.Forms.Button();
            this.sei = new System.Windows.Forms.Button();
            this.cinque = new System.Windows.Forms.Button();
            this.tre = new System.Windows.Forms.Button();
            this.quattro = new System.Windows.Forms.Button();
            this.canc = new System.Windows.Forms.Button();
            this.virgola = new System.Windows.Forms.Button();
            this.pa = new System.Windows.Forms.Button();
            this.pc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // due
            // 
            this.due.Location = new System.Drawing.Point(183, 146);
            this.due.Name = "due";
            this.due.Size = new System.Drawing.Size(75, 23);
            this.due.TabIndex = 0;
            this.due.Text = "2";
            this.due.UseVisualStyleBackColor = true;
            this.due.Click += new System.EventHandler(this.due_Click);
            // 
            // ris
            // 
            this.ris.AutoSize = true;
            this.ris.Location = new System.Drawing.Point(12, 32);
            this.ris.Name = "ris";
            this.ris.Size = new System.Drawing.Size(13, 13);
            this.ris.TabIndex = 1;
            this.ris.Text = "0";
            // 
            // uno
            // 
            this.uno.Location = new System.Drawing.Point(102, 146);
            this.uno.Name = "uno";
            this.uno.Size = new System.Drawing.Size(75, 23);
            this.uno.TabIndex = 2;
            this.uno.Text = "1";
            this.uno.UseVisualStyleBackColor = true;
            this.uno.Click += new System.EventHandler(this.uno_Click);
            // 
            // piu
            // 
            this.piu.Location = new System.Drawing.Point(12, 146);
            this.piu.Name = "piu";
            this.piu.Size = new System.Drawing.Size(75, 23);
            this.piu.TabIndex = 3;
            this.piu.Text = "+";
            this.piu.UseVisualStyleBackColor = true;
            this.piu.Click += new System.EventHandler(this.piu_Click);
            // 
            // uguale
            // 
            this.uguale.Location = new System.Drawing.Point(13, 175);
            this.uguale.Name = "uguale";
            this.uguale.Size = new System.Drawing.Size(75, 23);
            this.uguale.TabIndex = 4;
            this.uguale.Text = "=";
            this.uguale.UseVisualStyleBackColor = true;
            this.uguale.Click += new System.EventHandler(this.uguale_Click);
            // 
            // diviso
            // 
            this.diviso.Location = new System.Drawing.Point(12, 59);
            this.diviso.Name = "diviso";
            this.diviso.Size = new System.Drawing.Size(75, 23);
            this.diviso.TabIndex = 5;
            this.diviso.Text = "/";
            this.diviso.UseVisualStyleBackColor = true;
            this.diviso.Click += new System.EventHandler(this.diviso_Click);
            // 
            // per
            // 
            this.per.Location = new System.Drawing.Point(12, 88);
            this.per.Name = "per";
            this.per.Size = new System.Drawing.Size(75, 23);
            this.per.TabIndex = 7;
            this.per.Text = "*";
            this.per.UseVisualStyleBackColor = true;
            this.per.Click += new System.EventHandler(this.per_Click);
            // 
            // meno
            // 
            this.meno.Location = new System.Drawing.Point(13, 117);
            this.meno.Name = "meno";
            this.meno.Size = new System.Drawing.Size(75, 23);
            this.meno.TabIndex = 8;
            this.meno.Text = "-";
            this.meno.UseVisualStyleBackColor = true;
            this.meno.Click += new System.EventHandler(this.meno_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(183, 175);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(75, 23);
            this.zero.TabIndex = 9;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // nove
            // 
            this.nove.Location = new System.Drawing.Point(264, 88);
            this.nove.Name = "nove";
            this.nove.Size = new System.Drawing.Size(75, 23);
            this.nove.TabIndex = 10;
            this.nove.Text = "9";
            this.nove.UseVisualStyleBackColor = true;
            this.nove.Click += new System.EventHandler(this.nove_Click);
            // 
            // otto
            // 
            this.otto.Location = new System.Drawing.Point(183, 88);
            this.otto.Name = "otto";
            this.otto.Size = new System.Drawing.Size(75, 23);
            this.otto.TabIndex = 11;
            this.otto.Text = "8";
            this.otto.UseVisualStyleBackColor = true;
            this.otto.Click += new System.EventHandler(this.otto_Click);
            // 
            // sette
            // 
            this.sette.Location = new System.Drawing.Point(102, 88);
            this.sette.Name = "sette";
            this.sette.Size = new System.Drawing.Size(75, 23);
            this.sette.TabIndex = 12;
            this.sette.Text = "7";
            this.sette.UseVisualStyleBackColor = true;
            this.sette.Click += new System.EventHandler(this.sette_Click);
            // 
            // sei
            // 
            this.sei.Location = new System.Drawing.Point(264, 117);
            this.sei.Name = "sei";
            this.sei.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sei.Size = new System.Drawing.Size(75, 23);
            this.sei.TabIndex = 13;
            this.sei.Text = "6";
            this.sei.UseVisualStyleBackColor = true;
            this.sei.Click += new System.EventHandler(this.sei_Click);
            // 
            // cinque
            // 
            this.cinque.Location = new System.Drawing.Point(183, 117);
            this.cinque.Name = "cinque";
            this.cinque.Size = new System.Drawing.Size(75, 23);
            this.cinque.TabIndex = 14;
            this.cinque.Text = "5";
            this.cinque.UseVisualStyleBackColor = true;
            this.cinque.Click += new System.EventHandler(this.cinque_Click);
            // 
            // tre
            // 
            this.tre.Location = new System.Drawing.Point(264, 146);
            this.tre.Name = "tre";
            this.tre.Size = new System.Drawing.Size(75, 23);
            this.tre.TabIndex = 15;
            this.tre.Text = "3";
            this.tre.UseVisualStyleBackColor = true;
            this.tre.Click += new System.EventHandler(this.tre_Click);
            // 
            // quattro
            // 
            this.quattro.Location = new System.Drawing.Point(102, 117);
            this.quattro.Name = "quattro";
            this.quattro.Size = new System.Drawing.Size(75, 23);
            this.quattro.TabIndex = 16;
            this.quattro.Text = "4";
            this.quattro.UseVisualStyleBackColor = true;
            this.quattro.Click += new System.EventHandler(this.quattro_Click);
            // 
            // canc
            // 
            this.canc.Location = new System.Drawing.Point(102, 59);
            this.canc.Name = "canc";
            this.canc.Size = new System.Drawing.Size(75, 23);
            this.canc.TabIndex = 17;
            this.canc.Text = "canc";
            this.canc.UseVisualStyleBackColor = true;
            this.canc.Click += new System.EventHandler(this.canc_Click);
            // 
            // virgola
            // 
            this.virgola.Location = new System.Drawing.Point(102, 175);
            this.virgola.Name = "virgola";
            this.virgola.Size = new System.Drawing.Size(75, 23);
            this.virgola.TabIndex = 18;
            this.virgola.Text = ",";
            this.virgola.UseVisualStyleBackColor = true;
            this.virgola.Click += new System.EventHandler(this.virgola_Click);
            // 
            // pa
            // 
            this.pa.Location = new System.Drawing.Point(183, 59);
            this.pa.Name = "pa";
            this.pa.Size = new System.Drawing.Size(75, 23);
            this.pa.TabIndex = 19;
            this.pa.Text = "(";
            this.pa.UseVisualStyleBackColor = true;
            this.pa.Click += new System.EventHandler(this.pa_Click);
            // 
            // pc
            // 
            this.pc.Location = new System.Drawing.Point(264, 59);
            this.pc.Name = "pc";
            this.pc.Size = new System.Drawing.Size(75, 23);
            this.pc.TabIndex = 20;
            this.pc.Text = ")";
            this.pc.UseVisualStyleBackColor = true;
            this.pc.Click += new System.EventHandler(this.pc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pc);
            this.Controls.Add(this.pa);
            this.Controls.Add(this.virgola);
            this.Controls.Add(this.canc);
            this.Controls.Add(this.quattro);
            this.Controls.Add(this.tre);
            this.Controls.Add(this.cinque);
            this.Controls.Add(this.sei);
            this.Controls.Add(this.sette);
            this.Controls.Add(this.otto);
            this.Controls.Add(this.nove);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.meno);
            this.Controls.Add(this.per);
            this.Controls.Add(this.diviso);
            this.Controls.Add(this.uguale);
            this.Controls.Add(this.piu);
            this.Controls.Add(this.uno);
            this.Controls.Add(this.ris);
            this.Controls.Add(this.due);
            this.Name = "Form1";
            this.Text = "Calcolatrice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button due;
        private System.Windows.Forms.Label ris;
        private System.Windows.Forms.Button uno;
        private System.Windows.Forms.Button piu;
        private System.Windows.Forms.Button uguale;
        private System.Windows.Forms.Button diviso;
        private System.Windows.Forms.Button per;
        private System.Windows.Forms.Button meno;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button nove;
        private System.Windows.Forms.Button otto;
        private System.Windows.Forms.Button sette;
        private System.Windows.Forms.Button sei;
        private System.Windows.Forms.Button cinque;
        private System.Windows.Forms.Button tre;
        private System.Windows.Forms.Button quattro;
        private System.Windows.Forms.Button canc;
        private System.Windows.Forms.Button virgola;
        private System.Windows.Forms.Button pa;
        private System.Windows.Forms.Button pc;
    }
}

//QDRAb6BQDLTeZZq1oiP79s98