using System.Collections.Generic;

namespace Address.Objects
{
  public class Contact
  {
    private string _Name;
    private string _Address;
    private int _PhoneNumber;
    private int _Id;
    private static List<Contact> _instances = new List<Contact> {};

    public Contact(string Name, string Address, int PhoneNumber)
    {
    _Name = Name;
    _Address = Address;
    _PhoneNumber = PhoneNumber;
    _instances.Add(this);
    _Id = _instances.Count;
    }

    public string GetName()
    {
      return _Name;
    }

    public void SetName(string newName)
    {
      _Name = newName;
    }

    public string GetAddress()
    {
      return _Address;
    }

    public void SetAddress(string newAddress)
    {
      _Address = newAddress;
    }

    public int GetPhoneNumber()
    {
      return _PhoneNumber;
    }

    public void SetPhoneNumber(int newPhoneNumber)
    {
      _PhoneNumber = newPhoneNumber;
    }

    public static List<Contact> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Contact Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
