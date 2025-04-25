namespace EsercizioFile
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
            IdCasella = new TextBox();
            CognomeCasella = new TextBox();
            NomeCasella = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Aggiungi = new Button();
            listBox1 = new ListBox();
            Cerca = new Button();
            IdDaCercare = new TextBox();
            label4 = new Label();
            Elimina = new Button();
            Modifica = new Button();
            SuspendLayout();
            // 
            // IdCasella
            // 
            IdCasella.Location = new Point(136, 57);
            IdCasella.Name = "IdCasella";
            IdCasella.Size = new Size(125, 27);
            IdCasella.TabIndex = 0;
            // 
            // CognomeCasella
            // 
            CognomeCasella.Location = new Point(349, 57);
            CognomeCasella.Name = "CognomeCasella";
            CognomeCasella.Size = new Size(125, 27);
            CognomeCasella.TabIndex = 1;
            // 
            // NomeCasella
            // 
            NomeCasella.Location = new Point(561, 57);
            NomeCasella.Name = "NomeCasella";
            NomeCasella.Size = new Size(125, 27);
            NomeCasella.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(186, 35);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 3;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(377, 35);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 4;
            label2.Text = "Cognome";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(594, 35);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 5;
            label3.Text = "Nome";
            // 
            // Aggiungi
            // 
            Aggiungi.Location = new Point(86, 357);
            Aggiungi.Name = "Aggiungi";
            Aggiungi.Size = new Size(283, 77);
            Aggiungi.TabIndex = 6;
            Aggiungi.Text = "AGGIUNGI";
            Aggiungi.UseVisualStyleBackColor = true;
            Aggiungi.Click += Aggiungi_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(45, 148);
            listBox1.Margin = new Padding(2, 3, 2, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(338, 164);
            listBox1.TabIndex = 7;
            // 
            // Cerca
            // 
            Cerca.Location = new Point(421, 216);
            Cerca.Name = "Cerca";
            Cerca.Size = new Size(150, 56);
            Cerca.TabIndex = 8;
            Cerca.Text = "CERCA";
            Cerca.UseVisualStyleBackColor = true;
            Cerca.Click += Cerca_Click;
            // 
            // IdDaCercare
            // 
            IdDaCercare.Location = new Point(530, 148);
            IdDaCercare.Name = "IdDaCercare";
            IdDaCercare.Size = new Size(125, 27);
            IdDaCercare.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(576, 125);
            label4.Name = "label4";
            label4.Size = new Size(22, 20);
            label4.TabIndex = 10;
            label4.Text = "Id";
            // 
            // Elimina
            // 
            Elimina.Location = new Point(607, 216);
            Elimina.Name = "Elimina";
            Elimina.Size = new Size(150, 56);
            Elimina.TabIndex = 11;
            Elimina.Text = "ELIMINA";
            Elimina.UseVisualStyleBackColor = true;
            Elimina.Click += Elimina_Click;
            // 
            // Modifica
            // 
            Modifica.Location = new Point(506, 293);
            Modifica.Name = "Modifica";
            Modifica.Size = new Size(150, 56);
            Modifica.TabIndex = 12;
            Modifica.Text = "MODIFICA";
            Modifica.UseVisualStyleBackColor = true;
            Modifica.Click += Modifica_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 449);
            Controls.Add(Modifica);
            Controls.Add(Elimina);
            Controls.Add(label4);
            Controls.Add(IdDaCercare);
            Controls.Add(Cerca);
            Controls.Add(listBox1);
            Controls.Add(Aggiungi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NomeCasella);
            Controls.Add(CognomeCasella);
            Controls.Add(IdCasella);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox IdCasella;
        private TextBox CognomeCasella;
        private TextBox NomeCasella;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button Aggiungi;
        private ListBox listBox1;
        private Button Cerca;
        private TextBox IdDaCercare;
        private Label label4;
        private Button Elimina;
        private Button Modifica;
    }
}
