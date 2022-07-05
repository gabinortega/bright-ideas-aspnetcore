using BrightIdeas.Core.Entities;

namespace BrightIdeas.Data.InMemoryDb
{
    public class InMemoryDbService : IDbRepository
    {
        readonly List<Idea> _ideas;
        readonly List<Tag> _tags;

        public InMemoryDbService()
        {
            _tags = new List<Tag>()
            {
                new() { Name = "To Buy" },
                new() { Name = "To Study" },
                new() { Name = "Health" }
            };

            _ideas = new List<Idea>()
            {
                new() { Title = "I need to buy a wallet." },
                new() { Title = "Need to study English" },
                new() { Title = "Need to go to the park" },
                new() { Title = "Need to buy some clothes" }
            };

            _tags[00].Ideas = new List<Idea>() { _ideas[00], _ideas[03] };
            _tags[01].Ideas = new List<Idea>() { _ideas[01] };
            _tags[02].Ideas = new List<Idea>() { _ideas[02] };

        }

        public async Task<Idea> GetIdeaByIdAsync(int id)
        {
            return _ideas[0];
        }

        public Task<IEnumerable<Idea>> GetIdeasByTagIdAsync(int tagId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Idea>> GetIdeasByTagNameAsync(string tagName)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Idea>> GetIdeasByTagIdAsync(IEnumerable<int> tagIdList)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Idea>> GetIdeasByTagNameAsync(IEnumerable<string> tagNameList)
        {
            throw new NotImplementedException();
        }

        public Task<Idea> CreateIdeaAsync(Idea idea)
        {
            throw new NotImplementedException();
        }

        public Task UpdateIdeaAsync(Idea idea)
        {
            throw new NotImplementedException();
        }

        public Task<Idea> GetTagsByIdAsync(int tagId)
        {
            throw new NotImplementedException();
        }

        public Task<Idea> GetTagsByNameAsync(string tagName)
        {
            throw new NotImplementedException();
        }

        public Task<Idea> CreateTagAsync(Tag tag)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTagAsync(Tag tag)
        {
            throw new NotImplementedException();
        }

        public Task<Idea> ChangeTagAsync(int idea, int oldTag, int newTag)
        {
            throw new NotImplementedException();
        }

        public Task<Idea> RemoveAllTagsFromIdeaAsync(int idea)
        {
            throw new NotImplementedException();
        }

        public Task<Idea> UpdateStatusAsync(int idea, int status)
        {
            throw new NotImplementedException();
        }
    }
}
