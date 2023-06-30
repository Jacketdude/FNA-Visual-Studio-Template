using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Game1 game = new Game1 ())
            {
                game.Run();
            }
        }
    }
}
