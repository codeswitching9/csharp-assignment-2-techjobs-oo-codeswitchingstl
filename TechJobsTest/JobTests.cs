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
            TechJob techJob1 = new TechJob();
            TechJob techJob2 = new TechJob();
            Assert.IsFalse(techJob1.Equals(techJob2));
            Assert.AreEqual(techJob1.Id - techJob2.Id, 1);
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
            TechJob techJob1 = new TechJob("Product tester", new Employer ("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual(techJob1.Name, "Product tester");
            Assert.AreEqual(techJob1.EmployerName, "ACME");
            Assert.AreEqual(techJob1.EmployerLocation, "Desert");
            Assert.AreEqual(techJob1.JobType, "Quality control");
            Assert.AreEqual(techJob1.JobCoreCompetency, "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            TechJob techJob1 = new TechJob("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            TechJob techJob2 = new TechJob("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            // Test that Equals() returns false.
            Assert.IsFalse(techJob1.Equals(techJob2));
        }
    }
}
