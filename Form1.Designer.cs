namespace plannning_ligue
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.JourFin = new System.Windows.Forms.DateTimePicker();
            this.JourDebut = new System.Windows.Forms.DateTimePicker();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Type = new System.Windows.Forms.ComboBox();
            this.ChoixJour = new System.Windows.Forms.ComboBox();
            this.Description = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.HeureD = new System.Windows.Forms.ComboBox();
            this.MinuteD = new System.Windows.Forms.ComboBox();
            this.HeureF = new System.Windows.Forms.ComboBox();
            this.MinuteF = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Application Calendrier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choisir jour";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jour début";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jour Fin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Heure fin des séances";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Heure début des séance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Description";
            // 
            // JourFin
            // 
            this.JourFin.Location = new System.Drawing.Point(181, 226);
            this.JourFin.Name = "JourFin";
            this.JourFin.Size = new System.Drawing.Size(188, 20);
            this.JourFin.TabIndex = 8;
            // 
            // JourDebut
            // 
            this.JourDebut.Location = new System.Drawing.Point(181, 174);
            this.JourDebut.Name = "JourDebut";
            this.JourDebut.Size = new System.Drawing.Size(188, 20);
            this.JourDebut.TabIndex = 9;
            // 
            // Type
            // 
            this.Type.FormattingEnabled = true;
            this.Type.Location = new System.Drawing.Point(181, 364);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(188, 21);
            this.Type.TabIndex = 12;
            // 
            // ChoixJour
            // 
            this.ChoixJour.FormattingEnabled = true;
            this.ChoixJour.Location = new System.Drawing.Point(181, 124);
            this.ChoixJour.Name = "ChoixJour";
            this.ChoixJour.Size = new System.Drawing.Size(188, 21);
            this.ChoixJour.TabIndex = 13;
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(181, 407);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(188, 20);
            this.Description.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // HeureD
            // 
            this.HeureD.FormattingEnabled = true;
            this.HeureD.Location = new System.Drawing.Point(181, 274);
            this.HeureD.Name = "HeureD";
            this.HeureD.Size = new System.Drawing.Size(75, 21);
            this.HeureD.TabIndex = 16;
            // 
            // MinuteD
            // 
            this.MinuteD.FormattingEnabled = true;
            this.MinuteD.Location = new System.Drawing.Point(285, 274);
            this.MinuteD.Name = "MinuteD";
            this.MinuteD.Size = new System.Drawing.Size(84, 21);
            this.MinuteD.TabIndex = 17;
            // 
            // HeureF
            // 
            this.HeureF.FormattingEnabled = true;
            this.HeureF.Location = new System.Drawing.Point(181, 314);
            this.HeureF.Name = "HeureF";
            this.HeureF.Size = new System.Drawing.Size(75, 21);
            this.HeureF.TabIndex = 18;
            // 
            // MinuteF
            // 
            this.MinuteF.FormattingEnabled = true;
            this.MinuteF.Location = new System.Drawing.Point(285, 314);
            this.MinuteF.Name = "MinuteF";
            this.MinuteF.Size = new System.Drawing.Size(84, 21);
            this.MinuteF.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 481);
            this.Controls.Add(this.MinuteF);
            this.Controls.Add(this.HeureF);
            this.Controls.Add(this.MinuteD);
            this.Controls.Add(this.HeureD);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.ChoixJour);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.JourDebut);
            this.Controls.Add(this.JourFin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker JourFin;
        private System.Windows.Forms.DateTimePicker JourDebut;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.ComboBox ChoixJour;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox HeureD;
        private System.Windows.Forms.ComboBox MinuteD;
        private System.Windows.Forms.ComboBox HeureF;
        private System.Windows.Forms.ComboBox MinuteF;
    }
}

