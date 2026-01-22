using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sotrudniktest.model
{
    public class User
    {
        public string FIO { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public string Position { get; set; }

        public override string ToString()
        {
            return $"{Login} - {FIO} ({Position})";
        }
    }
}
