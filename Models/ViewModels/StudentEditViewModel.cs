using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace StudentExercisesMVC.Models.ViewModels
{
    public class StudentEditViewModel
    {
        public List<SelectListItem> Cohorts { get; set; }
        public Student Student { get; set; }
        public StudentEditViewModel(Student student, List<Cohort> cohortList)
        {
            Student = student;
            Cohorts = cohortList
                .Select(cohort => new SelectListItem
                {
                    Text = cohort.Name,
                    Value = cohort.Id.ToString()
                })
                .ToList();
        }
    }
}
