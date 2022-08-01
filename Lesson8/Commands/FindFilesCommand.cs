using FileManager.Commands.Base;

namespace FileManager.Commands;

public class FindFilesCommand : FileManagerCommand
{
    private readonly IUserInterface _UserInterface;
    private readonly FileManagerLogic _FileManager;

    public override string Description => "Поиск файла/файлов";

    public FindFilesCommand(IUserInterface UserInterface, FileManagerLogic FileManager)
    {
        _UserInterface = UserInterface;
        _FileManager = FileManager;
    }

    public override void Execute(string[] args)
    {
        var existCatalog = args[1];
        var findFiles = args[2];

        DirectoryInfo? directory;

        if (args.Length != 3 || string.IsNullOrWhiteSpace(args[1]) || string.IsNullOrWhiteSpace(args[2]))
        {
            _UserInterface.WriteLine("Для команды поиска файла/файлов необходимо указать два параметра - существующий каталог и искомое значение");
            return;
        }

        if (!Path.IsPathRooted(existCatalog))
            existCatalog = Path.Combine(_FileManager.CurrentDirectory.FullName, existCatalog);

        directory = new DirectoryInfo(existCatalog);

        if (!directory.Exists)
        {
            _UserInterface.WriteLine($"Каталог не найден");
        }

        string[] ReultSearch = Directory.GetFiles(existCatalog, findFiles, SearchOption.AllDirectories);

        _UserInterface.WriteLine($"Найдено {ReultSearch.Length}");
    }
}

