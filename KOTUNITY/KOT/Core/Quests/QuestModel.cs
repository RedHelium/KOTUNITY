
namespace KOT.Core.Quests
{
    public enum QuestState : sbyte { New = 0, InProgress = 1, Complete = 2, Failed = 3, Cancel = 4 } 
    public enum QuestPriority : sbyte { Main = 0, Second = 1 }

    public struct QuestModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public QuestNodeEntity[] Nodes { get; set; }
        public QuestState State { get; set; }
        public QuestPriority Priority { get; set; }
    
    }

}