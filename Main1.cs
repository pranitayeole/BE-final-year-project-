using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;



using System.IO;
using System.Diagnostics;



namespace MultiFaceRec
{
    public partial class Main1 : Form
    {
        //private int childFormNumber = 0;

        public Main1()
        {
            InitializeComponent();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            //saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            //if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            //{
            //    string FileName = saveFileDialog.FileName;
            //}
        }



        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //foreach (Form childForm in MdiChildren)
            //{
            //    childForm.Close();
            //}
        }

        private void ElectricalMainForm_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CustomerBillForm1 frm2 = new CustomerBillForm1();
        //    FRM_Pashukhadya_Vikri frm = new FRM_Pashukhadya_Vikri();
         //   frm.MdiParent = this;
           // frm.Show();


        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {

            
            toolStripStatusLabel1.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");//DateTime.Now("dd/MM/yyyy hh:mm:ss tt");

        
        }

       
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  FRM_CustomerBonus frm = new FRM_CustomerBonus();
           // frm.MdiParent = this;

          //  frm.Show();
        }

      

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  FRM_ChangePassword frm = new FRM_ChangePassword();
          //  frm.MdiParent = this;
          //  frm.Show();
        }

        private void backupAndRestoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
         //   FRM_Backup_And_Restore frm = new FRM_Backup_And_Restore();
          //  frm.MdiParent = this;
          //  frm.Show();

        }

        private void createNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  FRM_CreateNewUser frm = new FRM_CreateNewUser();
           // frm.MdiParent = this;
          //  frm.Show();

        }

        //private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //AboutUs Au = new AboutUs();
        //    //Au.Show();
        //}

       
        private void supplierInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  FRM_Milk_Bill_ frm = new FRM_Milk_Bill_();
           // frm.MdiParent = this;
           // frm.Show();
        }

        private void productInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  Frmuchrpt frm = new Frmuchrpt();
         //   frm.MdiParent = this;
          //  frm.Show();
        }

      

        private void paymentEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Payment_Entry_ReportForm frm = new Payment_Entry_ReportForm();
            //frm.Height = this.Height - 2;
            //frm.Width = this.Width - 2;
            //frm.MdiParent = this;
            //frm.Show();

        }

       

        private void exitToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                this.Close();
            }
        }


        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
          //  frmDailyCollection frm = new frmDailyCollection();
         //   frm.MdiParent = this;
          //  frm.Show();
        }

       

        //private void profitAndLossToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //FrmProfit_Loss_Form frm = new FrmProfit_Loss_Form();

        //    //frm.MdiParent = this;
        //    //frm.Show();
        //}



        private void ElectricalMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
           

        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }


        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

       


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }

        private void transport_Click(object sender, EventArgs e)
        {
          //  FrmTransportInfo frm = new FrmTransportInfo();
         //   frm.MdiParent = this;
          //  frm.Show();
        }

       

        private void cusbill_Click(object sender, EventArgs e)
        {
          //  FRM_Payment_Tran frm = new FRM_Payment_Tran();
//frm.MdiParent = this;
//frm.Show();
        }

        private void गरहकउचलमसटरToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void महसToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void गयToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

      

        private void रतबबलToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click_2(object sender, EventArgs e)
        {
     
            
        }

       
       


        

        private void CustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void dailytra_Click(object sender, EventArgs e)
        {
           

            
        }

        private void valueInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void custBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_ReportViewer frm = new Frm_ReportViewer();
            //Frm_ReportViewer frm = new Frm_ReportViewer();
            //frm.Width = this.Width - 2;
            //frm.Height = this.Height - 2;
            //frm.MdiParent = this;
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void saleTransactionListToolStripMenuItem_Click(object sender, EventArgs e)
        {

          
           
        }

      

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void receivedBillTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
          
        }

        private void creditCustomerReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

          

            
           
        }

        private void custBillToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void reservedInvoiceListToolStripMenuItem_Click(object sender, EventArgs e)
        {

          
           
        }

        private void accountStatementReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void makeReservedInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void purchaseRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }

        private void saleSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void purchaseSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void gSTComputationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void stateInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.MdiParent = this;
            frm.Show();
        }

        private void editMenu_Click(object sender, EventArgs e)
        {

        }

        private void billTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void saleTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            
        }

        private void reservedInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void createNewUserToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void createNewPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void setPrinterNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void gSTComputationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }

        private void productInformationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
        }

        private void makeReservedInvoiceToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
        }

        private void shriKrishnaServiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void backupAndRestoreToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void purchaseTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void verificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        
    }
}
