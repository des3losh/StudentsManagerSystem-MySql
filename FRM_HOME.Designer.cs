﻿namespace Students_Manager_System___With_MySql
{
    partial class FRM_HOME
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_HOME));
            this.menuStripTop = new System.Windows.Forms.MenuStrip();
            this.btFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSinOut = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.ادارةالطلبةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddNewSt = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSMange = new System.Windows.Forms.ToolStripMenuItem();
            this.الموادوالدرجاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCourceM = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMarks = new System.Windows.Forms.ToolStripMenuItem();
            this.مساعدةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnStudentMange = new System.Windows.Forms.ToolStripButton();
            this.btnCourcesMange = new System.Windows.Forms.ToolStripButton();
            this.btnMarksMange = new System.Windows.Forms.ToolStripButton();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblComputer = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDate = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDateTime = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsClose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripTop.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.lblDateTime.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripTop
            // 
            this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btFile,
            this.ادارةالطلبةToolStripMenuItem,
            this.الموادوالدرجاتToolStripMenuItem,
            this.مساعدةToolStripMenuItem});
            this.menuStripTop.Location = new System.Drawing.Point(0, 0);
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Size = new System.Drawing.Size(754, 24);
            this.menuStripTop.TabIndex = 0;
            this.menuStripTop.Text = "menuStrip1";
            // 
            // btFile
            // 
            this.btFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSinOut,
            this.btnClose});
            this.btFile.Name = "btFile";
            this.btFile.Size = new System.Drawing.Size(42, 20);
            this.btFile.Text = "ملف";
            // 
            // btnSinOut
            // 
            this.btnSinOut.Enabled = false;
            this.btnSinOut.Name = "btnSinOut";
            this.btnSinOut.Size = new System.Drawing.Size(152, 22);
            this.btnSinOut.Text = "تسجيل الخروج";
            this.btnSinOut.Click += new System.EventHandler(this.btnSinOut_Click);
            // 
            // btnClose
            // 
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(152, 22);
            this.btnClose.Text = "خروج";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ادارةالطلبةToolStripMenuItem
            // 
            this.ادارةالطلبةToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddNewSt,
            this.btnSMange});
            this.ادارةالطلبةToolStripMenuItem.Name = "ادارةالطلبةToolStripMenuItem";
            this.ادارةالطلبةToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ادارةالطلبةToolStripMenuItem.Text = "الطلبة";
            // 
            // btnAddNewSt
            // 
            this.btnAddNewSt.Name = "btnAddNewSt";
            this.btnAddNewSt.Size = new System.Drawing.Size(161, 22);
            this.btnAddNewSt.Text = "اضافة طالب جديد";
            this.btnAddNewSt.Click += new System.EventHandler(this.btnAddNewSt_Click);
            // 
            // btnSMange
            // 
            this.btnSMange.Name = "btnSMange";
            this.btnSMange.Size = new System.Drawing.Size(161, 22);
            this.btnSMange.Text = "ادارة الطلبة";
            this.btnSMange.Click += new System.EventHandler(this.btnSMange_Click);
            // 
            // الموادوالدرجاتToolStripMenuItem
            // 
            this.الموادوالدرجاتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCourceM,
            this.btnMarks});
            this.الموادوالدرجاتToolStripMenuItem.Name = "الموادوالدرجاتToolStripMenuItem";
            this.الموادوالدرجاتToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.الموادوالدرجاتToolStripMenuItem.Text = "المواد و الدرجات";
            // 
            // btnCourceM
            // 
            this.btnCourceM.Name = "btnCourceM";
            this.btnCourceM.Size = new System.Drawing.Size(171, 22);
            this.btnCourceM.Text = "ادارة المواد الدراسية";
            this.btnCourceM.Click += new System.EventHandler(this.btnCourceM_Click);
            // 
            // btnMarks
            // 
            this.btnMarks.Name = "btnMarks";
            this.btnMarks.Size = new System.Drawing.Size(171, 22);
            this.btnMarks.Text = "الدرجات";
            this.btnMarks.Click += new System.EventHandler(this.btnMarks_Click);
            // 
            // مساعدةToolStripMenuItem
            // 
            this.مساعدةToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAbout});
            this.مساعدةToolStripMenuItem.Name = "مساعدةToolStripMenuItem";
            this.مساعدةToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.مساعدةToolStripMenuItem.Text = "مساعدة";
            // 
            // btnAbout
            // 
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(134, 22);
            this.btnAbout.Text = "حول البرنامج";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnStudentMange,
            this.btnCourcesMange,
            this.btnMarksMange});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(754, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // btnStudentMange
            // 
            this.btnStudentMange.Image = global::Students_Manager_System___With_MySql.Properties.Resources.App_Main_ico;
            this.btnStudentMange.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStudentMange.Name = "btnStudentMange";
            this.btnStudentMange.Size = new System.Drawing.Size(83, 22);
            this.btnStudentMange.Text = "ادارة الطلبة";
            this.btnStudentMange.Click += new System.EventHandler(this.btnStudentMange_Click);
            // 
            // btnCourcesMange
            // 
            this.btnCourcesMange.Image = ((System.Drawing.Image)(resources.GetObject("btnCourcesMange.Image")));
            this.btnCourcesMange.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCourcesMange.Name = "btnCourcesMange";
            this.btnCourcesMange.Size = new System.Drawing.Size(124, 22);
            this.btnCourcesMange.Text = "ادارة المواد الدراسية";
            this.btnCourcesMange.Click += new System.EventHandler(this.btnCourcesMange_Click);
            // 
            // btnMarksMange
            // 
            this.btnMarksMange.Image = ((System.Drawing.Image)(resources.GetObject("btnMarksMange.Image")));
            this.btnMarksMange.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMarksMange.Name = "btnMarksMange";
            this.btnMarksMange.Size = new System.Drawing.Size(91, 22);
            this.btnMarksMange.Text = "ادارة الدرجات";
            this.btnMarksMange.Click += new System.EventHandler(this.btnMarksMange_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "مرحبا بك في نظام ادارة الطلبة الخاص بنا .";
            this.notifyIcon.BalloonTipTitle = "مرحباَ";
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "نظام ادارة الطلبة";
            this.notifyIcon.Visible = true;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblComputer
            // 
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(92, 20);
            this.lblComputer.Text = "اسم الحاسوب :";
            // 
            // lblDate
            // 
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(12, 20);
            // 
            // lblDateTime
            // 
            this.lblDateTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDateTime.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblComputer,
            this.lblDate});
            this.lblDateTime.Location = new System.Drawing.Point(0, 434);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(754, 24);
            this.lblDateTime.TabIndex = 2;
            this.lblDateTime.Text = "    ";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsOpen,
            this.cmsAbout,
            this.cmsClose});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip.Size = new System.Drawing.Size(153, 92);
            // 
            // cmsOpen
            // 
            this.cmsOpen.Name = "cmsOpen";
            this.cmsOpen.Size = new System.Drawing.Size(152, 22);
            this.cmsOpen.Text = "فتح";
            this.cmsOpen.Click += new System.EventHandler(this.cmsOpen_Click);
            // 
            // cmsAbout
            // 
            this.cmsAbout.Name = "cmsAbout";
            this.cmsAbout.Size = new System.Drawing.Size(152, 22);
            this.cmsAbout.Text = "حول البرنامج";
            this.cmsAbout.Click += new System.EventHandler(this.cmsAbout_Click);
            // 
            // cmsClose
            // 
            this.cmsClose.Name = "cmsClose";
            this.cmsClose.Size = new System.Drawing.Size(152, 22);
            this.cmsClose.Text = "خروج";
            this.cmsClose.Click += new System.EventHandler(this.cmsClose_Click);
            // 
            // FRM_HOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 458);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStripTop);
            this.Controls.Add(this.lblDateTime);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripTop;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FRM_HOME";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نظام ادارة الطَلبة";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_HOME_FormClosed);
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStripTop.ResumeLayout(false);
            this.menuStripTop.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.lblDateTime.ResumeLayout(false);
            this.lblDateTime.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripTop;
        private System.Windows.Forms.ToolStripMenuItem btFile;
        private System.Windows.Forms.ToolStripMenuItem btnSinOut;
        private System.Windows.Forms.ToolStripMenuItem ادارةالطلبةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAddNewSt;
        private System.Windows.Forms.ToolStripMenuItem btnSMange;
        private System.Windows.Forms.ToolStripMenuItem الموادوالدرجاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnCourceM;
        private System.Windows.Forms.ToolStripMenuItem btnMarks;
        private System.Windows.Forms.ToolStripMenuItem مساعدةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAbout;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnStudentMange;
        private System.Windows.Forms.ToolStripButton btnCourcesMange;
        private System.Windows.Forms.ToolStripButton btnMarksMange;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem btnClose;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem lblComputer;
        private System.Windows.Forms.ToolStripMenuItem lblDate;
        private System.Windows.Forms.MenuStrip lblDateTime;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem cmsOpen;
        private System.Windows.Forms.ToolStripMenuItem cmsAbout;
        private System.Windows.Forms.ToolStripMenuItem cmsClose;
    }
}