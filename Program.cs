﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginForm
{
    internal static class Program
    {
        public static FormMain formMain = null;
        public static Adatbazis db = new Adatbazis();
        public static List<Auto> autok = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            formMain=new FormMain(); //forMain példányosítása

            using (var formLogin = new FormLogin())
            {
                if (formLogin.ShowDialog()==DialogResult.OK)
                {
                    Application.Run(formMain);
                }
            }
        }
    }
}
