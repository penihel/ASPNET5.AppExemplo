using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExemplo.Application.Core
{
    public class Message
    {
        public string Text { get; set; }
        public MessageType Type { get; set; }

        public Message(string text) : this(text, MessageType.Error)
        {

        }
        public Message(string text, MessageType type)
        {
            Text = text;
            Type = type;
        }
    }
}
