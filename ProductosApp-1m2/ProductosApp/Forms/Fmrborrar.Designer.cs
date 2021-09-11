
namespace ProductosApp.Forms
{
    partial class Fmrborrar
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
            this.lblBorrar = new System.Windows.Forms.Label();
            this.txtBorrar = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBorrar
            // 
            this.lblBorrar.AutoSize = true;
            this.lblBorrar.Location = new System.Drawing.Point(264, 91);
            this.lblBorrar.Name = "lblBorrar";
            this.lblBorrar.Size = new System.Drawing.Size(16, 13);
            this.lblBorrar.TabIndex = 0;
            this.lblBorrar.Text = "Id";
            // 
            // txtBorrar
            // 
            this.txtBorrar.Location = new System.Drawing.Point(337, 88);
            this.txtBorrar.Name = "txtBorrar";
            this.txtBorrar.Size = new System.Drawing.Size(100, 20);
            this.txtBorrar.TabIndex = 1;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(502, 88);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "Borrar";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // Fmrborrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.txtBorrar);
            this.Controls.Add(this.lblBorrar);
            this.Name = "Fmrborrar";
            this.Text = "Fmrborrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBorrar;
        private System.Windows.Forms.TextBox txtBorrar;
        private System.Windows.Forms.Button btndelete;
    }
}