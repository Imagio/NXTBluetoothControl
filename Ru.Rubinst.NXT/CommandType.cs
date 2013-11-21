namespace Ru.Rubinst.NXT
{
    public enum CommandType
    {
        DirectCommandWithReply = 0x00,
        SystemCommandWithReply = 0x01,
        DirectCommandWithoutReply = 0x80,
        SystemCommandWithoutReply = 0x81
    }
}
