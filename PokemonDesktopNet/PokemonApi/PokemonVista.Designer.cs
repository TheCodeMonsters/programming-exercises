
namespace PokemonApi
{
    partial class PokemonVista
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.imagen = new System.Windows.Forms.PictureBox();
            this.nombre = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            this.SuspendLayout();

            // 
            // imagen
            // 
            this.imagen.Location = new System.Drawing.Point(20, 16);
            this.imagen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(196, 99);
            this.imagen.TabIndex = 0;
            this.imagen.TabStop = false;

            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(20, 120);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(38, 15);
            this.nombre.TabIndex = 1;
            this.nombre.Text = "label1";

            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.Location = new System.Drawing.Point(141, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Details";
            this.button1.UseVisualStyleBackColor = true;

            // 
            // PokemonVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.imagen);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PokemonVista";
            this.Size = new System.Drawing.Size(231, 150);
            this.Load += new System.EventHandler(this.PokemonVista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagen;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Button button1;
    }
}
