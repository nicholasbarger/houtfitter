using System;
namespace Web.Models
{
    public class WebSocketMessage
    {
        public WebSocketMessage()
        {
        }

        public WebSocketMessage(string id)
        {
            this.Id = id;
        }

        public string Id { get; set; }
    }

    public class WebSocketMessage<T>
    {
        public WebSocketMessage()
        {
        }

        public WebSocketMessage(string id, T data)
        {
            this.Id = id;
            this.Data = data;
        }

        public string Id { get; set; }
        public T Data { get; set; }
    }
}
