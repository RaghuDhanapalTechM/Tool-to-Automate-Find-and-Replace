using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppToFindFilesAndReplace.Interfaces
{

    public interface IfileOperationsInput
    {
        int FindNumberOfFiles(string[] strAllFilesArray);

        string[] GetAllFiles(string folderPath);

        List<string> GetDistinctFileExtensions(string[] strAllFilesArray);

    }

    public interface IFileRead
    {
        void OpenFile(string filePath);
    }

    public interface IFileReplace
    {
        void ReadAndReplace(string filePath, string findText, string replaceText, bool matchWholeWord = false, bool matchCase = false);
    }

    public interface IUserInputs
    {
        bool ValidatePath(string folderPath,string errorMessage);
        bool ValidateInputContent(string inputText, string errorMessage);
    }
}
