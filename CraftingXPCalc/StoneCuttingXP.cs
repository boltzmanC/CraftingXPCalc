using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftingXPCalc
{
    class StoneCuttingXP
    {

        const int stonebrick = 36;
        const int lodestonebrick = 180;
        const int obsidianvoidstone = 9240;

        public static int GetValueByName(string name)
        {
            switch (name)
            {
                case "bob": return 1;
                case "billy": return 2;
                default: return -1;
            }
        }

    }
}
