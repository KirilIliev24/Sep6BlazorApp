using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace SEP6_TEST.DbConnection
{
    class DBConn : DbContext
    {
        public DBConn()
        {
        }

        public DBConn(DbContextOptions<DBConn> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Data Source=35.240.12.17;Network Library=DBMSSOCN;Initial Catalog=SqlServerSep6;User ID=sqlserver;Password=kiril2403;",
                 sqlServerOptionsAction: sqlAction =>
                 {
                     sqlAction.EnableRetryOnFailure(
                            maxRetryCount: 10,
                            maxRetryDelay: TimeSpan.FromSeconds(30),
                            errorNumbersToAdd: null
                         );
                 });

            base.OnConfiguring(builder);

        }
    }
}
