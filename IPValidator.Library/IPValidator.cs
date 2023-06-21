using OutSystems.ExternalLibraries.SDK;
using NetTools;
using System.Net;

namespace AGV.IPValidator;

public class IPValidator : IIPValidator
{

    bool IIPValidator.isIPinRange(string ip, string ipRange)
    {        
        var range = IPAddressRange.Parse(ipRange);
        return range.Contains(IPAddress.Parse(ip));
    }
}
