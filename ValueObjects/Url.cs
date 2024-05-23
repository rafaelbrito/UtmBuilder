using System.Text.RegularExpressions;
using UtmBuilder.Core.Exceptions;

namespace UtmBuilder.Core.ValueObjects;

public class Url : ValueObject
{
    public string Address { get; }
    
    public Url(string address)
    {
        Address = address;
        InvalidUrlException.ThrowIfInvalid(address);
    }
}