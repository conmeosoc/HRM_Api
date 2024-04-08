using HumanResoureapi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResourceapi.DTOs.PersonnelContractDTO
{
    public class PersonnelContractCreationDTO
    {
        //public int ContractId { get; set; }

        //public int StaffId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int? TaxableSalary { get; set; }

        public int Salary { get; set; }

        public int? WorkDatePerWeek { get; set; }

        public string? Note { get; set; }

        public int? NoOfDependences { get; set; }

        public int ContractTypeId { get; set; }

        public string? SalaryType { get; set; }

        public string? ContractFile { get; set; }

        public DateTime? CreateAt { get; set; }

        public int? ResponseId { get; set; }

        public DateTime? ChangeAt { get; set; }

        public bool ContractStatus { get; set; }

        //public virtual ICollection<Allowance> Allowances { get; set; } = new List<Allowance>();

        //public virtual ContractType? ContractType { get; set; }

        //public virtual UserInfoDTO Staff { get; set; } = null!;

    }
}