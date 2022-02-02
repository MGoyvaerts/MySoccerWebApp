using AutoMapper;
using MySoccerWebApp.Core.Dto.Clubs;
using MySoccerWebApp.Core.Dto.Users;
using MySoccerWebApp.Core.Entities;
using MySoccerWebApp.Core.ViewModels;
using MySoccerWebApp.Infrastructure.UnitOfWork;
using MySoccerWebApp.Interfaces.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MySoccerWebApp.Controllers
{
    public class HomeController : Controller
    {
        #region Properties
        private readonly IClubDomain _clubDomain;
        private readonly IUserDomain _userDomain;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfwork;
        #endregion

        #region Constructor
        public HomeController(IClubDomain clubDomain, IUserDomain userDomain, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _clubDomain = clubDomain;
            _userDomain = userDomain;
            _mapper = mapper;
            _unitOfwork = unitOfWork;
        }
        #endregion

        #region Methods

        [HttpGet]
        [Route("Home")]
        public ActionResult Index()
        {
            var model = new HomeViewModel();

            if (string.IsNullOrEmpty((string)Session["Email"]) && string.IsNullOrEmpty((string)Session["Name"]))
            {
                var clubs = _clubDomain.GetAllClubs().ToList();

                List<ClubDto> clubDtos = _mapper.Map<List<Club>, List<ClubDto>>(clubs)
                    .OrderByDescending(x => x.TotalPoints)
                    .ThenByDescending(x => x.GoalsDifference).ToList();

                model.Clubs = clubDtos;
            }
            else
            {
                var user = _userDomain.GetUserByEmail(Session["Email"].ToString());
                model.User = _mapper.Map<User, UserDto>(user);
            }

            return View(model);
        }

        
        public ActionResult Header()
        {
            return PartialView("~/Views/Shared/_Header.cshtml");
        }

        
        public ActionResult Footer()
        {
            return PartialView("~/Views/Shared/_Footer.cshtml");
        }
        #endregion
    }
}