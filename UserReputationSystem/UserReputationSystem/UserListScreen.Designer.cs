namespace UserReputationSystem
{
    partial class UserListScreen
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
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbAvgRating = new System.Windows.Forms.TextBox();
            this.tbNumberRating = new System.Windows.Forms.TextBox();
            this.lblAvgRating = new System.Windows.Forms.Label();
            this.lblNumberRating = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userHandlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userHandlerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(135, 52);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(100, 20);
            this.tbUsername.TabIndex = 1;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(135, 78);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbFirstName.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(71, 55);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(69, 81);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name:";
            // 
            // tbAvgRating
            // 
            this.tbAvgRating.Location = new System.Drawing.Point(135, 104);
            this.tbAvgRating.Name = "tbAvgRating";
            this.tbAvgRating.Size = new System.Drawing.Size(100, 20);
            this.tbAvgRating.TabIndex = 5;
            // 
            // tbNumberRating
            // 
            this.tbNumberRating.Location = new System.Drawing.Point(135, 130);
            this.tbNumberRating.Name = "tbNumberRating";
            this.tbNumberRating.Size = new System.Drawing.Size(100, 20);
            this.tbNumberRating.TabIndex = 6;
            // 
            // lblAvgRating
            // 
            this.lblAvgRating.AutoSize = true;
            this.lblAvgRating.Location = new System.Drawing.Point(23, 108);
            this.lblAvgRating.Name = "lblAvgRating";
            this.lblAvgRating.Size = new System.Drawing.Size(106, 13);
            this.lblAvgRating.TabIndex = 7;
            this.lblAvgRating.Text = "Average Star Rating:";
            // 
            // lblNumberRating
            // 
            this.lblNumberRating.AutoSize = true;
            this.lblNumberRating.Location = new System.Drawing.Point(31, 134);
            this.lblNumberRating.Name = "lblNumberRating";
            this.lblNumberRating.Size = new System.Drawing.Size(98, 13);
            this.lblNumberRating.TabIndex = 8;
            this.lblNumberRating.Text = "Number of Ratings:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(756, 282);
            this.dataGridView1.TabIndex = 13;
            // 
            // userHandlerBindingSource
            // 
            this.userHandlerBindingSource.DataSource = typeof(UserReputationSystem.UserHandler);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // UserListScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 457);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblNumberRating);
            this.Controls.Add(this.lblAvgRating);
            this.Controls.Add(this.tbNumberRating);
            this.Controls.Add(this.tbAvgRating);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbUsername);
            this.Name = "UserListScreen";
            this.Text = "UserListScreen";
            this.Load += new System.EventHandler(this.UserListScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userHandlerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbAvgRating;
        private System.Windows.Forms.TextBox tbNumberRating;
        private System.Windows.Forms.Label lblAvgRating;
        private System.Windows.Forms.Label lblNumberRating;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource userHandlerBindingSource;
        private System.Windows.Forms.Label label1;
    }
}