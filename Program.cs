using DesignPatternChallenge.Entities;

Console.WriteLine("=== Sistema de Menus CMS ===\n");

var manager = new MenuManager();

// Item simples no nível raiz
manager.Add(new MenuItem("Home", "🏠", "/"));

// Grupo com itens
var productsMenu = new MenuGroup("Produtos", "📦", "");
productsMenu.Add(new MenuItem("Todos", "", "/produtos"));
productsMenu.Add(new MenuItem("Categorias", "","/categorias"));
productsMenu.Add(new MenuItem("Ofertas", "","/ofertas"));

// Subgrupo dentro de grupo
var clothingMenu = new MenuGroup("Roupas","👕", "");
clothingMenu.Add(new MenuItem("Camisetas", "","/roupas/camisetas"));
clothingMenu.Add(new MenuItem("Calças", "","/roupas/calcas"));
productsMenu.Add(clothingMenu);

manager.Add(productsMenu);

// Outro grupo
var adminMenu = new MenuGroup("Administração", "⚙️", "");
adminMenu.Add(new MenuItem("Usuários", "","/admin/usuarios"));
adminMenu.Add(new MenuItem("Configurações", "","/admin/config"));
manager.Add(adminMenu);

manager.RenderMenu();

Console.WriteLine($"\nTotal de itens no menu: {manager.CountItems()}");

// // Problema: Buscar item requer lógica especial para navegar hierarquia
// var item = manager.FindItemByUrl("/roupas/camisetas");
// if (item != null)
// {
//     Console.WriteLine($"\n✓ Item encontrado: {item.Title}");
// }
