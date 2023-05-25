namespace CSTECH_ExamGame_Ceraslan_Version2
{
    partial class Enter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enter));
            this.btn_UserPin = new System.Windows.Forms.Button();
            this.tbxPCNumber = new System.Windows.Forms.TextBox();
            this.tbxUserNumber = new System.Windows.Forms.TextBox();
            this.btn_PcPin = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.lbl_PC_KeptQuessNumber = new System.Windows.Forms.Label();
            this.lbl_PcInfoNumber = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timerEnterProcesses = new System.Windows.Forms.Timer(this.components);
            this.lblGameStarted = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_UserPin
            // 
            this.btn_UserPin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_UserPin.BackgroundImage")));
            this.btn_UserPin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_UserPin.FlatAppearance.BorderSize = 0;
            this.btn_UserPin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UserPin.Location = new System.Drawing.Point(198, 39);
            this.btn_UserPin.Name = "btn_UserPin";
            this.btn_UserPin.Size = new System.Drawing.Size(20, 19);
            this.btn_UserPin.TabIndex = 38;
            this.btn_UserPin.UseVisualStyleBackColor = true;
            this.btn_UserPin.Visible = false;
            // 
            // tbxPCNumber
            // 
            this.tbxPCNumber.BackColor = System.Drawing.Color.Black;
            this.tbxPCNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPCNumber.Enabled = false;
            this.tbxPCNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPCNumber.ForeColor = System.Drawing.Color.White;
            this.tbxPCNumber.Location = new System.Drawing.Point(122, 114);
            this.tbxPCNumber.Name = "tbxPCNumber";
            this.tbxPCNumber.ReadOnly = true;
            this.tbxPCNumber.Size = new System.Drawing.Size(70, 29);
            this.tbxPCNumber.TabIndex = 44;
            this.tbxPCNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxPCNumber.Visible = false;
            // 
            // tbxUserNumber
            // 
            this.tbxUserNumber.BackColor = System.Drawing.Color.Black;
            this.tbxUserNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUserNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUserNumber.ForeColor = System.Drawing.Color.White;
            this.tbxUserNumber.Location = new System.Drawing.Point(122, 32);
            this.tbxUserNumber.MaxLength = 4;
            this.tbxUserNumber.Name = "tbxUserNumber";
            this.tbxUserNumber.Size = new System.Drawing.Size(70, 29);
            this.tbxUserNumber.TabIndex = 37;
            this.tbxUserNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxUserNumber.TextChanged += new System.EventHandler(this.TbxUserNumber_TextChanged);
            this.tbxUserNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxUserNumber_KeyPress);
            // 
            // btn_PcPin
            // 
            this.btn_PcPin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_PcPin.BackgroundImage")));
            this.btn_PcPin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_PcPin.FlatAppearance.BorderSize = 0;
            this.btn_PcPin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PcPin.Location = new System.Drawing.Point(199, 120);
            this.btn_PcPin.Name = "btn_PcPin";
            this.btn_PcPin.Size = new System.Drawing.Size(19, 19);
            this.btn_PcPin.TabIndex = 43;
            this.btn_PcPin.UseVisualStyleBackColor = true;
            this.btn_PcPin.Visible = false;
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Start.Enabled = false;
            this.btn_Start.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_Start.FlatAppearance.BorderSize = 0;
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Start.ForeColor = System.Drawing.Color.White;
            this.btn_Start.Location = new System.Drawing.Point(110, 164);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(93, 24);
            this.btn_Start.TabIndex = 42;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            this.btn_Start.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btn_Start_MouseClick);
            // 
            // lbl_PC_KeptQuessNumber
            // 
            this.lbl_PC_KeptQuessNumber.AutoSize = true;
            this.lbl_PC_KeptQuessNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_PC_KeptQuessNumber.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_PC_KeptQuessNumber.Location = new System.Drawing.Point(33, 142);
            this.lbl_PC_KeptQuessNumber.Name = "lbl_PC_KeptQuessNumber";
            this.lbl_PC_KeptQuessNumber.Size = new System.Drawing.Size(249, 16);
            this.lbl_PC_KeptQuessNumber.TabIndex = 41;
            this.lbl_PC_KeptQuessNumber.Text = "*Note: Computer kept own number !";
            this.lbl_PC_KeptQuessNumber.Visible = false;
            // 
            // lbl_PcInfoNumber
            // 
            this.lbl_PcInfoNumber.AutoSize = true;
            this.lbl_PcInfoNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_PcInfoNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_PcInfoNumber.Location = new System.Drawing.Point(79, 95);
            this.lbl_PcInfoNumber.Name = "lbl_PcInfoNumber";
            this.lbl_PcInfoNumber.Size = new System.Drawing.Size(161, 16);
            this.lbl_PcInfoNumber.TabIndex = 40;
            this.lbl_PcInfoNumber.Text = "Number of Computer ! ";
            this.lbl_PcInfoNumber.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(3, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(315, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "*Note:The computer cannot see your number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(73, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "Take note your number ! ";
            // 
            // timerEnterProcesses
            // 
            this.timerEnterProcesses.Interval = 300;
            this.timerEnterProcesses.Tick += new System.EventHandler(this.TimerEnterProcesses_Tick);
            // 
            // lblGameStarted
            // 
            this.lblGameStarted.AutoSize = true;
            this.lblGameStarted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGameStarted.ForeColor = System.Drawing.Color.Orange;
            this.lblGameStarted.Location = new System.Drawing.Point(102, 168);
            this.lblGameStarted.Name = "lblGameStarted";
            this.lblGameStarted.Size = new System.Drawing.Size(109, 16);
            this.lblGameStarted.TabIndex = 45;
            this.lblGameStarted.Text = "Game started !";
            this.lblGameStarted.Visible = false;
            // 
            // Enter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.Controls.Add(this.btn_UserPin);
            this.Controls.Add(this.tbxPCNumber);
            this.Controls.Add(this.tbxUserNumber);
            this.Controls.Add(this.btn_PcPin);
            this.Controls.Add(this.lbl_PC_KeptQuessNumber);
            this.Controls.Add(this.lbl_PcInfoNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblGameStarted);
            this.Controls.Add(this.btn_Start);
            this.Name = "Enter";
            this.Size = new System.Drawing.Size(320, 200);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox tbxPCNumber;
        public System.Windows.Forms.TextBox tbxUserNumber;
        public System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timerEnterProcesses;
        public System.Windows.Forms.Label lblGameStarted;
        public System.Windows.Forms.Button btn_UserPin;
        public System.Windows.Forms.Button btn_PcPin;
        public System.Windows.Forms.Label lbl_PC_KeptQuessNumber;
        public System.Windows.Forms.Label lbl_PcInfoNumber;
    }
}
