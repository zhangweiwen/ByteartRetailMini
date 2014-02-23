using System.Collections.Generic;
using System.Data;
using FluentNHibernate.Cfg.Db;
using NHibernate.Driver;
using NHibernate.SqlCommand;
using NHibernate.SqlTypes;

namespace ByteartRetailMini.Services.Core
{
    public class LogSqliteDriver : SQLite20Driver
    {
        public override IDbCommand GenerateCommand(CommandType type, SqlString sqlString, SqlType[] parameterTypes)
        {
            var command = base.GenerateCommand(type, sqlString, parameterTypes);
            var xxx = command.CommandText;
            var hhh = command.Parameters;
            return command;
        }

    }
}