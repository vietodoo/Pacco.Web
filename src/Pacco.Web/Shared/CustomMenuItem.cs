namespace Pacco.Web.Shared
{
    public class CustomMenuItem
    {
        public string Url { get; }
        public string Text { get; }
        public bool IsActive { get; private set; }
        public string CssClass { get; private set; } = "button is-light";

        public CustomMenuItem(string url, string text, bool isActive = false)
        {
            Url = url;
            Text = text;
            if (isActive)
            {
                Activate();
                return;
            }

            Deactivate();
        }

        public void Activate()
        {
            IsActive = true;
            CssClass = "button is-primary";
        }
        
        public void Deactivate()
        {
            IsActive = false;
            CssClass = "button is-light";
        }
    }
}