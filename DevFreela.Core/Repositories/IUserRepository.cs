using DevFreela.Core.Entities;

namespace DevFreela.Core.Repositories
{
    public interface IUserRepository
    {
        Task<User?> GetById(int id);
        Task<User> GetUserByEmailAndPasswordAsync(string email, string passwordHash);
        Task<int> Add(User user);
        Task AddSkill(List<UserSkill> userSkills);
        //Task UpdateProfilePicture();
    }
}
