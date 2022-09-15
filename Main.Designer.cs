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
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnExit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.cmbTitle = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtContractNo = new System.Windows.Forms.TextBox();
            this.txtPlan = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtGAET = new System.Windows.Forms.TextBox();
            this.txtCell = new System.Windows.Forms.TextBox();
            this.txtWhatsapp = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNOB = new System.Windows.Forms.TextBox();
            this.txtAccType = new System.Windows.Forms.TextBox();
            this.txtAccNum = new System.Windows.Forms.TextBox();
            this.txtBranchCode = new System.Windows.Forms.TextBox();
            this.btn_Minimize = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtTerm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "PDF Generator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(15, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // btnGenerate
            // 
            this.btnGenerate.ActiveBorderThickness = 1;
            this.btnGenerate.ActiveCornerRadius = 20;
            this.btnGenerate.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnGenerate.ActiveForecolor = System.Drawing.Color.White;
            this.btnGenerate.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.btnGenerate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGenerate.BackgroundImage")));
            this.btnGenerate.ButtonText = "Generate";
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnGenerate.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnGenerate.IdleBorderThickness = 1;
            this.btnGenerate.IdleCornerRadius = 20;
            this.btnGenerate.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnGenerate.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnGenerate.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnGenerate.Location = new System.Drawing.Point(214, 630);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(155, 36);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.ActiveBorderThickness = 2;
            this.btnExit.ActiveCornerRadius = 1;
            this.btnExit.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnExit.ActiveForecolor = System.Drawing.Color.Red;
            this.btnExit.ActiveLineColor = System.Drawing.Color.Red;
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.ButtonText = " X";
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.IdleBorderThickness = 2;
            this.btnExit.IdleCornerRadius = 1;
            this.btnExit.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnExit.IdleForecolor = System.Drawing.Color.Silver;
            this.btnExit.IdleLineColor = System.Drawing.Color.Silver;
            this.btnExit.Location = new System.Drawing.Point(543, 8);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 35);
            this.btnExit.TabIndex = 4;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(15, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(15, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(15, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Contract No.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(15, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Plan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(15, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "ID Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(15, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Start Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(315, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "End Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(15, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Term";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(15, 321);
            this.label11.MaximumSize = new System.Drawing.Size(120, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 34);
            this.label11.TabIndex = 13;
            this.label11.Text = "Amount Invested";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Location = new System.Drawing.Point(15, 365);
            this.label12.MaximumSize = new System.Drawing.Size(103, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 68);
            this.label12.TabIndex = 14;
            this.label12.Text = "Guaranteed Amount Paid at end of Term";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Silver;
            this.label13.Location = new System.Drawing.Point(13, 440);
            this.label13.MaximumSize = new System.Drawing.Size(103, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 51);
            this.label13.TabIndex = 15;
            this.label13.Text = "Contact Number (Cell)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Silver;
            this.label14.Location = new System.Drawing.Point(315, 441);
            this.label14.MaximumSize = new System.Drawing.Size(103, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 34);
            this.label14.TabIndex = 16;
            this.label14.Text = "Whatsapp Number";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Silver;
            this.label15.Location = new System.Drawing.Point(15, 498);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 17);
            this.label15.TabIndex = 17;
            this.label15.Text = "Email Address";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.Silver;
            this.label16.Location = new System.Drawing.Point(15, 538);
            this.label16.MaximumSize = new System.Drawing.Size(120, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 17);
            this.label16.TabIndex = 18;
            this.label16.Text = "Name Of Bank";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.Silver;
            this.label17.Location = new System.Drawing.Point(304, 539);
            this.label17.MaximumSize = new System.Drawing.Size(120, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 17);
            this.label17.TabIndex = 19;
            this.label17.Text = "Account Type";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.Silver;
            this.label18.Location = new System.Drawing.Point(15, 577);
            this.label18.MaximumSize = new System.Drawing.Size(120, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 34);
            this.label18.TabIndex = 20;
            this.label18.Text = "Account Number";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.Silver;
            this.label19.Location = new System.Drawing.Point(304, 578);
            this.label19.MaximumSize = new System.Drawing.Size(120, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(96, 17);
            this.label19.TabIndex = 21;
            this.label19.Text = "Branch Code";
            // 
            // dtpStart
            // 
            this.dtpStart.CalendarFont = new System.Drawing.Font("Century Gothic", 12F);
            this.dtpStart.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dtpStart.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(124, 253);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(172, 23);
            this.dtpStart.TabIndex = 22;
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarFont = new System.Drawing.Font("Century Gothic", 12F);
            this.dtpEndDate.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dtpEndDate.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(388, 254);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(172, 23);
            this.dtpEndDate.TabIndex = 23;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // cmbTitle
            // 
            this.cmbTitle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmbTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTitle.FormattingEnabled = true;
            this.cmbTitle.Items.AddRange(new object[] {
            "",
            "Mr.",
            "Mrs.",
            "Ms."});
            this.cmbTitle.Location = new System.Drawing.Point(124, 46);
            this.cmbTitle.Name = "cmbTitle";
            this.cmbTitle.Size = new System.Drawing.Size(104, 21);
            this.cmbTitle.TabIndex = 25;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtName.Location = new System.Drawing.Point(124, 85);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(436, 23);
            this.txtName.TabIndex = 26;
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSurname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSurname.Location = new System.Drawing.Point(124, 119);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(436, 23);
            this.txtSurname.TabIndex = 27;
            // 
            // txtContractNo
            // 
            this.txtContractNo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtContractNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContractNo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtContractNo.Location = new System.Drawing.Point(124, 153);
            this.txtContractNo.Name = "txtContractNo";
            this.txtContractNo.Size = new System.Drawing.Size(436, 23);
            this.txtContractNo.TabIndex = 28;
            // 
            // txtPlan
            // 
            this.txtPlan.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPlan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlan.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPlan.Location = new System.Drawing.Point(124, 185);
            this.txtPlan.Name = "txtPlan";
            this.txtPlan.Size = new System.Drawing.Size(436, 23);
            this.txtPlan.TabIndex = 29;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtID.Location = new System.Drawing.Point(124, 218);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(436, 23);
            this.txtID.TabIndex = 30;
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAmount.Location = new System.Drawing.Point(124, 319);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(436, 23);
            this.txtAmount.TabIndex = 31;
            // 
            // txtGAET
            // 
            this.txtGAET.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtGAET.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGAET.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtGAET.Location = new System.Drawing.Point(124, 387);
            this.txtGAET.Name = "txtGAET";
            this.txtGAET.Size = new System.Drawing.Size(436, 23);
            this.txtGAET.TabIndex = 32;
            // 
            // txtCell
            // 
            this.txtCell.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCell.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCell.Location = new System.Drawing.Point(124, 447);
            this.txtCell.Name = "txtCell";
            this.txtCell.Size = new System.Drawing.Size(155, 23);
            this.txtCell.TabIndex = 33;
            // 
            // txtWhatsapp
            // 
            this.txtWhatsapp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtWhatsapp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWhatsapp.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtWhatsapp.Location = new System.Drawing.Point(405, 447);
            this.txtWhatsapp.Name = "txtWhatsapp";
            this.txtWhatsapp.Size = new System.Drawing.Size(155, 23);
            this.txtWhatsapp.TabIndex = 34;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEmail.Location = new System.Drawing.Point(124, 496);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(436, 23);
            this.txtEmail.TabIndex = 35;
            // 
            // txtNOB
            // 
            this.txtNOB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNOB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNOB.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNOB.Location = new System.Drawing.Point(125, 537);
            this.txtNOB.Name = "txtNOB";
            this.txtNOB.Size = new System.Drawing.Size(155, 23);
            this.txtNOB.TabIndex = 36;
            // 
            // txtAccType
            // 
            this.txtAccType.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtAccType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccType.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAccType.Location = new System.Drawing.Point(406, 537);
            this.txtAccType.Name = "txtAccType";
            this.txtAccType.Size = new System.Drawing.Size(155, 23);
            this.txtAccType.TabIndex = 37;
            // 
            // txtAccNum
            // 
            this.txtAccNum.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtAccNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccNum.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAccNum.Location = new System.Drawing.Point(125, 576);
            this.txtAccNum.Name = "txtAccNum";
            this.txtAccNum.Size = new System.Drawing.Size(155, 23);
            this.txtAccNum.TabIndex = 38;
            // 
            // txtBranchCode
            // 
            this.txtBranchCode.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBranchCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBranchCode.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBranchCode.Location = new System.Drawing.Point(406, 576);
            this.txtBranchCode.Name = "txtBranchCode";
            this.txtBranchCode.Size = new System.Drawing.Size(155, 23);
            this.txtBranchCode.TabIndex = 39;
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.ActiveBorderThickness = 2;
            this.btn_Minimize.ActiveCornerRadius = 1;
            this.btn_Minimize.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btn_Minimize.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Minimize.ActiveLineColor = System.Drawing.Color.White;
            this.btn_Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.btn_Minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Minimize.BackgroundImage")));
            this.btn_Minimize.ButtonText = " __";
            this.btn_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Minimize.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_Minimize.ForeColor = System.Drawing.Color.Black;
            this.btn_Minimize.IdleBorderThickness = 2;
            this.btn_Minimize.IdleCornerRadius = 1;
            this.btn_Minimize.IdleFillColor = System.Drawing.Color.Transparent;
            this.btn_Minimize.IdleForecolor = System.Drawing.Color.Silver;
            this.btn_Minimize.IdleLineColor = System.Drawing.Color.Silver;
            this.btn_Minimize.Location = new System.Drawing.Point(495, 8);
            this.btn_Minimize.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(34, 35);
            this.btn_Minimize.TabIndex = 40;
            this.btn_Minimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // txtTerm
            // 
            this.txtTerm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTerm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTerm.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTerm.ForeColor = System.Drawing.Color.Black;
            this.txtTerm.Location = new System.Drawing.Point(124, 285);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(172, 20);
            this.txtTerm.TabIndex = 41;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(585, 690);
            this.Controls.Add(this.txtTerm);
            this.Controls.Add(this.btn_Minimize);
            this.Controls.Add(this.txtBranchCode);
            this.Controls.Add(this.txtAccNum);
            this.Controls.Add(this.txtAccType);
            this.Controls.Add(this.txtNOB);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtWhatsapp);
            this.Controls.Add(this.txtCell);
            this.Controls.Add(this.txtGAET);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtPlan);
            this.Controls.Add(this.txtContractNo);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cmbTitle);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF Generator";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGenerate;
        private Bunifu.Framework.UI.BunifuThinButton2 btnExit;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEndDate;
        private ComboBox cmbTitle;
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtContractNo;
        private TextBox txtPlan;
        private TextBox txtID;
        private TextBox txtAmount;
        private TextBox txtGAET;
        private TextBox txtCell;
        private TextBox txtWhatsapp;
        private TextBox txtEmail;
        private TextBox txtNOB;
        private TextBox txtAccType;
        private TextBox txtAccNum;
        private TextBox txtBranchCode;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Minimize;
        private Label txtTerm;
    }
}