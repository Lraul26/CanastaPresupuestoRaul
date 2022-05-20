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
    [Activity(Label = "ListaAnioActivity", MainLauncher = true)]
    public class ListaAnioActivity : Activity
    {
        ListView ListaAnios, ListaT, ListaAL, ListaV, ListaU, ListaA;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ActivityListaAnio);

            ListaAnios = FindViewById<ListView>(Resource.Id.ListaAnio);

            ListaA  = FindViewById<ListView>(Resource.Id.listView1);
            ListaT  = FindViewById<ListView>(Resource.Id.listView2);
            ListaAL = FindViewById<ListView>(Resource.Id.listView3);
            ListaV  = FindViewById<ListView>(Resource.Id.listView4);
            ListaU  = FindViewById<ListView>(Resource.Id.listView5);

            //estas lista sera para que el usuario seleccione un año y pueda mostrar los meses que le pertenece a ese año
            //y asi pueda ver el detalle de gasto por mes
            ListaAnios.Adapter = new AdapterAnio(this, ClaseGlobal.Anios);

            //estas listas las vamos agrupar dentro de una tabla
            //para poder tener una mejor vista por el usuario
            //********La tabla demostrara los detalles promedio de gasto por cada año
            ListaA.Adapter  = new AdapterAnio(this, ClaseGlobal.Anios);
            ListaT.Adapter  = new PromedioTotal(this, ClaseGlobal.Anios);
            ListaAL.Adapter = new PromedioAlimento(this, ClaseGlobal.Anios);
            ListaV.Adapter  = new PromedioVestuario(this, ClaseGlobal.Anios);
            ListaU.Adapter  = new PromedioUsoHogar(this, ClaseGlobal.Anios);

            //cuando el usuario presione un año este se le mostrara sus meses correspondiente 
            ListaAnios.ItemClick += ListaAnios_ItemClick;
        }

        private void ListaAnios_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            //se pretende obtener el id del año seleccionado para poder detallar sus meses 
            Intent i = new Intent(this, typeof(DetalleAniosActivity));
            Anios anios = ClaseGlobal.Anios[e.Position];
            i.PutExtra("id", anios.Id);
            StartActivity(i);
        }
    }
}