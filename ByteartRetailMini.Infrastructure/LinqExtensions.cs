using System.Collections.Generic;
using System.Linq.Expressions;
using ByteartRetailMini.Infrastructure;

// ReSharper disable once CheckNamespace
namespace System.Linq.Dynamic
{
    public static class LinqExtensions
    {
        public static IQueryable<T> OrderBy<T>(this IQueryable<T> queryable, string propertyName)
        {
            return QueryableHelper<T>.OrderBy(queryable, propertyName, false);
        }

        public static IQueryable<T> OrderBy<T>(this IQueryable<T> queryable, string propertyName, bool desc)
        {
            return QueryableHelper<T>.OrderBy(queryable, propertyName, desc);
        }

        static class QueryableHelper<T>
        {
            private static Dictionary<string, LambdaExpression> cache = new Dictionary<string, LambdaExpression>();
            public static IQueryable<T> OrderBy(IQueryable<T> queryable, string propertyName, bool desc)
            {
                dynamic keySelector = GetLambdaExpression(propertyName);
                return desc ? Queryable.OrderByDescending(queryable, keySelector) : Queryable.OrderBy(queryable, keySelector);
            }
            private static LambdaExpression GetLambdaExpression(string propertyName)
            {
                if (cache.ContainsKey(propertyName)) return cache[propertyName];
                var param = Expression.Parameter(typeof(T));
                var body = Expression.Property(param, propertyName);
                var keySelector = Expression.Lambda(body, param);
                cache[propertyName] = keySelector;
                return keySelector;
            }
        }

        public static List<T> ToPagedList<T>(this IQueryable<T> queryable, PageInfo pageInfo)
        {
            return queryable.OrderBy(pageInfo.OrderPropertyName, pageInfo.IsDesc)
                .Skip((pageInfo.PageIndex - 1) * pageInfo.PageSize)
                .Take(pageInfo.PageSize).ToList();
        }
    }
}