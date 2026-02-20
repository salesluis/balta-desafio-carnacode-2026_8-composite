using DesignPatternChallenge.Contracts;

namespace DesignPatternChallenge.Entities;

public class MenuItem(string title, string icon, string path) 
    : MenuGroupItem(title, icon, path)
{
    private readonly string _path = path;
    private readonly bool _isActive = true;
    public override void RenderMenu(int indent = 0)
    {
        var indentation = new string(' ', indent * 2);
        var activeStatus = _isActive ? "✓" : "✗";
        Console.WriteLine($"{indentation}[{activeStatus}] {Icon} {Title} → {_path}");
    }

    public override int CountItems() => 1;
}