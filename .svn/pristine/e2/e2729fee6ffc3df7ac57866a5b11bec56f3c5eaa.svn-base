using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting.Drawing;
using System.Data;
using System.Collections.Generic;

namespace WeighingSystem
{
    public partial class Measure_Doc : DevExpress.XtraReports.UI.XtraReport
    {
        public Measure_Doc()
        {
            InitializeComponent();
        }

        public Measure_Doc(DataTable dt, Dictionary<string, Image> dicImage)
        {
            InitializeComponent();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    // 보관용
                    xrSLINO_1.Text += dt.Rows[0]["SLINO"]?.ToString();
                    xrTDATE_1.Text = dt.Rows[0]["TDATE"]?.ToString();
                    xrCARNO_1.Text = dt.Rows[0]["CARNO"]?.ToString();
                    xrITNAM_1.Text = dt.Rows[0]["ITNAM"]?.ToString();
                    xrCVNAM_1.Text = dt.Rows[0]["CVNAM"]?.ToString();
                    xrFTIME_1.Text = dt.Rows[0]["FTIME"]?.ToString();
                    xrSTIME_1.Text = dt.Rows[0]["STIME"]?.ToString();
                    xrRWEIT_1.Text = dt.Rows[0]["RWEIT"]?.ToString();
                    xrEWEIT_1.Text = dt.Rows[0]["EWEIT"]?.ToString();
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

                    // 제출용
                    xrSLINO_2.Text += dt.Rows[0]["SLINO"]?.ToString();
                    xrTDATE_2.Text = dt.Rows[0]["TDATE"]?.ToString();
                    xrCARNO_2.Text = dt.Rows[0]["CARNO"]?.ToString();
                    xrITNAM_2.Text = dt.Rows[0]["ITNAM"]?.ToString();
                    xrCVNAM_2.Text = dt.Rows[0]["CVNAM"]?.ToString();
                    xrFTIME_2.Text = dt.Rows[0]["FTIME"]?.ToString();
                    xrSTIME_2.Text = dt.Rows[0]["STIME"]?.ToString();
                    xrRWEIT_2.Text = dt.Rows[0]["RWEIT"]?.ToString();
                    xrEWEIT_2.Text = dt.Rows[0]["EWEIT"]?.ToString();
                    xrLSPER_2.Text = dt.Rows[0]["LSPER"]?.ToString();
                    xrLWEIT_2.Text = dt.Rows[0]["LWEIT"]?.ToString();
                    xrAWEIT_2.Text = dt.Rows[0]["AWEIT"]?.ToString();
                    //xrUCOST_2.Text = dt.Rows[0]["UCOST"]?.ToString();
                    //xrTRAMT_2.Text = dt.Rows[0]["TRAMT"]?.ToString();
                    xrCARPL_2.Text = dt.Rows[0]["CARPL"]?.ToString();
                    xrPLNAM_2.Text = dt.Rows[0]["PLNAM"]?.ToString();
                    xrRK_2.Text = dt.Rows[0]["RK"]?.ToString();
                    xrPic_1_1_2.ImageSource = new ImageSource(dicImage["1_1"]);
                    xrPic_1_2_2.ImageSource = new ImageSource(dicImage["1_2"]);
                    xrPic_2_1_2.ImageSource = new ImageSource(dicImage["2_1"]);
                    xrPic_2_2_2.ImageSource = new ImageSource(dicImage["2_2"]);
                    if (string.IsNullOrEmpty(xrRWEIT_2.Text)) { xrRWEIT_2.Text = "0"; }
                    if (string.IsNullOrEmpty(xrEWEIT_2.Text)) { xrEWEIT_2.Text = "0"; }
                    if (string.IsNullOrEmpty(xrLSPER_2.Text)) { xrLSPER_2.Text = "0.00"; }
                    if (string.IsNullOrEmpty(xrLWEIT_2.Text)) { xrLWEIT_2.Text = "0"; }
                    if (string.IsNullOrEmpty(xrAWEIT_2.Text)) { xrAWEIT_2.Text = "0"; }
                    //if (string.IsNullOrEmpty(xrUCOST_2.Text)) { xrUCOST_2.Text = "0.00"; }
                    //if (string.IsNullOrEmpty(xrTRAMT_2.Text)) { xrTRAMT_2.Text = "0"; }
                    xrCVGNM_2.Text = string.Concat("콜럼버스(주)", dt.Rows[0]["CVGNM"]?.ToString());
                    xrADDR_2.Text = dt.Rows[0]["ADDR"]?.ToString();
                    xrTELNO_2.Text = string.Concat("Tel : ", dt.Rows[0]["TEL"]?.ToString(), "    Fax : ", dt.Rows[0]["FAX"]?.ToString());
                }
            }
        }

        private void Measure_Doc_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
    }
}