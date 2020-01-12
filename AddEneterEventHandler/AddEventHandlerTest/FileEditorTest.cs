using Microsoft.VisualStudio.TestTools.UnitTesting;
using AddEventHandler;
using System.Collections.Generic;

namespace AddEventHandlerTest
{
    [TestClass]
    class FileEditorTest
    {

        private readonly FileEditor fileEditor;

        public FileEditorTest(FileEditor fileEditor)
        {
            this.fileEditor = fileEditor;
        }


        [TestMethod]
        public void TestMethod1()
        {
            //Assert.AreEqual(fileEditor.Grep(".Designer.cs", "new Common.LcoNumericEditor();") , new List<string>());
        }
    }
}
