//-----------------------------------------------------------------------
// <copyright file="GatewayFunction.cs" company="N/A">
//     Copyright © 2020 David Beckman. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Echo.Lambda
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Net;

    using Amazon.Lambda.APIGatewayEvents;
    using Amazon.Lambda.Core;

    using Newtonsoft.Json;

    /// <summary>
    ///     The AWS Lambda function entry-point for API Gateway.
    /// </summary>
    public class GatewayFunction
    {
        /// <summary>
        ///     A Lambda function to respond to HTTP Get methods from API Gateway.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="context">The context.</param>
        /// <returns>An echo-ed JSON response containing both the request and context.</returns>
        [SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "Only instance methods may be invoked via a lambda.")]
        public APIGatewayProxyResponse Get(APIGatewayProxyRequest request, ILambdaContext context)
        {
            return new APIGatewayProxyResponse
            {
                StatusCode = (int)HttpStatusCode.OK,
                Body = JsonConvert.SerializeObject(new Output { Request = request, Context = context }),
                Headers = new Dictionary<string, string> { { "Content-Type", "application/json" } },
            };
        }

        private class Output
        {
            internal APIGatewayProxyRequest Request { get; set; }

            internal ILambdaContext Context { get; set; }
        }
    }
}
