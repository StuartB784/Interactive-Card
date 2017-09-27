namespace Interactive_Card
{
    partial class InteractiveCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InteractiveCard));
            this.ScutumTitle = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.Label();
            this.Scutum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ScutumTitle
            // 
            this.ScutumTitle.AutoSize = true;
            this.ScutumTitle.BackColor = System.Drawing.Color.Transparent;
            this.ScutumTitle.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScutumTitle.ForeColor = System.Drawing.Color.Teal;
            this.ScutumTitle.Location = new System.Drawing.Point(21, 24);
            this.ScutumTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ScutumTitle.Name = "ScutumTitle";
            this.ScutumTitle.Size = new System.Drawing.Size(266, 86);
            this.ScutumTitle.TabIndex = 0;
            this.ScutumTitle.Text = "Scutum";
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.BackColor = System.Drawing.Color.Transparent;
            this.Author.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Author.Location = new System.Drawing.Point(14, 295);
            this.Author.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(293, 47);
            this.Author.TabIndex = 1;
            this.Author.Text = "Stuart Bachellier";
            // 
            // Scutum
            // 
            this.Scutum.BackColor = System.Drawing.Color.Transparent;
            this.Scutum.Font = new System.Drawing.Font("Hobo Std", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scutum.Image = global::Interactive_Card.Properties.Resources.Scutum;
            this.Scutum.Location = new System.Drawing.Point(100, 110);
            this.Scutum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Scutum.Name = "Scutum";
            this.Scutum.Size = new System.Drawing.Size(105, 140);
            this.Scutum.TabIndex = 2;
            this.Scutum.UseWaitCursor = true;
            // 
            // InteractiveCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(4F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Interactive_Card.Properties.Resources.Space;
            this.ClientSize = new System.Drawing.Size(314, 351);
            this.Controls.Add(this.Scutum);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.ScutumTitle);
            this.Font = new System.Drawing.Font("Mistral", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "InteractiveCard";
            this.Text = "Interactive Card";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScutumTitle;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Label Scutum;
    }
}

