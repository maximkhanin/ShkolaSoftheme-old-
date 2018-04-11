using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WcfRestServiceContracts
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        [WebGet(UriTemplate = "/ShowMessage?text={text}")]
        string ShowMessage(string text);
    }
}
