using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CanastaPresupuestoRaul
{
    [Activity(Label = "DetalleMesActivity")]
    public class DetalleMesActivity : Activity
    {
        Meses meses;
        TextView Nombre,alimentos,vestuarios,uso_hogar,total;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ActivityDetalleMes);

            int id = Intent.GetIntExtra("id", 0);
            meses = ClaseGlobal.Meses.Where(x => x.Id == id).FirstOrDefault();

            Nombre      = FindViewById<TextView>(Resource.Id.textView1);
            vestuarios  = FindViewById<TextView>(Resource.Id.textView6);
            alimentos   = FindViewById<TextView>(Resource.Id.textView7);
            uso_hogar   = FindViewById<TextView>(Resource.Id.textView8);
            total       = FindViewById<TextView>(Resource.Id.textView9);

            Nombre.Text     = meses.Nombre_mes;
            vestuarios.Text = meses.Vestuario.ToString();
            alimentos.Text  = meses.Alimentos.ToString();
            uso_hogar.Text  = meses.Uso_hogar.ToString();
            total.Text      = meses.Total.ToString();
        }
    }
}