
namespace Ejercicio_I03
{
    partial class ContadorForm
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
            this.rtxtForm = new System.Windows.Forms.RichTextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxtForm
            // 
            this.rtxtForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtForm.Location = new System.Drawing.Point(2, 0);
            this.rtxtForm.Name = "rtxtForm";
            this.rtxtForm.Size = new System.Drawing.Size(644, 410);
            this.rtxtForm.TabIndex = 0;
            this.rtxtForm.Text = "";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalcular.Location = new System.Drawing.Point(520, 417);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(119, 31);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // ContadorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 460);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.rtxtForm);
            this.Name = "ContadorForm";
            this.Text = "Contador de Palabras";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtForm;
        private System.Windows.Forms.Button btnCalcular;
    }
}

