// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="HundredProof">
//     Copyright (c) HundredProof 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace HundredProof.Identity.Feature.Proxy.Test
{
    using System;
    using System.Linq;

    /// <summary>
    /// Class Program.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            if (args?.Any(string.IsNullOrWhiteSpace) ?? true)
            {
                throw new ArgumentException("Null or white space.", nameof(args));
            }

            Console.WriteLine(args);
        }
    }
}
