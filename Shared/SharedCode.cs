using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Shared Code and Resources for HHW Tools Dll
namespace HHW.Tools.Shared
{
    public class SharedCode
    {
        public List<int> GetToolsVersion()
        {
            List<int> version = new List<int> { 1, 0, 0, 0 };
            return version;
        }

    }
}
