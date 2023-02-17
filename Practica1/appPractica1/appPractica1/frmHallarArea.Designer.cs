
namespace appPractica1
{
    partial class frmHallarArea
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
            this.lblHallarAreaTriangulo = new System.Windows.Forms.Label();
            this.txtLadoA = new System.Windows.Forms.TextBox();
            this.txtLadoB = new System.Windows.Forms.TextBox();
            this.txtLadoC = new System.Windows.Forms.TextBox();
            this.lblLadoA = new System.Windows.Forms.Label();
            this.lblLadoB = new System.Windows.Forms.Label();
            this.lblLadoC = new System.Windows.Forms.Label();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnHallarArea = new System.Windows.Forms.Button();
            this.gpbArea = new System.Windows.Forms.GroupBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblMsgArea = new System.Windows.Forms.Label();
            this.gpbArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHallarAreaTriangulo
            // 
            this.lblHallarAreaTriangulo.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHallarAreaTriangulo.ForeColor = System.Drawing.Color.Red;
            this.lblHallarAreaTriangulo.Location = new System.Drawing.Point(12, 9);
            this.lblHallarAreaTriangulo.Name = "lblHallarAreaTriangulo";
            this.lblHallarAreaTriangulo.Size = new System.Drawing.Size(550, 39);
            this.lblHallarAreaTriangulo.TabIndex = 0;
            this.lblHallarAreaTriangulo.Text = "Hallar Área del Triángulo";
            this.lblHallarAreaTriangulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLadoA
            // 
            this.txtLadoA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLadoA.Location = new System.Drawing.Point(308, 65);
            this.txtLadoA.MaxLength = 9;
            this.txtLadoA.Name = "txtLadoA";
            this.txtLadoA.Size = new System.Drawing.Size(100, 26);
            this.txtLadoA.TabIndex = 1;
            this.txtLadoA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLadoB
            // 
            this.txtLadoB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLadoB.Location = new System.Drawing.Point(308, 111);
            this.txtLadoB.MaxLength = 9;
            this.txtLadoB.Name = "txtLadoB";
            this.txtLadoB.Size = new System.Drawing.Size(100, 26);
            this.txtLadoB.TabIndex = 2;
            this.txtLadoB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLadoC
            // 
            this.txtLadoC.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLadoC.Location = new System.Drawing.Point(308, 161);
            this.txtLadoC.MaxLength = 9;
            this.txtLadoC.Name = "txtLadoC";
            this.txtLadoC.Size = new System.Drawing.Size(100, 26);
            this.txtLadoC.TabIndex = 3;
            this.txtLadoC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLadoA
            // 
            this.lblLadoA.AutoSize = true;
            this.lblLadoA.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLadoA.ForeColor = System.Drawing.Color.Blue;
            this.lblLadoA.Location = new System.Drawing.Point(193, 66);
            this.lblLadoA.Name = "lblLadoA";
            this.lblLadoA.Size = new System.Drawing.Size(78, 21);
            this.lblLadoA.TabIndex = 4;
            this.lblLadoA.Text = "Lado a:";
            // 
            // lblLadoB
            // 
            this.lblLadoB.AutoSize = true;
            this.lblLadoB.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLadoB.ForeColor = System.Drawing.Color.Blue;
            this.lblLadoB.Location = new System.Drawing.Point(193, 112);
            this.lblLadoB.Name = "lblLadoB";
            this.lblLadoB.Size = new System.Drawing.Size(79, 21);
            this.lblLadoB.TabIndex = 5;
            this.lblLadoB.Text = "Lado b:";
            // 
            // lblLadoC
            // 
            this.lblLadoC.AutoSize = true;
            this.lblLadoC.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLadoC.ForeColor = System.Drawing.Color.Blue;
            this.lblLadoC.Location = new System.Drawing.Point(193, 162);
            this.lblLadoC.Name = "lblLadoC";
            this.lblLadoC.Size = new System.Drawing.Size(77, 21);
            this.lblLadoC.TabIndex = 6;
            this.lblLadoC.Text = "Lado c:";
            // 
            // btnTerminar
            // 
            this.btnTerminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTerminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTerminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminar.Location = new System.Drawing.Point(448, 398);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(114, 40);
            this.btnTerminar.TabIndex = 7;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.UseVisualStyleBackColor = false;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(157, 212);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(114, 40);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnHallarArea
            // 
            this.btnHallarArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnHallarArea.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHallarArea.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHallarArea.Location = new System.Drawing.Point(308, 212);
            this.btnHallarArea.Name = "btnHallarArea";
            this.btnHallarArea.Size = new System.Drawing.Size(114, 40);
            this.btnHallarArea.TabIndex = 9;
            this.btnHallarArea.Text = "Hallar Área";
            this.btnHallarArea.UseVisualStyleBackColor = false;
            this.btnHallarArea.Click += new System.EventHandler(this.btnHallarArea_Click);
            // 
            // gpbArea
            // 
            this.gpbArea.BackColor = System.Drawing.Color.Gray;
            this.gpbArea.Controls.Add(this.lblArea);
            this.gpbArea.Controls.Add(this.lblMsgArea);
            this.gpbArea.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbArea.Location = new System.Drawing.Point(18, 258);
            this.gpbArea.Name = "gpbArea";
            this.gpbArea.Size = new System.Drawing.Size(544, 134);
            this.gpbArea.TabIndex = 10;
            this.gpbArea.TabStop = false;
            this.gpbArea.Text = "     Área:     ";
            this.gpbArea.Visible = false;
            // 
            // lblArea
            // 
            this.lblArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblArea.Location = new System.Drawing.Point(290, 50);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(100, 25);
            this.lblArea.TabIndex = 8;
            this.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMsgArea
            // 
            this.lblMsgArea.AutoSize = true;
            this.lblMsgArea.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgArea.ForeColor = System.Drawing.Color.Blue;
            this.lblMsgArea.Location = new System.Drawing.Point(175, 54);
            this.lblMsgArea.Name = "lblMsgArea";
            this.lblMsgArea.Size = new System.Drawing.Size(63, 21);
            this.lblMsgArea.TabIndex = 7;
            this.lblMsgArea.Text = "Área:";
            // 
            // frmHallarArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(574, 450);
            this.Controls.Add(this.gpbArea);
            this.Controls.Add(this.btnHallarArea);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.lblLadoC);
            this.Controls.Add(this.lblLadoB);
            this.Controls.Add(this.lblLadoA);
            this.Controls.Add(this.txtLadoC);
            this.Controls.Add(this.txtLadoB);
            this.Controls.Add(this.txtLadoA);
            this.Controls.Add(this.lblHallarAreaTriangulo);
            this.Name = "frmHallarArea";
            this.Text = "Práctica # 1";
            this.gpbArea.ResumeLayout(false);
            this.gpbArea.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHallarAreaTriangulo;
        private System.Windows.Forms.TextBox txtLadoA;
        private System.Windows.Forms.TextBox txtLadoB;
        private System.Windows.Forms.TextBox txtLadoC;
        private System.Windows.Forms.Label lblLadoA;
        private System.Windows.Forms.Label lblLadoB;
        private System.Windows.Forms.Label lblLadoC;
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnHallarArea;
        private System.Windows.Forms.GroupBox gpbArea;
        private System.Windows.Forms.Label lblMsgArea;
        private System.Windows.Forms.Label lblArea;
    }
}

