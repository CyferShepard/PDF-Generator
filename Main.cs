//using IronPdf;
//using iText.Html2pdf;
using System.Diagnostics;
//using iText.Kernel.Geom;
//using iText.Kernel.Pdf;
//using iText.Kernel.Pdf.Canvas;
//using iText.Kernel.Pdf.Xobject;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PDF_Generator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpStart.CustomFormat = "dd/MM/yyyy";
            dtpEndDate.CustomFormat = "dd/MM/yyyy";
        }



        public void terms()
        {
            string date=((dtpEndDate.Value.Year - dtpStart.Value.Year) * 12) + dtpEndDate.Value.Month - dtpStart.Value.Month+" Months";
            txtTerm.Text = date;
        }

        public void generatePDF(Details details)
        {



            string text = "";
            try
            {
                text = File.ReadAllText(@"Templates\Template.html");
            }catch
            {
                MessageBox.Show("No Template Found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            if(text.Equals(""))
            {
                return;
            }

            text = text.Replace("[Name]", details.Name);
            text = text.Replace("[Surname]", details.Surname);
            text = text.Replace("[Title]", details.Title);
            text = text.Replace("[ID]", details.ID);
            text = text.Replace("[Date]", details.Date);
            text = text.Replace("[StartDate]", details.StartDate);
            text = text.Replace("[EndDate]", details.EndDate);
            text = text.Replace("[Term]", details.Term);
            text = text.Replace("[Plan]", details.Plan);
            text = text.Replace("[ContractNo]", details.ContractNo);

            text = text.Replace("[Amount]", details.Amount);
            text = text.Replace("[PaidAmount]", details.PaidAmount);

            text = text.Replace("[Cell]", details.Cell);
            text = text.Replace("[CustEmail]", details.CustEmail);
            text = text.Replace("[Whatsapp]", details.Whatsapp);
            text = text.Replace("[BankName]", details.BankName);
            text = text.Replace("[AccountType]", details.AccountType);
            text = text.Replace("[AccNumber]", details.AccNumber);
            text = text.Replace("[BranchCode]", details.BranchCode);


            try
            {
            String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            String full_path = path + @"\PDFs\" + details.Name + "_" + details.Surname + "_" + details.ID + ".pdf";
            System.IO.Directory.CreateDirectory(path+ @"\PDFs\");

                Debug.WriteLine(full_path);

                createPdf(text,full_path);
            string message = "PDF has been saved in "+full_path+".\nOpen Folder?";
            string title = "Success!";




            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(message, title, buttons,MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    Debug.WriteLine("Open");
                    Process.Start("explorer.exe", path + @"\PDFs");
                }
     

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.Replace("IronPDF c","C"), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }




           

        }

        public void createPdf(string html, string dest)
        {

            var generator = new NReco.PdfGenerator.HtmlToPdfConverter();
            generator.CustomWkHtmlArgs = "--enable-local-file-access";

            generator.Orientation = NReco.PdfGenerator.PageOrientation.Portrait;
            generator.Zoom = 1.15f;
            generator.Size = NReco.PdfGenerator.PageSize.A4;
            var pdfBytes = generator.GeneratePdf(html);
            File.WriteAllBytes(dest, pdfBytes);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            terms();
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            terms();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnGenerate_Click_1(object sender, EventArgs e)
        {
            Details details= new Details();
            details.Name=txtName.Text;
            details.Surname=txtSurname.Text;
            details.Title=cmbTitle.Text;
            details.ID=txtID.Text;
            details.Date = DateTime.Now.ToString("dd/MM/yyyy");
            details.StartDate = dtpStart.Value.ToString();
            details.EndDate=dtpEndDate.Value.ToString();
            if(DateTime.Compare(Convert.ToDateTime(details.StartDate), Convert.ToDateTime(details.EndDate)) >0)
            {
               MessageBox.Show("End Date Cannot Be Before Start Date", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (details.Name.Equals(""))
            {
                MessageBox.Show("Name Cannot be Blank", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (details.Surname.Equals(""))
            {
                MessageBox.Show("Surname Cannot be Blank", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (details.ID.Equals(""))
            {
                MessageBox.Show("ID Number Cannot be Blank", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            details.Plan=txtPlan.Text;
            details.ContractNo=txtContractNo.Text;
            details.Term=txtTerm.Text;
            details.Amount=txtAmount.Text;
            details.PaidAmount = txtGAET.Text;
            details.Cell=txtCell.Text;
            details.Whatsapp=txtWhatsapp.Text;
            details.CustEmail=txtEmail.Text;
            details.BankName = txtNOB.Text;
            details.AccNumber = txtAccNum.Text;
            details.AccountType=txtAccType.Text;
            details.BranchCode=txtBranchCode.Text;

            generatePDF(details);
            


        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}