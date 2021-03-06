﻿using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Configuration.Core {

    internal sealed class ReferenceEqualityComparer<TKey> : IEqualityComparer<TKey> where TKey :class {
        public static ReferenceEqualityComparer<TKey> Default = new ReferenceEqualityComparer<TKey>();

        public bool Equals(TKey x, TKey y) {
            return ReferenceEquals(x, y);
        }

        public int GetHashCode(TKey obj) {
            if (ReferenceEquals(obj, null)) {
                return 0;
            }

            return RuntimeHelpers.GetHashCode(obj);
        }
    }
}
