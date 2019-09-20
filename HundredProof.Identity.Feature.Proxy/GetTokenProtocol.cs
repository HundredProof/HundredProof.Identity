// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetTokenProtocol.cs" company="HundredProof">
//     Copyright (c) HundredProof 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace HundredProof.Identity.Feature.Proxy
{
    using System;
    using HundredProof.Identity.Domain.Operations;
    using Naos.FluentUri;
    using Naos.Protocol.Domain;

    /// <summary>
    /// Protocol for <see cref="GetTokenOp" />.
    /// </summary>
    public class GetTokenProtocol : IReturningProtocol<GetTokenOp, Token>
    {
        private readonly Uri rootIdentityServiceUri;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTokenProtocol"/> class.
        /// </summary>
        /// <param name="rootIdentityServiceUri">The root identity service URI.</param>
        public GetTokenProtocol(
            Uri rootIdentityServiceUri)
        {
            this.rootIdentityServiceUri = rootIdentityServiceUri;
        }

        /// <summary>
        /// Executes the operation.
        /// </summary>
        /// <param name="operation">The operation.</param>
        /// <returns>The result of the operation.</returns>
        /// <inheritdoc />
        public Token Execute(
            GetTokenOp operation)
        {
            var proxyGetToken = operation.Proxy();
            var proxyToken = this.rootIdentityServiceUri.AppendPathSegment("identity")
                                 .AppendPathSegment("gettoken")
                                 .WithBody(proxyGetToken)
                                 .Post<ProxyToken>();
            var token = proxyToken.UnProxy();
            return token;
        }
    }

    /// <summary>
    /// Class ProxyGetToken.
    /// </summary>
    public class ProxyGetToken
    {
        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        /// <value>The username.</value>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>The password.</value>
        public string Password { get; set; }
    }

    /// <summary>
    /// Class ProxyToken.
    /// </summary>
    public class ProxyToken
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProxyToken"/> class.
        /// </summary>
        /// <param name="ticket">The ticket.</param>
        /// <exception cref="System.ArgumentNullException">ticket.</exception>
        public ProxyToken(
            string ticket)
        {
            this.Ticket = ticket ?? throw new ArgumentNullException(nameof(ticket));
        }

        /// <summary>
        /// Gets the ticket.
        /// </summary>
        /// <value>The ticket.</value>
        public string Ticket { get; private set; }
    }

    /// <summary>
    /// Class ProxyExtensions.
    /// </summary>
    public static class ProxyExtensions
    {
        /// <summary>
        /// Uns the proxy.
        /// </summary>
        /// <param name="proxyToken">The proxy token.</param>
        /// <returns>Token.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Un", Justification = "Spelling/name is correct.")]
        public static Token UnProxy(
            this ProxyToken proxyToken)
        {
            var ret = new Token(proxyToken.Ticket);
            return ret;
        }

        /// <summary>
        /// Proxies the specified operation.
        /// </summary>
        /// <param name="operation">The operation.</param>
        /// <returns>ProxyGetToken.</returns>
        public static ProxyGetToken Proxy(this GetTokenOp operation)
        {
            var ret = new ProxyGetToken
                      {
                          UserName = operation.UserName,
                          Password = operation.Password,
                      };

            return ret;
        }
    }
}
