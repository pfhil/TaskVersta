namespace TaskVersta.Models.ViewModels
{
    public class WarningViewModel
    {
        public string? WarningText { get; set; }

        public bool ShowWarningText => !string.IsNullOrEmpty(WarningText);
    }
}
