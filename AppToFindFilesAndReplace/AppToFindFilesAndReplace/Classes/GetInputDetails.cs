using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AppToFindFilesAndReplace.Interfaces;
using System.Collections;
using System.Text.RegularExpressions;

namespace AppToFindFilesAndReplace
{
    public class FileOperations : IfileOperationsInput
    {
        public int selcetedFilesCount = 0;
        //get total number of files
        public int FindNumberOfFiles(string[] strAllFilesArray)
        {
            return strAllFilesArray.Length;
        }

        //get all the files in the folder 
        public string[] GetAllFiles(string folderPath)
        {
            return  Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories);
        }

        //query and get distinct file extensions of all files in chosen folder
        public List<string> GetDistinctFileExtensions(string[] strAllFilesArray)
        {
            var lstFileExtensionsQuery = (from filename in strAllFilesArray
                                          let fileExtension = Path.GetExtension(filename)
                                          select fileExtension).Distinct().ToList();

            return lstFileExtensionsQuery;
        }

        public int GetSelectedExtensionsFileCount(string[] strAllFilesArray, List<string> lstSelectedExtensions)
        {
            int count = (strAllFilesArray.Where(t2 => lstSelectedExtensions.Count(t1 => t2.Contains(t1)) != 0)).Count();
            return count;
        }

      
    }


}
