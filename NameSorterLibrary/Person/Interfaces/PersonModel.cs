﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NameSorterLibrary.Person
{
    public class PersonModel : IPersonModel
    {
        public string FullName { get; set; }
        public string IndexName { get; set; }
    }
}