namespace Tarea_27
{
    partial class fmrTarea27
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
            this.lblNumAl = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.cmdVer = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblIntentos = new System.Windows.Forms.Label();
            this.cmdOtro = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumAl
            // 
            this.lblNumAl.AutoSize = true;
            this.lblNumAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumAl.Location = new System.Drawing.Point(21, 37);
            this.lblNumAl.Name = "lblNumAl";
            this.lblNumAl.Size = new System.Drawing.Size(461, 24);
            this.lblNumAl.TabIndex = 0;
            this.lblNumAl.Text = "Estoy pensando en un número del 1 al 100, ¿cuál es?";
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Location = new System.Drawing.Point(100, 76);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 26);
            this.txtNum.TabIndex = 1;
            // 
            // cmdVer
            // 
            this.cmdVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVer.Location = new System.Drawing.Point(221, 76);
            this.cmdVer.Name = "cmdVer";
            this.cmdVer.Size = new System.Drawing.Size(79, 26);
            this.cmdVer.TabIndex = 2;
            this.cmdVer.Text = "&Ver";
            this.cmdVer.UseVisualStyleBackColor = true;
            this.cmdVer.Click += new System.EventHandler(this.cmdVer_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(12, 167);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(123, 20);
            this.lblMensaje.TabIndex = 3;
            this.lblMensaje.Text = "alksdhfalksdhfjh";
            // 
            // lblIntentos
            // 
            this.lblIntentos.AutoSize = true;
            this.lblIntentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntentos.Location = new System.Drawing.Point(12, 198);
            this.lblIntentos.Name = "lblIntentos";
            this.lblIntentos.Size = new System.Drawing.Size(123, 20);
            this.lblIntentos.TabIndex = 4;
            this.lblIntentos.Text = "alksdhfalksdhfjh";
            // 
            // cmdOtro
            // 
            this.cmdOtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOtro.Location = new System.Drawing.Point(306, 76);
            this.cmdOtro.Name = "cmdOtro";
            this.cmdOtro.Size = new System.Drawing.Size(79, 26);
            this.cmdOtro.TabIndex = 5;
            this.cmdOtro.Text = "&Otro";
            this.cmdOtro.UseVisualStyleBackColor = true;
            this.cmdOtro.Click += new System.EventHandler(this.cmdOtro_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(391, 76);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(79, 26);
            this.cmdSalir.TabIndex = 6;
            this.cmdSalir.Text = "&Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // fmrTarea27
            // 
            this.AcceptButton = this.cmdVer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CancelButton = this.cmdSalir;
            this.ClientSize = new System.Drawing.Size(494, 265);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdOtro);
            this.Controls.Add(this.lblIntentos);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.cmdVer);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblNumAl);
            this.Name = "fmrTarea27";
            this.Text = "Adivina  número";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumAl;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button cmdVer;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblIntentos;
        private System.Windows.Forms.Button cmdOtro;
        private System.Windows.Forms.Button cmdSalir;
    }
}

