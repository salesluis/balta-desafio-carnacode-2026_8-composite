using DesignPatternChallenge.Contracts;

namespace DesignPatternChallenge.Entities;

public class MenuGroup(string title, string icon,string path) 
    : MenuGroupItem(title, icon, path)
{
    private readonly List<MenuGroupItem> _children = new();
    private readonly bool _isActive = true;
    public void Add(MenuGroupItem item) => _children.Add(item);
    public void Remove(MenuGroupItem item) => _children.Remove(item);
    
    public override void RenderMenu(int indent = 0)
    {
        var indentation = new string(' ', indent * 2);
        var activeStatus = _isActive ? "✓" : "✗";
        Console.WriteLine($"{indentation}[{activeStatus}] {Icon} {Title} ▼");
        foreach (var item in _children)
        {
            item.RenderMenu(indent + 2);
        }
    }

    public override int CountItems() =>  _children.Sum(x => x.CountItems());
    
}