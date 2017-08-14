namespace Waterpolo
{
    partial class Waterpolo
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
            this.pool = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pool
            // 
            this.pool.Location = new System.Drawing.Point(0, 185);
            this.pool.Name = "pool";
            this.pool.Size = new System.Drawing.Size(1251, 681);
            this.pool.TabIndex = 0;
            this.pool.Paint += new System.Windows.Forms.PaintEventHandler(this.Paint);
            // 
            // Waterpolo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 873);
            this.Controls.Add(this.pool);
            this.Name = "Waterpolo";
            this.Text = "Waterpolo game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pool;
    }
}

