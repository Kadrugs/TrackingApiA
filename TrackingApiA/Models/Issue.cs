﻿using System.ComponentModel.DataAnnotations;

namespace TrackingApiA.Models
{
    public class Issue
    {
        public int Id { get; set; }
        [Required]
        public string Title{ get; set; }
        [Required]
        public string Description { get; set; }
        public Priority Priority { get; set; }
        public IssueType IssueType { get; set; }
        public DateTime Created { get; set; }   
        public DateTime? Completed { get; set; }

    }

    public enum Priority
    {
        Low, Medium, High
    }

    public enum IssueType
    {
        Feature, Bug, Documentation
    }

}
