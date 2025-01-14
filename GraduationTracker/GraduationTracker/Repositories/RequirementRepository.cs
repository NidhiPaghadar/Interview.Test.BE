﻿using GraduationTracker.Models;
using System.Collections.Generic;
using System.Linq;

namespace GraduationTracker.Repositories
{
    public class RequirementRepository : IRequirementRepository
    {
        public Requirement GetRequirement(int id)
        {
            var requirements = GetRequirements();
            return requirements.ToList().FirstOrDefault(diploma => diploma.Id == id);
        }

        public IEnumerable<Requirement> GetRequirements()
        {
            return new List<Requirement>() {
                new Requirement{Id = 100, Name = "Math", MinimumMark=50, Courses = new int[]{1}, Credits=1 },
                new Requirement { Id = 102, Name = "Science", MinimumMark = 50, Courses = new int[] { 2 }, Credits = 1 },
                new Requirement { Id = 103, Name = "Literature", MinimumMark = 50, Courses = new int[] { 3 }, Credits = 1 },
                new Requirement { Id = 104, Name = "Physichal Education", MinimumMark = 50, Courses = new int[] { 4 }, Credits = 1 }
            };
        }
    }
}