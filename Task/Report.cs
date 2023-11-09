using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Report
    {
        private Employee Executor { get; set; }
        public string Text { get; set; }
        public string Status { get; set; }
        public DateTime UploadTime { get; set; }
        public DateTime ReviewTime { get; set; }
        public Employee Reviewer { get; set; }

        public Report(string description)
        {
            Text = description;
            Status = "Uploaded";
            UploadTime = DateTime.Now;
        }

        public void Approve(Employee reviewer)
        {
            Status = "Approved";
            ReviewTime = DateTime.Now;
            Reviewer = reviewer;
        }

        public void ReturnForRevision()
        {
            Status = "Returned for Revision";
            ReviewTime = DateTime.Now;
        }


    }
}
