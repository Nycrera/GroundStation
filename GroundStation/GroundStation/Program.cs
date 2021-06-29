using System;

namespace GroundStation
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
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
#endif
}

