using Dominio.QuickBuy.Contratos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio.QuickBuy.Repositorios
{
    public class BaseRepositorio<TEntety> : IBaseRepositorio<TEntety> where TEntety : class
    {
        public BaseRepositorio()
        {

        }
        public void Adicionar(TEntety entity)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(TEntety entity)
        {
            throw new NotImplementedException();
        }
  
        public TEntety ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntety> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(TEntety entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
