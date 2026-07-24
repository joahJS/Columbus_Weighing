using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
/*
 * 작성일자 
 * 작성자 : 앤로비
 * ----------------HISTORY------------------
 * 1. 수정일자 : 2021-01-28
 *    수정자 : 고혜성
 *    수정내용 : (현업요청)메시지 폼이 나온 후 10초간 아무런 액션이 없을 시 취소처리하도록 수정
 *    
 *    
 * 2. 수정일자 : 2022-12-08
 *    수정자   : 정은영
 *    수정내용 : (요청)
 *              1. (기존)완료버튼 눌렀을때 캡쳐프로그램 닫기 => (변경)계근표 출력 이후 닫기 진행
 */

namespace WeighingSystem
{
    public partial class PrintForm : Form
    {
        public PrintForm()
        {
            InitializeComponent();
        }

        public PrintForm(string _Label1, string _Label2)
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(_Label1)) { label1.Text = _Label1; }
            if (!string.IsNullOrEmpty(_Label2)) { label2.Text = _Label2; }
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private System.Timers.Timer _timer;
        private void PrintForm_Load(object sender, EventArgs e)
        {
            //_timer = new System.Timers.Timer();
            //_timer.Interval = 500; // 1초
            //_timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
            //_timer.Start();
        }

        /*
         * 2021-01-28 현업요청 
         * 메시지 폼이 나온 후 15초간 아무런 액션이 없을 시 취소처리하도록 수정
         */
        private int _TIMER_CNT = 0;
        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            //try
            //{
            //    if (_TIMER_CNT == 9)
            //    {
            //        DialogResult = DialogResult.No;
            //        _timer.Stop();
            //    }
            //    _TIMER_CNT++;
            //}
            //catch(Exception ex)
            //{

            //}
        }

        private void PrintForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //try
            //{
            //    _timer.Stop();
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void PrintForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //#001
            //Process[] prcList = Process.GetProcessesByName("FxVRAPI_FHS_App");
            //if (prcList.Length != 0)
            //{
            //    prcList[0].Kill();
            //}
        }
    }
}
