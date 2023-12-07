using CountVowels;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountVowelsTest
{
    [TestFixture]
    public class VowelCountTest
    {
        
        [Test]
        public void countVowels_WhenCalled_ShouldCountVowelsUsed() 
        {
            //TRIPLE A
            //ARRANGE
            VowelCount test = new();

            //ACT
            var result=test.countVowels("Evans");

            //ASSERT
            Assert.That(result, Is.EqualTo(2));

        }
    }
}
