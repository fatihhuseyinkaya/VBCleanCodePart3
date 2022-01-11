using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public interface IMessage
    {
        string From { get; set; }
        string To { get; set; }
        string Subject { get; set; }
        public string Body { get; set; }
        
       
       
    }

    public interface IVideoMessage : IMessage
    {
        int VideoDuration { get; set; }
        string VideoFormat { get; set; }
    }

    public interface IPictureMessage : IMessage
    {
        string ImageFormat { get; set; }
        int ImageSize { get; set; }
    }

    public interface IAudioMessage: IMessage
    {
        int AudioDuration { get; set; }
    }
}
