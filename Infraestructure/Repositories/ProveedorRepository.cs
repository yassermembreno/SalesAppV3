using Core;
using Core.Poco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Data
{
    public class ProveedorRepository : ISupplierRepository
    {
        private RAFContext context;
        private readonly int SIZE = 388;

        public ProveedorRepository()
        {
            context = new RAFContext("Proveedor",SIZE);
        }

        public void Create(Supplier t)
        {
            context.Create<Supplier>(t);
        }

        public bool Delete(Supplier t)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Supplier> Find(Expression<Func<Supplier, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Supplier> GetAll()
        {
            return context.GetAll<Supplier>();
        }

        public int Update(Supplier t)
        {
            throw new NotImplementedException();
        }
    }
}
