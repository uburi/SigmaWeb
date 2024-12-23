using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Utils
{
    public class ReturnTable<T> where T : class
    {
        public ReturnTable()
        {
            List = new List<T>();
        }

        public ReturnTable(int totalRegister, int totalRegisterFilter)
        {
            TotalRegister = totalRegister;
            TotalRegisterFilter = totalRegisterFilter;
            List = new List<T>();
        }

        public int TotalRegister { get; set; }

        public int TotalRegisterFilter { get; set; }

        public IEnumerable<T> List { get; set; }
    }
}
