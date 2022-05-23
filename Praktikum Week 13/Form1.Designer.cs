
namespace Praktikum_Week_13
{
    partial class Player
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
            this.btnLeftEnd = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnRightEnd = new System.Windows.Forms.Button();
            this.lblPID = new System.Windows.Forms.Label();
            this.lblPName = new System.Windows.Forms.Label();
            this.lblBD = new System.Windows.Forms.Label();
            this.lblNationality = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
            this.lblTeamNum = new System.Windows.Forms.Label();
            this.txtBoxPID = new System.Windows.Forms.TextBox();
            this.txtBoxPName = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cBoxNationality = new System.Windows.Forms.ComboBox();
            this.cBoxTeam = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.numUpDownTeam = new System.Windows.Forms.NumericUpDown();
            this.lblAvaliable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLeftEnd
            // 
            this.btnLeftEnd.Location = new System.Drawing.Point(109, 23);
            this.btnLeftEnd.Name = "btnLeftEnd";
            this.btnLeftEnd.Size = new System.Drawing.Size(75, 46);
            this.btnLeftEnd.TabIndex = 0;
            this.btnLeftEnd.Text = "<<";
            this.btnLeftEnd.UseVisualStyleBackColor = true;
            this.btnLeftEnd.Click += new System.EventHandler(this.btnLeftEnd_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(222, 23);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 46);
            this.btnLeft.TabIndex = 1;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(336, 23);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 46);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnRightEnd
            // 
            this.btnRightEnd.Location = new System.Drawing.Point(454, 23);
            this.btnRightEnd.Name = "btnRightEnd";
            this.btnRightEnd.Size = new System.Drawing.Size(75, 46);
            this.btnRightEnd.TabIndex = 3;
            this.btnRightEnd.Text = ">>";
            this.btnRightEnd.UseVisualStyleBackColor = true;
            this.btnRightEnd.Click += new System.EventHandler(this.btnRightEnd_Click);
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.Location = new System.Drawing.Point(109, 105);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(73, 20);
            this.lblPID.TabIndex = 4;
            this.lblPID.Text = "Player ID";
            // 
            // lblPName
            // 
            this.lblPName.AutoSize = true;
            this.lblPName.Location = new System.Drawing.Point(111, 152);
            this.lblPName.Name = "lblPName";
            this.lblPName.Size = new System.Drawing.Size(98, 20);
            this.lblPName.TabIndex = 5;
            this.lblPName.Text = "Player Name";
            // 
            // lblBD
            // 
            this.lblBD.AutoSize = true;
            this.lblBD.Location = new System.Drawing.Point(111, 203);
            this.lblBD.Name = "lblBD";
            this.lblBD.Size = new System.Drawing.Size(77, 20);
            this.lblBD.TabIndex = 6;
            this.lblBD.Text = "BirthDate";
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Location = new System.Drawing.Point(109, 248);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(82, 20);
            this.lblNationality.TabIndex = 7;
            this.lblNationality.Text = "Nationality";
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Location = new System.Drawing.Point(109, 295);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(49, 20);
            this.lblTeam.TabIndex = 8;
            this.lblTeam.Text = "Team";
            // 
            // lblTeamNum
            // 
            this.lblTeamNum.AutoSize = true;
            this.lblTeamNum.Location = new System.Drawing.Point(111, 340);
            this.lblTeamNum.Name = "lblTeamNum";
            this.lblTeamNum.Size = new System.Drawing.Size(109, 20);
            this.lblTeamNum.TabIndex = 9;
            this.lblTeamNum.Text = "Team Number";
            // 
            // txtBoxPID
            // 
            this.txtBoxPID.Location = new System.Drawing.Point(246, 105);
            this.txtBoxPID.Name = "txtBoxPID";
            this.txtBoxPID.Size = new System.Drawing.Size(245, 26);
            this.txtBoxPID.TabIndex = 10;
            this.txtBoxPID.TextChanged += new System.EventHandler(this.txtBoxPID_TextChanged);
            // 
            // txtBoxPName
            // 
            this.txtBoxPName.Location = new System.Drawing.Point(246, 152);
            this.txtBoxPName.Name = "txtBoxPName";
            this.txtBoxPName.Size = new System.Drawing.Size(245, 26);
            this.txtBoxPName.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(249, 197);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(302, 26);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cBoxNationality
            // 
            this.cBoxNationality.FormattingEnabled = true;
            this.cBoxNationality.Location = new System.Drawing.Point(249, 248);
            this.cBoxNationality.Name = "cBoxNationality";
            this.cBoxNationality.Size = new System.Drawing.Size(242, 28);
            this.cBoxNationality.TabIndex = 13;
            this.cBoxNationality.SelectedIndexChanged += new System.EventHandler(this.cBoxNationality_SelectedIndexChanged);
            // 
            // cBoxTeam
            // 
            this.cBoxTeam.FormattingEnabled = true;
            this.cBoxTeam.Location = new System.Drawing.Point(249, 295);
            this.cBoxTeam.Name = "cBoxTeam";
            this.cBoxTeam.Size = new System.Drawing.Size(242, 28);
            this.cBoxTeam.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(115, 392);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 36);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(268, 392);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 36);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // numUpDownTeam
            // 
            this.numUpDownTeam.Location = new System.Drawing.Point(249, 338);
            this.numUpDownTeam.Name = "numUpDownTeam";
            this.numUpDownTeam.Size = new System.Drawing.Size(242, 26);
            this.numUpDownTeam.TabIndex = 18;
            // 
            // lblAvaliable
            // 
            this.lblAvaliable.AutoSize = true;
            this.lblAvaliable.Location = new System.Drawing.Point(546, 339);
            this.lblAvaliable.Name = "lblAvaliable";
            this.lblAvaliable.Size = new System.Drawing.Size(72, 20);
            this.lblAvaliable.TabIndex = 19;
            this.lblAvaliable.Text = "Available";
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 450);
            this.Controls.Add(this.lblAvaliable);
            this.Controls.Add(this.numUpDownTeam);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cBoxTeam);
            this.Controls.Add(this.cBoxNationality);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtBoxPName);
            this.Controls.Add(this.txtBoxPID);
            this.Controls.Add(this.lblTeamNum);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.lblNationality);
            this.Controls.Add(this.lblBD);
            this.Controls.Add(this.lblPName);
            this.Controls.Add(this.lblPID);
            this.Controls.Add(this.btnRightEnd);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnLeftEnd);
            this.Name = "Player";
            this.Text = "Player";
            this.Load += new System.EventHandler(this.Player_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTeam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeftEnd;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnRightEnd;
        private System.Windows.Forms.Label lblPID;
        private System.Windows.Forms.Label lblPName;
        private System.Windows.Forms.Label lblBD;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.Label lblTeamNum;
        private System.Windows.Forms.TextBox txtBoxPID;
        private System.Windows.Forms.TextBox txtBoxPName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cBoxNationality;
        private System.Windows.Forms.ComboBox cBoxTeam;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown numUpDownTeam;
        private System.Windows.Forms.Label lblAvaliable;
    }
}

