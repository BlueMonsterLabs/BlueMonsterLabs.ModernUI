using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Xml.Linq;
using System.Xml.XPath;

namespace BlueMonsterLabs.ModernUI
{
    /// <summary>
    /// Provides an attached property determining the current Bing image and assigning it to an image or imagebrush.
    /// </summary>
    public static class BingImage
    {
        /// <summary>
        /// Identifies the UseBingImage attached dependency property.
        /// </summary>
        public static readonly DependencyProperty UseBingImageProperty = DependencyProperty.RegisterAttached("UseBingImage", typeof(bool), typeof(BingImage), new PropertyMetadata(OnUseBingImageChanged));

        private static BitmapImage cachedBingImage;

        private static async void OnUseBingImageChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            var newValue = (bool)e.NewValue;
            var image = o as Image;
            var imageBrush = o as ImageBrush;

            if (!newValue || (image == null && imageBrush == null)) {
                return;
            }

            if (cachedBingImage == null) {
                var url = await GetCurrentBingImageUrl();
                if (url != null) {
                    cachedBingImage = new BitmapImage(url);
                }
            }

            if (cachedBingImage != null){
                if (image != null) {
                    image.Source = cachedBingImage;
                }
                else if (imageBrush != null) {
                    imageBrush.ImageSource = cachedBingImage;
                }
            }
        }

        private static async Task<Uri> GetCurrentBingImageUrl()
        {
            var client = new HttpClient();
            var result = await client.GetAsync("http://www.bing.com/hpimagearchive.aspx?format=xml&idx=0&n=2&mbl=1&mkt=en-ww");
            if (result.IsSuccessStatusCode) {
                using (var stream = await result.Content.ReadAsStreamAsync()) {
                    var doc = XDocument.Load(stream);

                    var url = (string)doc.XPathSelectElement("/images/image/url");

                    return new Uri(string.Format(CultureInfo.InvariantCulture, "http://bing.com{0}", url), UriKind.Absolute);
                }
            }

            return null;
        }

        /// <summary>
        /// Gets the value of the UseBingImage attached property for the specified dependency object.
        /// </summary>
        /// <param name="o">The dependency object to query.</param>
        /// <returns><c>true</c> if the Bing image should be used; otherwise, <c>false</c>.</returns>
        public static bool GetUseBingImage(DependencyObject o)
        {
            return (bool)o.GetValue(UseBingImageProperty);
        }

        /// <summary>
        /// Sets the value of the UseBingImage attached property for the specified dependency object.
        /// </summary>
        /// <param name="o">The dependency object to update.</param>
        /// <param name="value"><c>true</c> to use the Bing image; otherwise, <c>false</c>.</param>
        public static void SetUseBingImage(DependencyObject o, bool value)
        {
            o.SetValue(UseBingImageProperty, value);
        }
    }
}
