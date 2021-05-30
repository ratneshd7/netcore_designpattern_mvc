using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterDesignPattern
{
    public interface AbstractExpression
    {
        void Evaluate(Context context);
    }
}
