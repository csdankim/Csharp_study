using System;

namespace Generic
{
    public class EqualityChecker<T> where T : struct
    {
        /*
        Problems with object is
        1. typesafety
        2. unwanted boxing and unboxing

        conversion of a value type to a reference type is called boxing
        conversion of a reference type to a value type is called unboxing
        */

        public bool CheckEquality(object a, object b)
        {
            return a.Equals(b);
        }

        public bool CheckEquality(T a, T b)
        {
            return a.Equals(b);
        }
    }
}
