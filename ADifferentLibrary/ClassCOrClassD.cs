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
       
        public ClassCOrClassD(ClassD d) : base(d)  
        {
        }

    }
}
