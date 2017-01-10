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
            this.btnOpenUTAUFile = new System.Windows.Forms.Button();
            this.lbUTAUFile = new System.Windows.Forms.Label();
            this.lbUTAUVer = new System.Windows.Forms.Label();
            this.btnRegSomeThing = new System.Windows.Forms.Button();
            this.btnResetUTAU = new System.Windows.Forms.Button();
            this.btnPatch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCOMDLG32
            // 
            this.btnCOMDLG32.CausesValidation = false;
            this.btnCOMDLG32.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCOMDLG32.Location = new System.Drawing.Point(18, 201);
            this.btnCOMDLG32.Name = "btnCOMDLG32";
            this.btnCOMDLG32.Size = new System.Drawing.Size(221, 28);
            this.btnCOMDLG32.TabIndex = 1;
            this.btnCOMDLG32.TabStop = false;
            this.btnCOMDLG32.Text = "修补 COMDLG32";
            this.btnCOMDLG32.UseVisualStyleBackColor = true;
            this.btnCOMDLG32.Click += new System.EventHandler(this.btnCOMDLG32_Click);
            // 
            // lbWintypeT
            // 
            this.lbWintypeT.AutoSize = true;
            this.lbWintypeT.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbWintypeT.Location = new System.Drawing.Point(9, 13);
            this.lbWintypeT.Name = "lbWintypeT";
            this.lbWintypeT.Size = new System.Drawing.Size(104, 17);
            this.lbWintypeT.TabIndex = 1;
            this.lbWintypeT.Text = "操作系统为      位";
            // 
            // lbWinVer
            // 
            this.lbWinVer.AutoSize = true;
            this.lbWinVer.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbWinVer.Location = new System.Drawing.Point(9, 30);
            this.lbWinVer.Name = "lbWinVer";
            this.lbWinVer.Size = new System.Drawing.Size(59, 17);
            this.lbWinVer.TabIndex = 3;
            this.lbWinVer.Text = "Windows";
            // 
            // lbSystemFile
            // 
            this.lbSystemFile.AutoSize = true;
            this.lbSystemFile.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSystemFile.Location = new System.Drawing.Point(9, 47);
            this.lbSystemFile.Name = "lbSystemFile";
            this.lbSystemFile.Size = new System.Drawing.Size(61, 17);
            this.lbSystemFile.TabIndex = 4;
            this.lbSystemFile.Text = "System32";
            // 
            // btnMSCOMCTL
            // 
            this.btnMSCOMCTL.CausesValidation = false;
            this.btnMSCOMCTL.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMSCOMCTL.Location = new System.Drawing.Point(245, 201);
            this.btnMSCOMCTL.Name = "btnMSCOMCTL";
            this.btnMSCOMCTL.Size = new System.Drawing.Size(220, 28);
            this.btnMSCOMCTL.TabIndex = 2;
            this.btnMSCOMCTL.TabStop = false;
            this.btnMSCOMCTL.Text = "修补 MSCOMCTL";
            this.btnMSCOMCTL.UseVisualStyleBackColor = true;
            this.btnMSCOMCTL.Click += new System.EventHandler(this.btnMSCOMCTL_Click);
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
            this.lbCOMDLG32Name.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCOMDLG32Name.Location = new System.Drawing.Point(9, 64);
            this.lbCOMDLG32Name.Name = "lbCOMDLG32Name";
            this.lbCOMDLG32Name.Size = new System.Drawing.Size(75, 17);
            this.lbCOMDLG32Name.TabIndex = 6;
            this.lbCOMDLG32Name.Text = "COMDLG32";
            // 
            // lbCOMDLG32FileOn
            // 
            this.lbCOMDLG32FileOn.AutoSize = true;
            this.lbCOMDLG32FileOn.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCOMDLG32FileOn.Location = new System.Drawing.Point(83, 63);
            this.lbCOMDLG32FileOn.Name = "lbCOMDLG32FileOn";
            this.lbCOMDLG32FileOn.Size = new System.Drawing.Size(44, 17);
            this.lbCOMDLG32FileOn.TabIndex = 7;
            this.lbCOMDLG32FileOn.Text = "未存在";
            // 
            // lbCOMDLG32RegOn
            // 
            this.lbCOMDLG32RegOn.AutoSize = true;
            this.lbCOMDLG32RegOn.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCOMDLG32RegOn.Location = new System.Drawing.Point(127, 63);
            this.lbCOMDLG32RegOn.Name = "lbCOMDLG32RegOn";
            this.lbCOMDLG32RegOn.Size = new System.Drawing.Size(44, 17);
            this.lbCOMDLG32RegOn.TabIndex = 8;
            this.lbCOMDLG32RegOn.Text = "未注册";
            // 
            // lbMSCOMCTLRegOn
            // 
            this.lbMSCOMCTLRegOn.AutoSize = true;
            this.lbMSCOMCTLRegOn.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMSCOMCTLRegOn.Location = new System.Drawing.Point(127, 81);
            this.lbMSCOMCTLRegOn.Name = "lbMSCOMCTLRegOn";
            this.lbMSCOMCTLRegOn.Size = new System.Drawing.Size(44, 17);
            this.lbMSCOMCTLRegOn.TabIndex = 11;
            this.lbMSCOMCTLRegOn.Text = "未注册";
            // 
            // lbMSCOMCTLFileOn
            // 
            this.lbMSCOMCTLFileOn.AutoSize = true;
            this.lbMSCOMCTLFileOn.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMSCOMCTLFileOn.Location = new System.Drawing.Point(83, 81);
            this.lbMSCOMCTLFileOn.Name = "lbMSCOMCTLFileOn";
            this.lbMSCOMCTLFileOn.Size = new System.Drawing.Size(44, 17);
            this.lbMSCOMCTLFileOn.TabIndex = 10;
            this.lbMSCOMCTLFileOn.Text = "未存在";
            // 
            // lbMSCOMCTLName
            // 
            this.lbMSCOMCTLName.AutoSize = true;
            this.lbMSCOMCTLName.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMSCOMCTLName.Location = new System.Drawing.Point(9, 81);
            this.lbMSCOMCTLName.Name = "lbMSCOMCTLName";
            this.lbMSCOMCTLName.Size = new System.Drawing.Size(75, 17);
            this.lbMSCOMCTLName.TabIndex = 9;
            this.lbMSCOMCTLName.Text = "MSCOMCTL";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOpenUTAUFile
            // 
            this.btnOpenUTAUFile.CausesValidation = false;
            this.btnOpenUTAUFile.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenUTAUFile.Location = new System.Drawing.Point(18, 167);
            this.btnOpenUTAUFile.Name = "btnOpenUTAUFile";
            this.btnOpenUTAUFile.Size = new System.Drawing.Size(447, 28);
            this.btnOpenUTAUFile.TabIndex = 0;
            this.btnOpenUTAUFile.TabStop = false;
            this.btnOpenUTAUFile.Text = "打开UTAU程序目录";
            this.btnOpenUTAUFile.UseVisualStyleBackColor = true;
            this.btnOpenUTAUFile.Click += new System.EventHandler(this.btnOpenUTAUFile_Click);
            // 
            // lbUTAUFile
            // 
            this.lbUTAUFile.AutoSize = true;
            this.lbUTAUFile.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbUTAUFile.Location = new System.Drawing.Point(9, 98);
            this.lbUTAUFile.Name = "lbUTAUFile";
            this.lbUTAUFile.Size = new System.Drawing.Size(87, 17);
            this.lbUTAUFile.TabIndex = 13;
            this.lbUTAUFile.Text = "UTAU程序位置";
            // 
            // lbUTAUVer
            // 
            this.lbUTAUVer.AutoSize = true;
            this.lbUTAUVer.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbUTAUVer.Location = new System.Drawing.Point(9, 115);
            this.lbUTAUVer.Name = "lbUTAUVer";
            this.lbUTAUVer.Size = new System.Drawing.Size(87, 17);
            this.lbUTAUVer.TabIndex = 14;
            this.lbUTAUVer.Text = "UTAU程序版本";
            // 
            // btnRegSomeThing
            // 
            this.btnRegSomeThing.CausesValidation = false;
            this.btnRegSomeThing.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRegSomeThing.Location = new System.Drawing.Point(19, 269);
            this.btnRegSomeThing.Name = "btnRegSomeThing";
            this.btnRegSomeThing.Size = new System.Drawing.Size(221, 28);
            this.btnRegSomeThing.TabIndex = 4;
            this.btnRegSomeThing.TabStop = false;
            this.btnRegSomeThing.Text = "自行修补";
            this.btnRegSomeThing.UseVisualStyleBackColor = true;
            this.btnRegSomeThing.Click += new System.EventHandler(this.btnRegSomeThing_Click);
            // 
            // btnResetUTAU
            // 
            this.btnResetUTAU.CausesValidation = false;
            this.btnResetUTAU.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnResetUTAU.Location = new System.Drawing.Point(245, 269);
            this.btnResetUTAU.Name = "btnResetUTAU";
            this.btnResetUTAU.Size = new System.Drawing.Size(221, 28);
            this.btnResetUTAU.TabIndex = 5;
            this.btnResetUTAU.TabStop = false;
            this.btnResetUTAU.Text = "重置UTAU配置文件";
            this.btnResetUTAU.UseVisualStyleBackColor = true;
            this.btnResetUTAU.Click += new System.EventHandler(this.btnResetUTAU_Click);
            // 
            // btnPatch
            // 
            this.btnPatch.CausesValidation = false;
            this.btnPatch.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPatch.Location = new System.Drawing.Point(18, 235);
            this.btnPatch.Name = "btnPatch";
            this.btnPatch.Size = new System.Drawing.Size(447, 28);
            this.btnPatch.TabIndex = 3;
            this.btnPatch.TabStop = false;
            this.btnPatch.Text = "其他文件修补";
            this.btnPatch.UseVisualStyleBackColor = true;
            this.btnPatch.Click += new System.EventHandler(this.btnPatch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.btnPatch);
            this.Controls.Add(this.btnResetUTAU);
            this.Controls.Add(this.btnRegSomeThing);
            this.Controls.Add(this.lbUTAUVer);
            this.Controls.Add(this.lbUTAUFile);
            this.Controls.Add(this.btnOpenUTAUFile);
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
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UTAU Runtime Library Helper 0.1";
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
        private System.Windows.Forms.Button btnOpenUTAUFile;
        private System.Windows.Forms.Label lbUTAUFile;
        private System.Windows.Forms.Label lbUTAUVer;
        private System.Windows.Forms.Button btnRegSomeThing;
        private System.Windows.Forms.Button btnResetUTAU;
        private System.Windows.Forms.Button btnPatch;
    }
}

