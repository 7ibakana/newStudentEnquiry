namespace newStudentEnquiry
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxDepartment = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstDegrees = new System.Windows.Forms.ListBox();
            this.lblDegreeCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxHowDidYouHear = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Which department are you interested in?";
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDepartment.FormattingEnabled = true;
            this.cbxDepartment.Location = new System.Drawing.Point(31, 49);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(219, 21);
            this.cbxDepartment.TabIndex = 1;
            this.cbxDepartment.SelectedIndexChanged += new System.EventHandler(this.cbxDepartment_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "What degree programs are you interested in?";
            // 
            // lstDegrees
            // 
            this.lstDegrees.Location = new System.Drawing.Point(31, 114);
            this.lstDegrees.Name = "lstDegrees";
            this.lstDegrees.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstDegrees.Size = new System.Drawing.Size(219, 95);
            this.lstDegrees.Sorted = true;
            this.lstDegrees.TabIndex = 0;
            this.lstDegrees.SelectedIndexChanged += new System.EventHandler(this.lstDegrees_SelectedIndexChanged);
            // 
            // lblDegreeCount
            // 
            this.lblDegreeCount.AutoSize = true;
            this.lblDegreeCount.Location = new System.Drawing.Point(194, 212);
            this.lblDegreeCount.Name = "lblDegreeCount";
            this.lblDegreeCount.Size = new System.Drawing.Size(56, 13);
            this.lblDegreeCount.TabIndex = 3;
            this.lblDegreeCount.Text = "0 selected";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "How did you hear about us?";
            // 
            // cbxHowDidYouHear
            // 
            this.cbxHowDidYouHear.FormattingEnabled = true;
            this.cbxHowDidYouHear.Location = new System.Drawing.Point(31, 263);
            this.cbxHowDidYouHear.Name = "cbxHowDidYouHear";
            this.cbxHowDidYouHear.Size = new System.Drawing.Size(215, 21);
            this.cbxHowDidYouHear.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(118, 311);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 356);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbxHowDidYouHear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDegreeCount);
            this.Controls.Add(this.lstDegrees);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxDepartment);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstDegrees;
        private System.Windows.Forms.Label lblDegreeCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxHowDidYouHear;
        private System.Windows.Forms.Button btnSubmit;
    }
}

