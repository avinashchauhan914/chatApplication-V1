using chatBoxApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chatBoxApi.Bussiness_Model
{
  public interface commonBusiness
  {
    public RegistrationModel SaveRegistration(RegistrationModel registrationModel);
  }
}
