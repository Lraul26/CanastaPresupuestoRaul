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
    [Activity(Label = "DetalleAniosActivity")]
    public class DetalleAniosActivity : Activity
    {
        Anios anios;
        TextView Nombre;
        ListView Lista;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ActivityDetalleAnio);

            //recuperamos la variable mediante GetIntExtra
            int id = Intent.GetIntExtra("id", 0);
            anios = ClaseGlobal.Anios.Where(x => x.Id == id).FirstOrDefault();

            Nombre  = FindViewById<TextView>(Resource.Id.textView1);
            Lista   = FindViewById<ListView>(Resource.Id.listView1);

            //se pretende mostrar el año seleccionado y debajo de el todos sus meses correspondiente 
            Nombre.Text = anios.Anio.ToString();
            Lista.Adapter = new AdapterMes(this, ClaseGlobal.Meses.Where(x => x.Id_anio == anios.Id).ToList());

            //una vez listados todos los meses del año seleccionado, el usuaio podra tocar cada mes y ver su detalle de gastos de ese mismo mes
            Lista.ItemClick += Lista_ItemClick;
        }

        private void Lista_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            //el mismo procedimiento que realizamos para año, lo haremos para mes 
            Intent i = new Intent(this, typeof(DetalleMesActivity));
            Meses meses = ClaseGlobal.Meses[e.Position];
            i.PutExtra("id", meses.Id);
            StartActivity(i);
        }
    }
}