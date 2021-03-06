﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Korzh.EasyQuery.AspNetCore.Demo02.Models
{
    [DisplayColumn("FirstName")]
    public class Employee {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [NotMapped]
        public string FullName {
            get {
                string res = this.FirstName;

                if (!string.IsNullOrEmpty(res))
                    res += " ";

                if (!string.IsNullOrEmpty(this.LastName))
                    res += this.LastName;
                return res;
            }
        }


        [MaxLength(30)]
        public string Title { get; set; }

        [Display(Name = "Birth date")]
        public DateTime? BirthDate { get; set; }

        public DateTime? HireDate { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public string PostalCode { get; set; }

        [EqListValueEditor]
        public string Country { get; set; }

        [MaxLength(24)]
        public string HomePhone { get; set; }

        [MaxLength(4)]
        public string Extension { get; set; }

        [ScaffoldColumn(false)]
        public byte[] Photo { get; set; }

        public string Notes { get; set; }

        [ScaffoldColumn(false)]
        public int? ReportsTo { get; set; }

        public Employee Manager { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

    }


}