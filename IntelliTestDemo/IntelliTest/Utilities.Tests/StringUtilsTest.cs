// <copyright file="StringUtilsTest.cs">Copyright ©  2015</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utilities;

namespace Utilities.Tests
{
    /// <summary>This class contains parameterized unit tests for StringUtils</summary>
    [PexClass(typeof(StringUtils))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class StringUtilsTest
    {
        /// <summary>Test stub for Capitalize(String)</summary>
        [PexMethod]
        public string CapitalizeTest(string value)
        {
            string result = StringUtils.Capitalize(value);
            return result;
            // TODO: add assertions to method StringUtilsTest.CapitalizeTest(String)
        }
    }
}
