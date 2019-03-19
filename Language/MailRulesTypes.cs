namespace MailRules.Types
{
    enum Action
    {
        MoveTo,
        Delete,
        None
    }

    struct Message
    {
        string mSender;
        string mReceiver;
        string mObject;
    }
}