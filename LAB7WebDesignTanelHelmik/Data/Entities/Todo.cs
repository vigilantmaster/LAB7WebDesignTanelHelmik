﻿using System;
using System.ComponentModel.DataAnnotations;

namespace LAB7WebDesignTanelHelmik.Data.Entities
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Subject")]
        public string Subject { get; set; }

        [Required]
        [Display(Name = "Details")]
        public string Details { get; set; }

        [Required]
        [Display(Name = "Next Reminder")]
        public DateTime NextReminder { get; set; }

        [Required]
        [Display(Name = "Finished")]
        public bool Finished { get; set; }

        public int UserId { get; set; }
    }
}