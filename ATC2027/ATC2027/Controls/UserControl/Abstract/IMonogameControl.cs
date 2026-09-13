using ATC2027.Interfaces;

namespace ATC2027.Controls.UserControl.Abstract
{
    public interface IMonogameControl : IComponent
    {
        public bool IsActive();
        public bool IsVisible();
        public bool ShouldBeDrawn();
        public bool IsSelected();

    }
}
