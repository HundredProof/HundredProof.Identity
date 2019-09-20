// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetTokenOp.cs" company="HundredProof">
//    Copyright (c) HundredProof 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace HundredProof.Identity.Domain.Operations
{
    using System;
    using Naos.Protocol.Domain;

    /// <summary>
    /// The Login Operation.
    /// </summary>
    public class GetTokenOp : ReturningOperationBase<Token>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTokenOp"/> class.
        /// </summary>
        /// <param name="userName">The username.</param>
        /// <param name="password">The password.</param>
        /// <exception cref="System.ArgumentNullException">
        /// username
        /// or
        /// password.
        /// </exception>
        public GetTokenOp(
            string userName,
            string password)
        {
            this.UserName = userName ?? throw new ArgumentNullException(nameof(userName));
            this.Password = password ?? throw new ArgumentNullException(nameof(password));
        }

        /// <summary>
        /// Gets the username.
        /// </summary>
        /// <value>The username.</value>
        public string UserName { get; private set; }

        /// <summary>
        /// Gets the password.
        /// </summary>
        /// <value>The password.</value>
        public string Password { get; private set; }
    }
}
