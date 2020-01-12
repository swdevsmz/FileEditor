using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Common
{
    public partial class LcoNumericEditor :  TextBox
    {

        [DllImport("Msctf.dll", PreserveSig = false)]
        public static extern void SetInputScope(IntPtr handle, int inputScope);

        public LcoNumericEditor()
        {
            InitializeComponent();
        }
    }
}
