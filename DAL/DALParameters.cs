using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public struct DALParameters
    {
        /// <summary>
        /// The actual value to set.
        /// </summary>
        public object Value { get; private set; }
        /// <summary>
        /// The name of the parameter within the query whose value to set.
        /// </summary>
        public string ParameterName { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_value">The actual value to set.</param>
        /// <param name="_parameterName">The name of the parameter within the query whose value to set.</param>
        public DALParameters(object _value, string _parameterName)
        {
            Value = _value;
            ParameterName = _parameterName;
        }
    }
}
