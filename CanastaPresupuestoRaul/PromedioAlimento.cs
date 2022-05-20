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
    class PromedioAlimento : BaseAdapter
    {
        Activity context;
        List<Anios> lista;

        public PromedioAlimento(Activity context, List<Anios> lista)
        {
            this.context = context;
            this.lista = lista;
        }

        public override int Count => lista.Count();

        public override Java.Lang.Object GetItem(int position)
        {
            throw new NotImplementedException();
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = lista[position];
            View view = convertView;
            if (view == null)
                view = context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem1, null);
            //obtenemos el gasto promedio de alimentos de todo el año
            view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = "C$"+ClaseGlobal.Meses.Where(x => x.Id_anio == item.Id).Average(x => x.Alimentos).ToString("0");
            return view;
        }
    }
}