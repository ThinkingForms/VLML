using CNTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VL.Lib.CNTK;

namespace VL.Lib.CNTK
{
    public class Variable<T>
    {
        public static Variable<T> Default 
            = new Variable<T>(Variable.PlaceholderVariable(NDShape.CreateNDShape(new int[] { 1 }), Axis.DefaultInputVariableDynamicAxes()));

        public readonly Variable InternalVar;

        public DataType DataType => InternalVar.DataType;

        public Variable(T value, DeviceDescriptor device)
        {
            InternalVar = Constant.Scalar<T>(value, device);
        }

        public Variable(Variable var)
        {
            InternalVar = var;
        }

        //public virtual T Fetch()
        //{
        //    Evaluator e;
        //    e.feck

        //    return default(T);
        //}

        public Function<T> ToFunction()
        {
            return new Function<T>(InternalVar);
        }

        public IList<IList<T>> GetDenseData(Value value)
        {
            return value.GetDenseData<T>(InternalVar);
        }

        public override string ToString()
        {
            return InternalVar.AsString();
        }
    }



    public class Function<T> : Variable<T>
    {
        public readonly Function InternalFunc;

        public Function(Function f)
            : base(TryConvertToVariable(f))
        {
            InternalFunc = f;
        }

        public Function(Function f, Variable<T> dummyForInferingDataType)
            : base(TryConvertToVariable(f))
        {
            InternalFunc = f;
        }

        static Variable TryConvertToVariable(Function f)

        {

            try

            {

                return f;

            }

            catch (Exception)

            {

                // ignore the error

                return null;

            }

        }



        public override string ToString()
        {
            // return InternalFunc.Inputs.LastOrDefault().ToString() + " -> " + InternalFunc.Output.ToString();
            return InternalFunc.AsString();
        }
    }
}
