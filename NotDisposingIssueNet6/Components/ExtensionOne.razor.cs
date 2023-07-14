namespace NotDisposingIssueNet6.Components
{
	public partial class ExtensionOne : IDisposable
	{
		public const string PiralExtensionName = "ExtensionOne";

		public void Dispose()
		{
			Console.WriteLine("Disposing Extension One");
		}

	}
}
