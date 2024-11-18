using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static estadisticasForm.EstructuraModelo;
using static estadisticasForm.PoblarModelo;


 

namespace estadisticasForm
{
    internal class LogicaEstadistica
    {
        private List<Pago> pagos = ObtenerPagosDeEjemplo();
        private List<Miembro> miembros = ObtenerMiembrosDeEjemplo();
        private List<Entrada> entradas = ObtenerEntradasDeEjemplo();


        // ############################## INGRESOS POR MES ########################### //

        public SeriesCollection ObtenerIngresosPorMes()
        {
            var ingresosMensuales = pagos
                .GroupBy(p => p.FechaRealizacion.Month)
                .Select(g => new { Mes = g.Key, Total = g.Sum(p => p.Monto) })
                .OrderBy(x => x.Mes)
                .ToList();

            return new SeriesCollection
    {
        new LineSeries
        {
            Title = "Ingresos Mensuales",
            Values = new ChartValues<decimal>(ingresosMensuales.Select(x => x.Total)),
            PointGeometry = null // Para simplificar
        }
    };
        }

        // ############################## CONCEPTOS DE PAGOS ########################### //


        public SeriesCollection ObtenerDistribucionPorConcepto()
        {
            var conceptos = pagos
                .GroupBy(p => p.Descripcion)
                .Select(g => new { Concepto = g.Key, Total = g.Sum(p => p.Monto) })
                .ToList();

            var series = new SeriesCollection();
            foreach (var concepto in conceptos)
            {
                series.Add(new PieSeries
                {
                    Title = concepto.Concepto,
                    Values = new ChartValues<decimal> { concepto.Total },
                    DataLabels = true
                });
            }

            return series;
        }

        // ############################## MEMBRESIAS VIGENTES/VENCIDAS ########################### //


        public SeriesCollection ObtenerMembresiasActivasVencidas()
        {
            var activos = miembros.Count(m => m.FechaExp > DateTime.Now);
            var vencidos = miembros.Count(m => m.FechaExp <= DateTime.Now);

            return new SeriesCollection
    {
        new PieSeries
        {
            Title = "Activas",
            Values = new ChartValues<int> { activos },
            DataLabels = true
        },
        new PieSeries
        {
            Title = "Vencidas",
            Values = new ChartValues<int> { vencidos },
            DataLabels = true
        }
    };
        }

        // ############################## MIEMBROS POR FACULTAD ########################### //


        public SeriesCollection ObtenerMiembrosPorFacultad()
        {
            var facultades = miembros
                .GroupBy(m => m.Facultad)
                .Select(g => new { Facultad = g.Key, Total = g.Count() })
                .ToList();

            var series = new SeriesCollection();
            foreach (var facultad in facultades)
            {
                series.Add(new ColumnSeries
                {
                    Title = facultad.Facultad,
                    Values = new ChartValues<int> { facultad.Total }
                });
            }

            return series;
        }


        // ############################## INTERNOS Y EXTERNOS ########################### //


        public SeriesCollection ObtenerMiembrosInternosExternos()
        {
            var internos = miembros.Count(m => m.Interno);
            var externos = miembros.Count(m => !m.Interno);

            return new SeriesCollection
    {
        new PieSeries
        {
            Title = "Internos",
            Values = new ChartValues<int> { internos },
            DataLabels = true
        },
        new PieSeries
        {
            Title = "Externos",
            Values = new ChartValues<int> { externos },
            DataLabels = true
        }
    };
        }


        // ############################## ENTRADAS POR HORA ########################### //

        public SeriesCollection ObtenerEntradasPorHora()
        {
            var entradasPorHora = entradas
                .GroupBy(e => e.Hora.Hours)
                .Select(g => new { Hora = g.Key, Total = g.Count() })
                .OrderBy(x => x.Hora)
                .ToList();

            return new SeriesCollection
    {
        new LineSeries
        {
            Title = "Entradas por Hora",
            Values = new ChartValues<int>(entradasPorHora.Select(x => x.Total)),
            PointGeometry = null // Para simplificar
        }
    };
        }


        // ############################## ENTRADAS POR DIA ########################### //


        public SeriesCollection ObtenerEntradasPorDia()
        {
            var entradasPorDia = entradas
                .GroupBy(e => e.Fecha.Date)
                .Select(g => new { Fecha = g.Key, Total = g.Count() })
                .OrderBy(x => x.Fecha)
                .ToList();

            return new SeriesCollection
    {
        new LineSeries
        {
            Title = "Entradas por Día",
            Values = new ChartValues<int>(entradasPorDia.Select(x => x.Total)),
            PointGeometry = null // Para simplificar
        }
    };
        }

    }



}

