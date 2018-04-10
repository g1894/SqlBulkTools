﻿using System.Data.SqlClient;
using System.Threading.Tasks;

namespace SqlBulkTools
{
    internal interface ITransaction
    {
        void CommitTransaction(string connectionString = null, SqlConnection connection = null);
        Task CommitTransactionAsync(string connectionString = null, SqlConnection connection = null);
    }
}
