﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArchitecture.DA.Entities
{
    public class Homework
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Uri Link { get; set; }

        public int LessonId { get; set; }
        public Lesson Lesson { get; set; }

        public ICollection<Member> Members { get; set; }
    }
}
