using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace StudentExercisesMVC.Models.ViewModels
{
    public class StudentEditViewModel
    {
        public List<SelectListItem> Cohorts { get; set; }
        public Student Student { get; set; }
    }
}
