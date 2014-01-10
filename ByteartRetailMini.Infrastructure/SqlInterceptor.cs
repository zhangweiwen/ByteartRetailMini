using System;
using NHibernate;
using NHibernate.SqlCommand;

namespace ByteartRetailMini.Infrastructure
{
    public class SqlInterceptor : EmptyInterceptor
    {
        public override SqlString OnPrepareStatement(SqlString sql)
        {
            Console.WriteLine(sql);
            return base.OnPrepareStatement(sql);
        }
    }
}