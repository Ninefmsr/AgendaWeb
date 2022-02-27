using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaWeb.Infra.Data.Interfaces
{
    /// <summary>
    /// Interface generica p/ as operações do repositorio
    /// </summary>
   
    public interface IBaseRepository<TEntity>
        where TEntity : class
    {
        void Create(TEntity obj);
        void Update(TEntity obj);
        void Delete(TEntity obj);

        List<TEntity> GetAll();  //CONSULTA TODOS OR REGISTROS
        TEntity GetById(Guid id);//CONSULTA APENAS UM REGISTRO PELO  ID
    }
}
