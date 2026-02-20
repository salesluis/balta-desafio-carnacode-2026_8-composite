using DesignPatternChallenge.Contracts;

namespace DesignPatternChallenge.Entities;

public class MenuManager()
{
    private readonly List<MenuGroupItem> _children = new();
    
    public void Add(MenuGroupItem item) => _children.Add(item);
    public void Remove(MenuGroupItem item) => _children.Remove(item);
    public void RenderMenu(int indent = 0)
    {
        foreach (var item in _children)
            item.RenderMenu();
    }

    public int CountItems() 
        =>  _children.Sum(x => x.CountItems());

    public MenuGroupItem? FindItemByUrl(string path)
    {
        var item = _children.Find(x => x.Path == path);
        return item;
    }
}