using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSTECH_ExamGame_Ceraslan_Version2
{
    public partial class Form1 : Form
    {


       //parameters --------------------------------------------

        public ArrayList PCNumbers;
        public List<int> UserLastGuessNumbers =new List<int>();
        public int[] userKeptNumberReservedDigit;
        public int[] pcKeptNumberReservedDigit;
        int[] userGuessNumberReserveDigit;
        int NowPCGuessNumber;
        int userGuessNumber;

        int SelectPCorUser;
        bool timerSelect = false;
        int timerSelectCount = 0;
        public bool FormState = false;
        int timerWaitSelect;

        int scorePC, scoreUser = 0;
        //-----------------------------------------------------

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            this.Location = new Point(800, 80);

            activePage = null;
            lastPage = null;

            info = new Info();
            info.Visible = false;
            panel_AnaGiris.Controls.Add(info);

            enter = new Enter(this);
            enter.Visible = true;
            panel_AnaGiris.Controls.Add(enter);

            isBoard = true;            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
                   
        }


        // UI Settings ----------------------------------------------------
               
        private bool Dragging;
        private Point Offset;
        private void PanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            Offset = e.Location;
        }
        private void PanelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new
                Point(currentScreenPos.X - Offset.X,
                currentScreenPos.Y - Offset.Y);
            }
        }
        private void PanelTop_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }
        private void Btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //-------------------------

        Info info;
        Enter enter;
        bool isBoard = false;
        Control activePage = new Control();
        public enum BoardPages
        {
            Info,
            Enter
        }
        BoardPages? lastPage = null;
        public void AddMainPanelControl()
        {
            activePage.Dock = DockStyle.Fill;
            activePage.Visible = true;
        }
        public void BoardPagesVisible(BoardPages page)
        {
            if (!isBoard)
            {
                return;
            }
            if (page == lastPage)
            {
                return;
            }

            info.Visible = false;
            enter.Visible = false;

            switch (page)
            {
                case BoardPages.Info:
                    activePage = info;
                    lastPage = page;
                    AddMainPanelControl();
                    info.InfoLoad();
                    break;

                case BoardPages.Enter:
                    activePage = enter;
                    lastPage = page;
                    AddMainPanelControl();
                    enter.EnterLoad();
                    break;
            }
        }

        //  ----------------------------------------------------


        // Triggers ----------------------------------------------------

        private void Btn_info_Click(object sender, EventArgs e)
        {
            BoardPagesVisible(BoardPages.Info);
            btn_back.Visible = true;
        }
        private void Btn_back_Click(object sender, EventArgs e)
        {
            BoardPagesVisible(BoardPages.Enter);
            btn_back.Visible = false;
        }
        private void Btn_Guess_Click(object sender, EventArgs e)
        {
            btn_Guess.Enabled = false; // for single press

            int value = UserFirstProcesses();
            if (value == -1) { return; }
            if (IsWinUser() == 1) { FreezeGameArea(); }
            else
            {

                int[] resultUserTips = UserMainProcesses();
                if (resultUserTips[0] == 0)
                {
                    lblresultUserTipsZero.Visible = true;
                    gbxresultUserTipsPlusMinusValues.Visible = false;
                }
                else
                {
                    lblresultUserTipsZero.Visible = false;
                    gbxresultUserTipsPlusMinusValues.Visible = true;
                    tbxResultUserTipPlus.Text = resultUserTips[1].ToString();
                    tbxResultUserTipMinus.Text = resultUserTips[2].ToString();
                }
                int userLastGuess = ConvertTo32fromString(tbxUserGuess.Text);
                UserLastGuessNumbers.Add(userLastGuess);
                lblUserLastGuess.Text = tbxUserGuess.Text;
                tbxUserGuess.Text = "";

                timerWaitSelect = 1;
                timerWait.Start();

            }
        }
        private void BtnPCsendTips_Click(object sender, EventArgs e)
        {
            btnPCsendTips.Enabled = false;// for single press
            if (cbxPCZero.Checked == false && tbxResultPCTipMinus.Text == "" && tbxResultPCTipPlus.Text == "")
            {
                MessageBox.Show("Please Select Tips ", "Game Rule", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnPCsendTips.Enabled = true;
                return;
            }
            
            if (cbxPCZero.Checked == true)
            {
                ifStateZeroRemoveNumbersfromList();
                cbxPCZero.Enabled = false;
            }
            else
            {
                int plus, minus;
                if (tbxResultPCTipPlus.Text == "") { plus = 0; } else { plus = Convert.ToInt32(tbxResultPCTipPlus.Text); }
                if (tbxResultPCTipMinus.Text == "") { minus = 0; } else { minus = Convert.ToInt32(tbxResultPCTipMinus.Text); }
                string STip = ("" + plus + minus);
                int Itip = Convert.ToInt32(STip);
                SolveTips(Itip);
            }

            lblPcLastGuess.Text = tbxPCGuess.Text;
            tbxPCGuess.Text = "";
            timerWaitSelect = 0;
            timerWait.Start();

        }
        private void Btn_NewGame_Click(object sender, EventArgs e)
        {
            btn_NewGame.Visible = false;
            ResetGame();
        }

        //  ----------------------------------------------------


        // Game Processes ----------------------------------------------------

        public void GeneratePCNumbersList()
        {
            PCNumbers = new ArrayList();
            for (int p = 1023; p < 9877; p++)
            {
                int[] result = ReserveDigitNumber(p);
                if (ControlNumberUniqeDigit(result))
                {
                    PCNumbers.Add(p);
                }
            }
        }       
        public bool IsThereNumberinLastGuesses_User(int number)
        {                
           if (UserLastGuessNumbers.Contains(number))
           {
               return true;
           }
           else
           {
               return false;
           }                
        }
        public int[] ReserveDigitNumber(int number)
        {
            int[] digitNumber = new int[5];
            for(int i = 1; i <= 4; i++)
            {
                digitNumber[i] = number % 10;
                number = (number - digitNumber[i]) / 10;
            }

            return digitNumber;                            
        }
        public int ConvertTo32fromString(string Snumber)
        {
            try
            {
                int number = Convert.ToInt32(Snumber);
                return number;
            }
            catch 
            {
                return -1;
            }        
        }
        public  bool ControlNumberUniqeDigit(int[] digitalNumber)
        {
            int k = 1;
            for(int i = 1; i <= 3; i++)
            {
                k = i + 1;
                for (; k <= 4; k++)
                {
                    if (digitalNumber[i] == digitalNumber[k])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public  int ControlStringNumber4Digit(int number)
        {
            int[] DigitofNumber= ReserveDigitNumber(number);
            if (DigitofNumber[4] == 0)
            {
                MessageBox.Show("Your number must be a 4-digit number", "Game Rule", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;  // false
            }
            else
            {
                return 1; 
            }                           
        }       
        public void SelectRandomUserOrPc()
        {
            Random random = new Random();
            int number = random.Next(2);
            if (number == 0)
            {
                SelectPCorUser = 0;
            }
            else
            {
                SelectPCorUser =1;
            }          
        }
        public object GetRandomNumberforPCfromPCList()
        {
            Random random = new Random();
            int countList = PCNumbers.Count;
            if (countList < 1)
            {            
                return 0;
            }
            else
            {
                int numberindex = random.Next(countList);
                return PCNumbers[numberindex];
            }        
        }     
        public void SortMechanismProcess(int select)
        {           
            switch (select)
            {
                case 0://User
                    btnOKpc.Visible = false;
                    btnOKuser.Visible = true;
                    panelUser.Enabled = true;
                    panelPC.Enabled = false;
                    ResetUserArea();
                    break;
                case 1://Pc
                    btnOKpc.Visible = true;
                    btnOKuser.Visible = false;
                    panelUser.Enabled = false;
                    panelPC.Enabled = true;                   
                    NowPCGuessNumber = Convert.ToInt32(GetRandomNumberforPCfromPCList());
                    if (NowPCGuessNumber==0)
                    {
                        FreezeGameArea();
                        btnOKpc.Visible = false;
                        btnOKuser.Visible = false;
                        lbl_Warning1.Visible = true;
                        lbl_Warning2.Visible = true;                       
                        btn_FACE.BackgroundImage = Properties.Resources.sad;
                    }
                    else
                    {
                        tbxPCGuess.Text = NowPCGuessNumber.ToString();
                        btnPCsendTips.Enabled = true;
                        ResetPCArea();
                        IsWinPC();
                    }               
                    break;
            }
        }                    
        private int UserFirstProcesses()
        {
            userGuessNumber = ConvertTo32fromString(tbxUserGuess.Text);

            int result4D = ControlStringNumber4Digit(userGuessNumber);
            if (result4D == 0) { tbxUserGuess.Text = ""; return -1; }

            userGuessNumberReserveDigit = ReserveDigitNumber(userGuessNumber);
            bool resultUniqD = ControlNumberUniqeDigit(userGuessNumberReserveDigit);
            if (resultUniqD == false)
            {
                MessageBox.Show("Numbers must be different from each other", "Game Rule", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxUserGuess.Text = ""; return -1;
            }

            bool resultIsLastGuess= IsThereNumberinLastGuesses_User(userGuessNumber);
            if (resultIsLastGuess == true)
            {
                MessageBox.Show("Enter a number you didn't guess", "Game Rule", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxUserGuess.Text = ""; return -1;
            }
            return 1;
        }
        private int[] UserMainProcesses()
        {
            int[] result = new int[3];
            int userPlusValue = 0;
            int userMinusValue = 0;

            for (int guessIndex=1; guessIndex <= 4; guessIndex++)
            {
                for(int keptIndex = 1; keptIndex <= 4; keptIndex++)
                {
                    if (pcKeptNumberReservedDigit[keptIndex] == userGuessNumberReserveDigit[guessIndex])
                    {
                        if (keptIndex == guessIndex)
                        {
                            userPlusValue++;
                        }
                        else
                        {
                            userMinusValue++;
                        }
                        break;
                    }
                }
            }
            if(userPlusValue==0 && userMinusValue == 0)
            {
                result[0] = 0;
                return result;
            }
            else
            {
                result[0] = 1;
                result[1] = userPlusValue;
                result[2] = userMinusValue;
                return result;
            }

        }
        private void IsWinPC()
        {
            int userKeptNumber = Convert.ToInt32(enter.tbxUserNumber.Text);
            int pcGuessNumber = Convert.ToInt32(tbxPCGuess.Text);
            if (userKeptNumber == pcGuessNumber)
            {
                lblPCWinner.Visible = true;
                btn_FACE.BackgroundImage = Properties.Resources.laughing;
                scorePC++;
                lblPCScore.Text = scorePC.ToString();

                FreezeGameArea();
            }
        }
        private int IsWinUser()
        {
            int pcKeptNumber = Convert.ToInt32(enter.tbxPCNumber.Text);
            int userGuessNumber = Convert.ToInt32(tbxUserGuess.Text);
            if (pcKeptNumber == userGuessNumber)
            {
                lblUserWinner.Visible = true;
                btn_FACE.BackgroundImage = Properties.Resources.crying;
                scoreUser++;
                lblUserScore.Text = scoreUser.ToString();
                return 1;
            }
            else
            {
                return -1;
            }

        }
        private void FreezeGameArea()
        {
            enter.lblGameStarted.Text = "Game Finished";
            tbxUserGuess.ReadOnly = true;
            panelPC.Enabled = true;
            panelUser.Enabled = true;
            enter.tbxPCNumber.Visible = true;
            btn_Guess.Enabled = false;
            btnPCsendTips.Enabled = false;
            btn_NewGame.Visible = true;
        }
        private void ifStateZeroRemoveNumbersfromList()
        {
           int result =ConvertTo32fromString(tbxPCGuess.Text);
           int[] resultDigit= ReserveDigitNumber(result);
            for (int i=1;i<=4;i++)
            {               
                for (int item = 0; item < PCNumbers.Count; )
                {

                    string itemS = PCNumbers[item].ToString();
                    string digitS = resultDigit[i].ToString();
                    if (itemS.Contains(digitS))
                    {
                        PCNumbers.Remove(PCNumbers[item]);
                    }
                    else
                    {
                        item++;
                    }
                }
            }
        }                
        private void whichStateXplusXminus(int number,int pValue,int mValue)
        {
            int[] DigitsPCguessNumber = ReserveDigitNumber(number);

            for (int item = 0; item < PCNumbers.Count;)
            {
                int pcNumberInPCList = Convert.ToInt32(PCNumbers[item]);
                string pcNumberStringInPCList = pcNumberInPCList.ToString();
                int[] DigitsInPCNumbersList = ReserveDigitNumber(pcNumberInPCList);

                int i = 1;
                int countP = 0;
                int countM = 0;

                for (i = 1; i <= 4; i++)
                {
                    if (pcNumberStringInPCList.Contains(DigitsPCguessNumber[i].ToString()))
                    {
                        if (DigitsInPCNumbersList[i] == DigitsPCguessNumber[i])
                        {
                            countP++;
                        }
                        else
                        {
                            countM++;
                        }
                    }
                }

                if (countP == pValue && countM == mValue)
                {
                    item++;
                }
                else
                {
                    PCNumbers.Remove(PCNumbers[item]);
                }
            }
            PCNumbers.Remove(number);
        }    
        private void SolveTips(int tip) // states
        {
            int number = ConvertTo32fromString(tbxPCGuess.Text);
            switch (tip)
            {
                case 10:                 
                    whichStateXplusXminus(number,1,0);
                    break;
                case 11:                 
                    whichStateXplusXminus(number, 1, 1);
                    break;
                case 12:                
                    whichStateXplusXminus(number, 1, 2);
                    break;
                case 13:                  
                    whichStateXplusXminus(number, 1, 3);
                    break;
                case 20:                  
                    whichStateXplusXminus(number, 2, 0);
                    break;
                case 21:                  
                    whichStateXplusXminus(number, 2, 1);
                    break;
                case 22:
                    whichStateXplusXminus(number, 2, 2);
                    break;
                case 30:                   
                    whichStateXplusXminus(number, 3, 0);
                    break;
                case 01:                
                    whichStateXplusXminus(number, 0, 1);
                    break;
                case 02:                  
                    whichStateXplusXminus(number, 0, 2);
                    break;
                case 03:               
                    whichStateXplusXminus(number, 0, 3);
                    break;
                case 04:                  
                    whichStateXplusXminus(number, 0, 4);
                    break;

            }
        }
        private void ResetGame()
        {
            FormState = true;
            timerUpDown.Start();
            UserLastGuessNumbers.Clear();  // look again 
            enter.btn_UserPin.Visible = false;
            enter.tbxUserNumber.Enabled = true;
            enter.tbxUserNumber.Text = "";
            enter.lbl_PcInfoNumber.Visible = false;
            enter.tbxPCNumber.Visible = false;
            enter.btn_PcPin.Visible = false;
            enter.lbl_PC_KeptQuessNumber.Visible = false;
            enter.lblGameStarted.Visible = false;
            enter.lblGameStarted.Text = "Game Started";
            enter.btn_Start.Visible = true;
            enter.enterProcessCount = 0;

            tbxUserGuess.ReadOnly = false;
            lblPcLastGuess.Text = "";
            lblUserLastGuess.Text = "";
            lblresultUserTipsZero.Visible = true;
            gbxresultUserTipsPlusMinusValues.Visible = true;
            tbxResultUserTipMinus.Text = "";
            tbxResultUserTipPlus.Text = "";
            lblUserWinner.Visible = false;
            lblPCWinner.Visible = false;
            cbxPCZero.Enabled = true;
            tbxPCGuess.Text = "";

            tbxResultPCTipMinus.Text = "";
            tbxResultPCTipPlus.Text = "";

            lbl_Warning1.Visible = false;
            lbl_Warning2.Visible = false;
           
            btn_FACE.BackgroundImage = null;
            tbxUserGuess.Text = "";
        }
        private void ResetUserArea()
        {
            tbxUserGuess.Text = "";
            btn_Guess.Enabled = false;        
        }
        private void ResetPCArea()
        {
            tbxResultPCTipMinus.Text = "";
            tbxResultPCTipPlus.Text = "";
            cbxPCZero.CheckState = CheckState.Unchecked;
            gbxPC_plusminus.Visible = true;

        }

        //--------------------------------------------------


        // Auxiliary opearations ---------------------------------------

        private void CbxPCZero_Click(object sender, EventArgs e)
        {
            if (cbxPCZero.Checked)
            {
                gbxPC_plusminus.Visible = false;
            }
            else
            {
                gbxPC_plusminus.Visible = true;
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.L)
            {
                enter.tbxPCNumber.Visible = true;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.L)
            {
                enter.tbxPCNumber.Visible = false; 
            }
        }
        private void TbxUserGuess_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void TbxUserGuess_TextChanged(object sender, EventArgs e)
        {
            if (tbxUserGuess.Text != null)
            {
                btn_Guess.Enabled = true;
            }
            else
            {
                btn_Guess.Enabled = false;
            }
        }
        private void TbxResultPCTipMinus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 52) || (int)e.KeyChar == 8)
            {
                e.Handled = false;//eğer rakamsa  yazdır.
            }
            else
            {
                e.Handled = true;
            }
            //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
        private void TbxResultPCTipPlus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 51) || (int)e.KeyChar == 8 )
            {
                e.Handled = false;//eğer rakamsa  yazdır.
            }
            else
            {
                e.Handled = true;
            }
            
            //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        //--------------------------------------------------------------------------


        // Timers----------------------------------------------------
        
        private void TimerSelectPCorUser_Tick(object sender, EventArgs e)
        {
            if (timerSelect == false)
            {
                btnOKpc.Visible = true;
                btnOKuser.Visible = false;
                timerSelect = true;
            }
            else
            {
                btnOKpc.Visible = false;
                btnOKuser.Visible = true;
                timerSelect = false;
            }
            timerSelectCount++;
            if (timerSelectCount == 6)
            {

                timerSelectCount = 0;
                panelUser.Visible = true;
                panelPC.Visible = true;
                if (SelectPCorUser == 0)
                {
                    SortMechanismProcess(0);
                }
                else
                {
                    SortMechanismProcess(1);
                }
                timerSelectPCorUser.Stop();
            }

        }   
        private void TimerUpDown_Tick(object sender, EventArgs e)
        {
            if (FormState == false)
            {
                if (Height < 723) { Height = Height + 40; }
                else { timerUpDown.Stop(); }
            }
            else
            {
                if (Height > 298) { Height = Height - 40; }
                else { timerUpDown.Stop(); }
            }
        }      
        private void TimerWait_Tick(object sender, EventArgs e)
        {
            if (timerWaitSelect == 0)
            {
                SortMechanismProcess(0);
            }
            else if (timerWaitSelect == 1)
            {
                SortMechanismProcess(1);
            }
            timerWait.Stop();
        }

        //  ----------------------------------------------------



    }
}
