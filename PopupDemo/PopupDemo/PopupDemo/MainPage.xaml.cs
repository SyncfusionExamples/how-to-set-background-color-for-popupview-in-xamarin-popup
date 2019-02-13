using Syncfusion.XForms.PopupLayout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PopupDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Setting background color for popup view.

            //popupLayout.PopupView.ContentTemplate = new DataTemplate(() =>
            //{
            //    return new Label()
            //    {
            //        Text = "Popup content view",
            //        TextColor = Color.White,
            //        BackgroundColor = Color.Transparent
            //    };
            //});

            //popupLayout.PopupView.BackgroundColor = Color.DimGray;
        }

        private void isOpenButton_Clicked(object sender, EventArgs e)
        {
            //Displays the popup.
            popupLayout.Show();
        }
    }
}
