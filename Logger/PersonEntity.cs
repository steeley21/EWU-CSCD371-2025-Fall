using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public abstract class PersonEntity : Entity
    {
        protected PersonEntity(FullName fullName)
        {
            FullName = fullName;
        }

        public FullName FullName { get; init; }

        protected string PersonDisplayName => FullName.ToString();
    }
}
