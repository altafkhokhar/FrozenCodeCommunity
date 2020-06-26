namespace FrozenCode.Community.AppUI
{
    partial class frmMemberList
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchKeyWord = new System.Windows.Forms.TextBox();
            this.dgMembers = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLoadAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgMembers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(582, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 28);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchKeyWord
            // 
            this.txtSearchKeyWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchKeyWord.Location = new System.Drawing.Point(109, 32);
            this.txtSearchKeyWord.Name = "txtSearchKeyWord";
            this.txtSearchKeyWord.Size = new System.Drawing.Size(455, 29);
            this.txtSearchKeyWord.TabIndex = 1;
            this.txtSearchKeyWord.TextChanged += new System.EventHandler(this.txtSearchKeyWord_TextChanged);
            // 
            // dgMembers
            // 
            this.dgMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMembers.Location = new System.Drawing.Point(47, 80);
            this.dgMembers.Name = "dgMembers";
            this.dgMembers.Size = new System.Drawing.Size(1005, 461);
            this.dgMembers.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnLoadAll);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.dgMembers);
            this.panel1.Controls.Add(this.txtSearchKeyWord);
            this.panel1.Location = new System.Drawing.Point(52, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 557);
            this.panel1.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(901, 33);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(78, 28);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLoadAll
            // 
            this.btnLoadAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadAll.Location = new System.Drawing.Point(793, 33);
            this.btnLoadAll.Name = "btnLoadAll";
            this.btnLoadAll.Size = new System.Drawing.Size(74, 28);
            this.btnLoadAll.TabIndex = 3;
            this.btnLoadAll.Text = "Load All";
            this.btnLoadAll.UseVisualStyleBackColor = true;
            this.btnLoadAll.Click += new System.EventHandler(this.btnLoadAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(689, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMemberList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 589);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMemberList";
            this.Text = "Members";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgMembers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchKeyWord;
        private System.Windows.Forms.DataGridView dgMembers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadAll;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button1;
    }
}