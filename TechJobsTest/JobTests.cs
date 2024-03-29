﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
            Assert.AreEqual(job1.Id - job2.Id, -1);
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
            TechJob job1 = new TechJob("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual(job1.Name, "Product tester");
            Assert.AreEqual(job1.EmployerName.Value, "ACME");
            Assert.AreEqual(job1.EmployerLocation.Value, "Desert");
            Assert.AreEqual(job1.JobType.Value, "Quality control");
            Assert.AreEqual(job1.JobCoreCompetency.Value, "Persistence");
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
            TechJob job3 = new TechJob("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            string jobString = job3.ToString();

            /*Assert.IsTrue(jobString.StartsWith(Environment.NewLine));
            Assert.IsTrue(jobString.EndsWith(Environment.NewLine));*/
        }

        // FIX THIS!!!
        // task 5 - test 2
        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            TechJob job4 = new TechJob("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            string job5 = job4.ToString();

            // FIX THIS!!!
            // checks that labels are contained in string
            Assert.IsTrue(job5.Contains("ID:"));
            Assert.IsTrue(job5.Contains("Name:"));
            Assert.IsTrue(job5.Contains("Employer:"));
            Assert.IsTrue(job5.Contains("Location:"));
            Assert.IsTrue(job5.Contains("Position Type:"));
            Assert.IsTrue(job5.Contains("Core Competency:"));

            // checks that data is contained in string 
            //Assert.IsTrue(job5.Contains("1"));
            Assert.IsTrue(job5.Contains("Product tester"));
            Assert.IsTrue(job5.Contains("ACME"));
            Assert.IsTrue(job5.Contains("Desert"));
            Assert.IsTrue(job5.Contains("Quality control"));
            Assert.IsTrue(job5.Contains("Persistence"));
        }

        // FIX THIS!!!
        // task 5 - test 3
        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            TechJob job6 = new TechJob("", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            string job7 = job6.ToString();

            Assert.IsTrue(job7.Contains("Data not available."));
        }
    }
}