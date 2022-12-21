using UnityEngine;

namespace KOT.Extensions
{
    public static class Extensions
    {
        public enum PathType { DataPath, Persistent, Stream, Temp }
        public static string CreatePath(this string @this, PathType type)
        {
            string dataPath;
            switch (type)
            {
                case PathType.Persistent: dataPath = Application.persistentDataPath; break;
                case PathType.Stream: dataPath = Application.streamingAssetsPath; break;
                case PathType.Temp: dataPath = Application.temporaryCachePath; break;
                case PathType.DataPath:
                default: dataPath = Application.dataPath; break;
            }
            return $"{dataPath}/{@this}";
        }
    }
}