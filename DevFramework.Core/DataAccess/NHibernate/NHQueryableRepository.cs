using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.Entities;

namespace DevFramework.Core.DataAccess.NHibernate
{
    class NHQueryableRepository<T>:IQueryableRepository<T> where T:class,IEntity,new()
    {
        private NHibernateHelper _nHibernateHelper;
        private IQueryable<T> _entities;
        public NHQueryableRepository(NHibernateHelper nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }


        public IQueryable<T> Table
        {
            get { return this.Entites; }
        }

        public virtual IQueryable<T> Entites
        {
            get { return _entities ?? (_entities = _nHibernateHelper.OpenSession().Query<T>()); }
        }
    }
}
