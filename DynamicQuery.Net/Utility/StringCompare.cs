﻿using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;
using DynamicQuery.Net.Utility.dto.input;
using DynamicQuery.Net.Utility.Interface;

namespace DynamicQuery.Net.Utility
{
    public class StringCompare : ICompare
    {
        private static int _equalNumber = 0;
        private const bool TrueValue = true;
        
        public Expression Equal<T>(CompareInput input)
        {
            var compare = Expression.Call(typeof(string), "Compare", null, input.Property, input.Value);
            return Expression.Equal(compare, Expression.Constant(_equalNumber));
        }

        public Expression NotEqual<T>(CompareInput input)
        {
            var compare = Expression.Call(typeof(string), "Compare", null, input.Property, input.Value);
            return Expression.NotEqual(compare, Expression.Constant(_equalNumber));
        }

        public Expression GreaterThan<T>(CompareInput input)
        {
            var compare = Expression.Call(typeof(string), "Compare", null, input.Property, input.Value);
            return Expression.GreaterThan(compare, Expression.Constant(_equalNumber));
        }

        public Expression GreaterThanOrEqual<T>(CompareInput input)
        {
            var compare = Expression.Call(typeof(string), "Compare", null, input.Property, input.Value);
            return Expression.GreaterThanOrEqual(compare, Expression.Constant(_equalNumber));
        }

        public Expression LessThan<T>(CompareInput input)
        {
            var compare = Expression.Call(typeof(string), "Compare", null, input.Property, input.Value);
            return Expression.LessThan(compare, Expression.Constant(_equalNumber));
        }

        public Expression LessThanOrEqual<T>(CompareInput input)
        {   
            var compare = Expression.Call(typeof(string), "Compare", null, input.Property, input.Value);
            return Expression.LessThanOrEqual(compare, Expression.Constant(_equalNumber));
        }

        public Expression Contains<T>(CompareInput input)
        {
            var method = typeof(string).GetMethod("Contains", new[] { typeof(string) });
            var contains = Expression.Call(input.Property, method, input.Value);
            return Expression.Equal(contains, Expression.Constant(TrueValue));
        }
    }
}
