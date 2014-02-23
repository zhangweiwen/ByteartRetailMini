using System;
using System.Diagnostics;
using System.IO;
using NHibernate;
using NHibernate.SqlCommand;

namespace ByteartRetailMini.Infrastructure
{
    public class SqlInterceptor : EmptyInterceptor
    {
        public override SqlString OnPrepareStatement(SqlString sql)
        {
            Debug.WriteLine(sql);
            var parameters = sql.GetParameters();
            foreach (var parameter in parameters)
            {
                Debug.WriteLine(parameter.ToString());
            }
            return base.OnPrepareStatement(sql);
        }
    }
}