using System;

namespace Classes_M1_C;

public class Customer
{
  public string FirstName 
  { 
    get; 
    set
    {
        field = (string.IsNullOrWhiteSpace(value) is false ? value: throw new ArgumentException(nameof(value),"FirstName cannot be null or whitespace"));
    }
  } 
}
