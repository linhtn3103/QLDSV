﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace QLDSV.Forms
{
    public partial class XfrmDSSV : DevExpress.XtraEditors.XtraForm
    {
        public XfrmDSSV()
        {
            InitializeComponent();
        }

        private void XfrmDSSV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_QLDSV.v_dskhoa' table. You can move, or remove it, as needed.
            this.v_dskhoaTableAdapter.Fill(this.dS_QLDSV.v_dskhoa);
            // TODO: This line of code loads data into the 'dS_QLDSV.v_dslop' table. You can move, or remove it, as needed.
            this.v_dslopTableAdapter.Fill(this.dS_QLDSV.v_dslop);
            // TODO: This line of code loads data into the 'dS_DSPM.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Fill(this.dS_DSPM.V_DSPM);

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            String makhoa = cbbMAKHOA.SelectedValue.ToString();
            Console.WriteLine("ma khoa: " + makhoa);
            String malop = cbbMALOP.SelectedValue.ToString();
            Console.WriteLine("ma lop: " + malop);
            Xtrp_DSSV xtrp_DSSV = new Xtrp_DSSV(makhoa, malop);
            ReportPrintTool print = new ReportPrintTool(xtrp_DSSV);
            print.ShowPreviewDialog();
        }
    }
}