﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information. 

#if NO_RXINTERFACES
namespace System
{
    /// <summary>
    /// Supports push-style iteration over an observable sequence.
    /// </summary>
#if !NO_VARIANCE
    public interface IObserver<in T>
#else
    public interface IObserver<T>
#endif
    {
        /// <summary>
        /// Notifies the observer of a new element in the sequence.
        /// </summary>
        /// <param name="value">Next element in the sequence.</param>
        void OnNext(T value);

        /// <summary>
        /// Notifies the observer that an exception has occurred.
        /// </summary>
        /// <param name="error">The error that has occurred.</param>
        void OnError(Exception error);

        /// <summary>
        /// Notifies the observer of the end of the sequence.
        /// </summary>
        void OnCompleted();
    }
}
#elif !WINDOWSPHONE7 // TypeForwardedTo is not present on Windows Phone 7 so we can't really target
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.IObserver<>))]
#endif