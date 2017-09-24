namespace WinFormOOP
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControllStatusText = new System.Windows.Forms.Label();
            this.labelControllerStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelControllStatusText
            // 
            this.labelControllStatusText.AutoSize = true;
            this.labelControllStatusText.Location = new System.Drawing.Point(13, 13);
            this.labelControllStatusText.Name = "labelControllStatusText";
            this.labelControllStatusText.Size = new System.Drawing.Size(121, 17);
            this.labelControllStatusText.TabIndex = 0;
            this.labelControllStatusText.Text = "Controller Status: ";
            // 
            // labelControllerStatus
            // 
            this.labelControllerStatus.AutoSize = true;
            this.labelControllerStatus.Location = new System.Drawing.Point(141, 13);
            this.labelControllerStatus.Name = "labelControllerStatus";
            this.labelControllerStatus.Size = new System.Drawing.Size(48, 17);
            this.labelControllerStatus.TabIndex = 1;
            this.labelControllerStatus.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 327);
            this.Controls.Add(this.labelControllerStatus);
            this.Controls.Add(this.labelControllStatusText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelControllStatusText;
        private System.Windows.Forms.Label labelControllerStatus;
    }
}

