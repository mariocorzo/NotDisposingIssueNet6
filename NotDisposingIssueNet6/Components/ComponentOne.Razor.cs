using System.Diagnostics;

namespace NotDisposingIssueNet6.Components
{
    public partial class ComponentOne : IDisposable
    {

        public void Dispose()
        {
			Console.WriteLine("Disposing Component One");
        }
    }
}
