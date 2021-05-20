
namespace Yoda_Regressive
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rotulo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rotuloMinutos = new System.Windows.Forms.Label();
            this.rotuloHoras = new System.Windows.Forms.Label();
            this.rotuloDias = new System.Windows.Forms.Label();
            this.rotuloReserva = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rotulo
            // 
            this.rotulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rotulo.BackColor = System.Drawing.Color.Transparent;
            this.rotulo.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rotulo.Location = new System.Drawing.Point(98, 316);
            this.rotulo.Name = "rotulo";
            this.rotulo.Size = new System.Drawing.Size(80, 61);
            this.rotulo.TabIndex = 0;
            this.rotulo.Text = "00";
            this.rotulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
            // 
            // rotuloMinutos
            // 
            this.rotuloMinutos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rotuloMinutos.BackColor = System.Drawing.Color.Transparent;
            this.rotuloMinutos.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rotuloMinutos.Location = new System.Drawing.Point(14, 259);
            this.rotuloMinutos.Name = "rotuloMinutos";
            this.rotuloMinutos.Size = new System.Drawing.Size(80, 61);
            this.rotuloMinutos.TabIndex = 2;
            this.rotuloMinutos.Text = "00";
            this.rotuloMinutos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rotuloHoras
            // 
            this.rotuloHoras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rotuloHoras.BackColor = System.Drawing.Color.Transparent;
            this.rotuloHoras.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rotuloHoras.Location = new System.Drawing.Point(85, 162);
            this.rotuloHoras.Name = "rotuloHoras";
            this.rotuloHoras.Size = new System.Drawing.Size(77, 61);
            this.rotuloHoras.TabIndex = 4;
            this.rotuloHoras.Text = "00";
            this.rotuloHoras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rotuloDias
            // 
            this.rotuloDias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rotuloDias.BackColor = System.Drawing.Color.Transparent;
            this.rotuloDias.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rotuloDias.Location = new System.Drawing.Point(14, 13);
            this.rotuloDias.Name = "rotuloDias";
            this.rotuloDias.Size = new System.Drawing.Size(127, 110);
            this.rotuloDias.TabIndex = 5;
            this.rotuloDias.Text = "00";
            this.rotuloDias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rotuloReserva
            // 
            this.rotuloReserva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rotuloReserva.BackColor = System.Drawing.Color.Transparent;
            this.rotuloReserva.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rotuloReserva.ForeColor = System.Drawing.Color.Maroon;
            this.rotuloReserva.Location = new System.Drawing.Point(257, 23);
            this.rotuloReserva.Name = "rotuloReserva";
            this.rotuloReserva.Size = new System.Drawing.Size(207, 74);
            this.rotuloReserva.TabIndex = 7;
            this.rotuloReserva.Text = "Reserva pouco falta!!";
            this.rotuloReserva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(500, 397);
            this.Controls.Add(this.rotuloReserva);
            this.Controls.Add(this.rotulo);
            this.Controls.Add(this.rotuloMinutos);
            this.Controls.Add(this.rotuloHoras);
            this.Controls.Add(this.rotuloDias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yoda Regressive";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label rotulo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label rotuloMinutos;
        private System.Windows.Forms.Label rotuloHoras;
        private System.Windows.Forms.Label rotuloDias;
        private System.Windows.Forms.Label rotuloReserva;
    }
}

