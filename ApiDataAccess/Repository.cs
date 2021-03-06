﻿

namespace ApiDataAccess
{
    using ApiRepositories;
    using Dapper.Contrib.Extensions;
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Text;
    public class Repository<T> : IRepository<T> where T : class
    {
        protected string _connectionString;
        public Repository(string _connectionString)
        {
            SqlMapperExtensions.TableNameMapper = (type) => { return $"{type.Name }"; };
            this._connectionString = _connectionString;
        }
        public bool Delete(T entity)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Delete(entity); //ORM dapper
            }
        }

        public T GetById(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Get<T>(id);
            }
        }

        public IEnumerable<T> GetList()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.GetAll<T>();
            }
        }

        public int Insert(T entity)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return (int)connection.Insert(entity);
            }
        }

        public bool Update(T entity)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Update(entity);
            }
        }
    }
}
