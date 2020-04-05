using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

#nullable enable

namespace DiscriminatedUnion
{
    public class ClassC : IEquatable<ClassC>
    {
        public int Id { get; }


        public ClassC(int id)
        {
            Id = id;
        }

        public bool Equals(ClassC? other)
        {
            return other != null && Id == other.Id;
        }

        public override bool Equals(object? other)
        {
            return other is ClassC x && Equals(x);
        }

        public static bool operator ==(ClassC? a, ClassC? b)
        {
            if (a is null) return b is null;
            return b is ClassC x && a.Equals(x);
        }
        public static bool operator !=(ClassC? a, ClassC? b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

    }
}
