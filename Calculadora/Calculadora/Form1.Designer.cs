
namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btSete = new System.Windows.Forms.Button();
            this.btOito = new System.Windows.Forms.Button();
            this.btNove = new System.Windows.Forms.Button();
            this.btQuatro = new System.Windows.Forms.Button();
            this.btCinco = new System.Windows.Forms.Button();
            this.btSeis = new System.Windows.Forms.Button();
            this.btUm = new System.Windows.Forms.Button();
            this.btDois = new System.Windows.Forms.Button();
            this.btTres = new System.Windows.Forms.Button();
            this.btSoma = new System.Windows.Forms.Button();
            this.btResultado = new System.Windows.Forms.Button();
            this.btSubtrai = new System.Windows.Forms.Button();
            this.btDivide = new System.Windows.Forms.Button();
            this.btMultiplica = new System.Windows.Forms.Button();
            this.btZero = new System.Windows.Forms.Button();
            this.btPonto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbResultado
            // 
            this.tbResultado.Enabled = false;
            this.tbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResultado.Location = new System.Drawing.Point(13, 12);
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.Size = new System.Drawing.Size(337, 38);
            this.tbResultado.TabIndex = 0;
            this.tbResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btLimpar
            // 
            this.btLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Location = new System.Drawing.Point(13, 80);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(78, 48);
            this.btLimpar.TabIndex = 1;
            this.btLimpar.Text = "C";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btSete
            // 
            this.btSete.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSete.Location = new System.Drawing.Point(13, 134);
            this.btSete.Name = "btSete";
            this.btSete.Size = new System.Drawing.Size(78, 48);
            this.btSete.TabIndex = 2;
            this.btSete.Text = "7";
            this.btSete.UseVisualStyleBackColor = true;
            this.btSete.Click += new System.EventHandler(this.btSete_Click);
            // 
            // btOito
            // 
            this.btOito.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOito.Location = new System.Drawing.Point(97, 134);
            this.btOito.Name = "btOito";
            this.btOito.Size = new System.Drawing.Size(78, 48);
            this.btOito.TabIndex = 3;
            this.btOito.Text = "8";
            this.btOito.UseVisualStyleBackColor = true;
            this.btOito.Click += new System.EventHandler(this.btOito_Click);
            // 
            // btNove
            // 
            this.btNove.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNove.Location = new System.Drawing.Point(181, 134);
            this.btNove.Name = "btNove";
            this.btNove.Size = new System.Drawing.Size(78, 48);
            this.btNove.TabIndex = 4;
            this.btNove.Text = "9";
            this.btNove.UseVisualStyleBackColor = true;
            this.btNove.Click += new System.EventHandler(this.btNove_Click);
            // 
            // btQuatro
            // 
            this.btQuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuatro.Location = new System.Drawing.Point(13, 188);
            this.btQuatro.Name = "btQuatro";
            this.btQuatro.Size = new System.Drawing.Size(78, 48);
            this.btQuatro.TabIndex = 5;
            this.btQuatro.Text = "4";
            this.btQuatro.UseVisualStyleBackColor = true;
            this.btQuatro.Click += new System.EventHandler(this.btQuatro_Click);
            // 
            // btCinco
            // 
            this.btCinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCinco.Location = new System.Drawing.Point(97, 188);
            this.btCinco.Name = "btCinco";
            this.btCinco.Size = new System.Drawing.Size(78, 48);
            this.btCinco.TabIndex = 6;
            this.btCinco.Text = "5";
            this.btCinco.UseVisualStyleBackColor = true;
            this.btCinco.Click += new System.EventHandler(this.btCinco_Click);
            // 
            // btSeis
            // 
            this.btSeis.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSeis.Location = new System.Drawing.Point(181, 188);
            this.btSeis.Name = "btSeis";
            this.btSeis.Size = new System.Drawing.Size(78, 48);
            this.btSeis.TabIndex = 7;
            this.btSeis.Text = "6";
            this.btSeis.UseVisualStyleBackColor = true;
            this.btSeis.Click += new System.EventHandler(this.btSeis_Click);
            // 
            // btUm
            // 
            this.btUm.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUm.Location = new System.Drawing.Point(13, 242);
            this.btUm.Name = "btUm";
            this.btUm.Size = new System.Drawing.Size(78, 48);
            this.btUm.TabIndex = 8;
            this.btUm.Text = "1";
            this.btUm.UseVisualStyleBackColor = true;
            this.btUm.Click += new System.EventHandler(this.btUm_Click);
            // 
            // btDois
            // 
            this.btDois.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDois.Location = new System.Drawing.Point(97, 242);
            this.btDois.Name = "btDois";
            this.btDois.Size = new System.Drawing.Size(78, 48);
            this.btDois.TabIndex = 9;
            this.btDois.Text = "2";
            this.btDois.UseVisualStyleBackColor = true;
            this.btDois.Click += new System.EventHandler(this.btDois_Click);
            // 
            // btTres
            // 
            this.btTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTres.Location = new System.Drawing.Point(181, 242);
            this.btTres.Name = "btTres";
            this.btTres.Size = new System.Drawing.Size(78, 48);
            this.btTres.TabIndex = 10;
            this.btTres.Text = "3";
            this.btTres.UseVisualStyleBackColor = true;
            this.btTres.Click += new System.EventHandler(this.btTres_Click);
            // 
            // btSoma
            // 
            this.btSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSoma.Location = new System.Drawing.Point(271, 188);
            this.btSoma.Name = "btSoma";
            this.btSoma.Size = new System.Drawing.Size(78, 48);
            this.btSoma.TabIndex = 11;
            this.btSoma.Text = "+";
            this.btSoma.UseVisualStyleBackColor = true;
            this.btSoma.Click += new System.EventHandler(this.btSoma_Click);
            // 
            // btResultado
            // 
            this.btResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResultado.Location = new System.Drawing.Point(271, 251);
            this.btResultado.Name = "btResultado";
            this.btResultado.Size = new System.Drawing.Size(78, 102);
            this.btResultado.TabIndex = 12;
            this.btResultado.Text = "=";
            this.btResultado.UseVisualStyleBackColor = true;
            this.btResultado.Click += new System.EventHandler(this.btResultado_Click);
            // 
            // btSubtrai
            // 
            this.btSubtrai.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSubtrai.Location = new System.Drawing.Point(271, 134);
            this.btSubtrai.Name = "btSubtrai";
            this.btSubtrai.Size = new System.Drawing.Size(78, 48);
            this.btSubtrai.TabIndex = 13;
            this.btSubtrai.Text = "-";
            this.btSubtrai.UseVisualStyleBackColor = true;
            this.btSubtrai.Click += new System.EventHandler(this.btSubtrai_Click);
            // 
            // btDivide
            // 
            this.btDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDivide.Location = new System.Drawing.Point(271, 80);
            this.btDivide.Name = "btDivide";
            this.btDivide.Size = new System.Drawing.Size(78, 48);
            this.btDivide.TabIndex = 14;
            this.btDivide.Text = "÷";
            this.btDivide.UseVisualStyleBackColor = true;
            this.btDivide.Click += new System.EventHandler(this.btDivide_Click);
            // 
            // btMultiplica
            // 
            this.btMultiplica.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMultiplica.Location = new System.Drawing.Point(181, 80);
            this.btMultiplica.Name = "btMultiplica";
            this.btMultiplica.Size = new System.Drawing.Size(78, 48);
            this.btMultiplica.TabIndex = 15;
            this.btMultiplica.Text = "X";
            this.btMultiplica.UseVisualStyleBackColor = true;
            this.btMultiplica.Click += new System.EventHandler(this.btMultiplica_Click);
            // 
            // btZero
            // 
            this.btZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btZero.Location = new System.Drawing.Point(13, 296);
            this.btZero.Name = "btZero";
            this.btZero.Size = new System.Drawing.Size(163, 57);
            this.btZero.TabIndex = 16;
            this.btZero.Text = "0";
            this.btZero.UseVisualStyleBackColor = true;
            this.btZero.Click += new System.EventHandler(this.btZero_Click);
            // 
            // btPonto
            // 
            this.btPonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPonto.Location = new System.Drawing.Point(182, 300);
            this.btPonto.Name = "btPonto";
            this.btPonto.Size = new System.Drawing.Size(78, 48);
            this.btPonto.TabIndex = 17;
            this.btPonto.Text = ".";
            this.btPonto.UseVisualStyleBackColor = true;
            this.btPonto.Click += new System.EventHandler(this.btPonto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 378);
            this.Controls.Add(this.btPonto);
            this.Controls.Add(this.btZero);
            this.Controls.Add(this.btMultiplica);
            this.Controls.Add(this.btDivide);
            this.Controls.Add(this.btSubtrai);
            this.Controls.Add(this.btResultado);
            this.Controls.Add(this.btSoma);
            this.Controls.Add(this.btTres);
            this.Controls.Add(this.btDois);
            this.Controls.Add(this.btUm);
            this.Controls.Add(this.btSeis);
            this.Controls.Add(this.btCinco);
            this.Controls.Add(this.btQuatro);
            this.Controls.Add(this.btNove);
            this.Controls.Add(this.btOito);
            this.Controls.Add(this.btSete);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.tbResultado);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbResultado;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btSete;
        private System.Windows.Forms.Button btOito;
        private System.Windows.Forms.Button btNove;
        private System.Windows.Forms.Button btQuatro;
        private System.Windows.Forms.Button btCinco;
        private System.Windows.Forms.Button btSeis;
        private System.Windows.Forms.Button btUm;
        private System.Windows.Forms.Button btDois;
        private System.Windows.Forms.Button btTres;
        private System.Windows.Forms.Button btSoma;
        private System.Windows.Forms.Button btResultado;
        private System.Windows.Forms.Button btSubtrai;
        private System.Windows.Forms.Button btDivide;
        private System.Windows.Forms.Button btMultiplica;
        private System.Windows.Forms.Button btZero;
        private System.Windows.Forms.Button btPonto;
    }
}

