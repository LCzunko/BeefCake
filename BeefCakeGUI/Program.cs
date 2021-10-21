using BeefCakeData.DAL.DAOImpl;
using BeefCakeLogic;
using System;
using System.Windows.Forms;

namespace BeefCakeGUI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var userDao = new UserDao();
            var measurementDao = new MeasurementDao();
            Application.Run(new MainForm(userDao, measurementDao, new InputValidator(userDao), new MeasurementController(measurementDao)));
        }
    }
}
