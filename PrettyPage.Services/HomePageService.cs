using Nelibur.ObjectMapper;
using PrettyPage.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using HomePageEntity = PrettyPage.Entities.Models.HomePage;

namespace PrettyPage.Services
{
    public class HomePageService : IHomePageService
    {
        private IContentAccessRepository _contentAccessRepository;
        public HomePageService(IContentAccessRepository contentAccessRepository)
        {
            _contentAccessRepository = contentAccessRepository;
        }

        public HomePage GetContent()
        {

            HomePageEntity homePageEntity = _contentAccessRepository.GetHomePageData();


            return ConvertToPresentationData(homePageEntity);
        }

        private HomePage ConvertToPresentationData(HomePageEntity homePageEntity)
        {
            //Automapper or any transformation here

            TinyMapper.Bind<HomePageEntity, HomePage>();

            return TinyMapper.Map<HomePage>(homePageEntity);
        }
    }
}
