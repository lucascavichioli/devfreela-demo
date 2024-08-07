namespace DevFreela.API.Entities
{
    public class UserSkill
    {
        public UserSkill(User user, Skill skill) : base()
        {
            User = user;
            Skill = skill;
        }

        public int IdUser { get; private set; }
        public User User { get; private set; }
        public int IdSkill { get; private set; }
        public Skill Skill { get; private set; }
    }
}
