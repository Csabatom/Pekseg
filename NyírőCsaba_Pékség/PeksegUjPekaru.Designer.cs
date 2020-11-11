namespace NyírőCsaba_Pékség
{
    partial class PeksegUjPekaru
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
            this.BTN_PekaruHozzaadas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_PekaruHozzaadas
            // 
            this.BTN_PekaruHozzaadas.Location = new System.Drawing.Point(12, 123);
            this.BTN_PekaruHozzaadas.Name = "BTN_PekaruHozzaadas";
            this.BTN_PekaruHozzaadas.Size = new System.Drawing.Size(226, 47);
            this.BTN_PekaruHozzaadas.TabIndex = 5;
            this.BTN_PekaruHozzaadas.Text = "FELVÉTEL";
            this.BTN_PekaruHozzaadas.UseVisualStyleBackColor = true;
            this.BTN_PekaruHozzaadas.Click += new System.EventHandler(this.BTN_PekaruHozzaadas_Click);
            // 
            // PeksegUjPekaru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 193);
            this.Controls.Add(this.BTN_PekaruHozzaadas);
            this.Name = "PeksegUjPekaru";
            this.Text = "PeksegUjPekaru";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_PekaruHozzaadas;
    }
}