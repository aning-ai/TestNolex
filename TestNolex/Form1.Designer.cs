
namespace TestNolex
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
            this.lstAmbul = new System.Windows.Forms.ListBox();
            this.lstPartiCorpo = new System.Windows.Forms.ListBox();
            this.lstEsami = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CodMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodInt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrizione = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ambulatorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParteCorpo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elimina = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSelEsame = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textCerca = new System.Windows.Forms.TextBox();
            this.btnCerca = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstAmbul
            // 
            this.lstAmbul.FormattingEnabled = true;
            this.lstAmbul.Location = new System.Drawing.Point(12, 27);
            this.lstAmbul.Name = "lstAmbul";
            this.lstAmbul.Size = new System.Drawing.Size(189, 173);
            this.lstAmbul.TabIndex = 0;
            this.lstAmbul.SelectedIndexChanged += new System.EventHandler(this.lstAmbul_SelectedIndexChanged);
            // 
            // lstPartiCorpo
            // 
            this.lstPartiCorpo.FormattingEnabled = true;
            this.lstPartiCorpo.Location = new System.Drawing.Point(227, 27);
            this.lstPartiCorpo.Name = "lstPartiCorpo";
            this.lstPartiCorpo.Size = new System.Drawing.Size(189, 173);
            this.lstPartiCorpo.TabIndex = 1;
            this.lstPartiCorpo.SelectedIndexChanged += new System.EventHandler(this.lstPartiCorpo_SelectedIndexChanged);
            // 
            // lstEsami
            // 
            this.lstEsami.FormattingEnabled = true;
            this.lstEsami.Location = new System.Drawing.Point(438, 27);
            this.lstEsami.Name = "lstEsami";
            this.lstEsami.Size = new System.Drawing.Size(189, 173);
            this.lstEsami.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodMin,
            this.CodInt,
            this.Descrizione,
            this.Ambulatorio,
            this.ParteCorpo,
            this.elimina});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 132);
            this.dataGridView1.TabIndex = 9;
            // 
            // CodMin
            // 
            this.CodMin.HeaderText = "Codice ministeriale";
            this.CodMin.Name = "CodMin";
            // 
            // CodInt
            // 
            this.CodInt.HeaderText = "Codice Interno";
            this.CodInt.Name = "CodInt";
            // 
            // Descrizione
            // 
            this.Descrizione.HeaderText = "Descrizione esame";
            this.Descrizione.Name = "Descrizione";
            // 
            // Ambulatorio
            // 
            this.Ambulatorio.HeaderText = "Ambulatorio";
            this.Ambulatorio.Name = "Ambulatorio";
            // 
            // ParteCorpo
            // 
            this.ParteCorpo.HeaderText = "Parte del corpo";
            this.ParteCorpo.Name = "ParteCorpo";
            // 
            // elimina
            // 
            this.elimina.HeaderText = "";
            this.elimina.Name = "elimina";
            this.elimina.Text = "Elimina";
            this.elimina.ToolTipText = "Elimina l\'esame dalla lista";
            this.elimina.UseColumnTextForButtonValue = true;
            // 
            // btnSelEsame
            // 
            this.btnSelEsame.Location = new System.Drawing.Point(438, 210);
            this.btnSelEsame.Name = "btnSelEsame";
            this.btnSelEsame.Size = new System.Drawing.Size(189, 22);
            this.btnSelEsame.TabIndex = 10;
            this.btnSelEsame.Text = "Seleziona esame";
            this.btnSelEsame.UseVisualStyleBackColor = true;
            this.btnSelEsame.Click += new System.EventHandler(this.btnSelEsame_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ambulatori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Parti del corpo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Esami";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textCerca);
            this.groupBox1.Controls.Add(this.btnCerca);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(647, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 171);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ricerca esame per:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 22);
            this.button1.TabIndex = 15;
            this.button1.Text = "Tutto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textCerca
            // 
            this.textCerca.Location = new System.Drawing.Point(0, 95);
            this.textCerca.Name = "textCerca";
            this.textCerca.Size = new System.Drawing.Size(131, 20);
            this.textCerca.TabIndex = 14;
            // 
            // btnCerca
            // 
            this.btnCerca.Location = new System.Drawing.Point(0, 121);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(132, 22);
            this.btnCerca.TabIndex = 13;
            this.btnCerca.Text = "Cerca";
            this.btnCerca.UseVisualStyleBackColor = true;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(4, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(112, 17);
            this.radioButton3.TabIndex = 12;
            this.radioButton3.Text = "descrizione esame";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(4, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(92, 17);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.Text = "codice interno";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(4, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(111, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "codice ministeriale";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelEsame);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lstEsami);
            this.Controls.Add(this.lstPartiCorpo);
            this.Controls.Add(this.lstAmbul);
            this.Name = "Form1";
            this.Text = "Test Nolex";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAmbul;
        private System.Windows.Forms.ListBox lstPartiCorpo;
        private System.Windows.Forms.ListBox lstEsami;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSelEsame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textCerca;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodInt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrizione;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ambulatorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParteCorpo;
        private System.Windows.Forms.DataGridViewButtonColumn elimina;
    }
}

