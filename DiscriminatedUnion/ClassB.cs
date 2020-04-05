using System;
using System.Collections.Generic;
using System.Text;

#nullable enable

namespace DiscriminatedUnion
{

    public class ClassB : IEquatable<ClassB>
    {
        public string Name { get; }
        public ClassB(string name) { Name = name; }

        public bool Equals(ClassB other)
        {
            return Name == other.Name;
        }

        public override bool Equals(object? other)
        {
            return other is ClassB x && Equals(x);
        }

        public static bool operator ==(ClassB? a, ClassB? b)
        {
            if (a is null) return b is null;
            return b is ClassB x && a.Equals(x);
        }
        public static bool operator !=(ClassB? a, ClassB? b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name);
        }

    }

}
