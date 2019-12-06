using chatBoxApi.Bussiness_Model;
using chatBoxApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chatBoxApi.Repository
{
  public class commonRepository: commonBusiness
  {

    public RegistrationModel SaveRegistration(RegistrationModel registrationModel)
    {

      return registrationModel;
    }

  }
}
