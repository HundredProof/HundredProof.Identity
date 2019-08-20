// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StoreCertificate.cs" company="Naos">
//   Copyright (c) Naos 2018. All rights reserved.
// </copyright>
// <auto-generated>
//   Sourced from NuGet package. Will be overwritten with package update except in Naos.Recipes.Api.SelfHost.Bootstrapper.Common source.
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace HundredProof.Identity.Server.Owin.Console
{
    using System.Security.Cryptography.X509Certificates;

    /// <summary>
    /// Describes a certificate in a store.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [System.CodeDom.Compiler.GeneratedCode("Naos.Recipes.Api.SelfHost.Bootstrapper.Common", "See package version number")]
    public class StoreCertificate
    {
        /// <summary>
        /// Gets or sets the name of the store. Defaults to StoreName.My.
        /// </summary>
        /// <value>
        /// The name of the store.
        /// </value>
        public StoreName StoreName { get; set; } = StoreName.My;

        /// <summary>
        /// Gets or sets the store location. Defaults to StoreLocation.LocalMachine.
        /// </summary>
        /// <value>
        /// The store location.
        /// </value>
        public StoreLocation StoreLocation { get; set; } = StoreLocation.LocalMachine;

        /// <summary>
        /// Gets or sets the certificate thumbprint.
        /// </summary>
        /// <value>
        /// The certificate thumbprint.
        /// </value>
        public string CertificateThumbprint { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether certificate validity is required. Defaults to true.
        /// </summary>
        /// <value>
        /// <c>true</c> if certificate validity is required; otherwise, <c>false</c>.
        /// </value>
        public bool CertificateValidityRequired { get; set; } = true;
    }
}