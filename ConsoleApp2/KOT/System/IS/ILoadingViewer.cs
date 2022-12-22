namespace KOT.System
{
    public interface ILoadingViewer
    {
        public void LoadProgress(float progress);
        public void LoadComplete();

    }
}
