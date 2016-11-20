﻿using System;
using System.ComponentModel.DataAnnotations;

namespace DailySports.DataLayer.Model
{
    public class PetOfTheWeek
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PetImage { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string FunFact { get; set; }
        public string Owner { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
