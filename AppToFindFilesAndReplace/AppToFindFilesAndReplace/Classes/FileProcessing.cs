using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using AppToFindFilesAndReplace.Interfaces;
using System.Collections;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Windows.Forms;


namespace AppToFindFilesAndReplace
{
    class FileProcessing : IFileReplace
    {
        public int modifiedFileCount = 0;

        //replace with content of the file and save it
        public void ReadAndReplace(string filePath, string findText, string replaceText, bool matchWholeWord = false, bool matchCase = false)
        {
            string pattern = string.Empty;
            string result = string.Empty;

            //form pattern based on matchwhole word is selected or not
            if (matchWholeWord) { pattern = @"\b" + findText + @"\b"; }
            else { pattern = findText; }

            //open the file ,find the text and replace its contents
            string fullFileText = File.ReadAllText(filePath);

            //replace based on match case is selected or not
            if (matchCase) { result = Regex.Replace(fullFileText, pattern, replaceText); }
            else { result = Regex.Replace(fullFileText, pattern, replaceText, RegexOptions.IgnoreCase); }

            //write the contents in file
            if (!(fullFileText == result))
            {
                File.WriteAllText(filePath, result);
                modifiedFileCount += 1;
            }

        }

        //loop each file and process to replace
        public void LoopEachFileForProcessing(string[] strAllFilesArray, CheckedListBox clbFileExtensions,
                         ToolStripStatusLabel slblCurrentFile, string rtxtTextToFind, string rtxtTextToReplace,
                                                                    bool chbMatchWholeWord, bool chbMatchCase)
        {
            foreach (var item in strAllFilesArray)
            {
                if (clbFileExtensions.CheckedItems.Contains(Path.GetExtension(item)))
                {
                    slblCurrentFile.Text = Path.GetFileName(item) + " is in progress....";
                    ReadAndReplace(item, rtxtTextToFind, rtxtTextToReplace,
                                                        chbMatchWholeWord, chbMatchCase);
                }

            }
        }


    }
}
