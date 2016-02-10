namespace BlobDemoClient
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
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.txtBlobURL = new System.Windows.Forms.TextBox();
            this.lblStorageURL = new System.Windows.Forms.Label();
            this.txtContainerName = new System.Windows.Forms.TextBox();
            this.txtBlobName = new System.Windows.Forms.TextBox();
            this.lblContainerName = new System.Windows.Forms.Label();
            this.lblBlobName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(62, 364);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(94, 35);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(62, 85);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(849, 26);
            this.txtFilePath.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(937, 81);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(98, 35);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(58, 62);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(107, 20);
            this.lblFilePath.TabIndex = 3;
            this.lblFilePath.Text = "File to Upload";
            // 
            // txtBlobURL
            // 
            this.txtBlobURL.AcceptsTab = true;
            this.txtBlobURL.Location = new System.Drawing.Point(62, 159);
            this.txtBlobURL.Name = "txtBlobURL";
            this.txtBlobURL.Size = new System.Drawing.Size(849, 26);
            this.txtBlobURL.TabIndex = 4;
            this.txtBlobURL.Text = "http://khblobdemoclient.blob.core.windows.net/";
            // 
            // lblStorageURL
            // 
            this.lblStorageURL.AutoSize = true;
            this.lblStorageURL.Location = new System.Drawing.Point(58, 136);
            this.lblStorageURL.Name = "lblStorageURL";
            this.lblStorageURL.Size = new System.Drawing.Size(103, 20);
            this.lblStorageURL.TabIndex = 5;
            this.lblStorageURL.Text = "Storage URL";
            // 
            // txtContainerName
            // 
            this.txtContainerName.Location = new System.Drawing.Point(62, 235);
            this.txtContainerName.Name = "txtContainerName";
            this.txtContainerName.Size = new System.Drawing.Size(316, 26);
            this.txtContainerName.TabIndex = 6;
            this.txtContainerName.Text = "test1";
            // 
            // txtBlobName
            // 
            this.txtBlobName.Location = new System.Drawing.Point(62, 308);
            this.txtBlobName.Name = "txtBlobName";
            this.txtBlobName.Size = new System.Drawing.Size(316, 26);
            this.txtBlobName.TabIndex = 7;
            // 
            // lblContainerName
            // 
            this.lblContainerName.AutoSize = true;
            this.lblContainerName.Location = new System.Drawing.Point(62, 212);
            this.lblContainerName.Name = "lblContainerName";
            this.lblContainerName.Size = new System.Drawing.Size(124, 20);
            this.lblContainerName.TabIndex = 8;
            this.lblContainerName.Text = "Container Name";
            // 
            // lblBlobName
            // 
            this.lblBlobName.AutoSize = true;
            this.lblBlobName.Location = new System.Drawing.Point(62, 285);
            this.lblBlobName.Name = "lblBlobName";
            this.lblBlobName.Size = new System.Drawing.Size(130, 20);
            this.lblBlobName.TabIndex = 9;
            this.lblBlobName.Text = "Block Blob Name";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1123, 452);
            this.Controls.Add(this.lblBlobName);
            this.Controls.Add(this.lblContainerName);
            this.Controls.Add(this.txtBlobName);
            this.Controls.Add(this.txtContainerName);
            this.Controls.Add(this.lblStorageURL);
            this.Controls.Add(this.txtBlobURL);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnUpload);
            this.Name = "Form1";
            this.Text = "Block Blob Demo Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.TextBox txtBlobURL;
        private System.Windows.Forms.Label lblStorageURL;
        private System.Windows.Forms.TextBox txtContainerName;
        private System.Windows.Forms.TextBox txtBlobName;
        private System.Windows.Forms.Label lblContainerName;
        private System.Windows.Forms.Label lblBlobName;
    }
}

