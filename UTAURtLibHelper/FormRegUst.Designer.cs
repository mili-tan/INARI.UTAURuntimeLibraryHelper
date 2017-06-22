namespace UTAURtLibHelper
{
    partial class FormRegUst
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
            this.buttonOpenUTAUFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonRegFileLink = new System.Windows.Forms.Button();
            this.buttonUnRegFileLink = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOpenUTAUFile
            // 
            this.buttonOpenUTAUFile.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.buttonOpenUTAUFile.Location = new System.Drawing.Point(13, 13);
            this.buttonOpenUTAUFile.Name = "buttonOpenUTAUFile";
            this.buttonOpenUTAUFile.Size = new System.Drawing.Size(357, 37);
            this.buttonOpenUTAUFile.TabIndex = 0;
            this.buttonOpenUTAUFile.Text = "打开UTAU主程序";
            this.buttonOpenUTAUFile.UseVisualStyleBackColor = true;
            this.buttonOpenUTAUFile.Click += new System.EventHandler(this.buttonOpenUTAUFile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "utau.exe";
            this.openFileDialog.Filter = "UTAU主程序|utau.exe";
            // 
            // buttonRegFileLink
            // 
            this.buttonRegFileLink.Enabled = false;
            this.buttonRegFileLink.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.buttonRegFileLink.Location = new System.Drawing.Point(13, 56);
            this.buttonRegFileLink.Name = "buttonRegFileLink";
            this.buttonRegFileLink.Size = new System.Drawing.Size(357, 37);
            this.buttonRegFileLink.TabIndex = 1;
            this.buttonRegFileLink.Text = "注册文件关联";
            this.buttonRegFileLink.UseVisualStyleBackColor = true;
            this.buttonRegFileLink.Click += new System.EventHandler(this.buttonRegFileLink_Click);
            // 
            // buttonUnRegFileLink
            // 
            this.buttonUnRegFileLink.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.buttonUnRegFileLink.Location = new System.Drawing.Point(13, 99);
            this.buttonUnRegFileLink.Name = "buttonUnRegFileLink";
            this.buttonUnRegFileLink.Size = new System.Drawing.Size(357, 37);
            this.buttonUnRegFileLink.TabIndex = 2;
            this.buttonUnRegFileLink.Text = "取消注册文件关联";
            this.buttonUnRegFileLink.UseVisualStyleBackColor = true;
            this.buttonUnRegFileLink.Click += new System.EventHandler(this.buttonUnRegFileLink_Click);
            // 
            // FormRegUst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 203);
            this.Controls.Add(this.buttonUnRegFileLink);
            this.Controls.Add(this.buttonRegFileLink);
            this.Controls.Add(this.buttonOpenUTAUFile);
            this.Name = "FormRegUst";
            this.Text = "注册文件关联";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenUTAUFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonRegFileLink;
        private System.Windows.Forms.Button buttonUnRegFileLink;
    }
}