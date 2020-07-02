namespace News
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
            this.lstbxNewsTitle = new System.Windows.Forms.ListBox();
            this.cmbbxChannels = new System.Windows.Forms.ComboBox();
            this.rchbxNewsDetail = new System.Windows.Forms.RichTextBox();
            this.rchbxPublish = new System.Windows.Forms.RichTextBox();
            this.lblPublish = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstbxNewsTitle
            // 
            this.lstbxNewsTitle.FormattingEnabled = true;
            this.lstbxNewsTitle.Location = new System.Drawing.Point(12, 88);
            this.lstbxNewsTitle.Name = "lstbxNewsTitle";
            this.lstbxNewsTitle.Size = new System.Drawing.Size(270, 277);
            this.lstbxNewsTitle.TabIndex = 2;
            this.lstbxNewsTitle.SelectedIndexChanged += new System.EventHandler(this.LstbxNewsTitle_SelectedIndexChanged);
            // 
            // cmbbxChannels
            // 
            this.cmbbxChannels.FormattingEnabled = true;
            this.cmbbxChannels.Location = new System.Drawing.Point(53, 41);
            this.cmbbxChannels.Name = "cmbbxChannels";
            this.cmbbxChannels.Size = new System.Drawing.Size(187, 21);
            this.cmbbxChannels.TabIndex = 3;
            this.cmbbxChannels.SelectedIndexChanged += new System.EventHandler(this.CmbbxChannels_SelectedIndexChanged);
            // 
            // rchbxNewsDetail
            // 
            this.rchbxNewsDetail.Location = new System.Drawing.Point(308, 178);
            this.rchbxNewsDetail.Name = "rchbxNewsDetail";
            this.rchbxNewsDetail.Size = new System.Drawing.Size(274, 187);
            this.rchbxNewsDetail.TabIndex = 4;
            this.rchbxNewsDetail.Text = "";
            // 
            // rchbxPublish
            // 
            this.rchbxPublish.Location = new System.Drawing.Point(364, 104);
            this.rchbxPublish.Name = "rchbxPublish";
            this.rchbxPublish.Size = new System.Drawing.Size(151, 32);
            this.rchbxPublish.TabIndex = 5;
            this.rchbxPublish.Text = "";
            // 
            // lblPublish
            // 
            this.lblPublish.AutoSize = true;
            this.lblPublish.Location = new System.Drawing.Point(399, 88);
            this.lblPublish.Name = "lblPublish";
            this.lblPublish.Size = new System.Drawing.Size(81, 13);
            this.lblPublish.TabIndex = 6;
            this.lblPublish.Text = "Publishing Date";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(401, 152);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Description";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 387);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPublish);
            this.Controls.Add(this.rchbxPublish);
            this.Controls.Add(this.rchbxNewsDetail);
            this.Controls.Add(this.cmbbxChannels);
            this.Controls.Add(this.lstbxNewsTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstbxNewsTitle;
        private System.Windows.Forms.ComboBox cmbbxChannels;
        private System.Windows.Forms.RichTextBox rchbxNewsDetail;
        private System.Windows.Forms.RichTextBox rchbxPublish;
        private System.Windows.Forms.Label lblPublish;
        private System.Windows.Forms.Label lblDescription;
    }
}

