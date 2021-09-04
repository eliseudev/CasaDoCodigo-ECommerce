using CasaDoCodigo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Repositories
{
    public class CadastroRepository : BaseRepository<ItemPedido>
    {
        public CadastroRepository(ApplicationContext contexto) : base(contexto)
        {
        }
    }
}
