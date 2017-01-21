using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace TupleExtensions
{
    public static class TaskExtensions
    {
        public static TaskAwaiter GetAwaiter(this(Task, Task) t) => Task.WhenAll(t.Item1, t.Item2).GetAwaiter();
        public static TaskAwaiter GetAwaiter(this(Task, Task, Task) t) => Task.WhenAll(t.Item1, t.Item2, t.Item3).GetAwaiter();
        public static TaskAwaiter GetAwaiter(this(Task, Task, Task, Task) t) => Task.WhenAll(t.Item1, t.Item2, t.Item3, t.Item4).GetAwaiter();
        public static TaskAwaiter GetAwaiter(this(Task, Task, Task, Task, Task) t) => Task.WhenAll(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5).GetAwaiter();
        public static TaskAwaiter GetAwaiter(this(Task, Task, Task, Task, Task, Task) t) => Task.WhenAll(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6).GetAwaiter();
        public static TaskAwaiter GetAwaiter(this(Task, Task, Task, Task, Task, Task, Task) t) => Task.WhenAll(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7).GetAwaiter();
        public static TaskAwaiter<TResult[]> GetAwaiter<TResult>(this(Task<TResult>, Task<TResult>) t) => Task.WhenAll(t.Item1, t.Item2).GetAwaiter();
        public static TaskAwaiter<TResult[]> GetAwaiter<TResult>(this(Task<TResult>, Task<TResult>, Task<TResult>) t) => Task.WhenAll(t.Item1, t.Item2, t.Item3).GetAwaiter();
        public static TaskAwaiter<TResult[]> GetAwaiter<TResult>(this(Task<TResult>, Task<TResult>, Task<TResult>, Task<TResult>) t) => Task.WhenAll(t.Item1, t.Item2, t.Item3, t.Item4).GetAwaiter();
        public static TaskAwaiter<TResult[]> GetAwaiter<TResult>(this(Task<TResult>, Task<TResult>, Task<TResult>, Task<TResult>, Task<TResult>) t) => Task.WhenAll(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5).GetAwaiter();
        public static TaskAwaiter<TResult[]> GetAwaiter<TResult>(this(Task<TResult>, Task<TResult>, Task<TResult>, Task<TResult>, Task<TResult>, Task<TResult>) t) => Task.WhenAll(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6).GetAwaiter();
        public static TaskAwaiter<TResult[]> GetAwaiter<TResult>(this(Task<TResult>, Task<TResult>, Task<TResult>, Task<TResult>, Task<TResult>, Task<TResult>, Task<TResult>) t) => Task.WhenAll(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7).GetAwaiter();
    }
}