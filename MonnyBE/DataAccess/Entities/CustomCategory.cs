using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entities
{
    public class CustomCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public int UserId { get; set; }
        public User User { get; set; }
        public List<Expense> Expenses { get; set; }
    }
}
