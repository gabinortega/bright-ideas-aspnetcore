using BrightIdeas.Core.Entities;

namespace BrightIdeas.Data
{
    public interface IDbRepository
    {
        Task<Idea?> GetIdeaByIdAsync(int id);
        Task<IEnumerable<Idea>> GetIdeasByTagIdAsync(int tagId);
        Task<IEnumerable<Idea>> GetIdeasByTagNameAsync(string tagName);
        Task<IEnumerable<Idea>> GetIdeasByTagIdAsync(IEnumerable<int> tagIdList);
        Task<IEnumerable<Idea>> GetIdeasByTagNameAsync(IEnumerable<string> tagNameList);

        Task<Idea?> CreateIdeaAsync(Idea idea);
        Task UpdateIdeaAsync(Idea idea);

        Task<Idea?> GetTagsByIdAsync(int tagId);
        Task<Idea?> GetTagsByNameAsync(string tagName);
        Task<Idea?> CreateTagAsync(Tag tag);
        Task UpdateTagAsync(Tag tag);

        Task<Idea?> ChangeTagAsync(int idea, int oldTag, int newTag);
        Task<Idea?> RemoveAllTagsFromIdeaAsync(int idea);

        Task<Idea?> UpdateStatusAsync(int idea, int status);
    }
}