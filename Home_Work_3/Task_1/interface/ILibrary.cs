﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task_1
{
    interface ILibrary
    {
        void Add<T>(params T[] objct) where T: Book;
        

    }
}
