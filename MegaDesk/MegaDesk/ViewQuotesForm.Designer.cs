namespace MegaDesk
{
    partial class ViewQuotesForm
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
            this.ReturnToHomeFromView = new System.Windows.Forms.Button();
            this.ViewQuotesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReturnToHomeFromView
            // 
            this.ReturnToHomeFromView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ReturnToHomeFromView.Location = new System.Drawing.Point(621, 387);
            this.ReturnToHomeFromView.Name = "ReturnToHomeFromView";
            this.ReturnToHomeFromView.Size = new System.Drawing.Size(124, 25);
            this.ReturnToHomeFromView.TabIndex = 0;
            this.ReturnToHomeFromView.Text = "Return To Home";
            this.ReturnToHomeFromView.UseVisualStyleBackColor = false;
            this.ReturnToHomeFromView.Click += new System.EventHandler(this.ReturnToHomeFromView_Click);
            // 
            // ViewQuotesLabel
            // 
            this.ViewQuotesLabel.AutoSize = true;
            this.ViewQuotesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewQuotesLabel.Location = new System.Drawing.Point(286, 54);
            this.ViewQuotesLabel.Name = "ViewQuotesLabel";
            this.ViewQuotesLabel.Size = new System.Drawing.Size(183, 29);
            this.ViewQuotesLabel.TabIndex = 1;
            this.ViewQuotesLabel.Text = "View All Quotes";
            // 
            // ViewQuotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewQuotesLabel);
            this.Controls.Add(this.ReturnToHomeFromView);
            this.Name = "ViewQuotesForm";
            this.Text = "ViewQuotesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnToHomeFromView;
        private System.Windows.Forms.Label ViewQuotesLabel;
    }
}