namespace auto_extract_watcher
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textWatchLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.BrowseDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.textExtractLocation = new System.Windows.Forms.TextBox();
            this.buttonBrowseExtractLocation = new System.Windows.Forms.Button();
            this.buttonBrowseWatchLocation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textWatchLocation
            // 
            this.textWatchLocation.Location = new System.Drawing.Point(12, 27);
            this.textWatchLocation.Name = "textWatchLocation";
            this.textWatchLocation.Size = new System.Drawing.Size(319, 23);
            this.textWatchLocation.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Watch Location:";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(289, 138);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "Start";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Extract Location:";
            // 
            // textExtractLocation
            // 
            this.textExtractLocation.Location = new System.Drawing.Point(12, 84);
            this.textExtractLocation.Name = "textExtractLocation";
            this.textExtractLocation.Size = new System.Drawing.Size(319, 23);
            this.textExtractLocation.TabIndex = 4;
            // 
            // buttonBrowseExtractLocation
            // 
            this.buttonBrowseExtractLocation.Location = new System.Drawing.Point(337, 84);
            this.buttonBrowseExtractLocation.Name = "buttonBrowseExtractLocation";
            this.buttonBrowseExtractLocation.Size = new System.Drawing.Size(27, 23);
            this.buttonBrowseExtractLocation.TabIndex = 6;
            this.buttonBrowseExtractLocation.Text = "...";
            this.buttonBrowseExtractLocation.UseVisualStyleBackColor = true;
            this.buttonBrowseExtractLocation.Click += new System.EventHandler(this.buttonBrowseExtractLocation_Click);
            // 
            // buttonBrowseWatchLocation
            // 
            this.buttonBrowseWatchLocation.Location = new System.Drawing.Point(337, 27);
            this.buttonBrowseWatchLocation.Name = "buttonBrowseWatchLocation";
            this.buttonBrowseWatchLocation.Size = new System.Drawing.Size(27, 23);
            this.buttonBrowseWatchLocation.TabIndex = 7;
            this.buttonBrowseWatchLocation.Text = "...";
            this.buttonBrowseWatchLocation.UseVisualStyleBackColor = true;
            this.buttonBrowseWatchLocation.Click += new System.EventHandler(this.buttonBrowseWatchLocation_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 173);
            this.Controls.Add(this.buttonBrowseWatchLocation);
            this.Controls.Add(this.buttonBrowseExtractLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textExtractLocation);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textWatchLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Extract Watcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textWatchLocation;
        private Label label1;
        private Button buttonOk;
        private FolderBrowserDialog BrowseDialog;
        private Label label2;
        private TextBox textExtractLocation;
        private Button buttonBrowseExtractLocation;
        private Button buttonBrowseWatchLocation;
    }
}