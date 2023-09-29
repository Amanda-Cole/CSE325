namespace MegaDesk
{
    partial class AddNewQuote
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
            this.ExitAddNew = new System.Windows.Forms.Button();
            this.AddLabel = new System.Windows.Forms.Label();
            this.InputNameLabel = new System.Windows.Forms.Label();
            this.InputMaterialLabel = new System.Windows.Forms.Label();
            this.InputDepthLabel = new System.Windows.Forms.Label();
            this.InputWidthLabel = new System.Windows.Forms.Label();
            this.InputRushLabel = new System.Windows.Forms.Label();
            this.InputDrawerLabel = new System.Windows.Forms.Label();
            this.InputName = new System.Windows.Forms.TextBox();
            this.InputWidth = new System.Windows.Forms.TextBox();
            this.InputDepth = new System.Windows.Forms.TextBox();
            this.CalcQuoteButton = new System.Windows.Forms.Button();
            this.InputDrawers = new System.Windows.Forms.ComboBox();
            this.InputSurfMat = new System.Windows.Forms.ComboBox();
            this.InputRushOrder = new System.Windows.Forms.ComboBox();
            this.DateBox = new System.Windows.Forms.TextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExitAddNew
            // 
            this.ExitAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ExitAddNew.Location = new System.Drawing.Point(517, 226);
            this.ExitAddNew.Name = "ExitAddNew";
            this.ExitAddNew.Size = new System.Drawing.Size(129, 34);
            this.ExitAddNew.TabIndex = 8;
            this.ExitAddNew.Text = "Return to Main";
            this.ExitAddNew.UseVisualStyleBackColor = false;
            this.ExitAddNew.Click += new System.EventHandler(this.ExitAddNew_Click);
            // 
            // AddLabel
            // 
            this.AddLabel.AutoSize = true;
            this.AddLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLabel.Location = new System.Drawing.Point(315, 9);
            this.AddLabel.Name = "AddLabel";
            this.AddLabel.Size = new System.Drawing.Size(186, 31);
            this.AddLabel.TabIndex = 1;
            this.AddLabel.Text = "Add New Quote";
            this.AddLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputNameLabel
            // 
            this.InputNameLabel.AutoSize = true;
            this.InputNameLabel.BackColor = System.Drawing.Color.White;
            this.InputNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputNameLabel.Location = new System.Drawing.Point(57, 104);
            this.InputNameLabel.Name = "InputNameLabel";
            this.InputNameLabel.Size = new System.Drawing.Size(124, 20);
            this.InputNameLabel.TabIndex = 2;
            this.InputNameLabel.Text = "Customer Name";
            // 
            // InputMaterialLabel
            // 
            this.InputMaterialLabel.AutoSize = true;
            this.InputMaterialLabel.BackColor = System.Drawing.Color.White;
            this.InputMaterialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputMaterialLabel.Location = new System.Drawing.Point(56, 276);
            this.InputMaterialLabel.Name = "InputMaterialLabel";
            this.InputMaterialLabel.Size = new System.Drawing.Size(125, 20);
            this.InputMaterialLabel.TabIndex = 3;
            this.InputMaterialLabel.Text = "Surface Material";
            // 
            // InputDepthLabel
            // 
            this.InputDepthLabel.AutoSize = true;
            this.InputDepthLabel.BackColor = System.Drawing.Color.White;
            this.InputDepthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputDepthLabel.Location = new System.Drawing.Point(62, 185);
            this.InputDepthLabel.Name = "InputDepthLabel";
            this.InputDepthLabel.Size = new System.Drawing.Size(119, 20);
            this.InputDepthLabel.TabIndex = 4;
            this.InputDepthLabel.Text = "Depth in inches";
            // 
            // InputWidthLabel
            // 
            this.InputWidthLabel.AutoSize = true;
            this.InputWidthLabel.BackColor = System.Drawing.Color.White;
            this.InputWidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputWidthLabel.Location = new System.Drawing.Point(62, 145);
            this.InputWidthLabel.Name = "InputWidthLabel";
            this.InputWidthLabel.Size = new System.Drawing.Size(116, 20);
            this.InputWidthLabel.TabIndex = 5;
            this.InputWidthLabel.Text = "Width in inches";
            // 
            // InputRushLabel
            // 
            this.InputRushLabel.AutoSize = true;
            this.InputRushLabel.BackColor = System.Drawing.Color.White;
            this.InputRushLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputRushLabel.Location = new System.Drawing.Point(90, 327);
            this.InputRushLabel.Name = "InputRushLabel";
            this.InputRushLabel.Size = new System.Drawing.Size(91, 20);
            this.InputRushLabel.TabIndex = 6;
            this.InputRushLabel.Text = "Rush Order";
            // 
            // InputDrawerLabel
            // 
            this.InputDrawerLabel.AutoSize = true;
            this.InputDrawerLabel.BackColor = System.Drawing.Color.White;
            this.InputDrawerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputDrawerLabel.Location = new System.Drawing.Point(113, 232);
            this.InputDrawerLabel.Name = "InputDrawerLabel";
            this.InputDrawerLabel.Size = new System.Drawing.Size(68, 20);
            this.InputDrawerLabel.TabIndex = 7;
            this.InputDrawerLabel.Text = "Drawers";
            // 
            // InputName
            // 
            this.InputName.Location = new System.Drawing.Point(188, 103);
            this.InputName.Name = "InputName";
            this.InputName.Size = new System.Drawing.Size(196, 20);
            this.InputName.TabIndex = 1;
            // 
            // InputWidth
            // 
            this.InputWidth.Location = new System.Drawing.Point(188, 145);
            this.InputWidth.Name = "InputWidth";
            this.InputWidth.Size = new System.Drawing.Size(40, 20);
            this.InputWidth.TabIndex = 2;
            this.InputWidth.Leave += new System.EventHandler(this.InputWidth_Leave);
            // 
            // InputDepth
            // 
            this.InputDepth.Location = new System.Drawing.Point(188, 185);
            this.InputDepth.Name = "InputDepth";
            this.InputDepth.Size = new System.Drawing.Size(40, 20);
            this.InputDepth.TabIndex = 3;
            this.InputDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputDepth_KeyPress);
            this.InputDepth.Leave += new System.EventHandler(this.InputDepth_Leave);
            // 
            // CalcQuoteButton
            // 
            this.CalcQuoteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CalcQuoteButton.Location = new System.Drawing.Point(517, 145);
            this.CalcQuoteButton.Name = "CalcQuoteButton";
            this.CalcQuoteButton.Size = new System.Drawing.Size(129, 40);
            this.CalcQuoteButton.TabIndex = 7;
            this.CalcQuoteButton.Text = "Calculate Quote";
            this.CalcQuoteButton.UseVisualStyleBackColor = false;
            this.CalcQuoteButton.Click += new System.EventHandler(this.CalcQuoteButton_Click);
            // 
            // InputDrawers
            // 
            this.InputDrawers.FormattingEnabled = true;
            this.InputDrawers.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.InputDrawers.Location = new System.Drawing.Point(188, 230);
            this.InputDrawers.Name = "InputDrawers";
            this.InputDrawers.Size = new System.Drawing.Size(40, 21);
            this.InputDrawers.TabIndex = 4;
            // 
            // InputSurfMat
            // 
            this.InputSurfMat.FormattingEnabled = true;
            this.InputSurfMat.Items.AddRange(new object[] {
            "laminate",
            "oak",
            "rosewood",
            "veneer",
            "pine"});
            this.InputSurfMat.Location = new System.Drawing.Point(188, 274);
            this.InputSurfMat.Name = "InputSurfMat";
            this.InputSurfMat.Size = new System.Drawing.Size(121, 21);
            this.InputSurfMat.TabIndex = 5;
            // 
            // InputRushOrder
            // 
            this.InputRushOrder.FormattingEnabled = true;
            this.InputRushOrder.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "14"});
            this.InputRushOrder.Location = new System.Drawing.Point(188, 326);
            this.InputRushOrder.Name = "InputRushOrder";
            this.InputRushOrder.Size = new System.Drawing.Size(40, 21);
            this.InputRushOrder.TabIndex = 6;
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(188, 63);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(210, 20);
            this.DateBox.TabIndex = 13;
            this.DateBox.TabStop = false;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.Color.White;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(94, 63);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(88, 20);
            this.DateLabel.TabIndex = 14;
            this.DateLabel.Text = "Order Date";
            // 
            // AddNewQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.InputRushOrder);
            this.Controls.Add(this.InputSurfMat);
            this.Controls.Add(this.InputDrawers);
            this.Controls.Add(this.CalcQuoteButton);
            this.Controls.Add(this.InputDepth);
            this.Controls.Add(this.InputWidth);
            this.Controls.Add(this.InputName);
            this.Controls.Add(this.InputDrawerLabel);
            this.Controls.Add(this.InputRushLabel);
            this.Controls.Add(this.InputWidthLabel);
            this.Controls.Add(this.InputDepthLabel);
            this.Controls.Add(this.InputMaterialLabel);
            this.Controls.Add(this.InputNameLabel);
            this.Controls.Add(this.AddLabel);
            this.Controls.Add(this.ExitAddNew);
            this.Name = "AddNewQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Quote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitAddNew;
        private System.Windows.Forms.Label AddLabel;
        private System.Windows.Forms.Label InputNameLabel;
        private System.Windows.Forms.Label InputMaterialLabel;
        private System.Windows.Forms.Label InputDepthLabel;
        private System.Windows.Forms.Label InputWidthLabel;
        private System.Windows.Forms.Label InputRushLabel;
        private System.Windows.Forms.Label InputDrawerLabel;
        private System.Windows.Forms.TextBox InputName;
        private System.Windows.Forms.TextBox InputWidth;
        private System.Windows.Forms.TextBox InputDepth;
        private System.Windows.Forms.Button CalcQuoteButton;
        private System.Windows.Forms.ComboBox InputDrawers;
        private System.Windows.Forms.ComboBox InputSurfMat;
        private System.Windows.Forms.ComboBox InputRushOrder;
        private System.Windows.Forms.TextBox DateBox;
        private System.Windows.Forms.Label DateLabel;
    }
}