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
    }
}
