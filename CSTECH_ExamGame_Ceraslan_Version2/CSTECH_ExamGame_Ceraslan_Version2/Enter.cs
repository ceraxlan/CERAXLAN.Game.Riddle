using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSTECH_ExamGame_Ceraslan_Version2
{
    public partial class Enter : UserControl
    {
        Form1 mainForm;
        public Enter(Form1 frm)
        {
            mainForm = frm;
            InitializeComponent();
        }
        internal void EnterLoad()
        {

        }
        private void Btn_Start_Click(object sender, EventArgs e)
        {
            int userNumber=mainForm.ConvertTo32fromString(tbxUserNumber.Text);
            int result4D=mainForm.ControlStringNumber4Digit(userNumber);
            if (result4D == 0) { tbxUserNumber.Text = ""; return; }
            int[] resultReservedD = mainForm.ReserveDigitNumber(userNumber);
            bool resultUniqD = mainForm.ControlNumberUniqeDigit(resultReservedD);
            if (resultUniqD == false)
            {   MessageBox.Show("Numbers must be different from each other", "Game Rule", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxUserNumber.Text = ""; return;
            }
            btn_Start.Visible = false;
            mainForm.userKeptNumberReservedDigit = mainForm.ReserveDigitNumber(userNumber);
           
            timerEnterProcesses.Start();
        }
        private void TbxUserNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void TbxUserNumber_TextChanged(object sender, EventArgs e)
        {
            if (tbxUserNumber.Text != null)
            {
                btn_Start.Enabled = true;
            }
        }

        public  int enterProcessCount = 0;
        private void TimerEnterProcesses_Tick(object sender, EventArgs e)
        {
            switch (enterProcessCount)
            {
                case 0:
                    tbxUserNumber.Enabled = false;
                    break;
                case 1:
                    btn_UserPin.Visible = true;
                    break;
                case 2:
                    lbl_PcInfoNumber.Visible = true;
                    break;
                case 3:
                    mainForm.GeneratePCNumbersList();
                    tbxPCNumber.Text= mainForm.GetRandomNumberforPCfromPCList().ToString();
                    break;
                case 4:
                    btn_PcPin.Visible = true;
                    break;
                case 5:
                    lbl_PC_KeptQuessNumber.Visible = true;
                    int pcNumber = mainForm.ConvertTo32fromString(tbxPCNumber.Text);
                    mainForm.pcKeptNumberReservedDigit = mainForm.ReserveDigitNumber(pcNumber);
                    break;
                case 6:
                    lblGameStarted.Visible = true;
                    mainForm.FormState = false;
                    mainForm.timerUpDown.Start();
                    break;
                case 7:
                    mainForm.SelectRandomUserOrPc();
                    mainForm.timerSelectPCorUser.Start();
                    enterProcessCount = 0;
                    timerEnterProcesses.Stop();
                    break;

            }
            enterProcessCount++;
        }       
        private void Btn_Start_MouseClick(object sender, MouseEventArgs e)
        {
            btn_Start.Enabled = false;
        }
    }
}
