using Microsoft.AspNetCore.Components;

namespace Pacco.Web.Shared
{
    public class MenuComponent
    {
        private readonly IUriHelper _uriHelper;
        public CustomMenu RightMenu { get; } = new CustomMenu();
        public CustomMenu LeftMenu { get; } = new CustomMenu();

        public MenuComponent(IUriHelper uriHelper)
        {
            _uriHelper = uriHelper;
            InitRightMenu();
            InitLeftMenu();
        }

        private void InitRightMenu()
        {
            RightMenu.AddItem("sign-in", "Sign in");
            RightMenu.AddItem("sign-up", "Sign up");

            foreach (var item in RightMenu.Items)
            {
                if (_uriHelper.GetAbsoluteUri().Contains(item.Url))
                {
                    item.Activate();
                }
            }
        }

        private void InitLeftMenu()
        {
            LeftMenu.AddItem("orders", "Orders");
            LeftMenu.AddItem("parcels", "Parcels");

            foreach (var item in LeftMenu.Items)
            {
                if (_uriHelper.GetAbsoluteUri().Contains(item.Url))
                {
                    item.Activate();
                }
            }
        }

        public void SetActiveRightMenuItem(CustomMenuItem menuItem)
        {
            foreach (var item in RightMenu.Items)
            {
                menuItem.Deactivate();
            }

            menuItem.Activate();
        }
        
        public void SetActiveLeftMenuItem(CustomMenuItem menuItem)
        {
            foreach (var item in LeftMenu.Items)
            {
                menuItem.Deactivate();
            }

            menuItem.Activate();
        }
    }
}