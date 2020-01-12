using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace AddEventHandler
{
    public class FileEditor
    {
        public List<string> Grep(string path, string searchFilePattern, string searchString)
        {
            return Directory.GetFiles(path, searchFilePattern, SearchOption.AllDirectories)
                .Where(x => File.ReadAllText(x).Contains(searchString))
                .ToList();
        }

        public List<string> Convert(List<string> list, string replaceString)
        {
            return list.Select(x => x.Replace(replaceString, "")).ToList();
        }

        public void Edit(List<string> list) 
        {
            list.ForEach(x => {
                Console.WriteLine(x);
            });
        }
    }
}
