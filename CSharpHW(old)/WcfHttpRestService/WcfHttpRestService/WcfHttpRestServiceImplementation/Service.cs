using WcfRestServiceContracts;

namespace WcfHttpRestServiceImplementation
{
    public class Service: IService
    {
        public string ShowMessage(string text)
        {
            return "Text: " + text;
        }
    }
}
