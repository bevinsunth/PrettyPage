using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrettyPage.Entities.Models
{
    //Entity Model Goes Here 
    public class HomePage
    {
        public string IntroHeading { get; set; }
        public string IntroText { get; set; }
        public List<NavigationLink> NavigationLinks { get; set; }
        public List<CarousalImage> CarousalImages { get; set; }

    }

    public class CarousalImage
    {
        public string ImageUrl { get; set; }
        public string Text { get; set; }
    }

    public class NavigationLink
    {
        public string TargetUrl { get; set; }
        public string Text { get; set; }
    }
}
