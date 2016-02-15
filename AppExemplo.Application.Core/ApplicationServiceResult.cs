using System.Collections.Generic;
using System.Linq;

namespace AppExemplo.Application.Core
{
    public class ApplicationServiceResult<TDataResult>
    {
        
        

        public ApplicationServiceResult(TDataResult dataResult)
        {
            DataResult = dataResult;
            Messages = new List<Message>();
        }
        public List<Message> Messages { get; }

        public TDataResult DataResult { get; }

        public bool Success
        {
            get { return Messages.All(m => m.Type != MessageType.Error); }
        }

        public void AddMessage(string msg)
        {
            AddMessage(new Message(msg));
        }
        public void AddMessage(Message msg)
        {
            Messages.Add(msg);
        }

    }
}
