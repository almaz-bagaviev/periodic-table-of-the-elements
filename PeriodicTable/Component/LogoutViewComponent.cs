namespace WebClients.Component;

public class LogoutViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }

    //Примечание. Имя метода должен быть именно Invoke(), не Default
}
