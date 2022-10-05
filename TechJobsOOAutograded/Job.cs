using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    public class TechJob
    {
        
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public TechJob()
        {
            Id = nextId;
            nextId++;
        }

        public TechJob(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            this.Name = name;
            this.EmployerName = employerName;
            this.EmployerLocation = employerLocation;
            this.JobType = jobType;
            this.JobCoreCompetency = jobCoreCompetency;
        }

        // TODO: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            return obj is TechJob job &&
                   Id == job.Id &&
                   Name == job.Name &&
                   EqualityComparer<Employer>.Default.Equals(EmployerName, job.EmployerName) &&
                   EqualityComparer<Location>.Default.Equals(EmployerLocation, job.EmployerLocation) &&
                   EqualityComparer<PositionType>.Default.Equals(JobType, job.JobType) &&
                   EqualityComparer<CoreCompetency>.Default.Equals(JobCoreCompetency, job.JobCoreCompetency);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, EmployerName, EmployerLocation, JobType, JobCoreCompetency);
        }

        public override string ToString()
        {
            string incompleteString = "Data not available.";
            
            if (Name == "")
            {
                Name = incompleteString;
            }
            else if(EmployerName.ToString() == "")
            {
                EmployerName.Value = incompleteString;
            }
            else if(EmployerLocation.ToString() == "")
            {
                EmployerLocation.Value = incompleteString;
            }
            else if (JobType.ToString() == "")
            {
                JobType.Value = incompleteString;
            }
            else if (JobCoreCompetency.ToString() == "")
            {
                JobCoreCompetency.Value = incompleteString;
            }

            return Environment.NewLine + "ID: " + Id + Environment.NewLine +
                "Name: " + Name + Environment.NewLine +
                "Location: " + EmployerLocation.Value + Environment.NewLine +
                "Position Type: " + JobType.Value + Environment.NewLine +
                "Core Competency: " + JobCoreCompetency.Value + Environment.NewLine;
        }

    }
}