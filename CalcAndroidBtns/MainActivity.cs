using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.Data;

namespace CalcAndroidBtns
{
    [Activity(Label = "CalcAndroidBtns", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button num1 = (Button)FindViewById(Resource.Id.btn1);
            Button num2 = (Button)FindViewById(Resource.Id.btn2);
            Button num3 = (Button)FindViewById(Resource.Id.btn3);
            Button num4 = (Button)FindViewById(Resource.Id.btn4);
            Button num5 = (Button)FindViewById(Resource.Id.btn5);
            Button num6 = (Button)FindViewById(Resource.Id.btn6);
            Button num7 = (Button)FindViewById(Resource.Id.btn7);
            Button num8 = (Button)FindViewById(Resource.Id.btn8);
            Button num9 = (Button)FindViewById(Resource.Id.btn9);
            Button num0 = (Button)FindViewById(Resource.Id.btn0);

            //Buttons that receive user mathematical operators
            Button equ = (Button)FindViewById(Resource.Id.btnEql);
            Button div = (Button)FindViewById(Resource.Id.btnDiv);
            Button mul = (Button)FindViewById(Resource.Id.btnMul);
            Button add = (Button)FindViewById(Resource.Id.btnAdd);
            Button sub = (Button)FindViewById(Resource.Id.btnSub);

            //text area to receive and display the user input
            EditText resu = (EditText)FindViewById(Resource.Id.resultText);

            //Text area to display the result generated after calculations
            EditText resu2 = (EditText)FindViewById(Resource.Id.resultText2);

            num1.Click += delegate { resu.Text += num1.Text.ToString(); };
            num2.Click += delegate { resu.Text += num2.Text.ToString(); };
            num3.Click += delegate { resu.Text += num3.Text.ToString(); };
            num4.Click += delegate { resu.Text += num4.Text.ToString(); };
            num5.Click += delegate { resu.Text += num5.Text.ToString(); };
            num6.Click += delegate { resu.Text += num6.Text.ToString(); };
            num7.Click += delegate { resu.Text += num7.Text.ToString(); };
            num8.Click += delegate { resu.Text += num8.Text.ToString(); };
            num9.Click += delegate { resu.Text += num9.Text.ToString(); };
            num0.Click += delegate { resu.Text += num0.Text.ToString(); };

            add.Click += delegate
            {
                resu.Text += add.Text.ToString();
            };
            sub.Click += delegate
            {
                resu.Text += sub.Text.ToString();

            };
            mul.Click += delegate
            {
                resu.Text += mul.Text.ToString();
            };
            div.Click += delegate
            {
                resu.Text += div.Text.ToString();
            };

            equ.Click += delegate
            {
                    string formula = resu.Text;
                    char op = '.';

                    foreach (char c in formula)
                    {
                        if (c == '+' || c == '-' || c == '*' || c == '/')
                            op = c;
                    }

                    string[] parts = formula.Split(op);
                    if (op != '.' && parts.Length == 2)
                    {
                        if (formula.StartsWith("-"))
                            resu2.Text = Calculator.Calc(-(Int32.Parse(parts[0])), Int32.Parse(parts[1]), op).ToString();
                        else
                            resu2.Text = Calculator.Calc(Int32.Parse(parts[0]), Int32.Parse(parts[1]), op).ToString();

                    }
                resu.Text = "";
            };
        }
    }
}

