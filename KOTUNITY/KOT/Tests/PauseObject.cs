using KOT.System.Controllers;
using KOT.System.Interfaces;
using System;

namespace KotunityConsole.KOT.Tests
{
    public sealed class PauseObject : Pausable
    {
        public PauseObject()
        {
            PauseController.Add(this);
        }

        public void OnContinue()
        {
            Console.WriteLine("Continue. Object work.");
        }

        public void OnPause()
        {
            Console.WriteLine("Pause. Object stopped.");
        }
    }
}
