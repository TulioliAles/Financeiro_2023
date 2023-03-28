using Dominio.Interfaces.Generics;
using Infra.Configuracao;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositorio.Generics
{
    public class RepositoryGenerics<T> : IGeneric<T> where T : class
    {
        private readonly DbContextOptions<ContextBase> _OptionsBuilder;

        public RepositoryGenerics()
        {
            _OptionsBuilder = new DbContextOptions<ContextBase>();
        }

        public async Task Add(T Objeto)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(T Objeto)
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetEntityById(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> List()
        {
            throw new NotImplementedException();
        }

        public async Task Update(T Objeto)
        {
            throw new NotImplementedException();
        }
    }
}
