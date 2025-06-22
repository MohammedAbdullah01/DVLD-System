using DVLDBusinessLayer.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusinessLayer.Interface
{
    public interface IValidator <T>
    {
        ValidationResult Validate(T entity);
    }
}
