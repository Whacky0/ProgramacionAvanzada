namespace Tp_Programacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.play = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.playerPuntaje = new System.Windows.Forms.Label();
            this.Player2Puntaje = new System.Windows.Forms.Label();
            this.playPlayer2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.Location = new System.Drawing.Point(691, 402);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(97, 36);
            this.play.TabIndex = 4;
            this.play.Text = "Play Player 1";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.deal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(691, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "cartasRestantes";
            // 
            // playerPuntaje
            // 
            this.playerPuntaje.AutoSize = true;
            this.playerPuntaje.Location = new System.Drawing.Point(12, 384);
            this.playerPuntaje.Name = "playerPuntaje";
            this.playerPuntaje.Size = new System.Drawing.Size(36, 13);
            this.playerPuntaje.TabIndex = 6;
            this.playerPuntaje.Text = "Player";
            // 
            // Player2Puntaje
            // 
            this.Player2Puntaje.AutoSize = true;
            this.Player2Puntaje.Location = new System.Drawing.Point(370, 384);
            this.Player2Puntaje.Name = "Player2Puntaje";
            this.Player2Puntaje.Size = new System.Drawing.Size(42, 13);
            this.Player2Puntaje.TabIndex = 7;
            this.Player2Puntaje.Text = "Player2";
            // 
            // playPlayer2
            // 
            this.playPlayer2.Location = new System.Drawing.Point(691, 342);
            this.playPlayer2.Name = "playPlayer2";
            this.playPlayer2.Size = new System.Drawing.Size(97, 36);
            this.playPlayer2.TabIndex = 8;
            this.playPlayer2.Text = "Play Player 2";
            this.playPlayer2.UseVisualStyleBackColor = true;
            this.playPlayer2.Click += new System.EventHandler(this.playPlayer2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playPlayer2);
            this.Controls.Add(this.Player2Puntaje);
            this.Controls.Add(this.playerPuntaje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.play);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label playerPuntaje;
        private System.Windows.Forms.Label Player2Puntaje;
        private System.Windows.Forms.Button playPlayer2;
    }
}

