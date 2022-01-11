using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class TextMessage : IMessage
    {
        public string From { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string To { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Subject { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Body { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public class VideoMessage : IVideoMessage
    {
        public int VideoDuration { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string VideoFormat { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string From { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string To { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Subject { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Body { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }








}
