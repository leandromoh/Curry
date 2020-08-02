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

    public static partial class CurryfyExtensions
    { 
        // 1
        public static Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ApplyPartial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> function, T1 arg1)
            => (arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        
        // 2
        public static Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ApplyPartial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> function, T1 arg1, T2 arg2)
            => (arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        
        // 3
        public static Action<T4, T5, T6, T7, T8, T9, T10, T11, T12> ApplyPartial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> function, T1 arg1, T2 arg2, T3 arg3)
            => (arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        
        // 4
        public static Action<T5, T6, T7, T8, T9, T10, T11, T12> ApplyPartial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
            => (arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        
        // 5
        public static Action<T6, T7, T8, T9, T10, T11, T12> ApplyPartial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
            => (arg6, arg7, arg8, arg9, arg10, arg11, arg12) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        
        // 6
        public static Action<T7, T8, T9, T10, T11, T12> ApplyPartial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
            => (arg7, arg8, arg9, arg10, arg11, arg12) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        
        // 7
        public static Action<T8, T9, T10, T11, T12> ApplyPartial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
            => (arg8, arg9, arg10, arg11, arg12) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        
        // 8
        public static Action<T9, T10, T11, T12> ApplyPartial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
            => (arg9, arg10, arg11, arg12) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        
        // 9
        public static Action<T10, T11, T12> ApplyPartial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
            => (arg10, arg11, arg12) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        
        // 10
        public static Action<T11, T12> ApplyPartial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
            => (arg11, arg12) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        
        // 11
        public static Action<T12> ApplyPartial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
            => (arg12) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
    }
}
