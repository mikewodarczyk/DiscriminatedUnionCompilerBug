using System;
using System.Collections.Generic;
using System.Text;

#nullable enable

namespace DiscriminatedUnion
{

    public class ClassAOrClassB : OneOf<ClassA, ClassB>
    {
        public ClassAOrClassB(ClassA a) : base(a)
        {
        }

        public ClassAOrClassB(ClassB b) : base(b)
        {
        }
    }

}
