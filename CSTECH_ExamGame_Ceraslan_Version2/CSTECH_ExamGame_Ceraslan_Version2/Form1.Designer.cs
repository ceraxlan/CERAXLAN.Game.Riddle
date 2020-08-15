namespace CSTECH_ExamGame_Ceraslan_Version2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPCScore = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblUserScore = new System.Windows.Forms.Label();
            this.lbl_Warning1 = new System.Windows.Forms.Label();
            this.lbl_Warning2 = new System.Windows.Forms.Label();
            this.lblUserLastGuess = new System.Windows.Forms.Label();
            this.lblPcLastGuess = new System.Windows.Forms.Label();
            this.btn_NewGame = new System.Windows.Forms.Button();
            this.panel_AnaGiris = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panelGameArea = new System.Windows.Forms.Panel();
            this.panelPC = new System.Windows.Forms.Panel();
            this.btn_FACE = new System.Windows.Forms.Button();
            this.btnPCsendTips = new System.Windows.Forms.Button();
            this.gbxPC_plusminus = new System.Windows.Forms.GroupBox();
            this.tbxResultPCTipPlus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxResultPCTipMinus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPCZero = new System.Windows.Forms.CheckBox();
            this.lblPCWinner = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxPCGuess = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelUser = new System.Windows.Forms.Panel();
            this.lblresultUserTipsZero = new System.Windows.Forms.Label();
            this.gbxresultUserTipsPlusMinusValues = new System.Windows.Forms.GroupBox();
            this.tbxResultUserTipPlus = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxResultUserTipMinus = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblUserWinner = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Guess = new System.Windows.Forms.Button();
            this.tbxUserGuess = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_info = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btnOKuser = new System.Windows.Forms.Button();
            this.btnOKpc = new System.Windows.Forms.Button();
            this.timerSelectPCorUser = new System.Windows.Forms.Timer(this.components);
            this.timerUpDown = new System.Windows.Forms.Timer(this.components);
            this.timerWait = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panelGameArea.SuspendLayout();
            this.panelPC.SuspendLayout();
            this.gbxPC_plusminus.SuspendLayout();
            this.panelUser.SuspendLayout();
            this.gbxresultUserTipsPlusMinusValues.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblPCScore);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.lblUserScore);
            this.panel1.Controls.Add(this.lbl_Warning1);
            this.panel1.Controls.Add(this.lbl_Warning2);
            this.panel1.Controls.Add(this.lblUserLastGuess);
            this.panel1.Controls.Add(this.lblPcLastGuess);
            this.panel1.Controls.Add(this.btn_NewGame);
            this.panel1.Controls.Add(this.panel_AnaGiris);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.panelGameArea);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.panelTop);
            this.panel1.Controls.Add(this.btnOKuser);
            this.panel1.Controls.Add(this.btnOKpc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 298);
            this.panel1.TabIndex = 0;
            // 
            // lblPCScore
            // 
            this.lblPCScore.AutoSize = true;
            this.lblPCScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPCScore.ForeColor = System.Drawing.Color.White;
            this.lblPCScore.Location = new System.Drawing.Point(171, 327);
            this.lblPCScore.Name = "lblPCScore";
            this.lblPCScore.Size = new System.Drawing.Size(17, 18);
            this.lblPCScore.TabIndex = 559;
            this.lblPCScore.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(152, 327);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 18);
            this.label14.TabIndex = 558;
            this.label14.Text = "-";
            // 
            // lblUserScore
            // 
            this.lblUserScore.AutoSize = true;
            this.lblUserScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserScore.ForeColor = System.Drawing.Color.White;
            this.lblUserScore.Location = new System.Drawing.Point(130, 327);
            this.lblUserScore.Name = "lblUserScore";
            this.lblUserScore.Size = new System.Drawing.Size(17, 18);
            this.lblUserScore.TabIndex = 557;
            this.lblUserScore.Text = "0";
            // 
            // lbl_Warning1
            // 
            this.lbl_Warning1.AutoSize = true;
            this.lbl_Warning1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Warning1.ForeColor = System.Drawing.Color.Red;
            this.lbl_Warning1.Location = new System.Drawing.Point(111, 294);
            this.lbl_Warning1.Name = "lbl_Warning1";
            this.lbl_Warning1.Size = new System.Drawing.Size(98, 16);
            this.lbl_Warning1.TabIndex = 556;
            this.lbl_Warning1.Text = "SCORELESS";
            this.lbl_Warning1.Visible = false;
            // 
            // lbl_Warning2
            // 
            this.lbl_Warning2.AutoSize = true;
            this.lbl_Warning2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Warning2.ForeColor = System.Drawing.Color.Red;
            this.lbl_Warning2.Location = new System.Drawing.Point(23, 311);
            this.lbl_Warning2.Name = "lbl_Warning2";
            this.lbl_Warning2.Size = new System.Drawing.Size(279, 16);
            this.lbl_Warning2.TabIndex = 554;
            this.lbl_Warning2.Text = "You gave the computer an incorrect Tip";
            this.lbl_Warning2.Visible = false;
            // 
            // lblUserLastGuess
            // 
            this.lblUserLastGuess.AutoSize = true;
            this.lblUserLastGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblUserLastGuess.ForeColor = System.Drawing.Color.White;
            this.lblUserLastGuess.Location = new System.Drawing.Point(58, 653);
            this.lblUserLastGuess.Name = "lblUserLastGuess";
            this.lblUserLastGuess.Size = new System.Drawing.Size(0, 25);
            this.lblUserLastGuess.TabIndex = 553;
            this.lblUserLastGuess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPcLastGuess
            // 
            this.lblPcLastGuess.AutoSize = true;
            this.lblPcLastGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblPcLastGuess.ForeColor = System.Drawing.Color.White;
            this.lblPcLastGuess.Location = new System.Drawing.Point(210, 653);
            this.lblPcLastGuess.Name = "lblPcLastGuess";
            this.lblPcLastGuess.Size = new System.Drawing.Size(0, 25);
            this.lblPcLastGuess.TabIndex = 65;
            this.lblPcLastGuess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_NewGame
            // 
            this.btn_NewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_NewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_NewGame.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_NewGame.FlatAppearance.BorderSize = 0;
            this.btn_NewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_NewGame.ForeColor = System.Drawing.Color.White;
            this.btn_NewGame.Location = new System.Drawing.Point(112, 692);
            this.btn_NewGame.Name = "btn_NewGame";
            this.btn_NewGame.Size = new System.Drawing.Size(93, 24);
            this.btn_NewGame.TabIndex = 48;
            this.btn_NewGame.Text = "New Game";
            this.btn_NewGame.UseVisualStyleBackColor = false;
            this.btn_NewGame.Visible = false;
            this.btn_NewGame.Click += new System.EventHandler(this.Btn_NewGame_Click);
            // 
            // panel_AnaGiris
            // 
            this.panel_AnaGiris.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_AnaGiris.Location = new System.Drawing.Point(0, 90);
            this.panel_AnaGiris.Name = "panel_AnaGiris";
            this.panel_AnaGiris.Size = new System.Drawing.Size(318, 202);
            this.panel_AnaGiris.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(40, 637);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 16);
            this.label9.TabIndex = 52;
            this.label9.Text = "Last Guess !";
            // 
            // panelGameArea
            // 
            this.panelGameArea.Controls.Add(this.panelPC);
            this.panelGameArea.Controls.Add(this.panelUser);
            this.panelGameArea.Location = new System.Drawing.Point(0, 346);
            this.panelGameArea.Name = "panelGameArea";
            this.panelGameArea.Size = new System.Drawing.Size(318, 278);
            this.panelGameArea.TabIndex = 31;
            // 
            // panelPC
            // 
            this.panelPC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPC.Controls.Add(this.btn_FACE);
            this.panelPC.Controls.Add(this.btnPCsendTips);
            this.panelPC.Controls.Add(this.gbxPC_plusminus);
            this.panelPC.Controls.Add(this.cbxPCZero);
            this.panelPC.Controls.Add(this.lblPCWinner);
            this.panelPC.Controls.Add(this.label8);
            this.panelPC.Controls.Add(this.tbxPCGuess);
            this.panelPC.Controls.Add(this.label5);
            this.panelPC.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelPC.Location = new System.Drawing.Point(158, 0);
            this.panelPC.Name = "panelPC";
            this.panelPC.Size = new System.Drawing.Size(160, 278);
            this.panelPC.TabIndex = 1;
            // 
            // btn_FACE
            // 
            this.btn_FACE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_FACE.Enabled = false;
            this.btn_FACE.FlatAppearance.BorderSize = 0;
            this.btn_FACE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_FACE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FACE.Location = new System.Drawing.Point(65, 110);
            this.btn_FACE.Name = "btn_FACE";
            this.btn_FACE.Size = new System.Drawing.Size(30, 32);
            this.btn_FACE.TabIndex = 62;
            this.btn_FACE.UseVisualStyleBackColor = true;
            // 
            // btnPCsendTips
            // 
            this.btnPCsendTips.BackColor = System.Drawing.Color.DarkCyan;
            this.btnPCsendTips.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPCsendTips.Enabled = false;
            this.btnPCsendTips.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnPCsendTips.FlatAppearance.BorderSize = 0;
            this.btnPCsendTips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPCsendTips.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPCsendTips.ForeColor = System.Drawing.Color.White;
            this.btnPCsendTips.Location = new System.Drawing.Point(35, 242);
            this.btnPCsendTips.Name = "btnPCsendTips";
            this.btnPCsendTips.Size = new System.Drawing.Size(93, 24);
            this.btnPCsendTips.TabIndex = 61;
            this.btnPCsendTips.Text = "Send";
            this.btnPCsendTips.UseVisualStyleBackColor = false;
            this.btnPCsendTips.Click += new System.EventHandler(this.BtnPCsendTips_Click);
            // 
            // gbxPC_plusminus
            // 
            this.gbxPC_plusminus.Controls.Add(this.tbxResultPCTipPlus);
            this.gbxPC_plusminus.Controls.Add(this.label2);
            this.gbxPC_plusminus.Controls.Add(this.tbxResultPCTipMinus);
            this.gbxPC_plusminus.Controls.Add(this.label1);
            this.gbxPC_plusminus.Location = new System.Drawing.Point(44, 188);
            this.gbxPC_plusminus.Name = "gbxPC_plusminus";
            this.gbxPC_plusminus.Size = new System.Drawing.Size(112, 48);
            this.gbxPC_plusminus.TabIndex = 60;
            this.gbxPC_plusminus.TabStop = false;
            // 
            // tbxResultPCTipPlus
            // 
            this.tbxResultPCTipPlus.BackColor = System.Drawing.Color.Black;
            this.tbxResultPCTipPlus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxResultPCTipPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxResultPCTipPlus.ForeColor = System.Drawing.Color.White;
            this.tbxResultPCTipPlus.Location = new System.Drawing.Point(28, 13);
            this.tbxResultPCTipPlus.MaxLength = 1;
            this.tbxResultPCTipPlus.Name = "tbxResultPCTipPlus";
            this.tbxResultPCTipPlus.Size = new System.Drawing.Size(23, 29);
            this.tbxResultPCTipPlus.TabIndex = 55;
            this.tbxResultPCTipPlus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxResultPCTipPlus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxResultPCTipPlus_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(60, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 24);
            this.label2.TabIndex = 59;
            this.label2.Text = "-";
            // 
            // tbxResultPCTipMinus
            // 
            this.tbxResultPCTipMinus.BackColor = System.Drawing.Color.Black;
            this.tbxResultPCTipMinus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxResultPCTipMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxResultPCTipMinus.ForeColor = System.Drawing.Color.White;
            this.tbxResultPCTipMinus.Location = new System.Drawing.Point(78, 13);
            this.tbxResultPCTipMinus.MaxLength = 1;
            this.tbxResultPCTipMinus.Name = "tbxResultPCTipMinus";
            this.tbxResultPCTipMinus.Size = new System.Drawing.Size(23, 29);
            this.tbxResultPCTipMinus.TabIndex = 56;
            this.tbxResultPCTipMinus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxResultPCTipMinus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxResultPCTipMinus_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 24);
            this.label1.TabIndex = 58;
            this.label1.Text = "+";
            // 
            // cbxPCZero
            // 
            this.cbxPCZero.AutoSize = true;
            this.cbxPCZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxPCZero.ForeColor = System.Drawing.Color.White;
            this.cbxPCZero.Location = new System.Drawing.Point(3, 201);
            this.cbxPCZero.Name = "cbxPCZero";
            this.cbxPCZero.Size = new System.Drawing.Size(44, 29);
            this.cbxPCZero.TabIndex = 57;
            this.cbxPCZero.Text = "0";
            this.cbxPCZero.UseVisualStyleBackColor = true;
            this.cbxPCZero.Click += new System.EventHandler(this.CbxPCZero_Click);
            // 
            // lblPCWinner
            // 
            this.lblPCWinner.AutoSize = true;
            this.lblPCWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPCWinner.ForeColor = System.Drawing.Color.Lime;
            this.lblPCWinner.Location = new System.Drawing.Point(31, 31);
            this.lblPCWinner.Name = "lblPCWinner";
            this.lblPCWinner.Size = new System.Drawing.Size(104, 24);
            this.lblPCWinner.TabIndex = 50;
            this.lblPCWinner.Text = "WINNER !";
            this.lblPCWinner.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(19, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 16);
            this.label8.TabIndex = 49;
            this.label8.Text = "Give Hints to PC !";
            // 
            // tbxPCGuess
            // 
            this.tbxPCGuess.BackColor = System.Drawing.Color.Black;
            this.tbxPCGuess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPCGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPCGuess.ForeColor = System.Drawing.Color.White;
            this.tbxPCGuess.Location = new System.Drawing.Point(44, 72);
            this.tbxPCGuess.Name = "tbxPCGuess";
            this.tbxPCGuess.ReadOnly = true;
            this.tbxPCGuess.Size = new System.Drawing.Size(70, 29);
            this.tbxPCGuess.TabIndex = 48;
            this.tbxPCGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(61, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 24);
            this.label5.TabIndex = 46;
            this.label5.Text = "PC";
            // 
            // panelUser
            // 
            this.panelUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUser.Controls.Add(this.lblresultUserTipsZero);
            this.panelUser.Controls.Add(this.gbxresultUserTipsPlusMinusValues);
            this.panelUser.Controls.Add(this.lblUserWinner);
            this.panelUser.Controls.Add(this.label7);
            this.panelUser.Controls.Add(this.btn_Guess);
            this.panelUser.Controls.Add(this.tbxUserGuess);
            this.panelUser.Controls.Add(this.label4);
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelUser.Location = new System.Drawing.Point(0, 0);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(160, 278);
            this.panelUser.TabIndex = 0;
            // 
            // lblresultUserTipsZero
            // 
            this.lblresultUserTipsZero.AutoSize = true;
            this.lblresultUserTipsZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblresultUserTipsZero.ForeColor = System.Drawing.Color.White;
            this.lblresultUserTipsZero.Location = new System.Drawing.Point(11, 203);
            this.lblresultUserTipsZero.Name = "lblresultUserTipsZero";
            this.lblresultUserTipsZero.Size = new System.Drawing.Size(25, 25);
            this.lblresultUserTipsZero.TabIndex = 63;
            this.lblresultUserTipsZero.Text = "0";
            // 
            // gbxresultUserTipsPlusMinusValues
            // 
            this.gbxresultUserTipsPlusMinusValues.Controls.Add(this.tbxResultUserTipPlus);
            this.gbxresultUserTipsPlusMinusValues.Controls.Add(this.label11);
            this.gbxresultUserTipsPlusMinusValues.Controls.Add(this.tbxResultUserTipMinus);
            this.gbxresultUserTipsPlusMinusValues.Controls.Add(this.label12);
            this.gbxresultUserTipsPlusMinusValues.Location = new System.Drawing.Point(43, 188);
            this.gbxresultUserTipsPlusMinusValues.Name = "gbxresultUserTipsPlusMinusValues";
            this.gbxresultUserTipsPlusMinusValues.Size = new System.Drawing.Size(112, 48);
            this.gbxresultUserTipsPlusMinusValues.TabIndex = 62;
            this.gbxresultUserTipsPlusMinusValues.TabStop = false;
            // 
            // tbxResultUserTipPlus
            // 
            this.tbxResultUserTipPlus.BackColor = System.Drawing.Color.Black;
            this.tbxResultUserTipPlus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxResultUserTipPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxResultUserTipPlus.ForeColor = System.Drawing.Color.White;
            this.tbxResultUserTipPlus.Location = new System.Drawing.Point(28, 13);
            this.tbxResultUserTipPlus.Name = "tbxResultUserTipPlus";
            this.tbxResultUserTipPlus.ReadOnly = true;
            this.tbxResultUserTipPlus.Size = new System.Drawing.Size(23, 29);
            this.tbxResultUserTipPlus.TabIndex = 555;
            this.tbxResultUserTipPlus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(60, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 24);
            this.label11.TabIndex = 59;
            this.label11.Text = "-";
            // 
            // tbxResultUserTipMinus
            // 
            this.tbxResultUserTipMinus.BackColor = System.Drawing.Color.Black;
            this.tbxResultUserTipMinus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxResultUserTipMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxResultUserTipMinus.ForeColor = System.Drawing.Color.White;
            this.tbxResultUserTipMinus.Location = new System.Drawing.Point(78, 13);
            this.tbxResultUserTipMinus.Name = "tbxResultUserTipMinus";
            this.tbxResultUserTipMinus.ReadOnly = true;
            this.tbxResultUserTipMinus.Size = new System.Drawing.Size(23, 29);
            this.tbxResultUserTipMinus.TabIndex = 565;
            this.tbxResultUserTipMinus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Lime;
            this.label12.Location = new System.Drawing.Point(6, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 24);
            this.label12.TabIndex = 58;
            this.label12.Text = "+";
            // 
            // lblUserWinner
            // 
            this.lblUserWinner.AutoSize = true;
            this.lblUserWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserWinner.ForeColor = System.Drawing.Color.Lime;
            this.lblUserWinner.Location = new System.Drawing.Point(31, 31);
            this.lblUserWinner.Name = "lblUserWinner";
            this.lblUserWinner.Size = new System.Drawing.Size(104, 24);
            this.lblUserWinner.TabIndex = 49;
            this.lblUserWinner.Text = "WINNER !";
            this.lblUserWinner.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(41, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 48;
            this.label7.Text = "Your Hint !";
            // 
            // btn_Guess
            // 
            this.btn_Guess.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Guess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Guess.Enabled = false;
            this.btn_Guess.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_Guess.FlatAppearance.BorderSize = 0;
            this.btn_Guess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Guess.ForeColor = System.Drawing.Color.White;
            this.btn_Guess.Location = new System.Drawing.Point(33, 107);
            this.btn_Guess.Name = "btn_Guess";
            this.btn_Guess.Size = new System.Drawing.Size(93, 24);
            this.btn_Guess.TabIndex = 47;
            this.btn_Guess.Text = "Guess";
            this.btn_Guess.UseVisualStyleBackColor = false;
            this.btn_Guess.Click += new System.EventHandler(this.Btn_Guess_Click);
            // 
            // tbxUserGuess
            // 
            this.tbxUserGuess.BackColor = System.Drawing.Color.Black;
            this.tbxUserGuess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUserGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUserGuess.ForeColor = System.Drawing.Color.White;
            this.tbxUserGuess.Location = new System.Drawing.Point(45, 72);
            this.tbxUserGuess.MaxLength = 4;
            this.tbxUserGuess.Name = "tbxUserGuess";
            this.tbxUserGuess.Size = new System.Drawing.Size(70, 29);
            this.tbxUserGuess.TabIndex = 46;
            this.tbxUserGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxUserGuess.TextChanged += new System.EventHandler(this.TbxUserGuess_TextChanged);
            this.tbxUserGuess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxUserGuess_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(48, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 44;
            this.label4.Text = "USER";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_back);
            this.panel2.Controls.Add(this.btn_info);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 66);
            this.panel2.TabIndex = 30;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Location = new System.Drawing.Point(45, 28);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(25, 24);
            this.btn_back.TabIndex = 28;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Visible = false;
            this.btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // btn_info
            // 
            this.btn_info.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_info.BackgroundImage")));
            this.btn_info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_info.FlatAppearance.BorderSize = 0;
            this.btn_info.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_info.Location = new System.Drawing.Point(211, 24);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(30, 32);
            this.btn_info.TabIndex = 27;
            this.btn_info.UseVisualStyleBackColor = true;
            this.btn_info.Click += new System.EventHandler(this.Btn_info_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(76, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Game Information";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(194, 637);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 16);
            this.label10.TabIndex = 53;
            this.label10.Text = "Last Guess !";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.button1);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.btn_min);
            this.panelTop.Controls.Add(this.btn_exit);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(318, 24);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseUp);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 24);
            this.button1.TabIndex = 27;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseDown);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseMove);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(42, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Guess Win Game";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseMove);
            this.label3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseUp);
            // 
            // btn_min
            // 
            this.btn_min.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_min.FlatAppearance.BorderSize = 0;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_min.Location = new System.Drawing.Point(242, 0);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(38, 24);
            this.btn_min.TabIndex = 3;
            this.btn_min.Text = "_";
            this.btn_min.UseVisualStyleBackColor = true;
            this.btn_min.Click += new System.EventHandler(this.Btn_min_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_exit.Location = new System.Drawing.Point(280, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(38, 24);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // btnOKuser
            // 
            this.btnOKuser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOKuser.BackgroundImage")));
            this.btnOKuser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOKuser.Enabled = false;
            this.btnOKuser.FlatAppearance.BorderSize = 0;
            this.btnOKuser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnOKuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOKuser.Location = new System.Drawing.Point(65, 308);
            this.btnOKuser.Name = "btnOKuser";
            this.btnOKuser.Size = new System.Drawing.Size(30, 32);
            this.btnOKuser.TabIndex = 45;
            this.btnOKuser.UseVisualStyleBackColor = true;
            this.btnOKuser.Visible = false;
            // 
            // btnOKpc
            // 
            this.btnOKpc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOKpc.BackgroundImage")));
            this.btnOKpc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOKpc.Enabled = false;
            this.btnOKpc.FlatAppearance.BorderSize = 0;
            this.btnOKpc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnOKpc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOKpc.Location = new System.Drawing.Point(225, 308);
            this.btnOKpc.Name = "btnOKpc";
            this.btnOKpc.Size = new System.Drawing.Size(30, 32);
            this.btnOKpc.TabIndex = 47;
            this.btnOKpc.UseVisualStyleBackColor = true;
            this.btnOKpc.Visible = false;
            // 
            // timerSelectPCorUser
            // 
            this.timerSelectPCorUser.Interval = 250;
            this.timerSelectPCorUser.Tick += new System.EventHandler(this.TimerSelectPCorUser_Tick);
            // 
            // timerUpDown
            // 
            this.timerUpDown.Interval = 50;
            this.timerUpDown.Tick += new System.EventHandler(this.TimerUpDown_Tick);
            // 
            // timerWait
            // 
            this.timerWait.Interval = 1750;
            this.timerWait.Tick += new System.EventHandler(this.TimerWait_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(320, 298);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelGameArea.ResumeLayout(false);
            this.panelPC.ResumeLayout(false);
            this.panelPC.PerformLayout();
            this.gbxPC_plusminus.ResumeLayout(false);
            this.gbxPC_plusminus.PerformLayout();
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            this.gbxresultUserTipsPlusMinusValues.ResumeLayout(false);
            this.gbxresultUserTipsPlusMinusValues.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_back;
        public System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panelGameArea;
        private System.Windows.Forms.Panel panel_AnaGiris;
        private System.Windows.Forms.Panel panelPC;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label lblPCWinner;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox tbxPCGuess;
        public System.Windows.Forms.Button btnOKpc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label lblUserWinner;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button btn_Guess;
        public System.Windows.Forms.TextBox tbxUserGuess;
        public System.Windows.Forms.Button btnOKuser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbxPC_plusminus;
        public System.Windows.Forms.TextBox tbxResultPCTipPlus;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbxResultPCTipMinus;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbxPCZero;
        public System.Windows.Forms.Button btnPCsendTips;
        private System.Windows.Forms.Label lblresultUserTipsZero;
        private System.Windows.Forms.GroupBox gbxresultUserTipsPlusMinusValues;
        public System.Windows.Forms.TextBox tbxResultUserTipPlus;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox tbxResultUserTipMinus;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Timer timerSelectPCorUser;
        public System.Windows.Forms.Timer timerUpDown;
        private System.Windows.Forms.Label lblPcLastGuess;
        private System.Windows.Forms.Label lblUserLastGuess;
        private System.Windows.Forms.Timer timerWait;
        public System.Windows.Forms.Button btn_NewGame;
        private System.Windows.Forms.Label lbl_Warning1;
        private System.Windows.Forms.Label lbl_Warning2;
        public System.Windows.Forms.Button btn_FACE;
        private System.Windows.Forms.Label lblPCScore;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblUserScore;
    }
}

