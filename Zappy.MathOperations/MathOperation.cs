using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zappy.SharedInterface;
using Zappy.SharedInterface.Helper;

namespace Zappy.MathOperations
{
    public class MathOperation : TemplateAction
    {
       public enum Operation
        {
            Add,
            Sub,
            Mul,
            Div
        }
        [Category("Input")]
        public DynamicProperty<double> First_Value{ get; set; }
        [Category("Input")]
        public DynamicProperty<double> Second_Value { get; set; }

        [Category("Input")]
        public Operation MathOP { get; set; }
        [Category("Output")]
        public DynamicProperty<double> Result { get; set; }
        public override void Invoke(IZappyExecutionContext context, ZappyTaskActionInvoker actionInvoker)
        {
            if(MathOP == Operation.Add)
            {
                Result = First_Value + Second_Value;
            }
            else if(MathOP == Operation.Sub)
            {
                Result = First_Value - Second_Value;
            }
            else if(MathOP == Operation.Mul)
            {
                Result = First_Value * Second_Value;
            }
            else
            {
                Result = First_Value / Second_Value;
            }
        }

    }
}
