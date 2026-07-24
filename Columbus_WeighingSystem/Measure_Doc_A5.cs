using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.Data;
using DevExpress.XtraPrinting.Drawing;

namespace WeighingSystem
{
    public partial class Measure_Doc_A5 : DevExpress.XtraReports.UI.XtraReport
    {
        public Measure_Doc_A5()
        {
            InitializeComponent();
        }

        public Measure_Doc_A5(DataTable dt, Dictionary<string, Image> dicImage, string gubun)
        {
            InitializeComponent();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    string jobgu = dt.Columns.Contains("JOBGU")
                        ? dt.Rows[0]["JOBGU"]?.ToString().Trim()
                        : "";


                    bool isOut = jobgu == "O";
                    string gubunText = isOut ? "출고" : "입고";



                    if (gubun.Equals("IN")) { xrGUBUN.Text = "( 보 관 용 )"; }
                    if (gubun.Equals("OUT")) { xrGUBUN.Text = "( 제 출 용 )"; }

                    xrLabelGubun.Text = gubunText;

                    xrSLINO_1.Text += dt.Rows[0]["SLINO"]?.ToString();
                    xrTDATE_1.Text = dt.Rows[0]["TDATE"]?.ToString();
                    xrCARNO_1.Text = dt.Rows[0]["CARNO"]?.ToString();
                    xrITNAM_1.Text = dt.Rows[0]["ITNAM"]?.ToString();
                    xrCVNAM_1.Text = dt.Rows[0]["CVNAM"]?.ToString();
                    //xrFTIME_1.Text = dt.Rows[0]["FTIME"]?.ToString();
                    //xrSTIME_1.Text = dt.Rows[0]["STIME"]?.ToString();
                    //xrRWEIT_1.Text = dt.Rows[0]["RWEIT"]?.ToString();
                    //xrEWEIT_1.Text = dt.Rows[0]["EWEIT"]?.ToString();

                    // 중량 표시
                    xrRWEIT_1.Text = dt.Rows[0]["RWEIT"]?.ToString();
                    xrEWEIT_1.Text = dt.Rows[0]["EWEIT"]?.ToString();

                    // 시간 표시
                    if (isOut)
                    {
                        // 출고: 총중량 시간 = 2차 시간, 공차중량 시간 = 1차 시간
                        xrFTIME_1.Text = dt.Rows[0]["STIME"]?.ToString();
                        xrSTIME_1.Text = dt.Rows[0]["FTIME"]?.ToString();
                    }
                    else
                    {
                        // 입고: 총중량 시간 = 1차 시간, 공차중량 시간 = 2차 시간
                        xrFTIME_1.Text = dt.Rows[0]["FTIME"]?.ToString();
                        xrSTIME_1.Text = dt.Rows[0]["STIME"]?.ToString();
                    }

                    xrLSPER_1.Text = dt.Rows[0]["LSPER"]?.ToString();
                    xrLWEIT_1.Text = dt.Rows[0]["LWEIT"]?.ToString();
                    xrAWEIT_1.Text = dt.Rows[0]["AWEIT"]?.ToString();
                    //xrUCOST_1.Text = dt.Rows[0]["UCOST"]?.ToString();
                    //xrTRAMT_1.Text = dt.Rows[0]["TRAMT"]?.ToString();
                    xrCARPL_1.Text = dt.Rows[0]["CARPL"]?.ToString();
                    xrPLNAM_1.Text = dt.Rows[0]["PLNAM"]?.ToString();
                    xrRK_1.Text = dt.Rows[0]["RK"]?.ToString();
                    xrPic_1_1_1.ImageSource = new ImageSource(dicImage["1_1"]);
                    xrPic_1_2_1.ImageSource = new ImageSource(dicImage["1_2"]);
                    xrPic_2_1_1.ImageSource = new ImageSource(dicImage["2_1"]);
                    xrPic_2_2_1.ImageSource = new ImageSource(dicImage["2_2"]);
                    if (string.IsNullOrEmpty(xrRWEIT_1.Text)) { xrRWEIT_1.Text = "0"; }
                    if (string.IsNullOrEmpty(xrEWEIT_1.Text)) { xrEWEIT_1.Text = "0"; }
                    if (string.IsNullOrEmpty(xrLSPER_1.Text)) { xrLSPER_1.Text = "0.00"; }
                    if (string.IsNullOrEmpty(xrLWEIT_1.Text)) { xrLWEIT_1.Text = "0"; }
                    if (string.IsNullOrEmpty(xrAWEIT_1.Text)) { xrAWEIT_1.Text = "0"; }
                    //if (string.IsNullOrEmpty(xrUCOST_1.Text)) { xrUCOST_1.Text = "0.00"; }
                    //if (string.IsNullOrEmpty(xrTRAMT_1.Text)) { xrTRAMT_1.Text = "0"; }
                    xrCVGNM_1.Text = string.Concat("콜럼버스(주)", dt.Rows[0]["CVGNM"]?.ToString());
                    xrADDR_1.Text = dt.Rows[0]["ADDR"]?.ToString();
                    xrTELNO_1.Text = string.Concat("Tel : ", dt.Rows[0]["TEL"]?.ToString(), "    Fax : ", dt.Rows[0]["FAX"]?.ToString());
                }
            }
        }

        private void Measure_Doc_A5_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
        }
    }
}
