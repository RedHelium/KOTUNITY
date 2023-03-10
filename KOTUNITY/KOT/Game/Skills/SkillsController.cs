using System.Collections.Generic;

namespace KOT.Game.Skills
{
    public abstract class SkillsController
    {
        protected sbyte currentPoints;
        protected List<SkillModel> skills = new List<SkillModel>();

        public abstract void Add(sbyte count = 1);

        public abstract void Spend(sbyte count);

        public abstract void UnlockSkill(SkillModel skill);
    }
}
