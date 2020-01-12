using System;
using System.IO;
using System.Linq;

namespace AddEventHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            FileEditor fe = new FileEditor();
            fe.Grep(@"C:\00_data\90_repos\00_CAP\SampleForms\"
                            , "*.Designer.cs"
                            , "new Common.LcoNumericEditor();")
                .Select(x => x.Replace(".Designer", "")).ToList();
        }
    }
}
