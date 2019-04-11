using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNTK.VL.Helpers
{
    public class SetActivations
    {
        //public enum Activations
        //{
        //    None = 0, Hardmax, HardSigmoid, LeakyRelu, ReLU, SELU, Sigmoid, Softmax, Softplus, Tanh
        //}
        public enum Activations
        {
            None = 0, Relu, Sigmoid, Softmax, Tanh, Elu
        }
        public static int ActivationVal(Activations e)
        {
            return (int) e;
        }


    }
}
