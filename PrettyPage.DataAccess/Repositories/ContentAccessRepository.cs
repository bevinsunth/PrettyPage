using PrettyPage.Domain.Contracts;
using PrettyPage.Entities.Models;
using System.Collections.Generic;

namespace PrettyPage.DataAccess.Repositories
{
    //Generally ORM context goes here
    public class ContentAccessRepository : IContentAccessRepository
    {
        public HomePage GetHomePageData()
        {
            List<CarousalImage> carosolImages = new List<CarousalImage>();
            carosolImages.Add(new CarousalImage { ImageUrl = "https://picsum.photos/id/1/200/300", Text = "Image 1" });
            carosolImages.Add(new CarousalImage { ImageUrl = "https://picsum.photos/id/2/200/300", Text = "Image 2" });

            List<NavigationLink> navigationLinks = new List<NavigationLink>();
            navigationLinks.Add(new NavigationLink { TargetUrl = "/Link 1", Text = "Link 1" });
            navigationLinks.Add(new NavigationLink { TargetUrl = "/Link 2", Text = "Link 2" });

            return new HomePage()
            {
                CarousalImages = carosolImages,
                NavigationLinks = navigationLinks,
                IntroHeading = "Lorem Ipsum",
                IntroText = "Lorem Ipsum"
            };
        }
    }
}
