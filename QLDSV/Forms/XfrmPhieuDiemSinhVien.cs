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
    public partial class XfrmPhieuDiemSinhVien : DevExpress.XtraEditors.XtraForm
    {
        public XfrmPhieuDiemSinhVien()
        {
            InitializeComponent();
        }

        private void XfrmPhieuDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_QLDSV.V_dssv' table. You can move, or remove it, as needed.
            this.v_dssvTableAdapter.Fill(this.dS_QLDSV.V_dssv);

        }

        private void btnIn_Click(object sender, EventArgs e)
        {

            String masv = cbbMASV.SelectedValue.ToString();
            Xtrp_PhieuDiemSinhVien xtrp_PhieuDiem = new Xtrp_PhieuDiemSinhVien(masv);
            ReportPrintTool print = new ReportPrintTool(xtrp_PhieuDiem);
            print.ShowPreviewDialog();
        }
    }
}