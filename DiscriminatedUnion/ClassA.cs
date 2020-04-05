using System;
using System.Collections.Generic;
using System.Text;

#nullable enable

namespace DiscriminatedUnion
{
    public class ClassA : IEquatable<ClassA>
    {
        public int Id { get; }
        public ClassA(int id) { Id = id; }

        public bool Equals(ClassA other)
        {
            return Id == other.Id;
        }

        public override bool Equals(object? other)
        {
            return other is ClassA x && Equals(x);
        }

        public static bool operator ==(ClassA? a, ClassA? b)
        {
            if (a is null) return b is null;
            return b is ClassA x && a.Equals(x);
        }
        public static bool operator !=(ClassA? a, ClassA? b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
