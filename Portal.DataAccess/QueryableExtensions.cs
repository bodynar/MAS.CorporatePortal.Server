﻿namespace Portal.DataAccess
{
    using System.Linq;

    public static class QueryableExtensions
    {
        public static IQueryable<TEntity> Where<TEntity>(
            this IQueryable<TEntity> source, Specification<TEntity> specification)
        {
            return source.Where(specification.IsSatisfiedExpression);
        }

        public static bool Any<TEntity>(
            this IQueryable<TEntity> source, Specification<TEntity> specification)
        {
            return source.Any(specification.IsSatisfiedExpression);
        }

        public static int Count<TEntity>(
            this IQueryable<TEntity> source, Specification<TEntity> specification)
        {
            return source.Count(specification.IsSatisfiedExpression);
        }
    }
}