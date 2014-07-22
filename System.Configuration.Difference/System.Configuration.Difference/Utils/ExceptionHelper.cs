﻿using System;

namespace System.Configuration.Difference.Utils {
    
    public static class ExceptionHelper {

        internal static void ThrowArgumentNull(string paramName) {
            throw new ArgumentNullException(paramName);
        }

        internal static void ThrowNotSupported(string message) {
            throw new NotSupportedException(message);
        }
    }
}
