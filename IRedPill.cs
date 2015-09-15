using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServices
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [ServiceContract(Namespace = Constants.Namespace)]
    public interface IRedPill
    {
        [OperationContract()]
        Guid WhatIsYourToken();

        [OperationContractAttribute()]
        [FaultContractAttribute(typeof(System.ArgumentOutOfRangeException), Name = "ArgumentOutOfRangeException", Namespace = "http://schemas.datacontract.org/2004/07/System")]
        long FibonacciNumber(long n);

        [OperationContractAttribute()]
        TriangleType WhatShapeIsThis(int a, int b, int c);

        [OperationContractAttribute()]
        [FaultContractAttribute(typeof(System.ArgumentNullException), Name = "ArgumentNullException", Namespace = "http://schemas.datacontract.org/2004/07/System")]
        string ReverseWords(string s);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace = Constants.Namespace)]
    public enum TriangleType : int
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Error = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Equilateral = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Isosceles = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Scalene = 3,
    }

    public class Constants
    {
        public const string Namespace = "http://KnockKnock.readify.net";
    }
}
