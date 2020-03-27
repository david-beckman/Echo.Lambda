//-----------------------------------------------------------------------
// <copyright file="AssemblyInfo.cs" company="N/A">
//     Copyright © 2020 David Beckman. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System.Reflection;
using System.Runtime.InteropServices;

using Amazon.Lambda.Core;
using Amazon.Lambda.Serialization.Json;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("6662a0e5-986a-4e82-a82b-a92d41c4e59c")]

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(JsonSerializer))]
