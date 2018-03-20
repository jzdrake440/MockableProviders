namespace System.Linq
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    public interface IQueryableProvider
    {
        IQueryable<TSource> DefaultIfEmpty<TSource>(IQueryable<TSource> source, TSource defaultValue);
        Boolean Contains<TSource>(IQueryable<TSource> source, TSource item);
        Boolean Contains<TSource>(IQueryable<TSource> source, TSource item, IEqualityComparer<TSource> comparer);
        IQueryable<TSource> Reverse<TSource>(IQueryable<TSource> source);
        Boolean SequenceEqual<TSource>(IQueryable<TSource> source1, IEnumerable<TSource> source2);
        Boolean SequenceEqual<TSource>(IQueryable<TSource> source1, IEnumerable<TSource> source2, IEqualityComparer<TSource> comparer);
        Boolean Any<TSource>(IQueryable<TSource> source);
        Boolean Any<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Boolean>> predicate);
        Boolean All<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Boolean>> predicate);
        Int32 Count<TSource>(IQueryable<TSource> source);
        Int32 Count<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Boolean>> predicate);
        Int64 LongCount<TSource>(IQueryable<TSource> source);
        Int64 LongCount<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Boolean>> predicate);
        TSource Min<TSource>(IQueryable<TSource> source);
        TResult Min<TSource, TResult>(IQueryable<TSource> source, Expression<Func<TSource, TResult>> selector);
        TSource Max<TSource>(IQueryable<TSource> source);
        TResult Max<TSource, TResult>(IQueryable<TSource> source, Expression<Func<TSource, TResult>> selector);
        Int32 Sum(IQueryable<Int32> source);
        Nullable<Int32> Sum(IQueryable<Nullable<Int32>> source);
        Int64 Sum(IQueryable<Int64> source);
        Nullable<Int64> Sum(IQueryable<Nullable<Int64>> source);
        Single Sum(IQueryable<Single> source);
        Nullable<Single> Sum(IQueryable<Nullable<Single>> source);
        Double Sum(IQueryable<Double> source);
        Nullable<Double> Sum(IQueryable<Nullable<Double>> source);
        Decimal Sum(IQueryable<Decimal> source);
        Nullable<Decimal> Sum(IQueryable<Nullable<Decimal>> source);
        Int32 Sum<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Int32>> selector);
        Nullable<Int32> Sum<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Nullable<Int32>>> selector);
        Int64 Sum<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Int64>> selector);
        Nullable<Int64> Sum<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Nullable<Int64>>> selector);
        Single Sum<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Single>> selector);
        Nullable<Single> Sum<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Nullable<Single>>> selector);
        Double Sum<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Double>> selector);
        Nullable<Double> Sum<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Nullable<Double>>> selector);
        Decimal Sum<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Decimal>> selector);
        Nullable<Decimal> Sum<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Nullable<Decimal>>> selector);
        Double Average(IQueryable<Int32> source);
        Nullable<Double> Average(IQueryable<Nullable<Int32>> source);
        Double Average(IQueryable<Int64> source);
        Nullable<Double> Average(IQueryable<Nullable<Int64>> source);
        Single Average(IQueryable<Single> source);
        Nullable<Single> Average(IQueryable<Nullable<Single>> source);
        Double Average(IQueryable<Double> source);
        Nullable<Double> Average(IQueryable<Nullable<Double>> source);
        Decimal Average(IQueryable<Decimal> source);
        Nullable<Decimal> Average(IQueryable<Nullable<Decimal>> source);
        Double Average<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Int32>> selector);
        Nullable<Double> Average<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Nullable<Int32>>> selector);
        Single Average<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Single>> selector);
        Nullable<Single> Average<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Nullable<Single>>> selector);
        Double Average<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Int64>> selector);
        Nullable<Double> Average<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Nullable<Int64>>> selector);
        Double Average<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Double>> selector);
        Nullable<Double> Average<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Nullable<Double>>> selector);
        Decimal Average<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Decimal>> selector);
        Nullable<Decimal> Average<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Nullable<Decimal>>> selector);
        TSource Aggregate<TSource>(IQueryable<TSource> source, Expression<Func<TSource, TSource, TSource>> func);
        TAccumulate Aggregate<TSource, TAccumulate>(IQueryable<TSource> source, TAccumulate seed, Expression<Func<TAccumulate, TSource, TAccumulate>> func);
        TResult Aggregate<TSource, TAccumulate, TResult>(IQueryable<TSource> source, TAccumulate seed, Expression<Func<TAccumulate, TSource, TAccumulate>> func, Expression<Func<TAccumulate, TResult>> selector);
        IQueryable<TSource> SkipLast<TSource>(IQueryable<TSource> source, Int32 count);
        IQueryable<TSource> TakeLast<TSource>(IQueryable<TSource> source, Int32 count);
        IQueryable<TSource> Append<TSource>(IQueryable<TSource> source, TSource element);
        IQueryable<TSource> Prepend<TSource>(IQueryable<TSource> source, TSource element);
        IQueryable<TElement> AsQueryable<TElement>(IEnumerable<TElement> source);
        IQueryable AsQueryable(IEnumerable source);
        IQueryable<TSource> Where<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Boolean>> predicate);
        IQueryable<TSource> Where<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Int32, Boolean>> predicate);
        IQueryable<TResult> OfType<TResult>(IQueryable source);
        IQueryable<TResult> Cast<TResult>(IQueryable source);
        IQueryable<TResult> Select<TSource, TResult>(IQueryable<TSource> source, Expression<Func<TSource, TResult>> selector);
        IQueryable<TResult> Select<TSource, TResult>(IQueryable<TSource> source, Expression<Func<TSource, Int32, TResult>> selector);
        IQueryable<TResult> SelectMany<TSource, TResult>(IQueryable<TSource> source, Expression<Func<TSource, IEnumerable<TResult>>> selector);
        IQueryable<TResult> SelectMany<TSource, TResult>(IQueryable<TSource> source, Expression<Func<TSource, Int32, IEnumerable<TResult>>> selector);
        IQueryable<TResult> SelectMany<TSource, TCollection, TResult>(IQueryable<TSource> source, Expression<Func<TSource, Int32, IEnumerable<TCollection>>> collectionSelector, Expression<Func<TSource, TCollection, TResult>> resultSelector);
        IQueryable<TResult> SelectMany<TSource, TCollection, TResult>(IQueryable<TSource> source, Expression<Func<TSource, IEnumerable<TCollection>>> collectionSelector, Expression<Func<TSource, TCollection, TResult>> resultSelector);
        IQueryable<TResult> Join<TOuter, TInner, TKey, TResult>(IQueryable<TOuter> outer, IEnumerable<TInner> inner, Expression<Func<TOuter, TKey>> outerKeySelector, Expression<Func<TInner, TKey>> innerKeySelector, Expression<Func<TOuter, TInner, TResult>> resultSelector);
        IQueryable<TResult> Join<TOuter, TInner, TKey, TResult>(IQueryable<TOuter> outer, IEnumerable<TInner> inner, Expression<Func<TOuter, TKey>> outerKeySelector, Expression<Func<TInner, TKey>> innerKeySelector, Expression<Func<TOuter, TInner, TResult>> resultSelector, IEqualityComparer<TKey> comparer);
        IQueryable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(IQueryable<TOuter> outer, IEnumerable<TInner> inner, Expression<Func<TOuter, TKey>> outerKeySelector, Expression<Func<TInner, TKey>> innerKeySelector, Expression<Func<TOuter, IEnumerable<TInner>, TResult>> resultSelector);
        IQueryable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(IQueryable<TOuter> outer, IEnumerable<TInner> inner, Expression<Func<TOuter, TKey>> outerKeySelector, Expression<Func<TInner, TKey>> innerKeySelector, Expression<Func<TOuter, IEnumerable<TInner>, TResult>> resultSelector, IEqualityComparer<TKey> comparer);
        IOrderedQueryable<TSource> OrderBy<TSource, TKey>(IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector);
        IOrderedQueryable<TSource> OrderBy<TSource, TKey>(IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, IComparer<TKey> comparer);
        IOrderedQueryable<TSource> OrderByDescending<TSource, TKey>(IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector);
        IOrderedQueryable<TSource> OrderByDescending<TSource, TKey>(IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, IComparer<TKey> comparer);
        IOrderedQueryable<TSource> ThenBy<TSource, TKey>(IOrderedQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector);
        IOrderedQueryable<TSource> ThenBy<TSource, TKey>(IOrderedQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, IComparer<TKey> comparer);
        IOrderedQueryable<TSource> ThenByDescending<TSource, TKey>(IOrderedQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector);
        IOrderedQueryable<TSource> ThenByDescending<TSource, TKey>(IOrderedQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, IComparer<TKey> comparer);
        IQueryable<TSource> Take<TSource>(IQueryable<TSource> source, Int32 count);
        IQueryable<TSource> TakeWhile<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Boolean>> predicate);
        IQueryable<TSource> TakeWhile<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Int32, Boolean>> predicate);
        IQueryable<TSource> Skip<TSource>(IQueryable<TSource> source, Int32 count);
        IQueryable<TSource> SkipWhile<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Boolean>> predicate);
        IQueryable<TSource> SkipWhile<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Int32, Boolean>> predicate);
        IQueryable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector);
        IQueryable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, Expression<Func<TSource, TElement>> elementSelector);
        IQueryable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, IEqualityComparer<TKey> comparer);
        IQueryable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, Expression<Func<TSource, TElement>> elementSelector, IEqualityComparer<TKey> comparer);
        IQueryable<TResult> GroupBy<TSource, TKey, TElement, TResult>(IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, Expression<Func<TSource, TElement>> elementSelector, Expression<Func<TKey, IEnumerable<TElement>, TResult>> resultSelector);
        IQueryable<TResult> GroupBy<TSource, TKey, TResult>(IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, Expression<Func<TKey, IEnumerable<TSource>, TResult>> resultSelector);
        IQueryable<TResult> GroupBy<TSource, TKey, TResult>(IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, Expression<Func<TKey, IEnumerable<TSource>, TResult>> resultSelector, IEqualityComparer<TKey> comparer);
        IQueryable<TResult> GroupBy<TSource, TKey, TElement, TResult>(IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, Expression<Func<TSource, TElement>> elementSelector, Expression<Func<TKey, IEnumerable<TElement>, TResult>> resultSelector, IEqualityComparer<TKey> comparer);
        IQueryable<TSource> Distinct<TSource>(IQueryable<TSource> source);
        IQueryable<TSource> Distinct<TSource>(IQueryable<TSource> source, IEqualityComparer<TSource> comparer);
        IQueryable<TSource> Concat<TSource>(IQueryable<TSource> source1, IEnumerable<TSource> source2);
        IQueryable<TResult> Zip<TFirst, TSecond, TResult>(IQueryable<TFirst> source1, IEnumerable<TSecond> source2, Expression<Func<TFirst, TSecond, TResult>> resultSelector);
        IQueryable<TSource> Union<TSource>(IQueryable<TSource> source1, IEnumerable<TSource> source2);
        IQueryable<TSource> Union<TSource>(IQueryable<TSource> source1, IEnumerable<TSource> source2, IEqualityComparer<TSource> comparer);
        IQueryable<TSource> Intersect<TSource>(IQueryable<TSource> source1, IEnumerable<TSource> source2);
        IQueryable<TSource> Intersect<TSource>(IQueryable<TSource> source1, IEnumerable<TSource> source2, IEqualityComparer<TSource> comparer);
        IQueryable<TSource> Except<TSource>(IQueryable<TSource> source1, IEnumerable<TSource> source2);
        IQueryable<TSource> Except<TSource>(IQueryable<TSource> source1, IEnumerable<TSource> source2, IEqualityComparer<TSource> comparer);
        TSource First<TSource>(IQueryable<TSource> source);
        TSource First<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Boolean>> predicate);
        TSource FirstOrDefault<TSource>(IQueryable<TSource> source);
        TSource FirstOrDefault<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Boolean>> predicate);
        TSource Last<TSource>(IQueryable<TSource> source);
        TSource Last<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Boolean>> predicate);
        TSource LastOrDefault<TSource>(IQueryable<TSource> source);
        TSource LastOrDefault<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Boolean>> predicate);
        TSource Single<TSource>(IQueryable<TSource> source);
        TSource Single<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Boolean>> predicate);
        TSource SingleOrDefault<TSource>(IQueryable<TSource> source);
        TSource SingleOrDefault<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Boolean>> predicate);
        TSource ElementAt<TSource>(IQueryable<TSource> source, Int32 index);
        TSource ElementAtOrDefault<TSource>(IQueryable<TSource> source, Int32 index);
        IQueryable<TSource> DefaultIfEmpty<TSource>(IQueryable<TSource> source);
    }

    public class QueryableProvider : IQueryableProvider
    {
        public virtual IQueryable<TSource> DefaultIfEmpty<TSource>(IQueryable<TSource> source, TSource defaultValue)
        {
            return Queryable.DefaultIfEmpty<TSource>(source, defaultValue);
        }

        public virtual Boolean Contains<TSource>(IQueryable<TSource> source, TSource item)
        {
            return Queryable.Contains<TSource>(source, item);
        }

        public virtual Boolean Contains<TSource>(IQueryable<TSource> source, TSource item, IEqualityComparer<TSource> comparer)
        {
            return Queryable.Contains<TSource>(source, item, comparer);
        }

        public virtual IQueryable<TSource> Reverse<TSource>(IQueryable<TSource> source)
        {
            return Queryable.Reverse<TSource>(source);
        }

        public virtual Boolean SequenceEqual<TSource>(IQueryable<TSource> source1, IEnumerable<TSource> source2)
        {
            return Queryable.SequenceEqual<TSource>(source1, source2);
        }

        public virtual Boolean SequenceEqual<TSource>(IQueryable<TSource> source1, IEnumerable<TSource> source2, IEqualityComparer<TSource> comparer)
        {
            return Queryable.SequenceEqual<TSource>(source1, source2, comparer);
        }

        public virtual Boolean Any<TSource>(IQueryable<TSource> source)
        {
            return Queryable.Any<TSource>(source);
        }

        public virtual Boolean Any<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Boolean>> predicate)
        {
            return Queryable.Any<TSource>(source, predicate);
        }

        public virtual Boolean All<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Boolean>> predicate)
        {
            return Queryable.All<TSource>(source, predicate);
        }

        public virtual Int32 Count<TSource>(IQueryable<TSource> source)
        {
            return Queryable.Count<TSource>(source);
        }

        public virtual Int32 Count<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Boolean>> predicate)
        {
            return Queryable.Count<TSource>(source, predicate);
        }

        public virtual Int64 LongCount<TSource>(IQueryable<TSource> source)
        {
            return Queryable.LongCount<TSource>(source);
        }

        public virtual Int64 LongCount<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Boolean>> predicate)
        {
            return Queryable.LongCount<TSource>(source, predicate);
        }

        public virtual TSource Min<TSource>(IQueryable<TSource> source)
        {
            return Queryable.Min<TSource>(source);
        }

        public virtual TResult Min<TSource, TResult>(IQueryable<TSource> source, Expression<Func<TSource, TResult>> selector)
        {
            return Queryable.Min<TSource, TResult>(source, selector);
        }

        public virtual TSource Max<TSource>(IQueryable<TSource> source)
        {
            return Queryable.Max<TSource>(source);
        }

        public virtual TResult Max<TSource, TResult>(IQueryable<TSource> source, Expression<Func<TSource, TResult>> selector)
        {
            return Queryable.Max<TSource, TResult>(source, selector);
        }

        public virtual Int32 Sum(IQueryable<Int32> source)
        {
            return Queryable.Sum(source);
        }

        public virtual Nullable<Int32> Sum(IQueryable<Nullable<Int32>> source)
        {
            return Queryable.Sum(source);
        }

        public virtual Int64 Sum(IQueryable<Int64> source)
        {
            return Queryable.Sum(source);
        }

        public virtual Nullable<Int64> Sum(IQueryable<Nullable<Int64>> source)
        {
            return Queryable.Sum(source);
        }

        public virtual Single Sum(IQueryable<Single> source)
        {
            return Queryable.Sum(source);
        }

        public virtual Nullable<Single> Sum(IQueryable<Nullable<Single>> source)
        {
            return Queryable.Sum(source);
        }

        public virtual Double Sum(IQueryable<Double> source)
        {
            return Queryable.Sum(source);
        }

        public virtual Nullable<Double> Sum(IQueryable<Nullable<Double>> source)
        {
            return Queryable.Sum(source);
        }

        public virtual Decimal Sum(IQueryable<Decimal> source)
        {
            return Queryable.Sum(source);
        }

        public virtual Nullable<Decimal> Sum(IQueryable<Nullable<Decimal>> source)
        {
            return Queryable.Sum(source);
        }

        public virtual Int32 Sum<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Int32>> selector)
        {
            return Queryable.Sum<TSource>(source, selector);
        }

        public virtual Nullable<Int32> Sum<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Nullable<Int32>>> selector)
        {
            return Queryable.Sum<TSource>(source, selector);
        }

        public virtual Int64 Sum<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Int64>> selector)
        {
            return Queryable.Sum<TSource>(source, selector);
        }

        public virtual Nullable<Int64> Sum<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Nullable<Int64>>> selector)
        {
            return Queryable.Sum<TSource>(source, selector);
        }

        public virtual Single Sum<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Single>> selector)
        {
            return Queryable.Sum<TSource>(source, selector);
        }

        public virtual Nullable<Single> Sum<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Nullable<Single>>> selector)
        {
            return Queryable.Sum<TSource>(source, selector);
        }

        public virtual Double Sum<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Double>> selector)
        {
            return Queryable.Sum<TSource>(source, selector);
        }

        public virtual Nullable<Double> Sum<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Nullable<Double>>> selector)
        {
            return Queryable.Sum<TSource>(source, selector);
        }

        public virtual Decimal Sum<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Decimal>> selector)
        {
            return Queryable.Sum<TSource>(source, selector);
        }

        public virtual Nullable<Decimal> Sum<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Nullable<Decimal>>> selector)
        {
            return Queryable.Sum<TSource>(source, selector);
        }

        public virtual Double Average(IQueryable<Int32> source)
        {
            return Queryable.Average(source);
        }

        public virtual Nullable<Double> Average(IQueryable<Nullable<Int32>> source)
        {
            return Queryable.Average(source);
        }

        public virtual Double Average(IQueryable<Int64> source)
        {
            return Queryable.Average(source);
        }

        public virtual Nullable<Double> Average(IQueryable<Nullable<Int64>> source)
        {
            return Queryable.Average(source);
        }

        public virtual Single Average(IQueryable<Single> source)
        {
            return Queryable.Average(source);
        }

        public virtual Nullable<Single> Average(IQueryable<Nullable<Single>> source)
        {
            return Queryable.Average(source);
        }

        public virtual Double Average(IQueryable<Double> source)
        {
            return Queryable.Average(source);
        }

        public virtual Nullable<Double> Average(IQueryable<Nullable<Double>> source)
        {
            return Queryable.Average(source);
        }

        public virtual Decimal Average(IQueryable<Decimal> source)
        {
            return Queryable.Average(source);
        }

        public virtual Nullable<Decimal> Average(IQueryable<Nullable<Decimal>> source)
        {
            return Queryable.Average(source);
        }

        public virtual Double Average<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Int32>> selector)
        {
            return Queryable.Average<TSource>(source, selector);
        }

        public virtual Nullable<Double> Average<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Nullable<Int32>>> selector)
        {
            return Queryable.Average<TSource>(source, selector);
        }

        public virtual Single Average<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Single>> selector)
        {
            return Queryable.Average<TSource>(source, selector);
        }

        public virtual Nullable<Single> Average<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Nullable<Single>>> selector)
        {
            return Queryable.Average<TSource>(source, selector);
        }

        public virtual Double Average<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Int64>> selector)
        {
            return Queryable.Average<TSource>(source, selector);
        }

        public virtual Nullable<Double> Average<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Nullable<Int64>>> selector)
        {
            return Queryable.Average<TSource>(source, selector);
        }

        public virtual Double Average<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Double>> selector)
        {
            return Queryable.Average<TSource>(source, selector);
        }

        public virtual Nullable<Double> Average<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Nullable<Double>>> selector)
        {
            return Queryable.Average<TSource>(source, selector);
        }

        public virtual Decimal Average<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Decimal>> selector)
        {
            return Queryable.Average<TSource>(source, selector);
        }

        public virtual Nullable<Decimal> Average<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Nullable<Decimal>>> selector)
        {
            return Queryable.Average<TSource>(source, selector);
        }

        public virtual TSource Aggregate<TSource>(IQueryable<TSource> source, Expression<Func<TSource, TSource, TSource>> func)
        {
            return Queryable.Aggregate<TSource>(source, func);
        }

        public virtual TAccumulate Aggregate<TSource, TAccumulate>(IQueryable<TSource> source, TAccumulate seed, Expression<Func<TAccumulate, TSource, TAccumulate>> func)
        {
            return Queryable.Aggregate<TSource, TAccumulate>(source, seed, func);
        }

        public virtual TResult Aggregate<TSource, TAccumulate, TResult>(IQueryable<TSource> source, TAccumulate seed, Expression<Func<TAccumulate, TSource, TAccumulate>> func, Expression<Func<TAccumulate, TResult>> selector)
        {
            return Queryable.Aggregate<TSource, TAccumulate, TResult>(source, seed, func, selector);
        }

        public virtual IQueryable<TSource> SkipLast<TSource>(IQueryable<TSource> source, Int32 count)
        {
            return Queryable.SkipLast<TSource>(source, count);
        }

        public virtual IQueryable<TSource> TakeLast<TSource>(IQueryable<TSource> source, Int32 count)
        {
            return Queryable.TakeLast<TSource>(source, count);
        }

        public virtual IQueryable<TSource> Append<TSource>(IQueryable<TSource> source, TSource element)
        {
            return Queryable.Append<TSource>(source, element);
        }

        public virtual IQueryable<TSource> Prepend<TSource>(IQueryable<TSource> source, TSource element)
        {
            return Queryable.Prepend<TSource>(source, element);
        }

        public virtual IQueryable<TElement> AsQueryable<TElement>(IEnumerable<TElement> source)
        {
            return Queryable.AsQueryable<TElement>(source);
        }

        public virtual IQueryable AsQueryable(IEnumerable source)
        {
            return Queryable.AsQueryable(source);
        }

        public virtual IQueryable<TSource> Where<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Boolean>> predicate)
        {
            return Queryable.Where<TSource>(source, predicate);
        }

        public virtual IQueryable<TSource> Where<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Int32, Boolean>> predicate)
        {
            return Queryable.Where<TSource>(source, predicate);
        }

        public virtual IQueryable<TResult> OfType<TResult>(IQueryable source)
        {
            return Queryable.OfType<TResult>(source);
        }

        public virtual IQueryable<TResult> Cast<TResult>(IQueryable source)
        {
            return Queryable.Cast<TResult>(source);
        }

        public virtual IQueryable<TResult> Select<TSource, TResult>(IQueryable<TSource> source, Expression<Func<TSource, TResult>> selector)
        {
            return Queryable.Select<TSource, TResult>(source, selector);
        }

        public virtual IQueryable<TResult> Select<TSource, TResult>(IQueryable<TSource> source, Expression<Func<TSource, Int32, TResult>> selector)
        {
            return Queryable.Select<TSource, TResult>(source, selector);
        }

        public virtual IQueryable<TResult> SelectMany<TSource, TResult>(IQueryable<TSource> source, Expression<Func<TSource, IEnumerable<TResult>>> selector)
        {
            return Queryable.SelectMany<TSource, TResult>(source, selector);
        }

        public virtual IQueryable<TResult> SelectMany<TSource, TResult>(IQueryable<TSource> source, Expression<Func<TSource, Int32, IEnumerable<TResult>>> selector)
        {
            return Queryable.SelectMany<TSource, TResult>(source, selector);
        }

        public virtual IQueryable<TResult> SelectMany<TSource, TCollection, TResult>(IQueryable<TSource> source, Expression<Func<TSource, Int32, IEnumerable<TCollection>>> collectionSelector, Expression<Func<TSource, TCollection, TResult>> resultSelector)
        {
            return Queryable.SelectMany<TSource, TCollection, TResult>(source, collectionSelector, resultSelector);
        }

        public virtual IQueryable<TResult> SelectMany<TSource, TCollection, TResult>(IQueryable<TSource> source, Expression<Func<TSource, IEnumerable<TCollection>>> collectionSelector, Expression<Func<TSource, TCollection, TResult>> resultSelector)
        {
            return Queryable.SelectMany<TSource, TCollection, TResult>(source, collectionSelector, resultSelector);
        }

        public virtual IQueryable<TResult> Join<TOuter, TInner, TKey, TResult>(IQueryable<TOuter> outer, IEnumerable<TInner> inner, Expression<Func<TOuter, TKey>> outerKeySelector, Expression<Func<TInner, TKey>> innerKeySelector, Expression<Func<TOuter, TInner, TResult>> resultSelector)
        {
            return Queryable.Join<TOuter, TInner, TKey, TResult>(outer, inner, outerKeySelector, innerKeySelector, resultSelector);
        }

        public virtual IQueryable<TResult> Join<TOuter, TInner, TKey, TResult>(IQueryable<TOuter> outer, IEnumerable<TInner> inner, Expression<Func<TOuter, TKey>> outerKeySelector, Expression<Func<TInner, TKey>> innerKeySelector, Expression<Func<TOuter, TInner, TResult>> resultSelector, IEqualityComparer<TKey> comparer)
        {
            return Queryable.Join<TOuter, TInner, TKey, TResult>(outer, inner, outerKeySelector, innerKeySelector, resultSelector, comparer);
        }

        public virtual IQueryable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(IQueryable<TOuter> outer, IEnumerable<TInner> inner, Expression<Func<TOuter, TKey>> outerKeySelector, Expression<Func<TInner, TKey>> innerKeySelector, Expression<Func<TOuter, IEnumerable<TInner>, TResult>> resultSelector)
        {
            return Queryable.GroupJoin<TOuter, TInner, TKey, TResult>(outer, inner, outerKeySelector, innerKeySelector, resultSelector);
        }

        public virtual IQueryable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(IQueryable<TOuter> outer, IEnumerable<TInner> inner, Expression<Func<TOuter, TKey>> outerKeySelector, Expression<Func<TInner, TKey>> innerKeySelector, Expression<Func<TOuter, IEnumerable<TInner>, TResult>> resultSelector, IEqualityComparer<TKey> comparer)
        {
            return Queryable.GroupJoin<TOuter, TInner, TKey, TResult>(outer, inner, outerKeySelector, innerKeySelector, resultSelector, comparer);
        }

        public virtual IOrderedQueryable<TSource> OrderBy<TSource, TKey>(IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector)
        {
            return Queryable.OrderBy<TSource, TKey>(source, keySelector);
        }

        public virtual IOrderedQueryable<TSource> OrderBy<TSource, TKey>(IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, IComparer<TKey> comparer)
        {
            return Queryable.OrderBy<TSource, TKey>(source, keySelector, comparer);
        }

        public virtual IOrderedQueryable<TSource> OrderByDescending<TSource, TKey>(IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector)
        {
            return Queryable.OrderByDescending<TSource, TKey>(source, keySelector);
        }

        public virtual IOrderedQueryable<TSource> OrderByDescending<TSource, TKey>(IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, IComparer<TKey> comparer)
        {
            return Queryable.OrderByDescending<TSource, TKey>(source, keySelector, comparer);
        }

        public virtual IOrderedQueryable<TSource> ThenBy<TSource, TKey>(IOrderedQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector)
        {
            return Queryable.ThenBy<TSource, TKey>(source, keySelector);
        }

        public virtual IOrderedQueryable<TSource> ThenBy<TSource, TKey>(IOrderedQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, IComparer<TKey> comparer)
        {
            return Queryable.ThenBy<TSource, TKey>(source, keySelector, comparer);
        }

        public virtual IOrderedQueryable<TSource> ThenByDescending<TSource, TKey>(IOrderedQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector)
        {
            return Queryable.ThenByDescending<TSource, TKey>(source, keySelector);
        }

        public virtual IOrderedQueryable<TSource> ThenByDescending<TSource, TKey>(IOrderedQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, IComparer<TKey> comparer)
        {
            return Queryable.ThenByDescending<TSource, TKey>(source, keySelector, comparer);
        }

        public virtual IQueryable<TSource> Take<TSource>(IQueryable<TSource> source, Int32 count)
        {
            return Queryable.Take<TSource>(source, count);
        }

        public virtual IQueryable<TSource> TakeWhile<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Boolean>> predicate)
        {
            return Queryable.TakeWhile<TSource>(source, predicate);
        }

        public virtual IQueryable<TSource> TakeWhile<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Int32, Boolean>> predicate)
        {
            return Queryable.TakeWhile<TSource>(source, predicate);
        }

        public virtual IQueryable<TSource> Skip<TSource>(IQueryable<TSource> source, Int32 count)
        {
            return Queryable.Skip<TSource>(source, count);
        }

        public virtual IQueryable<TSource> SkipWhile<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Boolean>> predicate)
        {
            return Queryable.SkipWhile<TSource>(source, predicate);
        }

        public virtual IQueryable<TSource> SkipWhile<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Int32, Boolean>> predicate)
        {
            return Queryable.SkipWhile<TSource>(source, predicate);
        }

        public virtual IQueryable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector)
        {
            return Queryable.GroupBy<TSource, TKey>(source, keySelector);
        }

        public virtual IQueryable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, Expression<Func<TSource, TElement>> elementSelector)
        {
            return Queryable.GroupBy<TSource, TKey, TElement>(source, keySelector, elementSelector);
        }

        public virtual IQueryable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, IEqualityComparer<TKey> comparer)
        {
            return Queryable.GroupBy<TSource, TKey>(source, keySelector, comparer);
        }

        public virtual IQueryable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, Expression<Func<TSource, TElement>> elementSelector, IEqualityComparer<TKey> comparer)
        {
            return Queryable.GroupBy<TSource, TKey, TElement>(source, keySelector, elementSelector, comparer);
        }

        public virtual IQueryable<TResult> GroupBy<TSource, TKey, TElement, TResult>(IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, Expression<Func<TSource, TElement>> elementSelector, Expression<Func<TKey, IEnumerable<TElement>, TResult>> resultSelector)
        {
            return Queryable.GroupBy<TSource, TKey, TElement, TResult>(source, keySelector, elementSelector, resultSelector);
        }

        public virtual IQueryable<TResult> GroupBy<TSource, TKey, TResult>(IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, Expression<Func<TKey, IEnumerable<TSource>, TResult>> resultSelector)
        {
            return Queryable.GroupBy<TSource, TKey, TResult>(source, keySelector, resultSelector);
        }

        public virtual IQueryable<TResult> GroupBy<TSource, TKey, TResult>(IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, Expression<Func<TKey, IEnumerable<TSource>, TResult>> resultSelector, IEqualityComparer<TKey> comparer)
        {
            return Queryable.GroupBy<TSource, TKey, TResult>(source, keySelector, resultSelector, comparer);
        }

        public virtual IQueryable<TResult> GroupBy<TSource, TKey, TElement, TResult>(IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, Expression<Func<TSource, TElement>> elementSelector, Expression<Func<TKey, IEnumerable<TElement>, TResult>> resultSelector, IEqualityComparer<TKey> comparer)
        {
            return Queryable.GroupBy<TSource, TKey, TElement, TResult>(source, keySelector, elementSelector, resultSelector, comparer);
        }

        public virtual IQueryable<TSource> Distinct<TSource>(IQueryable<TSource> source)
        {
            return Queryable.Distinct<TSource>(source);
        }

        public virtual IQueryable<TSource> Distinct<TSource>(IQueryable<TSource> source, IEqualityComparer<TSource> comparer)
        {
            return Queryable.Distinct<TSource>(source, comparer);
        }

        public virtual IQueryable<TSource> Concat<TSource>(IQueryable<TSource> source1, IEnumerable<TSource> source2)
        {
            return Queryable.Concat<TSource>(source1, source2);
        }

        public virtual IQueryable<TResult> Zip<TFirst, TSecond, TResult>(IQueryable<TFirst> source1, IEnumerable<TSecond> source2, Expression<Func<TFirst, TSecond, TResult>> resultSelector)
        {
            return Queryable.Zip<TFirst, TSecond, TResult>(source1, source2, resultSelector);
        }

        public virtual IQueryable<TSource> Union<TSource>(IQueryable<TSource> source1, IEnumerable<TSource> source2)
        {
            return Queryable.Union<TSource>(source1, source2);
        }

        public virtual IQueryable<TSource> Union<TSource>(IQueryable<TSource> source1, IEnumerable<TSource> source2, IEqualityComparer<TSource> comparer)
        {
            return Queryable.Union<TSource>(source1, source2, comparer);
        }

        public virtual IQueryable<TSource> Intersect<TSource>(IQueryable<TSource> source1, IEnumerable<TSource> source2)
        {
            return Queryable.Intersect<TSource>(source1, source2);
        }

        public virtual IQueryable<TSource> Intersect<TSource>(IQueryable<TSource> source1, IEnumerable<TSource> source2, IEqualityComparer<TSource> comparer)
        {
            return Queryable.Intersect<TSource>(source1, source2, comparer);
        }

        public virtual IQueryable<TSource> Except<TSource>(IQueryable<TSource> source1, IEnumerable<TSource> source2)
        {
            return Queryable.Except<TSource>(source1, source2);
        }

        public virtual IQueryable<TSource> Except<TSource>(IQueryable<TSource> source1, IEnumerable<TSource> source2, IEqualityComparer<TSource> comparer)
        {
            return Queryable.Except<TSource>(source1, source2, comparer);
        }

        public virtual TSource First<TSource>(IQueryable<TSource> source)
        {
            return Queryable.First<TSource>(source);
        }

        public virtual TSource First<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Boolean>> predicate)
        {
            return Queryable.First<TSource>(source, predicate);
        }

        public virtual TSource FirstOrDefault<TSource>(IQueryable<TSource> source)
        {
            return Queryable.FirstOrDefault<TSource>(source);
        }

        public virtual TSource FirstOrDefault<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Boolean>> predicate)
        {
            return Queryable.FirstOrDefault<TSource>(source, predicate);
        }

        public virtual TSource Last<TSource>(IQueryable<TSource> source)
        {
            return Queryable.Last<TSource>(source);
        }

        public virtual TSource Last<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Boolean>> predicate)
        {
            return Queryable.Last<TSource>(source, predicate);
        }

        public virtual TSource LastOrDefault<TSource>(IQueryable<TSource> source)
        {
            return Queryable.LastOrDefault<TSource>(source);
        }

        public virtual TSource LastOrDefault<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Boolean>> predicate)
        {
            return Queryable.LastOrDefault<TSource>(source, predicate);
        }

        public virtual TSource Single<TSource>(IQueryable<TSource> source)
        {
            return Queryable.Single<TSource>(source);
        }

        public virtual TSource Single<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Boolean>> predicate)
        {
            return Queryable.Single<TSource>(source, predicate);
        }

        public virtual TSource SingleOrDefault<TSource>(IQueryable<TSource> source)
        {
            return Queryable.SingleOrDefault<TSource>(source);
        }

        public virtual TSource SingleOrDefault<TSource>(IQueryable<TSource> source, Expression<Func<TSource, Boolean>> predicate)
        {
            return Queryable.SingleOrDefault<TSource>(source, predicate);
        }

        public virtual TSource ElementAt<TSource>(IQueryable<TSource> source, Int32 index)
        {
            return Queryable.ElementAt<TSource>(source, index);
        }

        public virtual TSource ElementAtOrDefault<TSource>(IQueryable<TSource> source, Int32 index)
        {
            return Queryable.ElementAtOrDefault<TSource>(source, index);
        }

        public virtual IQueryable<TSource> DefaultIfEmpty<TSource>(IQueryable<TSource> source)
        {
            return Queryable.DefaultIfEmpty<TSource>(source);
        }
    }
}