namespace EZAudioSwitcher
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OutputDropdown = new System.Windows.Forms.ComboBox();
            this.InputDropdown = new System.Windows.Forms.ComboBox();
            this.OutputDLabel = new System.Windows.Forms.Label();
            this.InputDLabel = new System.Windows.Forms.Label();
            this.OutputSetDefault = new System.Windows.Forms.Button();
            this.OutputSetComDefault = new System.Windows.Forms.Button();
            this.InputSetDefault = new System.Windows.Forms.Button();
            this.InputSetComDefault = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.MinimizeToTray = new System.Windows.Forms.Button();
            this.thisNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DefaultOutputLabel = new System.Windows.Forms.Label();
            this.DefaultOutputComLabel = new System.Windows.Forms.Label();
            this.DefaultInputComLabel = new System.Windows.Forms.Label();
            this.DefaultInputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OutputDropdown
            // 
            this.OutputDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.OutputDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OutputDropdown.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.OutputDropdown.FormattingEnabled = true;
            this.OutputDropdown.Location = new System.Drawing.Point(48, 123);
            this.OutputDropdown.Name = "OutputDropdown";
            this.OutputDropdown.Size = new System.Drawing.Size(275, 21);
            this.OutputDropdown.TabIndex = 0;
            // 
            // InputDropdown
            // 
            this.InputDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.InputDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InputDropdown.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.InputDropdown.FormattingEnabled = true;
            this.InputDropdown.Location = new System.Drawing.Point(363, 123);
            this.InputDropdown.Name = "InputDropdown";
            this.InputDropdown.Size = new System.Drawing.Size(275, 21);
            this.InputDropdown.TabIndex = 1;
            // 
            // OutputDLabel
            // 
            this.OutputDLabel.AutoSize = true;
            this.OutputDLabel.BackColor = System.Drawing.Color.Transparent;
            this.OutputDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputDLabel.ForeColor = System.Drawing.Color.White;
            this.OutputDLabel.Location = new System.Drawing.Point(105, 84);
            this.OutputDLabel.Name = "OutputDLabel";
            this.OutputDLabel.Size = new System.Drawing.Size(142, 24);
            this.OutputDLabel.TabIndex = 2;
            this.OutputDLabel.Text = "Output Device";
            // 
            // InputDLabel
            // 
            this.InputDLabel.AutoSize = true;
            this.InputDLabel.BackColor = System.Drawing.Color.Transparent;
            this.InputDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputDLabel.ForeColor = System.Drawing.Color.White;
            this.InputDLabel.Location = new System.Drawing.Point(436, 84);
            this.InputDLabel.Name = "InputDLabel";
            this.InputDLabel.Size = new System.Drawing.Size(126, 24);
            this.InputDLabel.TabIndex = 3;
            this.InputDLabel.Text = "Input Device";
            // 
            // OutputSetDefault
            // 
            this.OutputSetDefault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.OutputSetDefault.ForeColor = System.Drawing.Color.White;
            this.OutputSetDefault.Location = new System.Drawing.Point(48, 169);
            this.OutputSetDefault.Name = "OutputSetDefault";
            this.OutputSetDefault.Size = new System.Drawing.Size(130, 23);
            this.OutputSetDefault.TabIndex = 4;
            this.OutputSetDefault.Text = "Default";
            this.OutputSetDefault.UseVisualStyleBackColor = false;
            this.OutputSetDefault.Click += new System.EventHandler(this.OutputSetDefault_Click);
            // 
            // OutputSetComDefault
            // 
            this.OutputSetComDefault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.OutputSetComDefault.ForeColor = System.Drawing.Color.White;
            this.OutputSetComDefault.Location = new System.Drawing.Point(194, 169);
            this.OutputSetComDefault.Name = "OutputSetComDefault";
            this.OutputSetComDefault.Size = new System.Drawing.Size(130, 23);
            this.OutputSetComDefault.TabIndex = 5;
            this.OutputSetComDefault.Text = "Communication";
            this.OutputSetComDefault.UseVisualStyleBackColor = false;
            this.OutputSetComDefault.Click += new System.EventHandler(this.OutputSetComDefault_Click);
            // 
            // InputSetDefault
            // 
            this.InputSetDefault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.InputSetDefault.ForeColor = System.Drawing.Color.White;
            this.InputSetDefault.Location = new System.Drawing.Point(363, 169);
            this.InputSetDefault.Name = "InputSetDefault";
            this.InputSetDefault.Size = new System.Drawing.Size(130, 23);
            this.InputSetDefault.TabIndex = 6;
            this.InputSetDefault.Text = "Default";
            this.InputSetDefault.UseVisualStyleBackColor = false;
            this.InputSetDefault.Click += new System.EventHandler(this.InputSetDefault_Click);
            // 
            // InputSetComDefault
            // 
            this.InputSetComDefault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.InputSetComDefault.ForeColor = System.Drawing.Color.White;
            this.InputSetComDefault.Location = new System.Drawing.Point(507, 169);
            this.InputSetComDefault.Name = "InputSetComDefault";
            this.InputSetComDefault.Size = new System.Drawing.Size(130, 23);
            this.InputSetComDefault.TabIndex = 7;
            this.InputSetComDefault.Text = "Communication";
            this.InputSetComDefault.UseVisualStyleBackColor = false;
            this.InputSetComDefault.Click += new System.EventHandler(this.InputSetComDefault_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.QuitButton.Font = new System.Drawing.Font("TYPOGRAPH PRO", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitButton.ForeColor = System.Drawing.Color.White;
            this.QuitButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.QuitButton.Location = new System.Drawing.Point(653, 12);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(34, 23);
            this.QuitButton.TabIndex = 10;
            this.QuitButton.Text = "X";
            this.QuitButton.UseVisualStyleBackColor = false;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.MinimizeButton.Font = new System.Drawing.Font("TYPOGRAPH PRO", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MinimizeButton.Location = new System.Drawing.Point(613, 12);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(34, 23);
            this.MinimizeButton.TabIndex = 11;
            this.MinimizeButton.Text = "_";
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // MinimizeToTray
            // 
            this.MinimizeToTray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.MinimizeToTray.Font = new System.Drawing.Font("TYPOGRAPH PRO", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeToTray.ForeColor = System.Drawing.Color.White;
            this.MinimizeToTray.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MinimizeToTray.Location = new System.Drawing.Point(573, 12);
            this.MinimizeToTray.Name = "MinimizeToTray";
            this.MinimizeToTray.Size = new System.Drawing.Size(34, 23);
            this.MinimizeToTray.TabIndex = 12;
            this.MinimizeToTray.Text = "↓";
            this.MinimizeToTray.UseVisualStyleBackColor = false;
            this.MinimizeToTray.Click += new System.EventHandler(this.MinimizeToTray_Click);
            // 
            // thisNotifyIcon
            // 
            this.thisNotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.thisNotifyIcon.BalloonTipText = "I\'m still here";
            this.thisNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("thisNotifyIcon.Icon")));
            this.thisNotifyIcon.Text = "EZAudioSwitcher";
            this.thisNotifyIcon.Visible = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(125, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Default Device:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(125, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Communication:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(437, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Communication:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(437, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Default Device:";
            // 
            // DefaultOutputLabel
            // 
            this.DefaultOutputLabel.AutoEllipsis = true;
            this.DefaultOutputLabel.BackColor = System.Drawing.Color.Transparent;
            this.DefaultOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DefaultOutputLabel.ForeColor = System.Drawing.Color.White;
            this.DefaultOutputLabel.Location = new System.Drawing.Point(45, 249);
            this.DefaultOutputLabel.Name = "DefaultOutputLabel";
            this.DefaultOutputLabel.Size = new System.Drawing.Size(278, 13);
            this.DefaultOutputLabel.TabIndex = 17;
            this.DefaultOutputLabel.Text = "Device";
            this.DefaultOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DefaultOutputComLabel
            // 
            this.DefaultOutputComLabel.BackColor = System.Drawing.Color.Transparent;
            this.DefaultOutputComLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DefaultOutputComLabel.ForeColor = System.Drawing.Color.White;
            this.DefaultOutputComLabel.Location = new System.Drawing.Point(45, 289);
            this.DefaultOutputComLabel.Name = "DefaultOutputComLabel";
            this.DefaultOutputComLabel.Size = new System.Drawing.Size(278, 17);
            this.DefaultOutputComLabel.TabIndex = 18;
            this.DefaultOutputComLabel.Text = "Device";
            this.DefaultOutputComLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DefaultInputComLabel
            // 
            this.DefaultInputComLabel.BackColor = System.Drawing.Color.Transparent;
            this.DefaultInputComLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DefaultInputComLabel.ForeColor = System.Drawing.Color.White;
            this.DefaultInputComLabel.Location = new System.Drawing.Point(363, 289);
            this.DefaultInputComLabel.Name = "DefaultInputComLabel";
            this.DefaultInputComLabel.Size = new System.Drawing.Size(274, 17);
            this.DefaultInputComLabel.TabIndex = 19;
            this.DefaultInputComLabel.Text = "Device";
            this.DefaultInputComLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DefaultInputLabel
            // 
            this.DefaultInputLabel.BackColor = System.Drawing.Color.Transparent;
            this.DefaultInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DefaultInputLabel.ForeColor = System.Drawing.Color.White;
            this.DefaultInputLabel.Location = new System.Drawing.Point(360, 249);
            this.DefaultInputLabel.Name = "DefaultInputLabel";
            this.DefaultInputLabel.Size = new System.Drawing.Size(277, 17);
            this.DefaultInputLabel.TabIndex = 20;
            this.DefaultInputLabel.Text = "Device";
            this.DefaultInputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.DefaultInputLabel);
            this.Controls.Add(this.DefaultInputComLabel);
            this.Controls.Add(this.DefaultOutputComLabel);
            this.Controls.Add(this.DefaultOutputLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MinimizeToTray);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.InputSetComDefault);
            this.Controls.Add(this.InputSetDefault);
            this.Controls.Add(this.OutputSetComDefault);
            this.Controls.Add(this.OutputSetDefault);
            this.Controls.Add(this.InputDLabel);
            this.Controls.Add(this.OutputDLabel);
            this.Controls.Add(this.InputDropdown);
            this.Controls.Add(this.OutputDropdown);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox OutputDropdown;
        private System.Windows.Forms.ComboBox InputDropdown;
        private System.Windows.Forms.Label OutputDLabel;
        private System.Windows.Forms.Label InputDLabel;
        private System.Windows.Forms.Button OutputSetDefault;
        private System.Windows.Forms.Button OutputSetComDefault;
        private System.Windows.Forms.Button InputSetDefault;
        private System.Windows.Forms.Button InputSetComDefault;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button MinimizeToTray;
        private System.Windows.Forms.NotifyIcon thisNotifyIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label DefaultOutputLabel;
        private System.Windows.Forms.Label DefaultOutputComLabel;
        private System.Windows.Forms.Label DefaultInputComLabel;
        private System.Windows.Forms.Label DefaultInputLabel;
    }
}

