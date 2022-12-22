using UnityEngine;
using UnityEngine.SceneManagement;

namespace KOT.System
{
    public class LoadingScreenEntity : MonoBehaviour
    {
        [SerializeField] private string sceneName;
        [SerializeField] private ILoadingViewer loadingViewer;

        private int sceneIndex = -1;
        private AsyncOperation loadOperation;

        public void SetSceneIndex(int sceneIndex) => this.sceneIndex = sceneIndex;

        protected virtual void Awake()
        {
            if (sceneIndex < 0 || !string.IsNullOrEmpty(sceneName))
                loadOperation = SceneManager.LoadSceneAsync(sceneName);
            else
                loadOperation = SceneManager.LoadSceneAsync(sceneIndex);
        }

        protected virtual void Update()
        {
            loadingViewer.LoadProgress(loadOperation.progress);
        }
    }
}