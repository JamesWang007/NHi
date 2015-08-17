using NHibernate;
using NHibernate.Linq;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Cache;

namespace Commencement_Mvc_Data {
    public static class DatabaseConnection {
        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory {
            get {
                if (_sessionFactory == null) {
                    var configuration = new Configuration();

                    configuration = FluentConfig.Configure(configuration);

                    _sessionFactory = configuration.BuildSessionFactory();
                }

                return _sessionFactory;
            }
        }

        public static ISession OpenSession() {
            return SessionFactory.OpenSession();
        }
    }


    public class Repository<T> : IDisposable where T : class {
        protected ISession _session = null;
        protected ITransaction _transaction = null;
        protected IQueryable<T> Set { get; set; }

        protected Repository() {
            _session = DatabaseConnection.OpenSession();
            Set = _session.Query<T>();
        }

        public void Save(T entity) {
            if (_transaction == null) {
                BeginTransaction();
            }

            _session.Save(entity);

        }

        public void Update(T entity) {
            if (_transaction == null) {
                BeginTransaction();
            }

            _session.Update(entity);

        }

        public void Delete(T entity) {
            if (_transaction == null) {
                BeginTransaction();
            }

            _session.Delete(entity);
        }

        public void BeginTransaction() {
            _transaction = _session.BeginTransaction();
        }

        public void CommitTransaction() {
            _transaction.Commit();
            CloseTransaction();
        }

        public void RollbackTransaction() {
            _transaction.Rollback();
            CloseTransaction();
        }

        private void CloseTransaction() {
            _transaction.Dispose();
            _transaction = null;
        }

        private void CloseSession() {
            _session.Close();
            _session.Dispose();
            _session = null;
        }

        public void Dispose() {
            if (_transaction != null) {
                CommitTransaction();
            }
            if (_session != null) {
                _session.Flush();
                CloseSession();
            }
        }
    }
}