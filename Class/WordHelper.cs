using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

using word = Microsoft.Office.Interop.Word;

        
namespace InvAc
{
   
    internal class WordHelper
    {
        private FileInfo _fileInfo;

        public WordHelper(string fileName)
        {
            if (File.Exists(fileName) )
            {
                _fileInfo = new FileInfo(fileName);
            }

            else
            {
                throw new ArgumentException("File not found");
            }
        }

        internal bool Process(Dictionary<string, string> items)
        {
            word.Application app = null;
            try
            {
                app = new word.Application();
                Object file = _fileInfo.FullName;

                Object missing = Type.Missing;

                app.Documents.Open(file);
                

                foreach (var item in items)
                {
                    word.Find find = app.Selection.Find;
                    find.Text = item.Key;
                    find.Replacement.Text = item.Value;


                    Object wrap = word.WdFindWrap.wdFindContinue;
                    Object replace = word.WdReplace.wdReplaceAll;

                    find.Execute(FindText: Type.Missing,
                        MatchCase: false,
                        MatchWholeWord: false,
                        MatchWildcards: false,
                        MatchSoundsLike: missing,
                        MatchAllWordForms: false,
                        Forward: true,
                        Wrap: wrap,
                        Format: false,
                        ReplaceWith: missing, Replace: replace);
                }

                Object newFileName = Path.Combine(_fileInfo.DirectoryName, DateTime.Now.ToString("yyyyMMdd HHmmss ") + _fileInfo.Name);

                app.ActiveDocument.SaveAs2(newFileName);
     

                

                
                return true;
            }
            catch(Exception ex) { Console.WriteLine(ex.Message); }

            finally
            {
                if (app != null)
                {
                    app.Visible = true;
                }
            }
            return false;
        }
    }
}
