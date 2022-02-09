using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace nombremagique.Views
{
    public partial class StarsView : ContentView
    {
        public StarsView()
        {
            InitializeComponent();
            #pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
            InfiniteRotation(star1, 5000);
            InfiniteRotation(star2, 7000);
            InfiniteRotation(star3, 9000);
            #pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed

        }

        private async Task InfiniteRotation(View view, uint length)
        {
            bool always = true;
            while (always)
            {
                await view.RotateTo(360, length);
                view.Rotation = 0;
            }
        }
    }
}
