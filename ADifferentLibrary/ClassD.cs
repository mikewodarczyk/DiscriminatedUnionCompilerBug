using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

#nullable enable

namespace DiscriminatedUnion
{
    public class ClassD : IEquatable<ClassD>
    {
        public string Name { get; }

        public ClassD(string name)
        {
            Name = name;
        }

        public bool Equals(ClassD? other)
        {
            return other != null && Name == other.Name;
        }

        public override bool Equals(object? other)
        {
            return other is ClassD x && Equals(x);
        }

        public static bool operator ==(ClassD? a, ClassD? b)
        {
            if (a is null) return b is null;
            return b is ClassD x && a.Equals(x);
        }
        public static bool operator !=(ClassD? a, ClassD? b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name);
        }

    }
}
