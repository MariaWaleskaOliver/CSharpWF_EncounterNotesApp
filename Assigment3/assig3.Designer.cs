namespace Assigment3
{
    partial class assig3
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
            this.btnStartNewNote = new System.Windows.Forms.Button();
            this.lblErroMsg = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.calender = new System.Windows.Forms.DateTimePicker();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtPacName = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.listBoxPacient = new System.Windows.Forms.ListBox();
            this.txtWriteNote = new System.Windows.Forms.TextBox();
            this.txtProblem = new System.Windows.Forms.TextBox();
            this.txtBP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStartNewNote
            // 
            this.btnStartNewNote.Location = new System.Drawing.Point(22, 23);
            this.btnStartNewNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartNewNote.Name = "btnStartNewNote";
            this.btnStartNewNote.Size = new System.Drawing.Size(131, 28);
            this.btnStartNewNote.TabIndex = 0;
            this.btnStartNewNote.Text = "Start New Note ";
            this.btnStartNewNote.UseVisualStyleBackColor = true;
            this.btnStartNewNote.Click += new System.EventHandler(this.btnStartNewNote_Click);
            // 
            // lblErroMsg
            // 
            this.lblErroMsg.AutoSize = true;
            this.lblErroMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblErroMsg.Location = new System.Drawing.Point(30, 512);
            this.lblErroMsg.Name = "lblErroMsg";
            this.lblErroMsg.Size = new System.Drawing.Size(16, 15);
            this.lblErroMsg.TabIndex = 2;
            this.lblErroMsg.Text = "...";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(242, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(184, 15);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Add/ Edit/Delete Encounter Note:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Note ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Patient Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "New Problem :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date of Birth";
            // 
            // calender
            // 
            this.calender.Location = new System.Drawing.Point(346, 136);
            this.calender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calender.Name = "calender";
            this.calender.Size = new System.Drawing.Size(275, 23);
            this.calender.TabIndex = 8;
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(346, 169);
            this.txtAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(279, 23);
            this.txtAdd.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(640, 169);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(61, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(742, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Problems :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(900, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "BP Measurements:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Notes:";
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(504, 462);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 22);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete note ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddNote
            // 
            this.btnAddNote.Enabled = false;
            this.btnAddNote.Location = new System.Drawing.Point(245, 462);
            this.btnAddNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(80, 22);
            this.btnAddNote.TabIndex = 18;
            this.btnAddNote.Text = "Add note";
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(356, 463);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 22);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update note";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtPacName
            // 
            this.txtPacName.Location = new System.Drawing.Point(346, 103);
            this.txtPacName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPacName.Name = "txtPacName";
            this.txtPacName.Size = new System.Drawing.Size(275, 23);
            this.txtPacName.TabIndex = 20;
            // 
            // txtNote
            // 
            this.txtNote.Enabled = false;
            this.txtNote.Location = new System.Drawing.Point(346, 69);
            this.txtNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNote.Name = "txtNote";
            this.txtNote.ReadOnly = true;
            this.txtNote.Size = new System.Drawing.Size(275, 23);
            this.txtNote.TabIndex = 21;
            // 
            // listBoxPacient
            // 
            this.listBoxPacient.FormattingEnabled = true;
            this.listBoxPacient.ItemHeight = 15;
            this.listBoxPacient.Location = new System.Drawing.Point(30, 77);
            this.listBoxPacient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPacient.Name = "listBoxPacient";
            this.listBoxPacient.Size = new System.Drawing.Size(132, 394);
            this.listBoxPacient.TabIndex = 22;
            this.listBoxPacient.SelectedIndexChanged += new System.EventHandler(this.listBoxPacient_SelectedIndexChanged);
            // 
            // txtWriteNote
            // 
            this.txtWriteNote.Enabled = false;
            this.txtWriteNote.Location = new System.Drawing.Point(243, 248);
            this.txtWriteNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWriteNote.Multiline = true;
            this.txtWriteNote.Name = "txtWriteNote";
            this.txtWriteNote.Size = new System.Drawing.Size(770, 197);
            this.txtWriteNote.TabIndex = 23;
            // 
            // txtProblem
            // 
            this.txtProblem.Enabled = false;
            this.txtProblem.Location = new System.Drawing.Point(738, 83);
            this.txtProblem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProblem.Multiline = true;
            this.txtProblem.Name = "txtProblem";
            this.txtProblem.ReadOnly = true;
            this.txtProblem.Size = new System.Drawing.Size(110, 107);
            this.txtProblem.TabIndex = 24;
            // 
            // txtBP
            // 
            this.txtBP.Location = new System.Drawing.Point(913, 86);
            this.txtBP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBP.Multiline = true;
            this.txtBP.Name = "txtBP";
            this.txtBP.ReadOnly = true;
            this.txtBP.Size = new System.Drawing.Size(113, 107);
            this.txtBP.TabIndex = 25;
            // 
            // assig3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 555);
            this.Controls.Add(this.txtBP);
            this.Controls.Add(this.txtProblem);
            this.Controls.Add(this.txtWriteNote);
            this.Controls.Add(this.listBoxPacient);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtPacName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddNote);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.calender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblErroMsg);
            this.Controls.Add(this.btnStartNewNote);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "assig3";
            this.Text = "Encounter Notes ";
            this.Load += new System.EventHandler(this.assig3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnStartNewNote;
        private Label lblErroMsg;
        private Label lblTitle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker calender;
        private TextBox txtAdd;
        private Button btnAdd;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnDelete;
        private Button btnAddNote;
        private Button btnUpdate;
        private TextBox txtPacName;
        private TextBox txtNote;
        private ListBox listBoxPacient;
        private TextBox txtWriteNote;
        private TextBox txtProblem;
        private TextBox txtBP;
    }
}