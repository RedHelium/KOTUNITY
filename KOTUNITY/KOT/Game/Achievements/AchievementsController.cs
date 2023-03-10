using KOT.System;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KOT.Game.Achievements
{
    public static class AchievementsController
    {
        private static List<AchievementModel> achievements = new List<AchievementModel>();
        private static AchievementsView view; 


        public static void Init()
        {
            //TODO Init list and view
        }

        public static void Achieve(ushort id)
        {

            AchievementModel achievement = achievements.Find(x => x.ID.Equals(id));

            if(!achievement.ID.Equals(0))
            {
                achievement.IsAchieve = true;

                view?.Show(achievement);

                DebugController.Log($"Achievement {achievement.Name} unlocked!");

                //TODO Save achievements state
            }
            else
            {
                DebugController.Log($"Achievement ID:{id} not found", logType: DebugController.LogType.Error);
            }
        }
    }
}
