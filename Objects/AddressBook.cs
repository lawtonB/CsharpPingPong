using System;
using System.Collections.Generic;

namespace Address.Objects
{
  public class Contact
  {
    private string _Name;
    private string _Address;
    private int _PhoneNumber;
    private int _Id;
    private List<Contact> _instances = new List<Contact> {};

    public Contact(string Name, string Address, int PhoneNumber)
    {
    _Name = Name;
    _Address = Address;
    _PhoneNumber = PhoneNumber;
    _Id = _instances.Count;
    _instances.Add(this);
    }
    public string GetName()
    {
      return _Name;
    }
    public void SetName(string Name)
    {
      _Name = Name;
    }
    public string GetAddress()
    {
      return _Address;
    }
    public void SetAddress(string Address)
    {
      _Address = Address;
    }
    public int GetPhoneNumber()
    {
      return _PhoneNumber;
    }
    public void SetPhoneNumber(int PhoneNumber)
    {
      _PhoneNumber = PhoneNumber;
    }
    public static List<Contact> GetAll()
    {
      return _instances;
    }
    public void Save();
    {
      _instances.Add(this);
    }
    public void Clear()
    {
      _instances.Clear();
    }
    public static Contact Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
