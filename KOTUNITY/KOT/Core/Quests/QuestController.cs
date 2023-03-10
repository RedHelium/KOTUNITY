
namespace KOT.Core.Quests
{
    public abstract class QuestController
    {
        protected QuestModel current;
        protected QuestModel inProgress;

        public abstract void Add(QuestModel model)
    }
}