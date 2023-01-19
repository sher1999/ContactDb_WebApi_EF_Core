using System.ComponentModel.DataAnnotations;
namespace Domain.Entities;

public class Contact
{
  public int Id{get;set;}
  [MaxLength(50)]
  public string Name{get;set;}
  [MaxLength(50)]
  public string Address{get;set;}
  public int Telephone{get;set;}
  
}
