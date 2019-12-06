using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chatBoxApi.Models
{
  public class commonModel
  {
  }

  public class RegistrationModel
  {
    public string Name { get; set; }
    public string Email { get; set; }
    public int Mobile { get; set; }
    public string Address { get; set; }
    public StateModel State { get; set; }
    public CityModel City { get; set; }
    public int ZipCode { get; set; }
    public UserType UserType { get; set; }
}
  public class UserType
  {
    public string userTypeId { get; set; }
    public string userTypeName { get; set; }
}
  public class StateModel
  {
     public string StateId { get; set; }
     public string StateName { get; set; }
}
  public class CityModel
  {
    public string CityId { get; set;}
    public string CityName { get; set; }
  }
}
