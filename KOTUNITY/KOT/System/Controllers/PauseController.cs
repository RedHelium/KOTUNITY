using KOT.System.Interfaces;
using System.Collections.Generic;

namespace KOT.System.Controllers
{
    public static class PauseController
    {

        private static List<Pausable> pausables = new List<Pausable>();

        public static void Add(Pausable pausable) => pausables.Add(pausable);

        public static void Pause(bool onPause)
        {
            foreach (Pausable pausable in pausables)
            {
                if (onPause)
                    pausable.OnPause();
                else
                    pausable.OnContinue();
            }
        }
    }
}
