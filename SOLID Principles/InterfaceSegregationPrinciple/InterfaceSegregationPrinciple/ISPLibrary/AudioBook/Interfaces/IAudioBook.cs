﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPLibrary
{
    public interface IAudioBook : ILibraryItem
    {
        int RunTimeInMinute { get; set; }
    }
}
