using System;
using System.Collections.Generic;
using System.Text;
using DiscriminatedUnion;

#nullable enable

namespace DiscriminatedUnion
{
    public class ClassCOrClassD : OneOf<ClassC, ClassD>
    {

        public ClassCOrClassD(ClassC c) : base(c)
        {
        }

        // gives error CS1520  Method must have a return type but only if in another project
        public ClassCOrClasssD(ClassD d) : base(d)  
        {
        }

    }
}
