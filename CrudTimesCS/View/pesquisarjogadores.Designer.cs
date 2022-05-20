
namespace CrudTimesCS.View
{
    partial class pesquisarjogadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pesquisarjogadores));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonbusj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxcodresj = new System.Windows.Forms.TextBox();
            this.textBoxfoneresj = new System.Windows.Forms.TextBox();
            this.textBoxemailresj = new System.Windows.Forms.TextBox();
            this.textBoxnomeresj = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxpesj = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(324, 304);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.buttonbusj);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.textBoxpesj);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(316, 276);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pesquisar por Código";
            // 
            // buttonbusj
            // 
            this.buttonbusj.Location = new System.Drawing.Point(195, 10);
            this.buttonbusj.Name = "buttonbusj";
            this.buttonbusj.Size = new System.Drawing.Size(90, 37);
            this.buttonbusj.TabIndex = 6;
            this.buttonbusj.Text = "Buscar";
            this.buttonbusj.UseVisualStyleBackColor = true;
            this.buttonbusj.Click += new System.EventHandler(this.buttonbusj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o  Código :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.textBoxcodresj);
            this.groupBox1.Controls.Add(this.textBoxfoneresj);
            this.groupBox1.Controls.Add(this.textBoxemailresj);
            this.groupBox1.Controls.Add(this.textBoxnomeresj);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(-4, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            // 
            // textBoxcodresj
            // 
            this.textBoxcodresj.Location = new System.Drawing.Point(54, 188);
            this.textBoxcodresj.Name = "textBoxcodresj";
            this.textBoxcodresj.Size = new System.Drawing.Size(36, 23);
            this.textBoxcodresj.TabIndex = 9;
            // 
            // textBoxfoneresj
            // 
            this.textBoxfoneresj.Location = new System.Drawing.Point(6, 149);
            this.textBoxfoneresj.Name = "textBoxfoneresj";
            this.textBoxfoneresj.Size = new System.Drawing.Size(136, 23);
            this.textBoxfoneresj.TabIndex = 8;
            // 
            // textBoxemailresj
            // 
            this.textBoxemailresj.Location = new System.Drawing.Point(6, 95);
            this.textBoxemailresj.Name = "textBoxemailresj";
            this.textBoxemailresj.Size = new System.Drawing.Size(174, 23);
            this.textBoxemailresj.TabIndex = 7;
            // 
            // textBoxnomeresj
            // 
            this.textBoxnomeresj.Location = new System.Drawing.Point(6, 45);
            this.textBoxnomeresj.Name = "textBoxnomeresj";
            this.textBoxnomeresj.Size = new System.Drawing.Size(170, 23);
            this.textBoxnomeresj.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Código :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fone :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome :";
            // 
            // textBoxpesj
            // 
            this.textBoxpesj.Location = new System.Drawing.Point(105, 18);
            this.textBoxpesj.Name = "textBoxpesj";
            this.textBoxpesj.Size = new System.Drawing.Size(33, 23);
            this.textBoxpesj.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(316, 276);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquisar por Nome";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // pesquisarjogadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(348, 328);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pesquisarjogadores";
            this.Text = "sistema gerenciador de jogadores";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxcodresj;
        private System.Windows.Forms.TextBox textBoxfoneresj;
        private System.Windows.Forms.TextBox textBoxemailresj;
        private System.Windows.Forms.TextBox textBoxnomeresj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxpesj;
        private System.Windows.Forms.Button buttonbusj;
    }
}