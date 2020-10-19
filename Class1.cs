using System;
using System.Collections.Generic;
using System.Text;

namespace Test2
{
    class Data_Main
    {
        public int Inputer { get; set; }
        public int Saver { get; set; }
        public void Getter(string input)
        {
            Console.WriteLine(input);
        }
        public int GetInfo(int input)
        {
            return input;
        }
        public float GetInfo(float input)
        {
            return input;
        }
    }
    class Car : Data_Main
    {

    }
}
