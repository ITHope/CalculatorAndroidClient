using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android;
using Android.Views;

namespace CalculatorAndroid
{
    [Activity(Label = "CalculatorAndroid", MainLauncher = true)]
    public class MainActivity : Activity
    {
        EditText etNum1;
        EditText etNum2;
        EditText etOp;

        Button btnRes;

        TextView tvResult;

        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            etNum1 = (EditText)FindViewById(Resource.Id.etNum1);
            etNum2 = (EditText)FindViewById(Resource.Id.etNum2);
            etOp = (EditText)FindViewById(Resource.Id.etOp);

            btnRes = (Button)FindViewById(Resource.Id.btnCalc);

            btnRes.Click += delegate {
                OnClickRes();
            };

            tvResult = (TextView)FindViewById(Resource.Id.tvResult);


        }

        private void OnClickRes()
        {
            int num1 = 0;
            int num2 = 0;
            int result = 0;

            num1 = Int32.Parse(etNum1.Text);
            num2 = Int32.Parse(etNum2.Text);

            switch (etOp.Text[0])
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':  
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                default:
                    break;
            }

          
            tvResult.Text = result.ToString();

        }

    }
}

