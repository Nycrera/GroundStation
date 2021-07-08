using System;
using System.Windows.Forms;

namespace GroundStation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form = new Form1();
            Simulation game = new Simulation(form.getDrawSurface());
            form.simulationObject = game;

#if DEBUG
            Debug debugForm = new Debug();
            debugForm.simulationObject = game;
            debugForm.mainFormObject = form;
            debugForm.Show();
#endif

            form.Show();
            game.Run();
        }
    }
}

