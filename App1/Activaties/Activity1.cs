using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Java.Util.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App1.Activaties
{
    [Activity(Label = "Activity1", MainLauncher = true)]
    public class Activity1 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            //Criar uma instancia da classe linearLayout (um layout é um container)
            LinearLayout layout = new LinearLayout(this);
            //Colocar a orientação em modo vertical da criação dos elementos não o do telemovel
            layout.Orientation = Orientation.Vertical;

            layout.SetGravity(GravityFlags.Center);
            
            EditText txt1 = new EditText(this);

            Button btn1 = new Button(this);

            btn1.Text = "Calcular";

            TextView tv1 = new TextView(this);
            tv1.Text = string.Empty;
            txt1.SetTextSize(ComplexUnitType.Dip, 30);

            layout.AddView(txt1);

            btn1.Click += delegate
            {
                int x = int.Parse(txt1.Text);
            
                double resoltado = Math.Sqrt(x);
                
                txt1.Text = resoltado.ToString();
            };

        }
    }
}