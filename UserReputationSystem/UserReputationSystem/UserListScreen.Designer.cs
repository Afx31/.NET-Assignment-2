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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRateUsers = new System.Windows.Forms.Button();
            this.userHandlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userHandlerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(561, 233);
            this.dataGridView1.TabIndex = 13;
            // 
            // btnRateUsers
            // 
            this.btnRateUsers.Location = new System.Drawing.Point(226, 251);
            this.btnRateUsers.Name = "btnRateUsers";
            this.btnRateUsers.Size = new System.Drawing.Size(133, 23);
            this.btnRateUsers.TabIndex = 14;
            this.btnRateUsers.Text = "Rate Selected Users";
            this.btnRateUsers.UseVisualStyleBackColor = true;
            this.btnRateUsers.Click += new System.EventHandler(this.btnRateUsers_Click);
            // 
            // userHandlerBindingSource
            // 
            this.userHandlerBindingSource.DataSource = typeof(UserReputationSystem.UserHandler);
            // 
            // UserListScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 285);
            this.Controls.Add(this.btnRateUsers);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserListScreen";
            this.Text = "UserListScreen";
            this.Load += new System.EventHandler(this.UserListScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userHandlerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource userHandlerBindingSource;
        private System.Windows.Forms.Button btnRateUsers;
    }
}