// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Token.cs" company="HundredProof">
//     Copyright (c) HundredProof 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace HundredProof.Identity.Domain.Operations
{
    using System;

    /// <summary>
    /// The identity token.
    /// </summary>
    public class Token
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Token" /> class.
        /// </summary>
        /// <param name="ticket">The ticket.</param>
        /// <exception cref="System.ArgumentNullException">ticket.</exception>
        public Token(string ticket)
        {
            this.Ticket = ticket ?? throw new ArgumentNullException(nameof(ticket));
        }

        /// <summary>
        /// Gets the ticket.
        /// </summary>
        /// <value>The ticket.</value>
        public string Ticket { get; private set; }
    }
}
