using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDuplicateHandler
{
    public class DuplicateHandler<T>
    {
        public ICollection<T> RemoveDuplicates(ICollection<T> input)
        {
            return input.Distinct().ToList();
        }

    }
}
