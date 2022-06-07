using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusWatch
{
    class Starter
    {
        [STAThread]
        static void Main(string[] args)
        {
            _ = new App().Run();
        }
    }
}
