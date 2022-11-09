namespace PCBPOO
{
    partial class frmPOO
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
            this.btnArea = new System.Windows.Forms.Button();
            this.btnVolumTriangle = new System.Windows.Forms.Button();
            this.btnVolum = new System.Windows.Forms.Button();
            this.btnAreaTriangle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDimensio1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDimensio2 = new System.Windows.Forms.TextBox();
            this.txtDimensio3 = new System.Windows.Forms.TextBox();
            this.btnAreaCercle = new System.Windows.Forms.Button();
            this.pnlFigura1 = new ControlFigures.pnlFigura();
            this.SuspendLayout();
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(17, 21);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(75, 46);
            this.btnArea.TabIndex = 0;
            this.btnArea.Text = "Area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // btnVolumTriangle
            // 
            this.btnVolumTriangle.Location = new System.Drawing.Point(454, 21);
            this.btnVolumTriangle.Name = "btnVolumTriangle";
            this.btnVolumTriangle.Size = new System.Drawing.Size(75, 60);
            this.btnVolumTriangle.TabIndex = 1;
            this.btnVolumTriangle.Text = "Volum Triangle";
            this.btnVolumTriangle.UseVisualStyleBackColor = true;
            this.btnVolumTriangle.Click += new System.EventHandler(this.btnVolumTriangle_Click);
            // 
            // btnVolum
            // 
            this.btnVolum.Location = new System.Drawing.Point(108, 21);
            this.btnVolum.Name = "btnVolum";
            this.btnVolum.Size = new System.Drawing.Size(75, 46);
            this.btnVolum.TabIndex = 2;
            this.btnVolum.Text = "Volum";
            this.btnVolum.UseVisualStyleBackColor = true;
            this.btnVolum.Click += new System.EventHandler(this.btnVolum_Click);
            // 
            // btnAreaTriangle
            // 
            this.btnAreaTriangle.Location = new System.Drawing.Point(373, 21);
            this.btnAreaTriangle.Name = "btnAreaTriangle";
            this.btnAreaTriangle.Size = new System.Drawing.Size(75, 60);
            this.btnAreaTriangle.TabIndex = 3;
            this.btnAreaTriangle.Text = "Area Triangle";
            this.btnAreaTriangle.UseVisualStyleBackColor = true;
            this.btnAreaTriangle.Click += new System.EventHandler(this.btnAreaTriangle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dimensió 1";
            // 
            // txtDimensio1
            // 
            this.txtDimensio1.Location = new System.Drawing.Point(114, 126);
            this.txtDimensio1.Name = "txtDimensio1";
            this.txtDimensio1.Size = new System.Drawing.Size(51, 20);
            this.txtDimensio1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dimensió 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Dimensió 3";
            // 
            // txtDimensio2
            // 
            this.txtDimensio2.Location = new System.Drawing.Point(114, 159);
            this.txtDimensio2.Name = "txtDimensio2";
            this.txtDimensio2.Size = new System.Drawing.Size(51, 20);
            this.txtDimensio2.TabIndex = 11;
            // 
            // txtDimensio3
            // 
            this.txtDimensio3.Location = new System.Drawing.Point(114, 187);
            this.txtDimensio3.Name = "txtDimensio3";
            this.txtDimensio3.Size = new System.Drawing.Size(51, 20);
            this.txtDimensio3.TabIndex = 12;
            // 
            // btnAreaCercle
            // 
            this.btnAreaCercle.Location = new System.Drawing.Point(242, 21);
            this.btnAreaCercle.Name = "btnAreaCercle";
            this.btnAreaCercle.Size = new System.Drawing.Size(75, 60);
            this.btnAreaCercle.TabIndex = 13;
            this.btnAreaCercle.Text = "Area Cercle";
            this.btnAreaCercle.UseVisualStyleBackColor = true;
            this.btnAreaCercle.Click += new System.EventHandler(this.btnAreaCercle_Click);
            // 
            // pnlFigura1
            // 
            this.pnlFigura1.Location = new System.Drawing.Point(305, 91);
            this.pnlFigura1.Name = "pnlFigura1";
            this.pnlFigura1.Size = new System.Drawing.Size(130, 159);
            this.pnlFigura1.TabIndex = 14;
            // 
            // frmPOO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 262);
            this.Controls.Add(this.pnlFigura1);
            this.Controls.Add(this.btnAreaCercle);
            this.Controls.Add(this.txtDimensio3);
            this.Controls.Add(this.txtDimensio2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDimensio1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAreaTriangle);
            this.Controls.Add(this.btnVolum);
            this.Controls.Add(this.btnVolumTriangle);
            this.Controls.Add(this.btnArea);
            this.Name = "frmPOO";
            this.Text = "POO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnVolumTriangle;
        private System.Windows.Forms.Button btnVolum;
        private System.Windows.Forms.Button btnAreaTriangle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDimensio1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDimensio2;
        private System.Windows.Forms.TextBox txtDimensio3;
        private System.Windows.Forms.Button btnAreaCercle;
        private ControlFigures.pnlFigura pnlFigura1;
    }
}