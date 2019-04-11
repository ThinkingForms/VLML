using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNTK.VL.Helpers
{
    public class SetMyInitializers
    {
        //public enum Activations
        //{
        //    None = 0, Hardmax, HardSigmoid, LeakyRelu, ReLU, SELU, Sigmoid, Softmax, Softplus, Tanh
        //}
        public enum Initializers
        {
            Constant = 0, GloroNormal, GloroUniform, HeNormal, HeUniform, Normal, RandomWithRank, TruncatedNormal, Uniform, Xavier
        }
        public static int IntilizerVal(Initializers e)
        {
            return (int) e;
        }


    }
}
