using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AppToFindFilesAndReplace.Interfaces;

namespace AppToFindFilesAndReplace
{
    public class InputValidation : IUserInputs
    {
        public const string emptyFolderPathMsg = "Please select a valid Input Folder";
        public const string emptyInputToFindContentMsg = "'Text to Find' Textbox cannot be empty";
        public const string emptyInputToReplaceContentMsg = "'Text to Replace' Textbox cannot be empty";

        //If input folder is empty
        public bool ValidatePath(string folderPath, string errorMessage)
        {
            if (!(Directory.Exists(folderPath)))
            {
                MessageBox.Show(errorMessage);
                return true;
            }
            else { return false; }
        }

        //if input contents required to replace is empty
        public bool ValidateInputContent(string inputText, string errorMessage)
        {
            if (string.IsNullOrEmpty(inputText))
            {
                MessageBox.Show(errorMessage);
                return true;
            }
            else { return false; }
        }
    }
}
