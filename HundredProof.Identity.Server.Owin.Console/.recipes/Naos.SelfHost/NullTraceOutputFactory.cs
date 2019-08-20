// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NullTraceOutputFactory.cs" company="Naos">
//   Copyright (c) Naos 2018. All rights reserved.
// </copyright>
// <auto-generated>
//   Sourced from NuGet package. Will be overwritten with package update except in Naos.Recipes.Api.SelfHost.Bootstrapper.Common source.
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace HundredProof.Identity.Server.Owin.Console
{
    using System.IO;
    using Microsoft.Owin.Hosting.Tracing;

    /// <summary>
    /// A default no-op implementation of the trace output factory.
    /// </summary>
    /// <seealso cref="Microsoft.Owin.Hosting.Tracing.ITraceOutputFactory" />
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [System.CodeDom.Compiler.GeneratedCode("Naos.Recipes.Api.SelfHost.Bootstrapper.Common", "See package version number")]
    public class NullTraceOutputFactory : ITraceOutputFactory
    {
        /// <summary>
        /// Used to create the trace output.
        /// </summary>
        /// <param name="outputFile">Ignored. Here to satisfy interface.</param>
        /// <returns>A null StreamWriter.</returns>
        public TextWriter Create(string outputFile)
        {
            return StreamWriter.Null;
        }
    }
}