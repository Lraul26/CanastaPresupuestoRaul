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
    class ClaseGlobal
    {
        public static List<Anios> Anios = new List<Anios>()
        {
            new Anios (1,2005),
            new Anios (2,2006),
            new Anios (3,2007),
            new Anios (4,2008)
        };
        public static List<Meses> Meses = new List<Meses>()
        {
            //datos del año 2005
            new Meses(1,"Enero",decimal.Parse("1504.10"),decimal.Parse("916.9"),decimal.Parse("142.8"),decimal.Parse("2563.70"),1),
            new Meses(2,"Febrero",decimal.Parse("1508.80"),decimal.Parse("913"),decimal.Parse("143.8"),decimal.Parse("2565.60"),1),
            new Meses(3,"Marzo",decimal.Parse("1514.50"),decimal.Parse("919.3"),decimal.Parse("144.3"),decimal.Parse("2578.20"),1),
            new Meses(4,"Abril",decimal.Parse("1556.30"),decimal.Parse("1003.90"),decimal.Parse("146.2"),decimal.Parse("2706.40"),1),
            new Meses(5,"Mayo",decimal.Parse("1592.60"),decimal.Parse("927.1"),decimal.Parse("146.6"),decimal.Parse("2666.30"),1),
            new Meses(6,"Junio",decimal.Parse("1597.00"),decimal.Parse("925.4"),decimal.Parse("147.1"),decimal.Parse("2669.50"),1),
            new Meses(7,"Julio",decimal.Parse("1611.10"),decimal.Parse("931.8"),decimal.Parse("147.9"),decimal.Parse("2690.80"),1),
            new Meses(8,"Agosto",decimal.Parse("1605.20"),decimal.Parse("946"),decimal.Parse("148.2"),decimal.Parse("2699.40"),1),
            new Meses(9,"Septiembre",decimal.Parse("1608.70"),decimal.Parse("952"),decimal.Parse("148.7"),decimal.Parse("2709.30"),1),
            new Meses(10,"Octubre",decimal.Parse("1631.20"),decimal.Parse("969.2"),decimal.Parse("149.2"),decimal.Parse("2749.60"),1),
            new Meses(11,"Noviembre",decimal.Parse("1680.80"),decimal.Parse("968.1"),decimal.Parse("149.3"),decimal.Parse("2798.20"),1),
            new Meses(12,"Diciembre",decimal.Parse("1,679.30"),decimal.Parse("964.1"),decimal.Parse("151.4"),decimal.Parse("2794.80"),1),

            //datos del año 2006
            new Meses(13,"Enero",decimal.Parse("1687.20"),decimal.Parse("970.3"),decimal.Parse("152.6"),decimal.Parse("2810.1"),2),
            new Meses(14,"Febrero",decimal.Parse("1691.60"),decimal.Parse("967.4"),decimal.Parse("153.4"),decimal.Parse("2812.4"),2),
            new Meses(15,"Marzo",decimal.Parse("1719.00"),decimal.Parse("960"),decimal.Parse("154.6"),decimal.Parse("2833.7"),2),
            new Meses(16,"Abril",decimal.Parse("1728.00"),decimal.Parse("964.4"),decimal.Parse("154.8"),decimal.Parse("2847.2"),2),
            new Meses(17,"Mayo",decimal.Parse("1733.90"),decimal.Parse("1063.8"),decimal.Parse("157.1"),decimal.Parse("2954.7"),2),
            new Meses(18,"Junio",decimal.Parse("1740.30"),decimal.Parse("1069.6"),decimal.Parse("158.8"),decimal.Parse("2968.7"),2),
            new Meses(19,"Julio",decimal.Parse("1732.80"),decimal.Parse("1077.8"),decimal.Parse("160.1"),decimal.Parse("2970.7"),2),
            new Meses(20,"Agosto",decimal.Parse("1740.80"),decimal.Parse("1085.8"),decimal.Parse("161.1"),decimal.Parse("2987.7"),2),
            new Meses(21,"Septiembre",decimal.Parse("1745.5"),decimal.Parse("1083.7"),decimal.Parse("163.4"),decimal.Parse("2992.5"),2),
            new Meses(22,"Octubre",decimal.Parse("1758.6"),decimal.Parse("1076.5"),decimal.Parse("163.9"),decimal.Parse("2999"),2),
            new Meses(23,"Noviembre",decimal.Parse("1797"),decimal.Parse("1066.1"),decimal.Parse("166.1"),decimal.Parse("3029.1"),2),
            new Meses(24,"Diciembre",decimal.Parse("1852.7"),decimal.Parse("1026.8"),decimal.Parse("166.9"),decimal.Parse("3046.4"),2),

            //datos del año 2007
            new Meses(25,"Enero",decimal.Parse("1876.2"),decimal.Parse("1001.4"),decimal.Parse("168.4"),decimal.Parse("3046.1"),3),
            new Meses(26,"Febrero",decimal.Parse("1909"),decimal.Parse("1002.6"),decimal.Parse("169.5"),decimal.Parse("3081"),3),
            new Meses(27,"Marzo",decimal.Parse("1910.6"),decimal.Parse("1010.4"),decimal.Parse("172.3"),decimal.Parse("3093.3"),3),
            new Meses(28,"Abril",decimal.Parse("1925.3"),decimal.Parse("1019.3"),decimal.Parse("174.5"),decimal.Parse("3119"),3),
            new Meses(29,"Mayo",decimal.Parse("1909.4"),decimal.Parse("1030.8"),decimal.Parse("174.8"),decimal.Parse("3115"),3),
            new Meses(30,"Junio",decimal.Parse("1967.8"),decimal.Parse("1038.3"),decimal.Parse("175.6"),decimal.Parse("3181.7"),3),
            new Meses(31,"Julio",decimal.Parse("2001.6"),decimal.Parse("1039.8"),decimal.Parse("176.8"),decimal.Parse("3218.2"),3),
            new Meses(32,"Agosto",decimal.Parse("2030.2"),decimal.Parse("1045.8"),decimal.Parse("178.6"),decimal.Parse("3254.6"),3),
            new Meses(33,"Septiembre",decimal.Parse("1745.5"),decimal.Parse("1083.7"),decimal.Parse("163.4"),decimal.Parse("2992.5"),3),
            new Meses(34,"Octubre",decimal.Parse("4398.6"),decimal.Parse("2347.8"),decimal.Parse("692.1"),decimal.Parse("7438.5"),3),
            new Meses(35,"Noviembre",decimal.Parse("4730.6"),decimal.Parse("2351.4"),decimal.Parse("704.5"),decimal.Parse("7786.5"),3),
            new Meses(36,"Diciembre",decimal.Parse("4647.2"),decimal.Parse("2366.3"),decimal.Parse("700.4"),decimal.Parse("7713.9"),3),

            //datos del año 2008
            new Meses(37,"Enero",decimal.Parse("4690.5"),decimal.Parse("2375.3"),decimal.Parse("711.1"),decimal.Parse("7776.9"),4),
            new Meses(38,"Febrero",decimal.Parse("4775.5"),decimal.Parse("2380.5"),decimal.Parse("718.4"),decimal.Parse("7874.4"),4),
            new Meses(39,"Marzo",decimal.Parse("4820.7"),decimal.Parse("2384.8"),decimal.Parse("721.3"),decimal.Parse("7926.8"),4),
            new Meses(40,"Abril",decimal.Parse("4903.4"),decimal.Parse("2400.2"),decimal.Parse("726"),decimal.Parse("8029.6"),4),
            new Meses(41,"Mayo",decimal.Parse("5179.3"),decimal.Parse("2420.1"),decimal.Parse("731.9"),decimal.Parse("8331.3"),4),
            new Meses(42,"Junio",decimal.Parse("5452"),decimal.Parse("2442.5"),decimal.Parse("741.9"),decimal.Parse("8636.4"),4),
            new Meses(43,"Julio",decimal.Parse("5469.6"),decimal.Parse("2470.2"),decimal.Parse("747.7"),decimal.Parse("8687.4"),4),
            new Meses(44,"Agosto",decimal.Parse("5444"),decimal.Parse("2472.9"),decimal.Parse("758"),decimal.Parse("8674.9"),4),
            new Meses(45,"Septiembre",decimal.Parse("5391.4"),decimal.Parse("2464.4"),decimal.Parse("761.6"),decimal.Parse("8617.4"),4),
            new Meses(46,"Octubre",decimal.Parse("5509.2"),decimal.Parse("2451.2"),decimal.Parse("766.2"),decimal.Parse("8726.5"),4),
            new Meses(47,"Noviembre",decimal.Parse("5672.6"),decimal.Parse("2403.3"),decimal.Parse("781.5"),decimal.Parse("8857.4"),4),
            new Meses(48,"Diciembre",decimal.Parse("5650.7"),decimal.Parse("2375.3"),decimal.Parse("792.4"),decimal.Parse("8818.4"),4)
        };
    }
    public class Anios
    {
        int id;
        int anio;

        public Anios(int id, int anio)
        {
            this.Id = id;
            this.Anio = anio;
        }

        public int Id { get => id; set => id = value; }
        public int Anio { get => anio; set => anio = value; }
    }
    public class Meses
    {
        int id;
        string nombre_mes;
        decimal alimentos;
        decimal uso_hogar;
        decimal vestuario;
        decimal total;
        int id_anio;

        public Meses(int id, string nombre_mes, decimal alimentos, decimal uso_hogar, decimal vestuario, decimal total, int id_anio)
        {
            this.Id = id;
            this.Nombre_mes = nombre_mes;
            this.Alimentos = alimentos;
            this.Uso_hogar = uso_hogar;
            this.Vestuario = vestuario;
            this.Total = total;
            this.Id_anio = id_anio;
        }
        public int Id { get => id; set => id = value; }
        public string Nombre_mes { get => nombre_mes; set => nombre_mes = value; }
        public decimal Alimentos { get => alimentos; set => alimentos = value; }
        public decimal Uso_hogar { get => uso_hogar; set => uso_hogar = value; }
        public decimal Vestuario { get => vestuario; set => vestuario = value; }
        public decimal Total { get => total; set => total = value; }
        public int Id_anio { get => id_anio; set => id_anio = value; }
    }
}