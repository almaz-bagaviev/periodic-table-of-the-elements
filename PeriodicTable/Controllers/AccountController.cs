namespace PeriodicTable.Controllers;

public class AccountController : Controller
{
    UserManager<ApplicationUser> userManager;
    SignInManager<ApplicationUser> signInManager;

    public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
    {
        this.userManager = userManager;
        this.signInManager = signInManager;
    }

    [HttpGet]
    public IActionResult Login(string returnUrl)
    {
        return View(new UserLogin()
        {
            ReturnUrl = returnUrl,
        });
    }

    [HttpPost, ValidateAntiForgeryToken /* Проверка токена от подделок*/ ]
    public async Task<IActionResult> Login(UserLogin model)
    {
        if (ModelState.IsValid)
        {
            Microsoft.AspNetCore.Identity.SignInResult loginResult = await signInManager.PasswordSignInAsync(
                userName: model.Login,
                password: model.Password,
                isPersistent: false,    //должен ли файл cookie для входа сохраняться после закрытия браузера
                lockoutOnFailure: false //аккаунт должен быть заблокирован, если войти не удалось
                );

            if (loginResult.Succeeded)
            {
                if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                {
                    return Redirect(model.ReturnUrl);
                }
            }
        }
        ModelState.AddModelError(key: "error", errorMessage: "Пользователь не найден!");
        return View(model);
    }

    public IActionResult Registration()
    {
        return View(new UserRegistration());
    }

    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> Registration(UserRegistration userRegistration)
    {
        if (ModelState.IsValid)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = new()
                {
                    UserName = userRegistration.Login
                };

                IdentityResult hasEntered = await this.userManager.CreateAsync(user, userRegistration.Password);
                /*С помощью метода userManager.SignInAsync пользователь добавляется в базу данных.
                В качестве параметра передается сам пользователь и его пароль.*/


                if (hasEntered.Succeeded)
                {
                    await signInManager.SignInAsync(user, false);

                    /*В случае удачного добавления с помощью метода signInManager.SignInAsync()
                    устанавливаем аутентификационные куки для добавленного пользователя.
                    В этот метод передается объект пользователя, который аутентифицируется,
                    и логическое значение, указывающее, надо ли сохранять куки в течение продолжительного времени.
                    И далее выполняем переадресацию на главную страницу приложения.*/

                    return Redirect2HomePage();
                }
                else
                {
                    foreach (var error in hasEntered.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
        }
        return View(userRegistration);
    }

    /// <summary>
    /// Окончание процесса авторизации, закрытие сессии
    /// </summary>
    /// <returns>View</returns>
    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> Logout()
    {
        await signInManager.SignOutAsync(); //out of the application
        return Redirect2HomePage();

        //await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        //return Redirect2HomePage();
    }

    public RedirectToActionResult Redirect2HomePage()
    {
        RedirectToActionResult redirect = RedirectToAction("Index", "Home");
        return redirect;
    }
}
