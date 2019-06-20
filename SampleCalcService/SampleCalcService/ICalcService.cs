using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SampleCalcService
{
    [ServiceContract]
    public interface ICalcService
    {
        [OperationContract]
        int GetSum(int a, int b);

    }
}
