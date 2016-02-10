using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Added references
using System.IO;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using System.Configuration;

//Author: Kevin Hilscher
//Add NuGet package 'WindowsAzure.Storage'
//Review 'Get started with Azure Blob storage using .Net' at 
//https://github.com/Azure/azure-content/blob/master/articles/storage/storage-dotnet-how-to-use-blobs.md

namespace BlobDemoClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

  

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFilePath.Text))
            {
                MessageBox.Show("Please select a file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Retrieve storage account connection string from app.config.
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(ConfigurationManager.ConnectionStrings["StorageConnectionString"].ConnectionString);

            // Create the blob client.
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

            // Retrieve reference to a previously created container.
            CloudBlobContainer container = blobClient.GetContainerReference(txtContainerName.Text);

            // Create the container if it doesn't already exist.
            container.CreateIfNotExists();

            // Retrieve reference to a blob 
            CloudBlockBlob blockBlob = container.GetBlockBlobReference(txtBlobName.Text);

            // Create or overwrite the blob with contents from a local file.
            using (var fileStream = System.IO.File.OpenRead(txtFilePath.Text))
            {
                try
                {
                    //TODO: Add better error handling
                    blockBlob.UploadFromStream(fileStream);
                    MessageBox.Show("Upload Complete", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not upload file. Error: " + ex.Message);
                }
            }

            

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            txtFilePath.Text = openFileDialog1.FileName;
                            txtBlobName.Text = openFileDialog1.SafeFileName;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not read file from disk. Error: " + ex.Message);
                }
            }

        }
    }
}
