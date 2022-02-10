
namespace VelikaiMalaSlova
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxUnosTeksta = new System.Windows.Forms.TextBox();
            this.UnosTeksta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxUnosTeksta
            // 
            resources.ApplyResources(this.textBoxUnosTeksta, "textBoxUnosTeksta");
            this.textBoxUnosTeksta.Name = "textBoxUnosTeksta";
            this.textBoxUnosTeksta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // UnosTeksta
            // 
            resources.ApplyResources(this.UnosTeksta, "UnosTeksta");
            this.UnosTeksta.Name = "UnosTeksta";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UnosTeksta);
            this.Controls.Add(this.textBoxUnosTeksta);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUnosTeksta;
        private System.Windows.Forms.Label UnosTeksta;
    }
}

