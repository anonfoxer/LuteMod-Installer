namespace LuteModInstaller
{
    partial class luteModInstaller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(luteModInstaller));
            this.label1 = new System.Windows.Forms.Label();
            this.pathDisplayBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pathHelpButton = new System.Windows.Forms.Button();
            this.defaultPathCheck = new System.Windows.Forms.CheckBox();
            this.pathBrowseButton = new System.Windows.Forms.Button();
            this.installButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.simpleInstallCheck = new System.Windows.Forms.CheckBox();
            this.installOptsHelp = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Mordhau Path";
            // 
            // pathDisplayBox
            // 
            this.pathDisplayBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.pathDisplayBox.Location = new System.Drawing.Point(10, 39);
            this.pathDisplayBox.Name = "pathDisplayBox";
            this.pathDisplayBox.ReadOnly = true;
            this.pathDisplayBox.Size = new System.Drawing.Size(337, 20);
            this.pathDisplayBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pathHelpButton);
            this.groupBox1.Controls.Add(this.defaultPathCheck);
            this.groupBox1.Controls.Add(this.pathBrowseButton);
            this.groupBox1.Controls.Add(this.pathDisplayBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 124);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Path settings";
            // 
            // pathHelpButton
            // 
            this.pathHelpButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pathHelpButton.Location = new System.Drawing.Point(97, 75);
            this.pathHelpButton.Name = "pathHelpButton";
            this.pathHelpButton.Size = new System.Drawing.Size(75, 39);
            this.pathHelpButton.TabIndex = 4;
            this.pathHelpButton.Text = "Help";
            this.pathHelpButton.UseVisualStyleBackColor = true;
            this.pathHelpButton.Click += new System.EventHandler(this.pathHelpButton_Click);
            // 
            // defaultPathCheck
            // 
            this.defaultPathCheck.AutoSize = true;
            this.defaultPathCheck.Location = new System.Drawing.Point(198, 97);
            this.defaultPathCheck.Name = "defaultPathCheck";
            this.defaultPathCheck.Size = new System.Drawing.Size(149, 17);
            this.defaultPathCheck.TabIndex = 3;
            this.defaultPathCheck.Text = "Use default Mordhau path";
            this.defaultPathCheck.UseVisualStyleBackColor = true;
            this.defaultPathCheck.CheckedChanged += new System.EventHandler(this.defaultPathCheck_CheckedChanged);
            // 
            // pathBrowseButton
            // 
            this.pathBrowseButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pathBrowseButton.Location = new System.Drawing.Point(10, 75);
            this.pathBrowseButton.Name = "pathBrowseButton";
            this.pathBrowseButton.Size = new System.Drawing.Size(75, 39);
            this.pathBrowseButton.TabIndex = 2;
            this.pathBrowseButton.Text = "Browse";
            this.pathBrowseButton.UseVisualStyleBackColor = true;
            this.pathBrowseButton.Click += new System.EventHandler(this.pathBrowseButton_Click);
            // 
            // installButton
            // 
            this.installButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installButton.Location = new System.Drawing.Point(12, 203);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(353, 94);
            this.installButton.TabIndex = 4;
            this.installButton.Text = "Install";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.simpleInstallCheck);
            this.groupBox2.Controls.Add(this.installOptsHelp);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(12, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 55);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Install options";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // simpleInstallCheck
            // 
            this.simpleInstallCheck.AutoSize = true;
            this.simpleInstallCheck.Location = new System.Drawing.Point(10, 24);
            this.simpleInstallCheck.Name = "simpleInstallCheck";
            this.simpleInstallCheck.Size = new System.Drawing.Size(108, 17);
            this.simpleInstallCheck.TabIndex = 5;
            this.simpleInstallCheck.Text = "Ignore modloader";
            this.simpleInstallCheck.UseVisualStyleBackColor = true;
            // 
            // installOptsHelp
            // 
            this.installOptsHelp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.installOptsHelp.Location = new System.Drawing.Point(272, 19);
            this.installOptsHelp.Name = "installOptsHelp";
            this.installOptsHelp.Size = new System.Drawing.Size(75, 23);
            this.installOptsHelp.TabIndex = 4;
            this.installOptsHelp.Text = "Help";
            this.installOptsHelp.UseVisualStyleBackColor = true;
            this.installOptsHelp.Click += new System.EventHandler(this.installOptsHelp_Click_1);
            // 
            // luteModInstaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(372, 307);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.installButton);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "luteModInstaller";
            this.Text = "anonfoxer\'s LuteMod Installer";
            this.Load += new System.EventHandler(this.luteModInstaller_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pathDisplayBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button pathHelpButton;
        private System.Windows.Forms.CheckBox defaultPathCheck;
        private System.Windows.Forms.Button pathBrowseButton;
        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button installOptsHelp;
        private System.Windows.Forms.CheckBox simpleInstallCheck;
    }
}

