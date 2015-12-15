﻿namespace Fp_Part.Fp_Model
{
    using System;

    public partial class Freezer
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public Nullable<int> subdivisions { get; set; }
        public Nullable<int> boxes { get; set; }
    }
}