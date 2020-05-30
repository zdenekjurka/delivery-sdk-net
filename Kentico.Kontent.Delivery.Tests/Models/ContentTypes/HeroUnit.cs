// This code was generated by a kontent-generators-net tool 
// (see https://github.com/Kentico/kontent-generators-net).
// 
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated. 
// For further modifications of the class, create a separate file with the partial class.

using System.Collections.Generic;
using Kentico.Kontent.Delivery.ContentItems;

namespace Kentico.Kontent.Delivery.Tests.Models.ContentTypes
{
    public class HeroUnit
    {
        public const string Codename = "hero_unit";
        public const string TitleCodename = "title";
        public const string ImageCodename = "image";
        public const string MarketingMessageCodename = "marketing_message";

        public string Title { get; set; }
        public IEnumerable<Asset> Image { get; set; }
        public string MarketingMessage { get; set; }
        public ContentItemSystemAttributes System { get; set; }
    }
}