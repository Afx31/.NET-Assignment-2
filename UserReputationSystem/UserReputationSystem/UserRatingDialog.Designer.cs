namespace UserReputationSystem
{
    partial class UserRatingDialog
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
            this.lblChooseRating = new System.Windows.Forms.Label();
            this.rdbtn0 = new System.Windows.Forms.RadioButton();
            this.rdbtn1 = new System.Windows.Forms.RadioButton();
            this.rdbtn2 = new System.Windows.Forms.RadioButton();
            this.rdbtn3 = new System.Windows.Forms.RadioButton();
            this.rdbtn4 = new System.Windows.Forms.RadioButton();
            this.rdbtn5 = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChooseRating
            // 
            this.lblChooseRating.AutoSize = true;
            this.lblChooseRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseRating.Location = new System.Drawing.Point(37, 22);
            this.lblChooseRating.Name = "lblChooseRating";
            this.lblChooseRating.Size = new System.Drawing.Size(203, 20);
            this.lblChooseRating.TabIndex = 0;
            this.lblChooseRating.Text = "Choose a rating out of 5";
            // 
            // rdbtn0
            // 
            this.rdbtn0.AutoSize = true;
            this.rdbtn0.Location = new System.Drawing.Point(58, 53);
            this.rdbtn0.Name = "rdbtn0";
            this.rdbtn0.Size = new System.Drawing.Size(31, 17);
            this.rdbtn0.TabIndex = 1;
            this.rdbtn0.TabStop = true;
            this.rdbtn0.Text = "0";
            this.rdbtn0.UseVisualStyleBackColor = true;
            // 
            // rdbtn1
            // 
            this.rdbtn1.AutoSize = true;
            this.rdbtn1.Location = new System.Drawing.Point(58, 76);
            this.rdbtn1.Name = "rdbtn1";
            this.rdbtn1.Size = new System.Drawing.Size(31, 17);
            this.rdbtn1.TabIndex = 2;
            this.rdbtn1.TabStop = true;
            this.rdbtn1.Text = "1";
            this.rdbtn1.UseVisualStyleBackColor = true;
            // 
            // rdbtn2
            // 
            this.rdbtn2.AutoSize = true;
            this.rdbtn2.Location = new System.Drawing.Point(58, 99);
            this.rdbtn2.Name = "rdbtn2";
            this.rdbtn2.Size = new System.Drawing.Size(31, 17);
            this.rdbtn2.TabIndex = 3;
            this.rdbtn2.TabStop = true;
            this.rdbtn2.Text = "2";
            this.rdbtn2.UseVisualStyleBackColor = true;
            // 
            // rdbtn3
            // 
            this.rdbtn3.AutoSize = true;
            this.rdbtn3.Location = new System.Drawing.Point(58, 122);
            this.rdbtn3.Name = "rdbtn3";
            this.rdbtn3.Size = new System.Drawing.Size(31, 17);
            this.rdbtn3.TabIndex = 4;
            this.rdbtn3.TabStop = true;
            this.rdbtn3.Text = "3";
            this.rdbtn3.UseVisualStyleBackColor = true;
            // 
            // rdbtn4
            // 
            this.rdbtn4.AutoSize = true;
            this.rdbtn4.Location = new System.Drawing.Point(58, 145);
            this.rdbtn4.Name = "rdbtn4";
            this.rdbtn4.Size = new System.Drawing.Size(31, 17);
            this.rdbtn4.TabIndex = 5;
            this.rdbtn4.TabStop = true;
            this.rdbtn4.Text = "4";
            this.rdbtn4.UseVisualStyleBackColor = true;
            // 
            // rdbtn5
            // 
            this.rdbtn5.AutoSize = true;
            this.rdbtn5.Location = new System.Drawing.Point(58, 168);
            this.rdbtn5.Name = "rdbtn5";
            this.rdbtn5.Size = new System.Drawing.Size(31, 17);
            this.rdbtn5.TabIndex = 6;
            this.rdbtn5.TabStop = true;
            this.rdbtn5.Text = "5";
            this.rdbtn5.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(143, 82);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(143, 122);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // UserRatingDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 197);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rdbtn5);
            this.Controls.Add(this.rdbtn4);
            this.Controls.Add(this.rdbtn3);
            this.Controls.Add(this.rdbtn2);
            this.Controls.Add(this.rdbtn1);
            this.Controls.Add(this.rdbtn0);
            this.Controls.Add(this.lblChooseRating);
            this.Name = "UserRatingDialog";
            this.Text = "UserRatingDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChooseRating;
        private System.Windows.Forms.RadioButton rdbtn0;
        private System.Windows.Forms.RadioButton rdbtn1;
        private System.Windows.Forms.RadioButton rdbtn2;
        private System.Windows.Forms.RadioButton rdbtn3;
        private System.Windows.Forms.RadioButton rdbtn4;
        private System.Windows.Forms.RadioButton rdbtn5;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}