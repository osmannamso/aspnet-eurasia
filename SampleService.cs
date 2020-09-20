using System.Xml.Linq;
using eurasia.Models;

namespace eurasia
{
    public class SampleService : ISampleService
    {
        public string Test(string s)
        {
            return s;
        }

        public void XmlMethod(XElement xml)
        {
            throw new System.NotImplementedException();
        }

        public Review Review(Review review)
        {
            return review;
        }
    }
}