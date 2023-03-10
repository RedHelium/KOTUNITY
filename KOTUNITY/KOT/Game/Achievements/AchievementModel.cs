using UnityEngine;

namespace KOT.Game.Achievements
{
    public struct AchievementModel
    {
        public ushort ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Sprite LockIcon { get; set; }
        public Sprite UnlockIcon { get; set; }
        public bool IsAchieve { get; set; }
    }
}
