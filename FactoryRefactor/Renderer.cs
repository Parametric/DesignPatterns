namespace FactoryRefactor
{
    public interface IWidgetFactory
    {
        IWidget CreateButton();
        IWidget CreateMenu();
    }

    public class FlatLinuxFactory : IWidgetFactory
    {
        public IWidget CreateButton()
        {
            return new FlatLinuxButton();
        }

        public IWidget CreateMenu()
        {
            return new FlatLinuxMenu();
        }
    }
    public class WindowsFactory : IWidgetFactory
    {
        public IWidget CreateButton()
        {
            return new WindowsButton();
        }

        public IWidget CreateMenu()
        {
            return new WindowsMenu();
        }
    }
    public class ChromeOsFactory : IWidgetFactory
    {
        public IWidget CreateButton()
        {
            return new ChromeOsButton();
        }

        public IWidget CreateMenu()
        {
            return new ChromeOsMenu();
        }
    }
    public class AndroidFactory : IWidgetFactory
    {
        public IWidget CreateButton()
        {
            return new AndroidButton();
        }

        public IWidget CreateMenu()
        {
            return new AndroidMenu();
        }
    }

    public class Renderer
    {
        public string Draw(IWidgetFactory factory)
        {
            IWidget button = factory.CreateButton();
            IWidget menu = factory.CreateMenu();
            return button.Draw() + " & " + menu.Draw();
        }

        //public string Draw(string operatingSystem)
        //{
        //    IWidget button;
        //    if (operatingSystem.Equals("FlatLinux"))
        //    {
        //        button = new FlatLinuxButton();
        //    }
        //    else if (operatingSystem.Equals("Windows")) 
        //    {
        //        button = new WindowsButton();
        //    }
        //    else
        //    {
        //        button = new ChromeOsButton();
        //    }

        //    IWidget menu;
        //    if (button.GetType() == typeof(FlatLinuxButton))
        //    {
        //        menu = new FlatLinuxMenu();
        //    }
        //    else if (button.GetType() == typeof(WindowsButton))
        //    {
        //        menu = new WindowsMenu();
        //    }
        //    else
        //    {
        //        menu = new ChromeOsMenu();
        //    }

        //    return button.Draw() + " & " + menu.Draw();
        //}
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
public class FlatLinuxButton : IWidget
{
    public string Draw()
    {
        return "FlatLinux button";
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

public class FlatLinuxMenu : IWidget
{
    public string Draw()
    {
        return "FlatLinux menu";
    }
}

public class ChromeOsButton : IWidget
{
    public string Draw()
    {
        return "ChromeOS button";
    }
}
public class ChromeOsMenu : IWidget
{
    public string Draw()
    {
        return "ChromeOS menu";
    }
}


public class AndroidButton : IWidget
{
    public string Draw()
    {
        return "Android button";
    }
}

public class AndroidMenu : IWidget
{
    public string Draw()
    {
        return "Android menu";
    }
}