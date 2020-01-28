using System;
using System.Collections;
using System.Collections.Generic;

namespace Assignment3
{
    //Allow for some managed types to be used as pointers
    unsafe class VarPointer
    {
        private Type objType;
        private char*[] stringAddresses;

        internal Type ObjType { get => objType; set => objType = value; }

        public enum Type
        {
            String
        }
        public VarPointer(string input)
        {
            objType = Type.String;
            stringAddresses = new char*[input.Length];

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                string value = "asdf";
                VarPointer pointer = new VarPointer(value);

                Console.WriteLine();
            }

            Console.WriteLine("Hello World!");
        }
    }
}
