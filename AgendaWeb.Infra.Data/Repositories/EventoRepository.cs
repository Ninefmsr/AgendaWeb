using AgendaWeb.Infra.Data.Entities;
using AgendaWeb.Infra.Data.Interfaces;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaWeb.Infra.Data.Repositories
{
    /// <summary>
    /// Programando a classe p/ receber a instring de conexão (connectionstring);
    /// Classe EventoRetpository é  p/ implementar as operaçãoes de banco de dados para Evento
    ///  </summary>
    public class EventoRepository : IEventoRepository
    {
        //Declarando atributo readonly
        private readonly string _connectionString;

        //Método construtor utilizado para q/ possamos passar 
        //o valor da connectionstring p/ a classe de repositório
        public EventoRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Create(Evento obj)
        {
            var query = @"
                 INSERT INTO EVENTO(ID, NOME, DATA, HORA, DESCRICAO, PRIORIDADE, DATAINCLUSAO, DATAALTERACAO)
                 VALUES(@Id,@Nome, @Data, @Hora, @Descricao, @Prioridade, @DataInclusao, @DataAlteracao)
            ";

            //conectando no banco de dados 
            using(var connection = new SqlConnection(_connectionString))
            {
                //executando a gravação do evento Create na base de dados
                connection.Execute(query, obj);
            }
        }

        public void Delete(Evento obj)
        {
            throw new NotImplementedException();
        }

        public List<Evento> GetAll()
        {
            throw new NotImplementedException();
        }

        public Evento GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Evento obj)
        {
            throw new NotImplementedException();
        }

        public List<Evento> GetByDatas(DateTime dataMin, DateTime dataMax)
        {
            throw new NotImplementedException();
        }
    }
}
