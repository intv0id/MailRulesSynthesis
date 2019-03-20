namespace MailRules.Types
{
    public enum MailAction : byte
    {
        MoveTo,
        Delete,
        None
    }

    public struct Message
    {
        string mSender;
        string mReceiver;
        string mObject;
    }
}