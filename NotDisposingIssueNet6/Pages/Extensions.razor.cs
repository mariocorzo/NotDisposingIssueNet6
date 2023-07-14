namespace NotDisposingIssueNet6.Pages
{
	public partial class Extensions
	{
		public bool ShowExtension;

		public void ShowExtensionButtonClicked()
		{
			Console.WriteLine("Button clicked!");
			ShowExtension = !ShowExtension;
		}

		public string GetShowExtensionButtonText()
		{
			return ShowExtension ? "Hide Extension" : "Show Extension";
		}
	}
}
