using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Properties4U
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Users : ContentPage
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Button_onClicked(Object sender, EventsArgs e)
        {
            var request = new HttpRequestMessage();
            request.RequestUri = new Uri("http://localhost:7896/api/Developments");
            request.Method = HttpMethod.Get;
            request.Headers.Add("Accept", "application/json");
            HttpResponsMessage response = await client.SendAsync(request);
            if (response.StatusCode == HttpStatusCode.Ok) { }
            HttpContent content = response.Content;
            var json = await content.ReadAsStringAsync();
        }
        private void Button_onClicked(Object sender, EventsArgs e)
        {

        }
    }
}