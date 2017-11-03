using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace CalcAndroidBtns
{
    public class Calculator
    {
        public static int Calc(int a1, int a2, char op)
        {
            int res = 0;
            switch (op)
            {
                case '*':
                    res = a1 * a2;
                    break;
                case '+':
                    res = a1 + a2;
                    break;
                case '-':
                    res = a1 - a2;
                    break;
                case '/':
                    res = a1 / a2;
                    break;
                default:
                    res = 0;
                    break;
            }
            return res;
        }
    }
}