

using MotoApp.Entities;

namespace MotoApp.Repositories
{
    public interface IWriteRepository <in T> where T : class, IEntity
    {
        void Add(T intem);
        void Remove(T intem);
        void Save();
    }
}
