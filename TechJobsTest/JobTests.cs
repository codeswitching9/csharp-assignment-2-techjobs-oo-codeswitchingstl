using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTest
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            // 2 new job objects
            TechJob job1 = new TechJob();
            TechJob job2 = new TechJob();
            Assert.IsFalse(job1.Equals(job2));
            Assert.AreEqual(job1.Id - job2.Id, 1);
        }

        // testing the full constructor
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            //Name name = new Name("Product tester");
            /*Employer employer = new Employer("ACME");
            Location location = new Location("Desert");
            PositionType positionType = new PositionType("Quality control");
            CoreCompetency competency = new CoreCompetency("Persistence");*/
            TechJob job1 = new TechJob("Product tester", new Employer ("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual(job1.Name, "Product tester");
            Assert.AreEqual(job1.EmployerName, "ACME");
            Assert.AreEqual(job1.EmployerLocation, "Desert");
            Assert.AreEqual(job1.JobType, "Quality control");
            Assert.AreEqual(job1.JobCoreCompetency, "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            TechJob job1 = new TechJob("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            TechJob job2 = new TechJob("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            // Test that Equals() returns false.
            Assert.IsFalse(job1.Equals(job2));
        }

        // task 5 - test 1
        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            TechJob job1 = new TechJob()/*("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"))*/;

            //string expected = 
        }
    }
}
