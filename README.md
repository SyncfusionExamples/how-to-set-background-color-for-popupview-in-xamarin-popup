# how-to-set-background-color-for-popupview-in-xamarin-popup
The sample demonstartes how to set background color for the popview. 

```
        SfPopupLayout popupLayout;
        DataTemplate dataTemplate;
        public MainPage()
        {
            InitializeComponent();
            this.popupLayout = new SfPopupLayout();
            this.dataTemplate = new DataTemplate(() =>
            {
                Label label = new Label();
                label.Text = "Syncfusion";
                label.BackgroundColor = Color.Transparent;
                return label;
            });

            this.popupLayout.PopupView.HeaderTitle = "Company name";
            this.popupLayout.PopupView.ContentTemplate = dataTemplate;

            //// You can customize your color based on the requirement.
            this.popupLayout.PopupView.BackgroundColor = Color.LightBlue;
            this.clickToShowPopup.Clicked += ClickToShowPopup_Clicked;
        }

        private void ClickToShowPopup_Clicked(object sender, EventArgs e)
        {
            //// Opens SfPopupLayout.
            this.popupLayout.Show();
        }
```

## Requirements to run the demo
* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/)
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).
