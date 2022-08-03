using SameContentSameName;

namespace Core
{
    public partial class Use_SameContentSameName
    {
        [SameContentSameName] private string daemonClosedFileTyping_Gen_field = "private field text";
        [SameContentSameName] private int t = 1;
        [SameContentSameName] private int t1 = 1;
    }

    public class Use_Use_SameContentSameName
    {
        public void Test()
        {
            var daemonClosedFileTypingGenField = new Use_SameContentSameName().DaemonClosedFileTyping_Gen_field;
            var fakeFieldProp = new Use_SameContentSameName().FakeFieldProp;
        }
    }
}
