﻿using System;

namespace assignment1
{
    public class TwitterDataLoader : BigDataLoader
    {
        public override void Extract()
        {
            Console.WriteLine("extracting twitter data...");
        }

        public override void Transform()
        {
            Console.WriteLine("transforming twitter data...");
        }
    }
}
