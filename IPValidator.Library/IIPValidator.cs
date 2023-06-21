using OutSystems.ExternalLibraries.SDK;

namespace AGV.IPValidator
{
    [OSInterface(
        Description = "Sample template action")]
    public interface IIPValidator
    {
        /// <summary>
        /// Sample ODC server action
        /// </summary>
        /// <param name="message">Any text that will</param>
        /// <returns>A text message including the message parameter</returns>

        [OSAction(
            Description = "Validates an IP address agains an IP Range",
            ReturnName = "EchoMessage",
            ReturnType = OSDataType.Boolean)]
        bool isIPinRange(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "IP address")]
            string ip,
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "IP address")]
            string ipRange);
    }
}