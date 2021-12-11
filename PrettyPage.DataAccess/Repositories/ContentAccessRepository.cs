using PrettyPage.Domain.Contracts;
using PrettyPage.Domain.Entities;
using System.Collections.Generic;

namespace PrettyPage.DataAccess.Repositories
{
    //Generally ORM context goes here
    public class ContentAccessRepository : IContentAccessRepository
    {
        public HomePage GetHomePageData()
        {
            List<CarousalImage> carosolImages = new List<CarousalImage>();
            carosolImages.Add(new CarousalImage { ImageUrl = "https://picsum.photos/id/1/200/300", Text = "Work Time" });
            carosolImages.Add(new CarousalImage { ImageUrl = "https://picsum.photos/id/2/200/300", Text = "Journal Time" });

            List<NavigationLink> navigationLinks = new List<NavigationLink>();
            navigationLinks.Add(new NavigationLink { TargetUrl = "/Home", Text = "Home" });
            navigationLinks.Add(new NavigationLink { TargetUrl = "/Pretty Stuff", Text = "Pretty Stuff" });
            navigationLinks.Add(new NavigationLink { TargetUrl = "/Pretty Cool Stuff", Text = "Cool Stuff" });

            return new HomePage()
            {
                CarousalImages = carosolImages,
                NavigationLinks = navigationLinks,
                IntroHeading = "Lorem Ipsum",
                IntroText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur id sapien dapibus, cursus odio et, pulvinar lorem. Cras arcu turpis, interdum non tortor in, dapibus venenatis mi. Sed libero justo, gravida a rutrum nec, accumsan vitae dui. Proin non enim consectetur dui rhoncus suscipit. Proin elementum commodo tellus at fringilla. Vivamus vehicula eros sed magna feugiat venenatis. Vestibulum aliquet neque tellus, non efficitur ex rutrum eu. Donec in luctus magna. Morbi a velit eu arcu accumsan molestie sit amet quis sem. Cras accumsan, ipsum pellentesque auctor commodo, elit libero luctus nulla, in faucibus mauris felis et arcu. Nam dictum nisi non volutpat sodales. Vestibulum felis nulla, elementum sed est vitae, elementum lobortis purus. Curabitur fermentum diam in feugiat bibendum. Vestibulum purus est, pulvinar id imperdiet vel, sodales vitae nunc."
            };
        }
    }
}
