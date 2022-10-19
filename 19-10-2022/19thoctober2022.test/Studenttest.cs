using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _19thOctober2022;
using NUnit.Framework;


namespace _19thoctober2022.test
{
    public class Studenttest
    {
        [TestCase (100,ExpectedResult =true)]
        [TestCase(0,ExpectedResult =false)]
        [TestCase(-234,ExpectedResult =false)]
        [TestCase(5000,ExpectedResult =true)]
        public bool GetFees(int Fees)
        {
            Student st = new Student();
            StudentEnrollment s = new StudentEnrollment();
            Enrollment enrollment = new Enrollment();
            enrollment.Enrollno = 101;
            enrollment.Fees = Fees;
            
            bool ans = s.Fees(st,enrollment);
            return ans;
        }
    }

    [TestFixture]
    public class UnitTest1
    {
        [TestCase]
        public void TestMethod1()
        {
            //Act  
            StubExtensionManager stub = new StubExtensionManager();
            FileChecker checker = new FileChecker(stub);

            //Action  
            bool IsTrueFile = checker.CheckFile("myFile.whatever");

            //Assert  
            Assert.AreEqual(true, IsTrueFile);
        }
    }

    [TestFixture]
    public class UnitTest2
    {
        [TestCase]
        public void TestMethod1()
        {
            //Act  
            MockExtensionService mockobject = new MockExtensionService();
            //Inject mock object now  
            ExtensionAnalyzer analyzer = new ExtensionAnalyzer(mockobject);
            //Action  
            analyzer.ExtensionCheck("somefile.someextension");

            //Assert  
            Assert.AreEqual(mockobject.ErrorMessage, "Wrong Type");
        }
    }

    
}
[TestFixture]
class Test1

{
    int s;
    [SetUp]
    [Test]
    public void Add()
    {
        int x = 10;
        int y = 20;
        s = x + y;
        Console.WriteLine(s);
    }
    [Test]
    public void subtract()
    {
        int p = s - 10;
        Console.WriteLine(p);
        Assert.AreEqual(p, 20);
    }
    [Test]
    [TearDown]


    public void Multiply()
    {
        int x = 100;
        int y = 20;
        int result = x * y;
        Console.WriteLine(result);
        Assert.AreEqual(result, 2000);
    }


}
