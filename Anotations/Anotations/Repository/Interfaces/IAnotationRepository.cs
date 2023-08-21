using Anotations.Models;

namespace Anotations.Repository.Interfaces
{
    public interface IAnotationRepository
    {
        public IEnumerable<Anotation> GetAnotations { get; }
    }
}
