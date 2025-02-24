using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskCoreHub.Core.ValueObjects
{
    public class Effort
    {
        public int Value { get; private set; }

        public Effort(int value)
        {
            if (value < 0) throw new ArgumentException("Effort cannot be negative.");
            Value = value;
        }

        public static implicit operator int(Effort effort) => effort.Value;
    }
}
