﻿namespace WebApplication5.Models
{
    namespace WebApplication1.Models
    {
        public class AddEmployeeRequest
        {
            public string Name { get; set; }
            public int CivilId { get; set; }
            public string Position { get; set; }
        }

        public class EmployeeResponse
        {
            public string Name { get; set; }
            public int CivilId { get; set; }
            public string Position { get; set; }
        }
    }
}