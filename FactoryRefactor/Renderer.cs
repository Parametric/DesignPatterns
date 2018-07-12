namespace FactoryRefactor
{
    public class Renderer
    {
        public string Draw(string operatingSystem)
        {
            IWidget button;
            if (operatingSystem.Equals("Linux"))
            {
                button = new LinuxButton();
            }
            else {
                button = new WindowsButton();
            }

            IWidget menu;
            if (button.GetType() == typeof(LinuxButton))
            {
                menu = new LinuxMenu();
            }
            else
            {
                menu = new WindowsMenu();
            }

            return button.Draw() + " & " + menu.Draw();
        }
    }
}
public interface IWidget
{
    string Draw();
}

public class LinuxButton : IWidget
{
    public string Draw()
    {
        return "Linux button";
    }
}
public class WindowsButton : IWidget
{
    public string Draw()
    {
        return "Windows button";
    }
}

public class LinuxMenu : IWidget
{
    public string Draw()
    {
        return "Linux menu";
    }
}

public class WindowsMenu : IWidget
{
    public string Draw()
    {
        return "Windows menu";
    }
}
