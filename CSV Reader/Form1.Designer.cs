namespace CSV_Reader
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
            this.LBoxAverages = new System.Windows.Forms.ListBox();
            this.BtnProcessGrades = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBoxAverages
            // 
            this.LBoxAverages.FormattingEnabled = true;
            this.LBoxAverages.Location = new System.Drawing.Point(12, 15);
            this.LBoxAverages.Name = "LBoxAverages";
            this.LBoxAverages.Size = new System.Drawing.Size(260, 134);
            this.LBoxAverages.TabIndex = 0;
            // 
            // BtnProcessGrades
            // 
            this.BtnProcessGrades.Location = new System.Drawing.Point(28, 155);
            this.BtnProcessGrades.Name = "BtnProcessGrades";
            this.BtnProcessGrades.Size = new System.Drawing.Size(147, 23);
            this.BtnProcessGrades.TabIndex = 1;
            this.BtnProcessGrades.Text = "Get and Process Grades";
            this.BtnProcessGrades.UseVisualStyleBackColor = true;
            this.BtnProcessGrades.Click += new System.EventHandler(this.BtnProcessGrades_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(181, 155);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 192);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnProcessGrades);
            this.Controls.Add(this.LBoxAverages);
            this.Name = "Form1";
            this.Text = "CSV Reader Example";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LBoxAverages;
        private System.Windows.Forms.Button BtnProcessGrades;
        private System.Windows.Forms.Button BtnExit;
    }
}

