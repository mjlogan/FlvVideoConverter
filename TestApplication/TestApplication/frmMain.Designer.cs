namespace TestApplication
{
    partial class frmMain
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
            this.lblSourceFile = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.btnSource = new System.Windows.Forms.Button();
            this.btnDestination = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.fbdFindFile = new System.Windows.Forms.FolderBrowserDialog();
            this.lblOutputWidth = new System.Windows.Forms.Label();
            this.txtOutputWidth = new System.Windows.Forms.TextBox();
            this.lblOutputHeight = new System.Windows.Forms.Label();
            this.txtOutputHeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSourceFile
            // 
            this.lblSourceFile.AutoSize = true;
            this.lblSourceFile.Location = new System.Drawing.Point(13, 15);
            this.lblSourceFile.Name = "lblSourceFile";
            this.lblSourceFile.Size = new System.Drawing.Size(60, 13);
            this.lblSourceFile.TabIndex = 0;
            this.lblSourceFile.Text = "Source file:";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(13, 50);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(79, 13);
            this.lblDestination.TabIndex = 1;
            this.lblDestination.Text = "Destination file:";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(98, 13);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(344, 20);
            this.txtSource.TabIndex = 2;
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(98, 47);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(344, 20);
            this.txtDestination.TabIndex = 2;
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(449, 12);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(28, 23);
            this.btnSource.TabIndex = 3;
            this.btnSource.Text = "...";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // btnDestination
            // 
            this.btnDestination.Location = new System.Drawing.Point(449, 44);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(28, 23);
            this.btnDestination.TabIndex = 3;
            this.btnDestination.Text = "...";
            this.btnDestination.UseVisualStyleBackColor = true;
            this.btnDestination.Click += new System.EventHandler(this.btnDestination_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(256, 134);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "&Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblOutputWidth
            // 
            this.lblOutputWidth.AutoSize = true;
            this.lblOutputWidth.Location = new System.Drawing.Point(13, 86);
            this.lblOutputWidth.Name = "lblOutputWidth";
            this.lblOutputWidth.Size = new System.Drawing.Size(60, 13);
            this.lblOutputWidth.TabIndex = 1;
            this.lblOutputWidth.Text = "Final width:";
            // 
            // txtOutputWidth
            // 
            this.txtOutputWidth.Location = new System.Drawing.Point(98, 83);
            this.txtOutputWidth.Name = "txtOutputWidth";
            this.txtOutputWidth.Size = new System.Drawing.Size(54, 20);
            this.txtOutputWidth.TabIndex = 2;
            this.txtOutputWidth.Text = "320";
            // 
            // lblOutputHeight
            // 
            this.lblOutputHeight.AutoSize = true;
            this.lblOutputHeight.Location = new System.Drawing.Point(162, 86);
            this.lblOutputHeight.Name = "lblOutputHeight";
            this.lblOutputHeight.Size = new System.Drawing.Size(64, 13);
            this.lblOutputHeight.TabIndex = 1;
            this.lblOutputHeight.Text = "Final height:";
            // 
            // txtOutputHeight
            // 
            this.txtOutputHeight.Location = new System.Drawing.Point(227, 83);
            this.txtOutputHeight.Name = "txtOutputHeight";
            this.txtOutputHeight.Size = new System.Drawing.Size(54, 20);
            this.txtOutputHeight.TabIndex = 2;
            this.txtOutputHeight.Text = "240";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 169);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnDestination);
            this.Controls.Add(this.btnSource);
            this.Controls.Add(this.txtOutputHeight);
            this.Controls.Add(this.txtOutputWidth);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.lblOutputHeight);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.lblOutputWidth);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblSourceFile);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Testing Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSourceFile;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.Button btnDestination;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.FolderBrowserDialog fbdFindFile;
        private System.Windows.Forms.Label lblOutputWidth;
        private System.Windows.Forms.TextBox txtOutputWidth;
        private System.Windows.Forms.Label lblOutputHeight;
        private System.Windows.Forms.TextBox txtOutputHeight;
    }
}

