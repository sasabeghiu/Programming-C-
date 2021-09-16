using System;

namespace assignment2
{
    interface IProcessor
    {
        void Execute(string text);
    }
    public enum Processors { Intel_i5, AMD_Ryzen_3, Intel_i7 }
}
