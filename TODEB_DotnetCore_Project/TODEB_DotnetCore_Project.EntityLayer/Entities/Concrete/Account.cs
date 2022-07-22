﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TODEB_DotnetCore_Project.EntityLayer.Entities.Interface;
using TODEB_DotnetCore_Project.EntityLayer.Enums;

namespace TODEB_DotnetCore_Project.EntityLayer.Entities.Concrete
{
    public class Account : IBaseEntity
    {
        [Key] // We set id as the primary key.
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  // We set it as identity key and auto id value will be increased by 1.
        public int Id { get; set; }
        public float Opening_Balance { get; set; }
        public int Sort_Code { get; set; }
        public string Account_number { get; set; }
        public bool IsActive { get; set; }
        public E_AccountType AccountType { get; set; }

        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate { get => _createDate; set => _createDate = value; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual List<Transaction> Transactions { get; set; }
        public virtual List<Loan> Loans { get; set; }
    }
}
