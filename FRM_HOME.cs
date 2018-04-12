﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students_Manager_System___With_MySql
{
    public partial class FRM_HOME : Form
    {

        // constractor ..
        public FRM_HOME()
        {
            InitializeComponent();
        }


        // Form Load
        private void Home_Load(object sender, EventArgs e)
        {
            // notifcation on load ..
            notifyIcon.ShowBalloonTip(4);

            // computer name
            lblComputer.Text += " " + System.Environment.UserName;
        }


        // Close Button ..
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.OpenForms["MainForm"].Close();
        }


        // Sing Out button ..  
        private void btnSinOut_Click(object sender, EventArgs e)
        {
            Application.OpenForms["MainForm"].Show();
            this.Hide();
        }
        

        // add new student button ..
        private void btnAddNewSt_Click(object sender, EventArgs e)
        {
            FRM_ADD_STUDENT FRM = new FRM_ADD_STUDENT();
            FRM.MdiParent = this;
            FRM.Show();
        }


        // when the form closed ..
        private void FRM_HOME_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["MainForm"].Close();
        }


        // Manage Student Button
        private void btnSMange_Click(object sender, EventArgs e)
        {
            FRM_STUDENT_MANAGE FRM = new FRM_STUDENT_MANAGE();
            FRM.MdiParent = this;
            FRM.Show();
        }

       
        // Student Manage button ShortCat
        private void btnStudentMange_Click(object sender, EventArgs e)
        {
            btnSMange_Click(null, null);
        }


        // About ..
        private void btnAbout_Click(object sender, EventArgs e)
        {
            FRM_ABOUT FRM = new FRM_ABOUT();
            FRM.ShowDialog();
        }


        // manage cources button 
        private void btnCourceM_Click(object sender, EventArgs e)
        {
            FRM_COURCES FRM = new FRM_COURCES();
            FRM.MdiParent = this;
            FRM.Show();
        }


        // manage cources shortcat ..
        private void btnCourcesMange_Click(object sender, EventArgs e)
        {
            btnCourceM_Click(null, null);
        }


        // timer
        private void timer_Tick(object sender, EventArgs e)
        {
            // Date Time
            lblDate.Text = DateTime.Now.AddSeconds(1).ToLongTimeString();
        }


        // open Marks Manage Form 
        private void btnMarks_Click(object sender, EventArgs e)
        {
            FRM_MARKS FRM = new FRM_MARKS();
            FRM.MdiParent = this;
            FRM.Show();
        }


        // open Marks Manage Form (shortcat)
        private void btnMarksMange_Click(object sender, EventArgs e)
        {
            btnMarks_Click(null, null);
        }


        // contacs Menue Strip close
        private void cmsClose_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Close();
        }


        // contacx Menue Strip open
        private void cmsOpen_Click(object sender, EventArgs e)
        {
            this.Show();
        }
        
        
        // contacs Menue Strip close
        private void cmsAbout_Click(object sender, EventArgs e)
        {
            btnAbout_Click(null, null);
        }
    }
}
