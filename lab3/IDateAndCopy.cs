using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal interface IDateAndCopy
    {
        object DeepCopy();
        System.DateTime Date { get; init; }
    }
}