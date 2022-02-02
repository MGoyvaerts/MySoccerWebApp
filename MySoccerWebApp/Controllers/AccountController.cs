using AutoMapper;
using MySoccerWebApp.Core.Dto.Users;
using MySoccerWebApp.Core.Entities;
using MySoccerWebApp.Core.ViewModels;
using MySoccerWebApp.Infrastructure.UnitOfWork;
using MySoccerWebApp.Interfaces.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MySoccerWebApp.Controllers
{
    public class AccountController : Controller
    {
        #region Properties
        private readonly IUserDomain _userDomain;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfwork;
        #endregion

        #region Constructors
        public AccountController(IUserDomain userDomain, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _userDomain = userDomain;
            _mapper = mapper;
            _unitOfwork = unitOfWork;
        }
        #endregion

        #region Public Methods
        public ActionResult Index()
        {
            return View();
        }

        [Route("Account/Login")]
        public ActionResult Login()
        {
            return View("Login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginUserDto userDto)
        {
            if (ModelState.IsValid)
            {
                var valid = _userDomain.ValidateUser(userDto.Email, userDto.Password);

                if (valid)
                {
                    var user = _userDomain.GetUserByEmail(userDto.Email);
                    _userDomain.UpdateUserLoginStatus(user);
                    _unitOfwork.Commit();

                    Session["Email"] = user.Email;
                    Session["Name"] = user.Firstname;

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError(nameof(LoginUserDto.ValidLogin), "E-mailadres en wachtwoord komen niet overeen");

                    return View("Login", userDto);
                }
            }
            else
            {
                return View("Login", userDto);
            }
        }

        [Route("Account/Register")]
        public ActionResult Register()
        {
            return View("Register");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterUserDto userDto)
        {
            if (ModelState.IsValid)
            {
                var user = _userDomain.GetUserByEmail(userDto.Email);

                if (user == null && userDto.Password == userDto.PasswordConfirmation)
                {
                    user = _mapper.Map<RegisterUserDto, User>(userDto);
                    try
                    {
                        _userDomain.CreateUser(user);
                        _unitOfwork.Commit();
                    }
                    catch (Exception ex)
                    {
                        //return Json(new { ok = false, message = ex.Message });
                    }
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    if (user != null)
                    {
                        ModelState.AddModelError(nameof(RegisterUserDto.Email), Resources.Content.EmailAddressAlreadyExistsErrorMessage);
                    }
                    if (userDto.Password != userDto.PasswordConfirmation)
                    {
                        ModelState.AddModelError(nameof(RegisterUserDto.PasswordConfirmation), Resources.Content.PasswordsDoNotMatchErrorMessage);
                    }
                    return View("Register", userDto);
                }
            }
            return View("Register", userDto);
        }

        public ActionResult Logout()
        {
            var user = _userDomain.GetUserByEmail(Session["Email"].ToString());
            _userDomain.UpdateUserLoginStatus(user);
            Session.Abandon();

            return RedirectToAction("Index", "Home");
        }
        #endregion
    }
}