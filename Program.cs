﻿using estadisticasForm;
using JaguarGymApp_Preview.Formularios;
using JaguarGymApp_Preview.FormulariosReportes;
using System;
using System.Windows.Forms;

namespace JaguarGymApp_Preview
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Solo para el commit
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Inicio_Sesion());
        }
    }
}
