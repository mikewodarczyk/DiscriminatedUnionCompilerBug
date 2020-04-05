using System;

#nullable enable

namespace DiscriminatedUnion
{
    // This class holds an object of type T1 or type T2.  Never both.  
    public class OneOf<T1,T2>  where T1 : class where T2 : class
    {
        private readonly T1? A;
        private readonly T2? B;

        public OneOf(T1 a)
        {
            A = a;
            B = null;
        }

        public OneOf(T2 b)
        {
            A = null;
            B = b;
        }

        static public implicit operator T1?(OneOf<T1,T2> obj) => obj.A;
        static public implicit operator T2?(OneOf<T1,T2> obj) => obj.B;
    }


}
