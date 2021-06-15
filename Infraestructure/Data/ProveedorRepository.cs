using Core.Interfaces;
using Core.Poco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Data
{
    public class ProveedorRepository : IProveedorRepository
    {
        private RAFContext context;
        private readonly int SIZE = 388;

        public ProveedorRepository()
        {
            context = new RAFContext("Proveedor",SIZE);
        }

        public void Create(Proveedor t)
        {
            context.Create<Proveedor>(t);
        }

        public bool Delete(Proveedor t)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Proveedor> Find(Expression<Func<Proveedor, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Proveedor> GetAll()
        {
            return context.GetAll<Proveedor>();
        }

        public int Update(Proveedor t)
        {
            throw new NotImplementedException();
        }
    }
}
