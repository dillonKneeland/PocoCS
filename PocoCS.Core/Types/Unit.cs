using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace PocoCS.Core.Types
{
    [Serializable]
    public struct Unit : IEquatable<Unit>, IComparable<Unit>
    {
        public static readonly Unit Default = new Unit();

        [Pure]
        public override int GetHashCode() =>
            0;

        [Pure]
        public override bool Equals(object? obj) =>
            obj is Unit;

        [Pure]
        public bool Equals(Unit other) =>
            true;

        [Pure]
        public override string ToString() =>
            "()";

        [Pure]
        public int CompareTo(Unit _) =>
            0;

        [Pure]
        public static implicit operator ValueTuple(Unit _) =>
            default;

        [Pure]
        public static implicit operator Unit(ValueTuple _) =>
            Default;

        #region Unary Operators

        [Pure]
        public static Unit operator +(Unit _) =>
            Default;

        [Pure]
        public static Unit operator -(Unit _) =>
            Default;

        [Pure]
        public static Unit operator ++(Unit _) =>
            Default;

        [Pure]
        public static Unit operator --(Unit _) =>
            Default;

        [Pure]
        public static bool operator true(Unit _) =>
            true;

        [Pure]
        public static bool operator false(Unit _) =>
            false;

        public static bool operator !(Unit _) =>
            true;

        #endregion

        #region Binary Operators

        // Logical

        [Pure]
        public static bool operator ==(Unit _, object b) =>
            b is Unit;

        [Pure]
        public static bool operator !=(Unit _, object b) =>
            !(b is Unit);

        [Pure]
        public static Unit operator &(Unit _, Unit __) =>
            Default;

        [Pure]
        public static Unit operator |(Unit _, Unit __) =>
            Default;

        [Pure]
        public static bool operator >(Unit _, Unit __) =>
            false;

        [Pure]
        public static bool operator <(Unit _, Unit __) =>
            false;

        [Pure]
        public static bool operator >=(Unit _, Unit __) =>
            false;

        [Pure]
        public static bool operator <=(Unit _, Unit __) =>
            false;

        // Arithmetical

        [Pure]
        public static Unit operator +(Unit _, Unit __) =>
            Default;

        [Pure]
        public static Unit operator -(Unit _, Unit __) =>
            Default;

        [Pure]
        public static Unit operator *(Unit _, Unit __) =>
            Default;

        [Pure]
        public static Unit operator /(Unit _, Unit __) =>
            Default;

        [Pure]
        public static Unit operator %(Unit _, Unit __) =>
            Default;

        #endregion
    }
}
