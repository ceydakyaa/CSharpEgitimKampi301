using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Repositories;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.EntityFramework
{
    public class EfAdminDal : GenericRepository<Admin>, IAdminDal
    {
        public void Delete(Admin entity)
        {
            throw new NotImplementedException();
        }

        public void Insert(Admin entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Admin entity)
        {
            throw new NotImplementedException();
        }

        List<Admin> IGenericDal<Admin>.GetAll()
        {
            throw new NotImplementedException();
        }

        Admin IGenericDal<Admin>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
