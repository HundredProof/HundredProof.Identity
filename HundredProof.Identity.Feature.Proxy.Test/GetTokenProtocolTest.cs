// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetTokenProtocolTest.cs" company="HundredProof">
//    Copyright (c) HundredProof 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace HundredProof.Identity.Feature.Proxy.Test
{
    using System;
    using FluentAssertions;
    using HundredProof.Identity.Domain.Operations;
    using Xunit;
    using Xunit.Sdk;

    /// <summary>
    /// Class GetTokenProtocolTest.
    /// </summary>
    public static class GetTokenProtocolTest
    {
        [Fact(Skip = "Needs debugging running.")]
        public static void GetToken()
        {
            // Arrange
            var userName = "testUser";
            var password = "password";
            var operation = new GetTokenOp(userName, password);
            var protocol = new GetTokenProtocol(new Uri("http://localhost/.../"));

            // Act
            var actual = protocol.Execute(operation);

            // Assert
            actual.Should().NotBeNull();
        }
    }
}
