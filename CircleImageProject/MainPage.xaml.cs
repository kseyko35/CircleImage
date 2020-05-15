using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageCircle.Forms.Plugin.Abstractions;
using Xamarin.Forms;

namespace CircleImageProject
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {

            Title = "XamarinCircleImage";
            var layout = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children = {
                    new Label {
                        HorizontalTextAlignment = TextAlignment.Center,
                        Text = "Welcome to my Circle Image example project!"
                    },
                    new CircleImage  // I used Xam.Plugins.Forms.ImageCircle plugin. Dont forget add specific init for mobile devices.
                    {
                        BorderColor = Color.Red,
                        BorderThickness = 5,
                        HeightRequest = 150,
                        WidthRequest = 150,
                        Aspect = Aspect.AspectFill,
                        HorizontalOptions = LayoutOptions.Center,
                        Source = UriImageSource.FromUri(new Uri("https://media-exp1.licdn.com/dms/image/C5603AQG7hbLbPS_haQ/profile-displayphoto-shrink_400_400/0?e=1594857600&v=beta&t=KKmuIFBDdQ58z8NDx0bOVEEjM2pBsXEE5aqpRlObH6w"))
                    },
                     new Label {
                        HorizontalTextAlignment = TextAlignment.Center,
                        Text = "This circle image is created with frame"
                    },
                    new Frame // We can create circle image with Frame
                    {
                        CornerRadius = 100,
                        Padding = 0,
                        HeightRequest = 150,
                        WidthRequest = 150,
                        HorizontalOptions = LayoutOptions.Center,
                        IsClippedToBounds = true,
                        Content = new Image
                        {
                            Source = "https://media-exp1.licdn.com/dms/image/C5603AQG7hbLbPS_haQ/profile-displayphoto-shrink_400_400/0?e=1594857600&v=beta&t=KKmuIFBDdQ58z8NDx0bOVEEjM2pBsXEE5aqpRlObH6w",
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.Center
                        }
                    }
                    
                }
           
            };
            Button mButton = new Button
            {
                Text = "Go for Xaml example",
                HorizontalOptions = LayoutOptions.Center,
               
            };
            layout.Children.Add(mButton);
            mButton.Clicked  += async (sender, args) => await Navigation.PushModalAsync(new SecondPage());
        
            Content = layout;
            
        }

        
    }
}
