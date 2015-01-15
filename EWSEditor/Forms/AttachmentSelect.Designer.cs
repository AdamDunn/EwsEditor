﻿namespace EWSEditor.Forms
{
    partial class AttachmentSelect
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
            this.txtFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnBrowseForFile = new System.Windows.Forms.Button();
            this.chkIsInline = new System.Windows.Forms.CheckBox();
            this.lblMessageType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContentId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContentLocation = new System.Windows.Forms.TextBox();
            this.chkIsContactPhoto = new System.Windows.Forms.CheckBox();
            this.txtContentType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFile
            // 
            this.txtFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFile.Location = new System.Drawing.Point(104, 15);
            this.txtFile.Margin = new System.Windows.Forms.Padding(2);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(481, 20);
            this.txtFile.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "File:";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(562, 189);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(58, 23);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(498, 189);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(58, 23);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnBrowseForFile
            // 
            this.btnBrowseForFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseForFile.Location = new System.Drawing.Point(590, 14);
            this.btnBrowseForFile.Name = "btnBrowseForFile";
            this.btnBrowseForFile.Size = new System.Drawing.Size(21, 23);
            this.btnBrowseForFile.TabIndex = 2;
            this.btnBrowseForFile.Text = "...";
            this.btnBrowseForFile.UseVisualStyleBackColor = true;
            this.btnBrowseForFile.Click += new System.EventHandler(this.btnBrowseForFile_Click);
            // 
            // chkIsInline
            // 
            this.chkIsInline.AutoSize = true;
            this.chkIsInline.Location = new System.Drawing.Point(12, 45);
            this.chkIsInline.Name = "chkIsInline";
            this.chkIsInline.Size = new System.Drawing.Size(62, 17);
            this.chkIsInline.TabIndex = 3;
            this.chkIsInline.Text = "Is Inline";
            this.chkIsInline.UseVisualStyleBackColor = true;
            this.chkIsInline.CheckedChanged += new System.EventHandler(this.chkIsInline_CheckedChanged);
            // 
            // lblMessageType
            // 
            this.lblMessageType.AutoSize = true;
            this.lblMessageType.Location = new System.Drawing.Point(39, 138);
            this.lblMessageType.Name = "lblMessageType";
            this.lblMessageType.Size = new System.Drawing.Size(74, 13);
            this.lblMessageType.TabIndex = 9;
            this.lblMessageType.Text = "Content Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ContentId:";
            // 
            // txtContentId
            // 
            this.txtContentId.Location = new System.Drawing.Point(133, 67);
            this.txtContentId.Margin = new System.Windows.Forms.Padding(2);
            this.txtContentId.Name = "txtContentId";
            this.txtContentId.Size = new System.Drawing.Size(196, 20);
            this.txtContentId.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Content Location:";
            // 
            // txtContentLocation
            // 
            this.txtContentLocation.Location = new System.Drawing.Point(133, 102);
            this.txtContentLocation.Margin = new System.Windows.Forms.Padding(2);
            this.txtContentLocation.Name = "txtContentLocation";
            this.txtContentLocation.Size = new System.Drawing.Size(196, 20);
            this.txtContentLocation.TabIndex = 8;
            // 
            // chkIsContactPhoto
            // 
            this.chkIsContactPhoto.AutoSize = true;
            this.chkIsContactPhoto.Location = new System.Drawing.Point(13, 169);
            this.chkIsContactPhoto.Name = "chkIsContactPhoto";
            this.chkIsContactPhoto.Size = new System.Drawing.Size(99, 17);
            this.chkIsContactPhoto.TabIndex = 12;
            this.chkIsContactPhoto.Text = "IsContactPhoto";
            this.chkIsContactPhoto.UseVisualStyleBackColor = true;
            // 
            // txtContentType
            // 
            this.txtContentType.Location = new System.Drawing.Point(133, 135);
            this.txtContentType.Margin = new System.Windows.Forms.Padding(2);
            this.txtContentType.Name = "txtContentType";
            this.txtContentType.Size = new System.Drawing.Size(196, 20);
            this.txtContentType.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Only set to override default set on saving.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Always set for inline attachments.";
            // 
            // AttachmentSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 223);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContentType);
            this.Controls.Add(this.chkIsContactPhoto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtContentLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContentId);
            this.Controls.Add(this.lblMessageType);
            this.Controls.Add(this.chkIsInline);
            this.Controls.Add(this.btnBrowseForFile);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFile);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AttachmentSelect";
            this.Text = "AttachmentSelect";
            this.Load += new System.EventHandler(this.SelectAttachmentToAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnBrowseForFile;
        private System.Windows.Forms.Label lblMessageType;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtFile;
        public System.Windows.Forms.CheckBox chkIsInline;
        public System.Windows.Forms.TextBox txtContentId;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtContentLocation;
        public System.Windows.Forms.CheckBox chkIsContactPhoto;
        public System.Windows.Forms.TextBox txtContentType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}