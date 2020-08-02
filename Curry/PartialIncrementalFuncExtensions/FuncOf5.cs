using System;

namespace Curryfy
{
    //------------------------------------------------------------------------------ 
    // <auto-generated> 
    // This code was generated by a tool. 
    // 
    // Changes to this file may cause incorrect behavior and will be lost if 
    // the code is regenerated. 
    // </auto-generated> 
    //------------------------------------------------------------------------------

    public static partial class PartialIncrementalFuncExtensions
    { 
        // 1
        public static Func<T2, T3, T4, T5, TResult> ApplyPartial<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> function, T1 arg1)
            => (arg2, arg3, arg4, arg5) => function(arg1, arg2, arg3, arg4, arg5);
        
        // 2
        public static Func<T3, T4, T5, TResult> ApplyPartial<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> function, T1 arg1, T2 arg2)
            => (arg3, arg4, arg5) => function(arg1, arg2, arg3, arg4, arg5);
        
        // 3
        public static Func<T4, T5, TResult> ApplyPartial<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> function, T1 arg1, T2 arg2, T3 arg3)
            => (arg4, arg5) => function(arg1, arg2, arg3, arg4, arg5);
        
        // 4
        public static Func<T5, TResult> ApplyPartial<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
            => (arg5) => function(arg1, arg2, arg3, arg4, arg5);
    }
}
