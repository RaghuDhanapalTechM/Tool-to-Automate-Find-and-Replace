using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AppToFindFilesAndReplace
{
    public partial class frmMain : Form
    {

        public string[] strAllFilesArray;

        public frmMain()
        {
            InitializeComponent();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void btnBrowseFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            {
                txtFolderPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnFindDetails_Click(object sender, EventArgs e)
        {
            try
            {
                InputValidation objValidation = new InputValidation();

                //Input Folder path does not exist
                if (objValidation.ValidatePath(txtFolderPath.Text, InputValidation.emptyFolderPathMsg)) { return; }

                //get the details about the list of files and count of total number of files
                FileOperations objFileOperations = new FileOperations();

                strAllFilesArray = objFileOperations.GetAllFiles(txtFolderPath.Text);
                lblTotalNumberofFilesValue.Text = objFileOperations.FindNumberOfFiles(strAllFilesArray).ToString();
                List<string> lstFileExtensions = objFileOperations.GetDistinctFileExtensions(strAllFilesArray);
                clbFileExtensions.DataSource = lstFileExtensions;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured please try again \n " + ex.ToString());
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                //textbox validations
                InputValidation objValidation = new InputValidation();
                if (objValidation.ValidatePath(txtFolderPath.Text, InputValidation.emptyFolderPathMsg)) { return; }
                if (objValidation.ValidateInputContent(rtxtTextToFind.Text, InputValidation.emptyInputToFindContentMsg)) { return; }
                if (objValidation.ValidateInputContent(rtxtTextToReplace.Text, InputValidation.emptyInputToReplaceContentMsg)) { return; }

                //loop each file and replace the text
                FileProcessing objfProc = new FileProcessing();

                objfProc.LoopEachFileForProcessing(strAllFilesArray, clbFileExtensions, slblCurrentFile, rtxtTextToFind.Text,
                    rtxtTextToReplace.Text, chbMatchWholeWord.Checked, chbMatchCase.Checked);

                slblCurrentFile.Text = "All files have been replaced successfully.";
                MessageBox.Show(objfProc.modifiedFileCount + " Files Replaced Successfully");

                //uncheck the selected items in checkedListbox
                for (int i = 0; i < clbFileExtensions.Items.Count; i++)
                    clbFileExtensions.SetItemCheckState(i, CheckState.Unchecked);
                //reset selected items count 
                lbltotalSelectedFileCountValue.Text = "0";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured please try again \n " + ex.ToString());
            }

        }

        private void clbFileExtensions_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                //get the list of all selected file extensions
                List<string> lstSelectedExtensions = clbFileExtensions.CheckedItems.Cast<string>().ToList();

                //get the count of the selected file extension's files
                FileOperations objfOperation = new FileOperations();
                count = objfOperation.GetSelectedExtensionsFileCount(strAllFilesArray, lstSelectedExtensions);

                //display the count in label
                lbltotalSelectedFileCountValue.Text = count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured please try again \n " + ex.ToString());
            }
        }
    }


}
