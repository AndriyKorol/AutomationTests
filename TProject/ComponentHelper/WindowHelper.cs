using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TProject.Settings;

namespace TProject.ComponentHelper
{
    //All browsers methods
    public class WindowHelper
    {
        public static string GetTitle()
        {
            return ObjectRpository.Driver.Title;
        }
    }
}
