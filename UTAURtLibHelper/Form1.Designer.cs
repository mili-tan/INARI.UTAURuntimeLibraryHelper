namespace UTAURtLibHelper
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCOMDLG32 = new System.Windows.Forms.Button();
            this.lbWintypeT = new System.Windows.Forms.Label();
            this.lbWinVer = new System.Windows.Forms.Label();
            this.lbSystemFile = new System.Windows.Forms.Label();
            this.btnMSCOMCTL = new System.Windows.Forms.Button();
            this.timerTest = new System.Windows.Forms.Timer(this.components);
            this.lbCOMDLG32Name = new System.Windows.Forms.Label();
            this.lbCOMDLG32FileOn = new System.Windows.Forms.Label();
            this.lbCOMDLG32RegOn = new System.Windows.Forms.Label();
            this.lbMSCOMCTLRegOn = new System.Windows.Forms.Label();
            this.lbMSCOMCTLFileOn = new System.Windows.Forms.Label();
            this.lbMSCOMCTLName = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnRegSomeThing = new System.Windows.Forms.Button();
            this.btnPatch = new System.Windows.Forms.Button();
            this.btnOneKey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCOMDLG32
            // 
            this.btnCOMDLG32.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCOMDLG32.CausesValidation = false;
            this.btnCOMDLG32.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCOMDLG32.Location = new System.Drawing.Point(24, 193);
            this.btnCOMDLG32.Margin = new System.Windows.Forms.Padding(4);
            this.btnCOMDLG32.Name = "btnCOMDLG32";
            this.btnCOMDLG32.Size = new System.Drawing.Size(292, 35);
            this.btnCOMDLG32.TabIndex = 1;
            this.btnCOMDLG32.TabStop = false;
            this.btnCOMDLG32.Text = "修补 COMDLG32";
            this.btnCOMDLG32.UseVisualStyleBackColor = true;
            this.btnCOMDLG32.Click += new System.EventHandler(this.btnCOMDLG32_Click);
            this.btnCOMDLG32.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCOMDLG32_MouseDown);
            // 
            // lbWintypeT
            // 
            this.lbWintypeT.AutoSize = true;
            this.lbWintypeT.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbWintypeT.Location = new System.Drawing.Point(24, 17);
            this.lbWintypeT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWintypeT.Name = "lbWintypeT";
            this.lbWintypeT.Size = new System.Drawing.Size(123, 20);
            this.lbWintypeT.TabIndex = 1;
            this.lbWintypeT.Text = "操作系统为      位";
            // 
            // lbWinVer
            // 
            this.lbWinVer.AutoSize = true;
            this.lbWinVer.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbWinVer.Location = new System.Drawing.Point(24, 39);
            this.lbWinVer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWinVer.Name = "lbWinVer";
            this.lbWinVer.Size = new System.Drawing.Size(76, 20);
            this.lbWinVer.TabIndex = 3;
            this.lbWinVer.Text = "Windows";
            // 
            // lbSystemFile
            // 
            this.lbSystemFile.AutoSize = true;
            this.lbSystemFile.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSystemFile.Location = new System.Drawing.Point(24, 60);
            this.lbSystemFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSystemFile.Name = "lbSystemFile";
            this.lbSystemFile.Size = new System.Drawing.Size(80, 20);
            this.lbSystemFile.TabIndex = 4;
            this.lbSystemFile.Text = "System32";
            // 
            // btnMSCOMCTL
            // 
            this.btnMSCOMCTL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMSCOMCTL.CausesValidation = false;
            this.btnMSCOMCTL.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMSCOMCTL.Location = new System.Drawing.Point(327, 193);
            this.btnMSCOMCTL.Margin = new System.Windows.Forms.Padding(4);
            this.btnMSCOMCTL.Name = "btnMSCOMCTL";
            this.btnMSCOMCTL.Size = new System.Drawing.Size(290, 35);
            this.btnMSCOMCTL.TabIndex = 2;
            this.btnMSCOMCTL.TabStop = false;
            this.btnMSCOMCTL.Text = "修补 MSCOMCTL";
            this.btnMSCOMCTL.UseVisualStyleBackColor = true;
            this.btnMSCOMCTL.Click += new System.EventHandler(this.btnMSCOMCTL_Click);
            this.btnMSCOMCTL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMSCOMCTL_MouseDown);
            // 
            // timerTest
            // 
            this.timerTest.Enabled = true;
            this.timerTest.Interval = 1000;
            this.timerTest.Tick += new System.EventHandler(this.timerTest_Tick);
            // 
            // lbCOMDLG32Name
            // 
            this.lbCOMDLG32Name.AutoSize = true;
            this.lbCOMDLG32Name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCOMDLG32Name.Location = new System.Drawing.Point(24, 81);
            this.lbCOMDLG32Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCOMDLG32Name.Name = "lbCOMDLG32Name";
            this.lbCOMDLG32Name.Size = new System.Drawing.Size(94, 20);
            this.lbCOMDLG32Name.TabIndex = 6;
            this.lbCOMDLG32Name.Text = "COMDLG32";
            // 
            // lbCOMDLG32FileOn
            // 
            this.lbCOMDLG32FileOn.AutoSize = true;
            this.lbCOMDLG32FileOn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCOMDLG32FileOn.Location = new System.Drawing.Point(123, 80);
            this.lbCOMDLG32FileOn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCOMDLG32FileOn.Name = "lbCOMDLG32FileOn";
            this.lbCOMDLG32FileOn.Size = new System.Drawing.Size(54, 20);
            this.lbCOMDLG32FileOn.TabIndex = 7;
            this.lbCOMDLG32FileOn.Text = "未存在";
            // 
            // lbCOMDLG32RegOn
            // 
            this.lbCOMDLG32RegOn.AutoSize = true;
            this.lbCOMDLG32RegOn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCOMDLG32RegOn.Location = new System.Drawing.Point(181, 80);
            this.lbCOMDLG32RegOn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCOMDLG32RegOn.Name = "lbCOMDLG32RegOn";
            this.lbCOMDLG32RegOn.Size = new System.Drawing.Size(54, 20);
            this.lbCOMDLG32RegOn.TabIndex = 8;
            this.lbCOMDLG32RegOn.Text = "未注册";
            // 
            // lbMSCOMCTLRegOn
            // 
            this.lbMSCOMCTLRegOn.AutoSize = true;
            this.lbMSCOMCTLRegOn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMSCOMCTLRegOn.Location = new System.Drawing.Point(181, 102);
            this.lbMSCOMCTLRegOn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMSCOMCTLRegOn.Name = "lbMSCOMCTLRegOn";
            this.lbMSCOMCTLRegOn.Size = new System.Drawing.Size(54, 20);
            this.lbMSCOMCTLRegOn.TabIndex = 11;
            this.lbMSCOMCTLRegOn.Text = "未注册";
            // 
            // lbMSCOMCTLFileOn
            // 
            this.lbMSCOMCTLFileOn.AutoSize = true;
            this.lbMSCOMCTLFileOn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMSCOMCTLFileOn.Location = new System.Drawing.Point(123, 102);
            this.lbMSCOMCTLFileOn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMSCOMCTLFileOn.Name = "lbMSCOMCTLFileOn";
            this.lbMSCOMCTLFileOn.Size = new System.Drawing.Size(54, 20);
            this.lbMSCOMCTLFileOn.TabIndex = 10;
            this.lbMSCOMCTLFileOn.Text = "未存在";
            // 
            // lbMSCOMCTLName
            // 
            this.lbMSCOMCTLName.AutoSize = true;
            this.lbMSCOMCTLName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMSCOMCTLName.Location = new System.Drawing.Point(24, 102);
            this.lbMSCOMCTLName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMSCOMCTLName.Name = "lbMSCOMCTLName";
            this.lbMSCOMCTLName.Size = new System.Drawing.Size(97, 20);
            this.lbMSCOMCTLName.TabIndex = 9;
            this.lbMSCOMCTLName.Text = "MSCOMCTL";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnRegSomeThing
            // 
            this.btnRegSomeThing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegSomeThing.CausesValidation = false;
            this.btnRegSomeThing.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRegSomeThing.Location = new System.Drawing.Point(24, 278);
            this.btnRegSomeThing.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegSomeThing.Name = "btnRegSomeThing";
            this.btnRegSomeThing.Size = new System.Drawing.Size(593, 35);
            this.btnRegSomeThing.TabIndex = 4;
            this.btnRegSomeThing.TabStop = false;
            this.btnRegSomeThing.Text = "自行修补";
            this.btnRegSomeThing.UseVisualStyleBackColor = true;
            this.btnRegSomeThing.Click += new System.EventHandler(this.btnRegSomeThing_Click);
            // 
            // btnPatch
            // 
            this.btnPatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPatch.CausesValidation = false;
            this.btnPatch.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPatch.Location = new System.Drawing.Point(24, 236);
            this.btnPatch.Margin = new System.Windows.Forms.Padding(4);
            this.btnPatch.Name = "btnPatch";
            this.btnPatch.Size = new System.Drawing.Size(593, 35);
            this.btnPatch.TabIndex = 3;
            this.btnPatch.TabStop = false;
            this.btnPatch.Text = "其他常见缺失文件修补";
            this.btnPatch.UseVisualStyleBackColor = true;
            this.btnPatch.Click += new System.EventHandler(this.btnPatch_Click);
            // 
            // btnOneKey
            // 
            this.btnOneKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOneKey.CausesValidation = false;
            this.btnOneKey.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOneKey.Location = new System.Drawing.Point(24, 150);
            this.btnOneKey.Margin = new System.Windows.Forms.Padding(4);
            this.btnOneKey.Name = "btnOneKey";
            this.btnOneKey.Size = new System.Drawing.Size(593, 35);
            this.btnOneKey.TabIndex = 0;
            this.btnOneKey.TabStop = false;
            this.btnOneKey.Text = "交给我吧";
            this.btnOneKey.UseVisualStyleBackColor = true;
            this.btnOneKey.Click += new System.EventHandler(this.btnOneKey_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 333);
            this.Controls.Add(this.btnPatch);
            this.Controls.Add(this.btnRegSomeThing);
            this.Controls.Add(this.btnOneKey);
            this.Controls.Add(this.lbMSCOMCTLRegOn);
            this.Controls.Add(this.lbMSCOMCTLFileOn);
            this.Controls.Add(this.lbMSCOMCTLName);
            this.Controls.Add(this.lbCOMDLG32RegOn);
            this.Controls.Add(this.lbCOMDLG32FileOn);
            this.Controls.Add(this.lbCOMDLG32Name);
            this.Controls.Add(this.btnMSCOMCTL);
            this.Controls.Add(this.lbSystemFile);
            this.Controls.Add(this.lbWinVer);
            this.Controls.Add(this.lbWintypeT);
            this.Controls.Add(this.btnCOMDLG32);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UTAU Runtime Library Helper 2.3.2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCOMDLG32;
        private System.Windows.Forms.Label lbWintypeT;
        private System.Windows.Forms.Label lbWinVer;
        private System.Windows.Forms.Label lbSystemFile;
        private System.Windows.Forms.Button btnMSCOMCTL;
        private System.Windows.Forms.Timer timerTest;
        private System.Windows.Forms.Label lbCOMDLG32Name;
        private System.Windows.Forms.Label lbCOMDLG32FileOn;
        private System.Windows.Forms.Label lbCOMDLG32RegOn;
        private System.Windows.Forms.Label lbMSCOMCTLRegOn;
        private System.Windows.Forms.Label lbMSCOMCTLFileOn;
        private System.Windows.Forms.Label lbMSCOMCTLName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnRegSomeThing;
        private System.Windows.Forms.Button btnPatch;
        private System.Windows.Forms.Button btnOneKey;
    }
}

