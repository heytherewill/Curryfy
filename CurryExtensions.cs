using System;

namespace Curryfy
{
	public static class CurryExtensions
    {
		public static Func<A, Func<B, Func<C, Func<D, Func<E, Func<F, Func<G, Func<H, Func<I, Func<J, Func<K, Func<L, Func<M, Func<N, Func<O, Func<P, Q>>>>>>>>>>>>>>>> Curry<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q>(this Func<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q> self)
		{
			return a => b => c => d => e => f => g => h => i => j => k => l => m => n => o => p => self(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
		}

		public static Func<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q> Uncurry<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q>(this Func<A, Func<B, Func<C, Func<D, Func<E, Func<F, Func<G, Func<H, Func<I, Func<J, Func<K, Func<L, Func<M, Func<N, Func<O, Func<P, Q>>>>>>>>>>>>>>>> self)
		{
			return (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => self(a)(b)(c)(d)(e)(f)(g)(h)(i)(j)(k)(l)(m)(n)(o)(p);
		}

		public static Func<A, Func<B, Func<C, Func<D, Func<E, Func<F, Func<G, Func<H, Func<I, Func<J, Func<K, Func<L, Func<M, Func<N, Func<O, P>>>>>>>>>>>>>>> Curry<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P>(this Func<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P> self)
		{
			return a => b => c => d => e => f => g => h => i => j => k => l => m => n => o => self(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
		}

		public static Func<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P> Uncurry<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P>(this Func<A, Func<B, Func<C, Func<D, Func<E, Func<F, Func<G, Func<H, Func<I, Func<J, Func<K, Func<L, Func<M, Func<N, Func<O, P>>>>>>>>>>>>>>> self)
		{
			return (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => self(a)(b)(c)(d)(e)(f)(g)(h)(i)(j)(k)(l)(m)(n)(o);
		}

		public static Func<A, Func<B, Func<C, Func<D, Func<E, Func<F, Func<G, Func<H, Func<I, Func<J, Func<K, Func<L, Func<M, Func<N, O>>>>>>>>>>>>>> Curry<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O>(this Func<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> self)
		{
			return a => b => c => d => e => f => g => h => i => j => k => l => m => n => self(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
		}

		public static Func<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> Uncurry<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O>(this Func<A, Func<B, Func<C, Func<D, Func<E, Func<F, Func<G, Func<H, Func<I, Func<J, Func<K, Func<L, Func<M, Func<N, O>>>>>>>>>>>>>> self)
		{
			return (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => self(a)(b)(c)(d)(e)(f)(g)(h)(i)(j)(k)(l)(m)(n);
		}

		public static Func<A, Func<B, Func<C, Func<D, Func<E, Func<F, Func<G, Func<H, Func<I, Func<J, Func<K, Func<L, Func<M, N>>>>>>>>>>>>> Curry<A, B, C, D, E, F, G, H, I, J, K, L, M, N>(this Func<A, B, C, D, E, F, G, H, I, J, K, L, M, N> self)
		{
			return a => b => c => d => e => f => g => h => i => j => k => l => m => self(a, b, c, d, e, f, g, h, i, j, k, l, m);
		}

		public static Func<A, B, C, D, E, F, G, H, I, J, K, L, M, N> Uncurry<A, B, C, D, E, F, G, H, I, J, K, L, M, N>(this Func<A, Func<B, Func<C, Func<D, Func<E, Func<F, Func<G, Func<H, Func<I, Func<J, Func<K, Func<L, Func<M, N>>>>>>>>>>>>> self)
		{
			return (a, b, c, d, e, f, g, h, i, j, k, l, m) => self(a)(b)(c)(d)(e)(f)(g)(h)(i)(j)(k)(l)(m);
		}

		public static Func<A, Func<B, Func<C, Func<D, Func<E, Func<F, Func<G, Func<H, Func<I, Func<J, Func<K, Func<L, M>>>>>>>>>>>> Curry<A, B, C, D, E, F, G, H, I, J, K, L, M>(this Func<A, B, C, D, E, F, G, H, I, J, K, L, M> self)
		{
			return a => b => c => d => e => f => g => h => i => j => k => l => self(a, b, c, d, e, f, g, h, i, j, k, l);
		}

		public static Func<A, B, C, D, E, F, G, H, I, J, K, L, M> Uncurry<A, B, C, D, E, F, G, H, I, J, K, L, M>(this Func<A, Func<B, Func<C, Func<D, Func<E, Func<F, Func<G, Func<H, Func<I, Func<J, Func<K, Func<L, M>>>>>>>>>>>> self)
		{
			return (a, b, c, d, e, f, g, h, i, j, k, l) => self(a)(b)(c)(d)(e)(f)(g)(h)(i)(j)(k)(l);
		}

		public static Func<A, Func<B, Func<C, Func<D, Func<E, Func<F, Func<G, Func<H, Func<I, Func<J, Func<K, L>>>>>>>>>>> Curry<A, B, C, D, E, F, G, H, I, J, K, L>(this Func<A, B, C, D, E, F, G, H, I, J, K, L> self)
		{
			return a => b => c => d => e => f => g => h => i => j => k => self(a, b, c, d, e, f, g, h, i, j, k);
		}

		public static Func<A, B, C, D, E, F, G, H, I, J, K, L> Uncurry<A, B, C, D, E, F, G, H, I, J, K, L>(this Func<A, Func<B, Func<C, Func<D, Func<E, Func<F, Func<G, Func<H, Func<I, Func<J, Func<K, L>>>>>>>>>>> self)
		{
			return (a, b, c, d, e, f, g, h, i, j, k) => self(a)(b)(c)(d)(e)(f)(g)(h)(i)(j)(k);
		}

		public static Func<A, Func<B, Func<C, Func<D, Func<E, Func<F, Func<G, Func<H, Func<I, Func<J, K>>>>>>>>>> Curry<A, B, C, D, E, F, G, H, I, J, K>(this Func<A, B, C, D, E, F, G, H, I, J, K> self)
		{
			return a => b => c => d => e => f => g => h => i => j => self(a, b, c, d, e, f, g, h, i, j);
		}

		public static Func<A, B, C, D, E, F, G, H, I, J, K> Uncurry<A, B, C, D, E, F, G, H, I, J, K>(this Func<A, Func<B, Func<C, Func<D, Func<E, Func<F, Func<G, Func<H, Func<I, Func<J, K>>>>>>>>>> self)
		{
			return (a, b, c, d, e, f, g, h, i, j) => self(a)(b)(c)(d)(e)(f)(g)(h)(i)(j);
		}

		public static Func<A, Func<B, Func<C, Func<D, Func<E, Func<F, Func<G, Func<H, Func<I, J>>>>>>>>> Curry<A, B, C, D, E, F, G, H, I, J>(this Func<A, B, C, D, E, F, G, H, I, J> self)
		{
			return a => b => c => d => e => f => g => h => i => self(a, b, c, d, e, f, g, h, i);
		}

		public static Func<A, B, C, D, E, F, G, H, I, J> Uncurry<A, B, C, D, E, F, G, H, I, J>(this Func<A, Func<B, Func<C, Func<D, Func<E, Func<F, Func<G, Func<H, Func<I, J>>>>>>>>> self)
		{
			return (a, b, c, d, e, f, g, h, i) => self(a)(b)(c)(d)(e)(f)(g)(h)(i);
		}

		public static Func<A, Func<B, Func<C, Func<D, Func<E, Func<F, Func<G, Func<H, I>>>>>>>> Curry<A, B, C, D, E, F, G, H, I>(this Func<A, B, C, D, E, F, G, H, I> self)
		{
			return a => b => c => d => e => f => g => h => self(a, b, c, d, e, f, g, h);
		}

		public static Func<A, B, C, D, E, F, G, H, I> Uncurry<A, B, C, D, E, F, G, H, I>(this Func<A, Func<B, Func<C, Func<D, Func<E, Func<F, Func<G, Func<H, I>>>>>>>> self)
		{
			return (a, b, c, d, e, f, g, h) => self(a)(b)(c)(d)(e)(f)(g)(h);
		}

		public static Func<A, Func<B, Func<C, Func<D, Func<E, Func<F, Func<G, H>>>>>>> Curry<A, B, C, D, E, F, G, H>(this Func<A, B, C, D, E, F, G, H> self)
		{
			return a => b => c => d => e => f => g => self(a, b, c, d, e, f, g);
		}

		public static Func<A, B, C, D, E, F, G, H> Uncurry<A, B, C, D, E, F, G, H>(this Func<A, Func<B, Func<C, Func<D, Func<E, Func<F, Func<G, H>>>>>>> self)
		{
			return (a, b, c, d, e, f, g) => self(a)(b)(c)(d)(e)(f)(g);
		}

		public static Func<A, Func<B, Func<C, Func<D, Func<E, Func<F, G>>>>>> Curry<A, B, C, D, E, F, G>(this Func<A, B, C, D, E, F, G> self)
		{
			return a => b => c => d => e => f => self(a, b, c, d, e, f);
		}

		public static Func<A, B, C, D, E, F, G> Uncurry<A, B, C, D, E, F, G>(this Func<A, Func<B, Func<C, Func<D, Func<E, Func<F, G>>>>>> self)
		{
			return (a, b, c, d, e, f) => self(a)(b)(c)(d)(e)(f);
		}

		public static Func<A, Func<B, Func<C, Func<D, Func<E, F>>>>> Curry<A, B, C, D, E, F>(this Func<A, B, C, D, E, F> self)
		{
			return a => b => c => d => e => self(a, b, c, d, e);
		}

		public static Func<A, B, C, D, E, F> Uncurry<A, B, C, D, E, F>(this Func<A, Func<B, Func<C, Func<D, Func<E, F>>>>> self)
		{
			return (a, b, c, d, e) => self(a)(b)(c)(d)(e);
		}

		public static Func<A, Func<B, Func<C, Func<D, E>>>> Curry<A, B, C, D, E>(this Func<A, B, C, D, E> self)
		{
			return a => b => c => d => self(a, b, c, d);
		}

		public static Func<A, B, C, D, E> Uncurry<A, B, C, D, E>(this Func<A, Func<B, Func<C, Func<D, E>>>> self)
		{
			return (a, b, c, d) => self(a)(b)(c)(d);
		}

		public static Func<A, Func<B, Func<C, D>>> Curry<A, B, C, D>(this Func<A, B, C, D> self)
		{
			return a => b => c => self(a, b, c);
		}

		public static Func<A, B, C, D> Uncurry<A, B, C, D>(this Func<A, Func<B, Func<C, D>>> self)
		{
			return (a, b, c) => self(a)(b)(c);
		}

		public static Func<A, Func<B, C>> Curry<A, B, C>(this Func<A, B, C> self)
		{
			return a => b => self(a, b);
		}

		public static Func<A, B, C> Uncurry<A, B, C>(this Func<A, Func<B, C>> self)
		{
			return (a, b) => self(a)(b);
		}
	}
}