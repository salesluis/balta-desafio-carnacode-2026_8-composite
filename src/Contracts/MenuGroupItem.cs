namespace DesignPatternChallenge.Contracts;

public abstract class MenuGroupItem
{
    public string Title { get; private set; }
    public string Icon { get; private set; }
    public string Path { get; private set; }
    protected MenuGroupItem(string title, string icon,  string path)
    {
        Title = title;
        Icon = icon;
        Path = path;
    }
    
    public abstract void RenderMenu(int indent = 0);
    public abstract int CountItems();
}