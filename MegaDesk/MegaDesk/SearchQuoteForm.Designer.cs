namespace MegaDesk
{
    partial class SearchQuoteForm
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
            this.SearchReturnButton = new System.Windows.Forms.Button();
            this.SearchQuoteLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SearchReturnButton
            // 
            this.SearchReturnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SearchReturnButton.Location = new System.Drawing.Point(575, 379);
            this.SearchReturnButton.Name = "SearchReturnButton";
            this.SearchReturnButton.Size = new System.Drawing.Size(152, 45);
            this.SearchReturnButton.TabIndex = 0;
            this.SearchReturnButton.Text = "Return To Home";
            this.SearchReturnButton.UseVisualStyleBackColor = false;
            this.SearchReturnButton.Click += new System.EventHandler(this.SearchReturnButton_Click);
            // 
            // SearchQuoteLabel
            // 
            this.SearchQuoteLabel.AutoSize = true;
            this.SearchQuoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchQuoteLabel.Location = new System.Drawing.Point(297, 34);
            this.SearchQuoteLabel.Name = "SearchQuoteLabel";
            this.SearchQuoteLabel.Size = new System.Drawing.Size(173, 29);
            this.SearchQuoteLabel.TabIndex = 1;
            this.SearchQuoteLabel.Text = "Search Quotes";
            // 
            // SearchQuoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchQuoteLabel);
            this.Controls.Add(this.SearchReturnButton);
            this.Name = "SearchQuoteForm";
            this.Text = "SearchQuoteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchReturnButton;
        private System.Windows.Forms.Label SearchQuoteLabel;
    }
}