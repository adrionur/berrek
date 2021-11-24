using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    public ServiceResponse Add(ServiceRequest request)
    {
        ServiceResponse response = new ServiceResponse();
        response.Result = request.Number1 + request.Number2;
        response.IsSuccessful = true;
        return response;
    }
}
