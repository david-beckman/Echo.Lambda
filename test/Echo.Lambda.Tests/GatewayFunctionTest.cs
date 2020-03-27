//-----------------------------------------------------------------------
// <copyright file="GatewayFunctionTest.cs" company="N/A">
//     Copyright © 2020 David Beckman. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Echo.Lambda.Tests
{
    using Amazon.Lambda.APIGatewayEvents;
    using Amazon.Lambda.TestUtilities;

    using Xunit;

    public class GatewayFunctionTest
    {
        [Fact]
        public void TetGetMethod()
        {
            var response = new GatewayFunction().Get(new APIGatewayProxyRequest(), new TestLambdaContext());

            Assert.Equal(200, response.StatusCode);
            Assert.NotNull(response.Body);
        }
    }
}
