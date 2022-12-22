using UnityEngine;
using UnityEngine.SceneManagement;

namespace KOT.System
{
    public static class MenuController
    {
        public static void LoadScene(string name) => SceneManager.LoadScene(name);

        public static void LoadSceneAsync(string name) => SceneManager.LoadSceneAsync(name);

        public static void ConfirmExit(IDialogWindow dialogWindow) => dialogWindow.SetState(true);

        public static void Exit() => Application.Quit();
    }
}