namespace WindowsFormsApp5
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
            this.SerialInfo = new System.Windows.Forms.Label();
            this.ConnectionButton = new System.Windows.Forms.Button();
            this.BaseBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.Forearm = new System.Windows.Forms.Label();
            this.ForearmBar = new System.Windows.Forms.TrackBar();
            this.Griper = new System.Windows.Forms.Label();
            this.GripperBar = new System.Windows.Forms.TrackBar();
            this.EventsBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BaseLabel = new System.Windows.Forms.Label();
            this.ForearmLabel = new System.Windows.Forms.Label();
            this.GripperLabel = new System.Windows.Forms.Label();
            this.Helpbutton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Refresh = new System.Windows.Forms.Button();
            this.SendTimer = new System.Windows.Forms.Timer(this.components);
            this.BaseRadio = new System.Windows.Forms.RadioButton();
            this.ForearmRadio = new System.Windows.Forms.RadioButton();
            this.GripperRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.BaseBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForearmBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GripperBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // SerialInfo
            // 
            this.SerialInfo.AutoSize = true;
            this.SerialInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SerialInfo.Location = new System.Drawing.Point(603, 32);
            this.SerialInfo.Name = "SerialInfo";
            this.SerialInfo.Size = new System.Drawing.Size(185, 24);
            this.SerialInfo.TabIndex = 1;
            this.SerialInfo.Text = "No Serial Connected";
            // 
            // ConnectionButton
            // 
            this.ConnectionButton.FlatAppearance.BorderSize = 0;
            this.ConnectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConnectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionButton.Location = new System.Drawing.Point(607, 59);
            this.ConnectionButton.Name = "ConnectionButton";
            this.ConnectionButton.Size = new System.Drawing.Size(181, 28);
            this.ConnectionButton.TabIndex = 2;
            this.ConnectionButton.Text = "Connect";
            this.ConnectionButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ConnectionButton.UseVisualStyleBackColor = true;
            this.ConnectionButton.Click += new System.EventHandler(this.ConnectionButton_Click);
            // 
            // BaseBar
            // 
            this.BaseBar.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BaseBar.Location = new System.Drawing.Point(23, 71);
            this.BaseBar.Maximum = 130;
            this.BaseBar.Name = "BaseBar";
            this.BaseBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.BaseBar.Size = new System.Drawing.Size(45, 367);
            this.BaseBar.TabIndex = 3;
            this.BaseBar.TickFrequency = 15;
            this.BaseBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.BaseBar.ValueChanged += new System.EventHandler(this.BaseBar_ValueChanged);
            this.BaseBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Base";
            // 
            // Forearm
            // 
            this.Forearm.AutoSize = true;
            this.Forearm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forearm.Location = new System.Drawing.Point(152, 16);
            this.Forearm.Name = "Forearm";
            this.Forearm.Size = new System.Drawing.Size(92, 25);
            this.Forearm.TabIndex = 6;
            this.Forearm.Text = "Forearm";
            // 
            // ForearmBar
            // 
            this.ForearmBar.BackColor = System.Drawing.SystemColors.GrayText;
            this.ForearmBar.Location = new System.Drawing.Point(189, 71);
            this.ForearmBar.Maximum = 710;
            this.ForearmBar.Name = "ForearmBar";
            this.ForearmBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ForearmBar.Size = new System.Drawing.Size(45, 366);
            this.ForearmBar.TabIndex = 7;
            this.ForearmBar.TickFrequency = 15;
            this.ForearmBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.ForearmBar.ValueChanged += new System.EventHandler(this.BaseBar_ValueChanged);
            this.ForearmBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // Griper
            // 
            this.Griper.AutoSize = true;
            this.Griper.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Griper.Location = new System.Drawing.Point(320, 16);
            this.Griper.Name = "Griper";
            this.Griper.Size = new System.Drawing.Size(83, 25);
            this.Griper.TabIndex = 8;
            this.Griper.Text = "Gripper";
            // 
            // GripperBar
            // 
            this.GripperBar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.GripperBar.Location = new System.Drawing.Point(343, 64);
            this.GripperBar.Maximum = 100;
            this.GripperBar.Name = "GripperBar";
            this.GripperBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.GripperBar.Size = new System.Drawing.Size(45, 366);
            this.GripperBar.TabIndex = 9;
            this.GripperBar.TickFrequency = 10;
            this.GripperBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.GripperBar.ValueChanged += new System.EventHandler(this.BaseBar_ValueChanged);
            this.GripperBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // EventsBox
            // 
            this.EventsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventsBox.FormattingEnabled = true;
            this.EventsBox.ItemHeight = 18;
            this.EventsBox.Items.AddRange(new object[] {
            "Event collector"});
            this.EventsBox.Location = new System.Drawing.Point(6, 101);
            this.EventsBox.Name = "EventsBox";
            this.EventsBox.Size = new System.Drawing.Size(175, 202);
            this.EventsBox.TabIndex = 10;
            this.EventsBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Status";
            // 
            // BaseLabel
            // 
            this.BaseLabel.AutoSize = true;
            this.BaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaseLabel.Location = new System.Drawing.Point(6, 44);
            this.BaseLabel.Name = "BaseLabel";
            this.BaseLabel.Size = new System.Drawing.Size(100, 18);
            this.BaseLabel.TabIndex = 13;
            this.BaseLabel.Text = "Base angle is ";
            // 
            // ForearmLabel
            // 
            this.ForearmLabel.AutoSize = true;
            this.ForearmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForearmLabel.Location = new System.Drawing.Point(6, 59);
            this.ForearmLabel.Name = "ForearmLabel";
            this.ForearmLabel.Size = new System.Drawing.Size(119, 18);
            this.ForearmLabel.TabIndex = 14;
            this.ForearmLabel.Text = "Forearm angle is";
            // 
            // GripperLabel
            // 
            this.GripperLabel.AutoSize = true;
            this.GripperLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GripperLabel.Location = new System.Drawing.Point(6, 80);
            this.GripperLabel.Name = "GripperLabel";
            this.GripperLabel.Size = new System.Drawing.Size(129, 18);
            this.GripperLabel.TabIndex = 15;
            this.GripperLabel.Text = "Gripper closure is ";
            // 
            // Helpbutton
            // 
            this.Helpbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Helpbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Helpbutton.Location = new System.Drawing.Point(472, 369);
            this.Helpbutton.Name = "Helpbutton";
            this.Helpbutton.Size = new System.Drawing.Size(124, 33);
            this.Helpbutton.TabIndex = 16;
            this.Helpbutton.Text = "Instructions";
            this.Helpbutton.UseVisualStyleBackColor = true;
            this.Helpbutton.Click += new System.EventHandler(this.Helpbutton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(481, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(116, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.UseWaitCursor = true;
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // Refresh
            // 
            this.Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.Location = new System.Drawing.Point(481, 60);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(116, 28);
            this.Refresh.TabIndex = 18;
            this.Refresh.Text = "RefreshPorts";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.button1_Click);
            this.Refresh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // SendTimer
            // 
            this.SendTimer.Interval = 10;
            this.SendTimer.Tick += new System.EventHandler(this.SendTimer_Tick);
            // 
            // BaseRadio
            // 
            this.BaseRadio.AutoSize = true;
            this.BaseRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaseRadio.Location = new System.Drawing.Point(18, 47);
            this.BaseRadio.Name = "BaseRadio";
            this.BaseRadio.Size = new System.Drawing.Size(64, 24);
            this.BaseRadio.TabIndex = 19;
            this.BaseRadio.TabStop = true;
            this.BaseRadio.Text = "Base";
            this.BaseRadio.UseVisualStyleBackColor = true;
            // 
            // ForearmRadio
            // 
            this.ForearmRadio.AutoSize = true;
            this.ForearmRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForearmRadio.Location = new System.Drawing.Point(18, 77);
            this.ForearmRadio.Name = "ForearmRadio";
            this.ForearmRadio.Size = new System.Drawing.Size(87, 24);
            this.ForearmRadio.TabIndex = 20;
            this.ForearmRadio.TabStop = true;
            this.ForearmRadio.Text = "Forearm";
            this.ForearmRadio.UseVisualStyleBackColor = true;
            // 
            // GripperRadio
            // 
            this.GripperRadio.AutoSize = true;
            this.GripperRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GripperRadio.Location = new System.Drawing.Point(18, 107);
            this.GripperRadio.Name = "GripperRadio";
            this.GripperRadio.Size = new System.Drawing.Size(80, 24);
            this.GripperRadio.TabIndex = 21;
            this.GripperRadio.TabStop = true;
            this.GripperRadio.Text = "Gripper";
            this.GripperRadio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(468, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Keyboard control";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Forearm);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Griper);
            this.groupBox1.Controls.Add(this.GripperBar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 431);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Angle Bars";
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(459, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 94);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connection";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BaseRadio);
            this.groupBox3.Controls.Add(this.GripperRadio);
            this.groupBox3.Controls.Add(this.ForearmRadio);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(454, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(142, 143);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Keyboard Selected";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.EventsBox);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.BaseLabel);
            this.groupBox4.Controls.Add(this.ForearmLabel);
            this.groupBox4.Controls.Add(this.GripperLabel);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(607, 112);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(188, 326);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Arm data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Helpbutton);
            this.Controls.Add(this.ForearmBar);
            this.Controls.Add(this.BaseBar);
            this.Controls.Add(this.ConnectionButton);
            this.Controls.Add(this.SerialInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "ArmControler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.BaseBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForearmBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GripperBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SerialInfo;
        private System.Windows.Forms.Button ConnectionButton;
        private System.Windows.Forms.TrackBar BaseBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Forearm;
        private System.Windows.Forms.TrackBar ForearmBar;
        private System.Windows.Forms.Label Griper;
        private System.Windows.Forms.TrackBar GripperBar;
        private System.Windows.Forms.ListBox EventsBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label BaseLabel;
        private System.Windows.Forms.Label ForearmLabel;
        private System.Windows.Forms.Label GripperLabel;
        private System.Windows.Forms.Button Helpbutton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Timer SendTimer;
        private System.Windows.Forms.RadioButton BaseRadio;
        private System.Windows.Forms.RadioButton ForearmRadio;
        private System.Windows.Forms.RadioButton GripperRadio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

