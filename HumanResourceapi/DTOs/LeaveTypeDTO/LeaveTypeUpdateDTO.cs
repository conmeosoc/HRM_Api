using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResourceapi.DTOs.LeaveTypeDTO
{
    public class LeaveTypeUpdateDTO
    {
        public string? LeaveTypeName { get; set; }

        public string? LeaveTypeDetail { get; set; }

        public int? LeaveTypeMaxDay { get; set; }
    }
}