namespace ProjectM
{
    public enum SwitchPageMessageType
    {
        SignUp,
        SignIn,
        Shell,
    }

    public class SwitchPageMessage
    {
        public SwitchPageMessage(SwitchPageMessageType pageType)
        {
            PageType = pageType;
        }

        public SwitchPageMessageType PageType { get; }
    }
}
