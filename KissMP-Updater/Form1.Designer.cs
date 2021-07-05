
namespace KissMP_Updater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn1SelectUserFolder = new System.Windows.Forms.Button();
            this.l1PathLabelUF = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.rtb2ProgressText = new System.Windows.Forms.RichTextBox();
            this.pb2ProgressBar = new System.Windows.Forms.ProgressBar();
            this.gbStage2 = new System.Windows.Forms.GroupBox();
            this.gbStage1 = new System.Windows.Forms.GroupBox();
            this.btnNotSteam = new System.Windows.Forms.Button();
            this.lNotSteam = new System.Windows.Forms.Label();
            this.tbNotSteam = new System.Windows.Forms.TextBox();
            this.cbSteam = new System.Windows.Forms.CheckBox();
            this.cbShortStart = new System.Windows.Forms.CheckBox();
            this.cbShortDesktop = new System.Windows.Forms.CheckBox();
            this.l1PathBR = new System.Windows.Forms.TextBox();
            this.btn1SelectBridgeInstallDir = new System.Windows.Forms.Button();
            this.l1PathLabelBR = new System.Windows.Forms.Label();
            this.l1PathUF = new System.Windows.Forms.TextBox();
            this.gbControls = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbStage3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.gbStage2.SuspendLayout();
            this.gbStage1.SuspendLayout();
            this.gbControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbStage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn1SelectUserFolder
            // 
            this.btn1SelectUserFolder.Location = new System.Drawing.Point(10, 19);
            this.btn1SelectUserFolder.Name = "btn1SelectUserFolder";
            this.btn1SelectUserFolder.Size = new System.Drawing.Size(255, 23);
            this.btn1SelectUserFolder.TabIndex = 3;
            this.btn1SelectUserFolder.Text = "Select BeamNG.drive User Folder";
            this.btn1SelectUserFolder.UseVisualStyleBackColor = true;
            this.btn1SelectUserFolder.Click += new System.EventHandler(this.button1_Click);
            // 
            // l1PathLabelUF
            // 
            this.l1PathLabelUF.AutoSize = true;
            this.l1PathLabelUF.Location = new System.Drawing.Point(7, 51);
            this.l1PathLabelUF.Name = "l1PathLabelUF";
            this.l1PathLabelUF.Size = new System.Drawing.Size(76, 13);
            this.l1PathLabelUF.TabIndex = 4;
            this.l1PathLabelUF.Text = "Selected path:";
            // 
            // btnContinue
            // 
            this.btnContinue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContinue.Enabled = false;
            this.btnContinue.Location = new System.Drawing.Point(268, 15);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(85, 22);
            this.btnContinue.TabIndex = 6;
            this.btnContinue.Text = "Next -->";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(13, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 22);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(184, 15);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(79, 22);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "<-- Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // rtb2ProgressText
            // 
            this.rtb2ProgressText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb2ProgressText.Location = new System.Drawing.Point(12, 51);
            this.rtb2ProgressText.Name = "rtb2ProgressText";
            this.rtb2ProgressText.ReadOnly = true;
            this.rtb2ProgressText.Size = new System.Drawing.Size(296, 111);
            this.rtb2ProgressText.TabIndex = 9;
            this.rtb2ProgressText.Text = "";
            this.rtb2ProgressText.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
            // 
            // pb2ProgressBar
            // 
            this.pb2ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb2ProgressBar.Location = new System.Drawing.Point(12, 22);
            this.pb2ProgressBar.Name = "pb2ProgressBar";
            this.pb2ProgressBar.Size = new System.Drawing.Size(296, 23);
            this.pb2ProgressBar.TabIndex = 10;
            // 
            // gbStage2
            // 
            this.gbStage2.Controls.Add(this.pb2ProgressBar);
            this.gbStage2.Controls.Add(this.rtb2ProgressText);
            this.gbStage2.Location = new System.Drawing.Point(202, 492);
            this.gbStage2.Name = "gbStage2";
            this.gbStage2.Size = new System.Drawing.Size(313, 201);
            this.gbStage2.TabIndex = 11;
            this.gbStage2.TabStop = false;
            this.gbStage2.Text = "stage2";
            this.gbStage2.Visible = false;
            // 
            // gbStage1
            // 
            this.gbStage1.Controls.Add(this.btnNotSteam);
            this.gbStage1.Controls.Add(this.lNotSteam);
            this.gbStage1.Controls.Add(this.tbNotSteam);
            this.gbStage1.Controls.Add(this.cbSteam);
            this.gbStage1.Controls.Add(this.cbShortStart);
            this.gbStage1.Controls.Add(this.cbShortDesktop);
            this.gbStage1.Controls.Add(this.l1PathBR);
            this.gbStage1.Controls.Add(this.btn1SelectBridgeInstallDir);
            this.gbStage1.Controls.Add(this.l1PathLabelBR);
            this.gbStage1.Controls.Add(this.l1PathUF);
            this.gbStage1.Controls.Add(this.btn1SelectUserFolder);
            this.gbStage1.Controls.Add(this.l1PathLabelUF);
            this.gbStage1.Location = new System.Drawing.Point(269, 463);
            this.gbStage1.Name = "gbStage1";
            this.gbStage1.Size = new System.Drawing.Size(312, 344);
            this.gbStage1.TabIndex = 12;
            this.gbStage1.TabStop = false;
            this.gbStage1.Text = "stage1";
            this.gbStage1.Visible = false;
            // 
            // btnNotSteam
            // 
            this.btnNotSteam.Location = new System.Drawing.Point(146, 228);
            this.btnNotSteam.Name = "btnNotSteam";
            this.btnNotSteam.Size = new System.Drawing.Size(130, 23);
            this.btnNotSteam.TabIndex = 20;
            this.btnNotSteam.Text = "Select game exe file";
            this.btnNotSteam.UseVisualStyleBackColor = true;
            this.btnNotSteam.Visible = false;
            this.btnNotSteam.Click += new System.EventHandler(this.btnNotSteam_Click);
            // 
            // lNotSteam
            // 
            this.lNotSteam.AutoSize = true;
            this.lNotSteam.Location = new System.Drawing.Point(7, 233);
            this.lNotSteam.Name = "lNotSteam";
            this.lNotSteam.Size = new System.Drawing.Size(133, 13);
            this.lNotSteam.TabIndex = 19;
            this.lNotSteam.Text = "Path to BeamNG.drive.exe";
            this.lNotSteam.Visible = false;
            // 
            // tbNotSteam
            // 
            this.tbNotSteam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNotSteam.Location = new System.Drawing.Point(10, 253);
            this.tbNotSteam.Name = "tbNotSteam";
            this.tbNotSteam.Size = new System.Drawing.Size(296, 20);
            this.tbNotSteam.TabIndex = 18;
            this.tbNotSteam.Visible = false;
            // 
            // cbSteam
            // 
            this.cbSteam.AutoSize = true;
            this.cbSteam.Checked = true;
            this.cbSteam.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSteam.Location = new System.Drawing.Point(10, 198);
            this.cbSteam.Name = "cbSteam";
            this.cbSteam.Size = new System.Drawing.Size(207, 17);
            this.cbSteam.TabIndex = 17;
            this.cbSteam.Text = "Do you own BeamNG.drive on steam?";
            this.cbSteam.UseVisualStyleBackColor = true;
            this.cbSteam.CheckedChanged += new System.EventHandler(this.cbSteam_CheckedChanged);
            // 
            // cbShortStart
            // 
            this.cbShortStart.AutoSize = true;
            this.cbShortStart.Enabled = false;
            this.cbShortStart.Location = new System.Drawing.Point(10, 175);
            this.cbShortStart.Name = "cbShortStart";
            this.cbShortStart.Size = new System.Drawing.Size(153, 17);
            this.cbShortStart.TabIndex = 16;
            this.cbShortStart.Text = "Add shortcut to Start Menu";
            this.cbShortStart.UseVisualStyleBackColor = true;
            // 
            // cbShortDesktop
            // 
            this.cbShortDesktop.AutoSize = true;
            this.cbShortDesktop.Checked = true;
            this.cbShortDesktop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShortDesktop.Location = new System.Drawing.Point(10, 152);
            this.cbShortDesktop.Name = "cbShortDesktop";
            this.cbShortDesktop.Size = new System.Drawing.Size(156, 17);
            this.cbShortDesktop.TabIndex = 15;
            this.cbShortDesktop.Text = "Create shortcut on Desktop";
            this.cbShortDesktop.UseVisualStyleBackColor = true;
            // 
            // l1PathBR
            // 
            this.l1PathBR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l1PathBR.Location = new System.Drawing.Point(82, 113);
            this.l1PathBR.Name = "l1PathBR";
            this.l1PathBR.Size = new System.Drawing.Size(224, 20);
            this.l1PathBR.TabIndex = 9;
            this.l1PathBR.TextChanged += new System.EventHandler(this.l1PathBR_TextChanged);
            // 
            // btn1SelectBridgeInstallDir
            // 
            this.btn1SelectBridgeInstallDir.Location = new System.Drawing.Point(10, 84);
            this.btn1SelectBridgeInstallDir.Name = "btn1SelectBridgeInstallDir";
            this.btn1SelectBridgeInstallDir.Size = new System.Drawing.Size(255, 23);
            this.btn1SelectBridgeInstallDir.TabIndex = 7;
            this.btn1SelectBridgeInstallDir.Text = "Select Bridge install location";
            this.btn1SelectBridgeInstallDir.UseVisualStyleBackColor = true;
            this.btn1SelectBridgeInstallDir.Click += new System.EventHandler(this.btn1SelectBridgeInstallDir_Click);
            // 
            // l1PathLabelBR
            // 
            this.l1PathLabelBR.AutoSize = true;
            this.l1PathLabelBR.Location = new System.Drawing.Point(7, 116);
            this.l1PathLabelBR.Name = "l1PathLabelBR";
            this.l1PathLabelBR.Size = new System.Drawing.Size(76, 13);
            this.l1PathLabelBR.TabIndex = 8;
            this.l1PathLabelBR.Text = "Selected path:";
            // 
            // l1PathUF
            // 
            this.l1PathUF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l1PathUF.Location = new System.Drawing.Point(82, 48);
            this.l1PathUF.Name = "l1PathUF";
            this.l1PathUF.Size = new System.Drawing.Size(224, 20);
            this.l1PathUF.TabIndex = 6;
            this.l1PathUF.TextChanged += new System.EventHandler(this.l1PathBR_TextChanged);
            // 
            // gbControls
            // 
            this.gbControls.Controls.Add(this.btnBack);
            this.gbControls.Controls.Add(this.btnContinue);
            this.gbControls.Controls.Add(this.btnCancel);
            this.gbControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbControls.Location = new System.Drawing.Point(0, 533);
            this.gbControls.Name = "gbControls";
            this.gbControls.Size = new System.Drawing.Size(364, 48);
            this.gbControls.TabIndex = 13;
            this.gbControls.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::KissMP_Updater.Properties.Resources.kissMpLogo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // gbStage3
            // 
            this.gbStage3.Controls.Add(this.linkLabel5);
            this.gbStage3.Controls.Add(this.linkLabel4);
            this.gbStage3.Controls.Add(this.label3);
            this.gbStage3.Controls.Add(this.label2);
            this.gbStage3.Controls.Add(this.linkLabel3);
            this.gbStage3.Controls.Add(this.linkLabel2);
            this.gbStage3.Controls.Add(this.linkLabel1);
            this.gbStage3.Controls.Add(this.label1);
            this.gbStage3.Location = new System.Drawing.Point(66, 159);
            this.gbStage3.Name = "gbStage3";
            this.gbStage3.Size = new System.Drawing.Size(287, 245);
            this.gbStage3.TabIndex = 14;
            this.gbStage3.TabStop = false;
            this.gbStage3.Text = "stage3";
            this.gbStage3.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thank you for installing KissMP.";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(31, 91);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(84, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "KissMP Website";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(31, 116);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(81, 13);
            this.linkLabel2.TabIndex = 2;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "KissMP Discord";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(31, 141);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(78, 13);
            this.linkLabel3.TabIndex = 3;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "KissMP GitHub";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(23, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "bridge via the shortcut on the desktop.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(23, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "You can now launch the game and ";
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(31, 166);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(146, 13);
            this.linkLabel4.TabIndex = 6;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Support KissMP development";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Location = new System.Drawing.Point(31, 191);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(79, 13);
            this.linkLabel5.TabIndex = 7;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Documentation";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 581);
            this.Controls.Add(this.gbStage3);
            this.Controls.Add(this.gbControls);
            this.Controls.Add(this.gbStage2);
            this.Controls.Add(this.gbStage1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "KissMP Installer [Unofficial]";
            this.gbStage2.ResumeLayout(false);
            this.gbStage1.ResumeLayout(false);
            this.gbStage1.PerformLayout();
            this.gbControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbStage3.ResumeLayout(false);
            this.gbStage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn1SelectUserFolder;
        private System.Windows.Forms.Label l1PathLabelUF;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RichTextBox rtb2ProgressText;
        private System.Windows.Forms.ProgressBar pb2ProgressBar;
        private System.Windows.Forms.GroupBox gbStage2;
        private System.Windows.Forms.GroupBox gbStage1;
        private System.Windows.Forms.GroupBox gbControls;
        private System.Windows.Forms.TextBox l1PathUF;
        private System.Windows.Forms.TextBox l1PathBR;
        private System.Windows.Forms.Button btn1SelectBridgeInstallDir;
        private System.Windows.Forms.Label l1PathLabelBR;
        private System.Windows.Forms.CheckBox cbShortStart;
        private System.Windows.Forms.CheckBox cbShortDesktop;
        private System.Windows.Forms.Button btnNotSteam;
        private System.Windows.Forms.Label lNotSteam;
        private System.Windows.Forms.TextBox tbNotSteam;
        private System.Windows.Forms.CheckBox cbSteam;
        private System.Windows.Forms.GroupBox gbStage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel5;
    }
}

