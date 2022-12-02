namespace Composite_Pattern
{
    partial class Form1
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
            this.FileNamelbl = new System.Windows.Forms.Label();
            this.SelectFilebtn = new System.Windows.Forms.Button();
            this.SelectFolderbtn = new System.Windows.Forms.Button();
            this.FolderNamelbl = new System.Windows.Forms.Label();
            this.SelectedFileSize = new System.Windows.Forms.Label();
            this.FolderSizeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FileNamelbl
            // 
            this.FileNamelbl.AutoSize = true;
            this.FileNamelbl.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.FileNamelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FileNamelbl.Location = new System.Drawing.Point(14, 9);
            this.FileNamelbl.Name = "FileNamelbl";
            this.FileNamelbl.Size = new System.Drawing.Size(43, 17);
            this.FileNamelbl.TabIndex = 0;
            this.FileNamelbl.Text = "Empty";
            // 
            // SelectFilebtn
            // 
            this.SelectFilebtn.BackColor = System.Drawing.SystemColors.Control;
            this.SelectFilebtn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SelectFilebtn.Location = new System.Drawing.Point(14, 43);
            this.SelectFilebtn.Name = "SelectFilebtn";
            this.SelectFilebtn.Size = new System.Drawing.Size(75, 23);
            this.SelectFilebtn.TabIndex = 1;
            this.SelectFilebtn.Text = "Select File";
            this.SelectFilebtn.UseVisualStyleBackColor = false;
            this.SelectFilebtn.Click += new System.EventHandler(this.SelectFile_Folderbtn_Click);
            // 
            // SelectFolderbtn
            // 
            this.SelectFolderbtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.SelectFolderbtn.Location = new System.Drawing.Point(12, 203);
            this.SelectFolderbtn.Name = "SelectFolderbtn";
            this.SelectFolderbtn.Size = new System.Drawing.Size(90, 23);
            this.SelectFolderbtn.TabIndex = 2;
            this.SelectFolderbtn.Text = "Select Folder";
            this.SelectFolderbtn.UseVisualStyleBackColor = true;
            this.SelectFolderbtn.Click += new System.EventHandler(this.SelectFile_Folderbtn_Click);
            // 
            // FolderNamelbl
            // 
            this.FolderNamelbl.AutoSize = true;
            this.FolderNamelbl.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.FolderNamelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FolderNamelbl.ForeColor = System.Drawing.Color.White;
            this.FolderNamelbl.Location = new System.Drawing.Point(12, 171);
            this.FolderNamelbl.Name = "FolderNamelbl";
            this.FolderNamelbl.Size = new System.Drawing.Size(43, 17);
            this.FolderNamelbl.TabIndex = 3;
            this.FolderNamelbl.Text = "Empty";
            // 
            // SelectedFileSize
            // 
            this.SelectedFileSize.AutoSize = true;
            this.SelectedFileSize.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.SelectedFileSize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SelectedFileSize.Location = new System.Drawing.Point(14, 79);
            this.SelectedFileSize.Name = "SelectedFileSize";
            this.SelectedFileSize.Size = new System.Drawing.Size(43, 17);
            this.SelectedFileSize.TabIndex = 4;
            this.SelectedFileSize.Text = "Empty";
            // 
            // FolderSizeLbl
            // 
            this.FolderSizeLbl.AutoSize = true;
            this.FolderSizeLbl.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.FolderSizeLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FolderSizeLbl.Location = new System.Drawing.Point(14, 241);
            this.FolderSizeLbl.Name = "FolderSizeLbl";
            this.FolderSizeLbl.Size = new System.Drawing.Size(43, 17);
            this.FolderSizeLbl.TabIndex = 5;
            this.FolderSizeLbl.Text = "Empty";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(598, 370);
            this.Controls.Add(this.FolderSizeLbl);
            this.Controls.Add(this.SelectedFileSize);
            this.Controls.Add(this.FolderNamelbl);
            this.Controls.Add(this.SelectFolderbtn);
            this.Controls.Add(this.SelectFilebtn);
            this.Controls.Add(this.FileNamelbl);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label FileNamelbl;
        private Button SelectFilebtn;
        private Button SelectFolderbtn;
        private Label FolderNamelbl;
        private Label SelectedFileSize;
        private Label FolderSizeLbl;
    }
}