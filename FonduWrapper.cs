﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace DfontSplitter
{
    class FonduWrapper
    {
        [DllImport("fondu-win-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int fondu_simple_main(string filename);
    }
}
