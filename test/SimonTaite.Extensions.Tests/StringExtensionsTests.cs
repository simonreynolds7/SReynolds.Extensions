using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

using SimonTaite.Extensions;

namespace SimonTaite.Extensions.Tests
{
    public class StringExtensionsTests
    {
        [Fact]
        public void SlugifyWorksAsExpected()
        {
            var expected = "this-is-a-test";
            var input = "This is a test";
            
            var result = input.Slugify();
            
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void SlugifyWorksAsExpected_RemovesBrackets()
        {
            var expected = "this-is-a-test";
            var input = "This is a test (with brackets)";
            
            var result = input.Slugify();
            
            Assert.Equal(expected, result);
        }

    }
}
