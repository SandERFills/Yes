using System;
using System.Net;
using System.Runtime.Serialization.Formatters;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Razbitien na stepeni
            //Data_Main data = new Data_Main();
            //int user_input = Convert.ToInt32(Console.ReadLine());
            //for (int i =0;user_input != 0;)
            //{
            //    Console.WriteLine(user_input % 10+" - "+"10*"+i +" ");
            //    i++;
            //    user_input /= 10;
            //}
            #endregion

            #region Transfer to Binary
            ToBinary trans = new ToBinary();
            int user = Convert.ToInt32(Console.ReadLine());
            Console.Write(trans.TransferToBinary(user));

            #endregion
        }
    }
}
