namespace lab_8
{
    public class StackHandlerArgs
    {
        private string _message;
        private object _sender;
        
        public string Message => _message;
        public object Sender => _sender;

        public StackHandlerArgs(string message, object sender)
        {
            _message = message;
            _sender = sender;
        }
    }
}