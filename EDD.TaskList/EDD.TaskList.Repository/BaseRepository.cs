using System.Data.Common;
using System.Collections.Generic;
using System.Data;
using System;
using EDD.TaskList.Entity;
using Dapper;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace EDD.TaskList.Repository
{
    public abstract class BaseRepository
    {
        protected String ConnectionString {
            get {
                return _configuration.GetSection("ConnectionStrings").GetSection("DbConnection").Value;
            }
        }

        protected int TimeOut {
            get {
                return Convert.ToInt32(_configuration.GetSection("ConnectionStrings").GetSection("TimeOut").Value);
            }
        }

        protected IConfiguration _configuration;

        private SqlConnection _dbContext;
        protected SqlConnection DbContext {
            get {
                if(_dbContext == null)
                    _dbContext  = new SqlConnection(ConnectionString);
                return _dbContext;
            }
        }

        protected void _save(String procedureName, DbTransaction transaction, DynamicParameters parameters)
        {
            DbContext.Execute(procedureName, parameters, transaction, TimeOut, CommandType.StoredProcedure);
        }

        protected void _save(String procedureName, DynamicParameters parameters)
        {
            DbContext.Execute(procedureName, parameters, null, TimeOut, CommandType.StoredProcedure);
        }
    }
}
