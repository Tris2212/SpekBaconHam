
namespace SpekBaconHam
{
    partial class UserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblWinner = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblWinner
            // 
            this.LblWinner.AutoSize = true;
            this.LblWinner.Font = new System.Drawing.Font("Raleway", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWinner.Location = new System.Drawing.Point(159, 168);
            this.LblWinner.Name = "LblWinner";
            this.LblWinner.Size = new System.Drawing.Size(88, 66);
            this.LblWinner.TabIndex = 1;
            this.LblWinner.Text = "lbl";
            this.LblWinner.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblWinner);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(689, 604);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LblWinner;
    }
}
