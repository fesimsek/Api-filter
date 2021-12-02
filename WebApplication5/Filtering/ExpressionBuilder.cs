using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;
using WebApplication5.DbOperations;
using static WebApplication5.Filter;
using System.Text.Json;


namespace WebApplication5.Filtering
{
    public static class ExpressionBuilder 
    {


        public static Expression<Func<T,
        bool>> GetExpression<T>(IList<Filter> filters)
        {
            if (filters.Count == 0)
                return null;

            ParameterExpression param = Expression.Parameter(typeof(T), "t");
            Expression exp = null;

            if (filters.Count == 1)
                exp = GetExpression<T>(param, filters[0]);
            else if (filters.Count == 2)
                exp = GetExpression<T>(param, filters[0], filters[1]);
            else
            {
                while (filters.Count > 0)
                {
                    var f1 = filters[0];
                    var f2 = filters[1];

                    if (exp == null)
                        exp = GetExpression<T>(param, filters[0], filters[1]);
                    else
                        exp = Expression.AndAlso(exp, GetExpression<T>(param, filters[0], filters[1]));

                    filters.Remove(f1);
                    filters.Remove(f2);

                    if (filters.Count == 1)
                    {
                        exp = Expression.AndAlso(exp, GetExpression<T>(param, filters[0]));
                        filters.RemoveAt(0);
                    }
                }
            }

            return Expression.Lambda<Func<T, bool>>(exp, param);
        }

        private static Expression GetExpression<T>(ParameterExpression param, Filter filter)
        {
            MemberExpression member = Expression.Property(param, filter.Field);          
            var constant = Expression.Constant(filter.Value);

            MethodInfo containsMethod = typeof(string).GetMethod("Contains", new Type[] { typeof(string) });
            MethodInfo startsWithMethod = typeof(string).GetMethod("StartsWith", new Type[] { typeof(string) });
            MethodInfo endsWithMethod = typeof(string).GetMethod("EndsWith", new Type[] { typeof(string) });

            if (member.Type.Name == "DateTime")
            {
                filter.Value = Convert.ToDateTime(filter.Value.ToString());
                constant = Expression.Constant(filter.Value);
            }
            else if (member.Type.Name == "Int32")
            {
                filter.Value = Convert.ToInt32(filter.Value.ToString());
                constant = Expression.Constant(filter.Value);
            }
            else if (member.Type.Name == "Nullable`1" )
            {
                string a = "Int32";
                string b = "DateTime";
                if (member.Type.FullName.Contains(a) == true )
                {
                    if(filter.Operator != "isnull" && filter.Operator != "isnotnull")
                    {
                        object searchVal = Int32.Parse(filter.Value.ToString());
                        constant = Expression.Constant(searchVal, typeof(Nullable<Int32>));
                    } 
                    else { }
                }

                else if (member.Type.FullName.Contains(b) == true)
                {
                    if (filter.Operator != "isnull" && filter.Operator != "isnotnull") { 
                        object searchVal = DateTime.Parse(filter.Value.ToString());
                        constant = Expression.Constant(searchVal, typeof(Nullable<DateTime>));
                    }
                    else { }
                }
            }
            else
            {
                filter.Value = Convert.ToString(filter.Value);
                constant = Expression.Constant(filter.Value);
            }
                
            switch (filter.Operator)
            {
                case "eq":
                    return Expression.Equal(member, constant);
                    
                case "neq":
                    return Expression.NotEqual(member, constant);

                case "contains":
                    return Expression.Call(member, containsMethod, constant);

                case "doesnotcontain":
                    return Expression.Not(Expression.Call(member, containsMethod, constant));

                case "startswith":
                    return Expression.Call(member, startsWithMethod, constant);

                case "endswith":
                    return Expression.Call(member, endsWithMethod, constant);

                case "isnull":
                    return Expression.Equal(member, Expression.Constant(null, member.Type));

                case "isnotnull":
                    return Expression.Not(Expression.Equal(member, Expression.Constant(null, member.Type)));

                case "isempty":
                    return Expression.Equal(member, Expression.Constant("", member.Type));

                case "isnotempty":
                    return Expression.Not(Expression.Equal(member, Expression.Constant("", member.Type)));

                case "gte":
                    return Expression.GreaterThanOrEqual(member, constant);

                case "gt":
                    return Expression.GreaterThan(member, constant);

                case "lte":
                    return Expression.LessThanOrEqual(member, constant);
                case "lt":
                    return Expression.LessThan(member, constant);
            }

            return null;
        }

        private static BinaryExpression GetExpression<T>
        (ParameterExpression param, Filter filter1, Filter filter2)
        {
            Expression bin1 = GetExpression<T>(param, filter1);
            Expression bin2 = GetExpression<T>(param, filter2);

            return Expression.AndAlso(bin1, bin2);
        }

    }


}
