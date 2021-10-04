
namespace FirstExample_
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombreJug = new System.Windows.Forms.TextBox();
            this.jugPosicion = new System.Windows.Forms.TextBox();
            this.jugPierna = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.MostrarEquipo = new System.Windows.Forms.Button();
            this.MostrarJugadores = new System.Windows.Forms.Button();
            this.AsignarEquipo = new System.Windows.Forms.Button();
            this.eliminarJugador = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(401, 174);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nombreJug
            // 
            this.nombreJug.Location = new System.Drawing.Point(688, 13);
            this.nombreJug.Name = "nombreJug";
            this.nombreJug.Size = new System.Drawing.Size(100, 20);
            this.nombreJug.TabIndex = 1;
            // 
            // jugPosicion
            // 
            this.jugPosicion.Location = new System.Drawing.Point(688, 64);
            this.jugPosicion.Name = "jugPosicion";
            this.jugPosicion.Size = new System.Drawing.Size(100, 20);
            this.jugPosicion.TabIndex = 2;
            // 
            // jugPierna
            // 
            this.jugPierna.Location = new System.Drawing.Point(688, 124);
            this.jugPierna.Name = "jugPierna";
            this.jugPierna.Size = new System.Drawing.Size(100, 20);
            this.jugPierna.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(558, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre_jugador";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(558, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Posicion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(558, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pierna Habil";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(688, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Guardar Datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MostrarEquipo
            // 
            this.MostrarEquipo.Location = new System.Drawing.Point(13, 293);
            this.MostrarEquipo.Name = "MostrarEquipo";
            this.MostrarEquipo.Size = new System.Drawing.Size(100, 41);
            this.MostrarEquipo.TabIndex = 8;
            this.MostrarEquipo.Text = "Mostrar Equipos";
            this.MostrarEquipo.UseVisualStyleBackColor = true;
            this.MostrarEquipo.Click += new System.EventHandler(this.MostrarEquipo_Click);
            // 
            // MostrarJugadores
            // 
            this.MostrarJugadores.Location = new System.Drawing.Point(167, 293);
            this.MostrarJugadores.Name = "MostrarJugadores";
            this.MostrarJugadores.Size = new System.Drawing.Size(114, 41);
            this.MostrarJugadores.TabIndex = 9;
            this.MostrarJugadores.Text = "Mostrar Jugadores";
            this.MostrarJugadores.UseVisualStyleBackColor = true;
            this.MostrarJugadores.Click += new System.EventHandler(this.MostrarJugadores_Click);
            // 
            // AsignarEquipo
            // 
            this.AsignarEquipo.Location = new System.Drawing.Point(561, 192);
            this.AsignarEquipo.Name = "AsignarEquipo";
            this.AsignarEquipo.Size = new System.Drawing.Size(100, 41);
            this.AsignarEquipo.TabIndex = 10;
            this.AsignarEquipo.Text = "Asignar Equipo";
            this.AsignarEquipo.UseVisualStyleBackColor = true;
            this.AsignarEquipo.Click += new System.EventHandler(this.button4_Click);
            // 
            // eliminarJugador
            // 
            this.eliminarJugador.Location = new System.Drawing.Point(561, 320);
            this.eliminarJugador.Name = "eliminarJugador";
            this.eliminarJugador.Size = new System.Drawing.Size(153, 41);
            this.eliminarJugador.TabIndex = 11;
            this.eliminarJugador.Text = "ELIMINAR JUGADOR";
            this.eliminarJugador.UseVisualStyleBackColor = true;
            this.eliminarJugador.Click += new System.EventHandler(this.eliminarJugador_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.eliminarJugador);
            this.Controls.Add(this.AsignarEquipo);
            this.Controls.Add(this.MostrarJugadores);
            this.Controls.Add(this.MostrarEquipo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jugPierna);
            this.Controls.Add(this.jugPosicion);
            this.Controls.Add(this.nombreJug);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox nombreJug;
        private System.Windows.Forms.TextBox jugPosicion;
        private System.Windows.Forms.TextBox jugPierna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button MostrarEquipo;
        private System.Windows.Forms.Button MostrarJugadores;
        private System.Windows.Forms.Button AsignarEquipo;
        private System.Windows.Forms.Button eliminarJugador;
    }
}

