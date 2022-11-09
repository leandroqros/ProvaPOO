
namespace ControlFigures
{
    partial class pnlFigura
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
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.pb1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(48, 12);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(33, 13);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipus";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(45, 132);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(46, 13);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Resultat";
            // 
            // pb1
            // 
            this.pb1.Image = global::ControlFigures.Properties.Resources.plain_triangle;
            this.pb1.Location = new System.Drawing.Point(15, 28);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(104, 101);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 2;
            this.pb1.TabStop = false;
            // 
            // pnlFigura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblTipo);
            this.Name = "pnlFigura";
            this.Size = new System.Drawing.Size(130, 159);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.PictureBox pb1;
    }
}
