namespace MegaDesk
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.AddNewQuote = new System.Windows.Forms.Button();
            this.ViewQuotes = new System.Windows.Forms.Button();
            this.SearchQuotes = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.MainFormLabel = new System.Windows.Forms.Label();
            this.deskImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.deskImage)).BeginInit();
            this.SuspendLayout();
            // 
            // AddNewQuote
            // 
            this.AddNewQuote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddNewQuote.Location = new System.Drawing.Point(75, 60);
            this.AddNewQuote.Name = "AddNewQuote";
            this.AddNewQuote.Size = new System.Drawing.Size(208, 80);
            this.AddNewQuote.TabIndex = 0;
            this.AddNewQuote.Text = "&Add New Quote";
            this.AddNewQuote.UseVisualStyleBackColor = false;
            this.AddNewQuote.Click += new System.EventHandler(this.AddNewQuote_Click);
            // 
            // ViewQuotes
            // 
            this.ViewQuotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ViewQuotes.Location = new System.Drawing.Point(75, 146);
            this.ViewQuotes.Name = "ViewQuotes";
            this.ViewQuotes.Size = new System.Drawing.Size(208, 80);
            this.ViewQuotes.TabIndex = 1;
            this.ViewQuotes.Text = "&View Quotes";
            this.ViewQuotes.UseVisualStyleBackColor = false;
            this.ViewQuotes.Click += new System.EventHandler(this.ViewQuotes_Click);
            // 
            // SearchQuotes
            // 
            this.SearchQuotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SearchQuotes.Location = new System.Drawing.Point(75, 232);
            this.SearchQuotes.Name = "SearchQuotes";
            this.SearchQuotes.Size = new System.Drawing.Size(208, 80);
            this.SearchQuotes.TabIndex = 2;
            this.SearchQuotes.Text = "&Search Quotes";
            this.SearchQuotes.UseVisualStyleBackColor = false;
            this.SearchQuotes.Click += new System.EventHandler(this.SearchQuotes_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Exit.Location = new System.Drawing.Point(75, 318);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(208, 80);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "&Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MainFormLabel
            // 
            this.MainFormLabel.AutoSize = true;
            this.MainFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainFormLabel.Location = new System.Drawing.Point(429, 46);
            this.MainFormLabel.Name = "MainFormLabel";
            this.MainFormLabel.Size = new System.Drawing.Size(228, 29);
            this.MainFormLabel.TabIndex = 4;
            this.MainFormLabel.Text = "MegaDesk Quotes";
            this.MainFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deskImage
            // 
            this.deskImage.Image = ((System.Drawing.Image)(resources.GetObject("deskImage.Image")));
            this.deskImage.Location = new System.Drawing.Point(333, 78);
            this.deskImage.Name = "deskImage";
            this.deskImage.Size = new System.Drawing.Size(424, 330);
            this.deskImage.TabIndex = 5;
            this.deskImage.TabStop = false;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deskImage);
            this.Controls.Add(this.MainFormLabel);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.SearchQuotes);
            this.Controls.Add(this.ViewQuotes);
            this.Controls.Add(this.AddNewQuote);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenuForm";
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.deskImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNewQuote;
        private System.Windows.Forms.Button ViewQuotes;
        private System.Windows.Forms.Button SearchQuotes;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label MainFormLabel;
        private System.Windows.Forms.PictureBox deskImage;
    }
}

