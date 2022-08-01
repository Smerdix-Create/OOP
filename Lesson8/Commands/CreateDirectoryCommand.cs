using FileManager.Commands.Base;

namespace FileManager.Commands;

public class CreateDirectoryCommand : FileManagerCommand
{
    private readonly IUserInterface _UserInterface;
    private readonly FileManagerLogic _FileManager;

    public override string Description => "Создание каталога";

    public CreateDirectoryCommand(IUserInterface UserInterface, FileManagerLogic FileManager)
    {
        _UserInterface = UserInterface;
        _FileManager = FileManager;
    }

    public override void Execute(string[] args)
    {
        var dir_path = args[1];

        DirectoryInfo? directory;

        if (args.Length != 2 || string.IsNullOrWhiteSpace(args[1]))
        {
            _UserInterface.WriteLine("Для команды создания каталога необходимо указать один параметр - целевой каталог");
            return;
        }

        if (!Path.IsPathRooted(dir_path))
            dir_path = Path.Combine(_FileManager.CurrentDirectory.FullName, dir_path);

        directory = new DirectoryInfo(dir_path);

        if (!directory.Exists)
        {
            directory.Create();
            _UserInterface.WriteLine($"Каталог создан");
        }      
        else
        {
            _UserInterface.WriteLine("Каталог уже существуют");
        }

    }
}

