using FileManager.Commands.Base;

namespace FileManager.Commands;

public class MoveDirectoryCommand : FileManagerCommand
{
    private readonly IUserInterface _UserInterface;
    private readonly FileManagerLogic _FileManager;

    public override string Description => "Перемещение/Переименование каталога";

    public MoveDirectoryCommand(IUserInterface UserInterface, FileManagerLogic FileManager)
    {
        _UserInterface = UserInterface;
        _FileManager = FileManager;
    }

    public override void Execute(string[] args)
    {
        var old_path = args[1];
        var new_path = args[2];

        DirectoryInfo? directory;

        if (args.Length != 3 || string.IsNullOrWhiteSpace(args[1]) || string.IsNullOrWhiteSpace(args[2]))
        {
            _UserInterface.WriteLine("Для команды перемещения/переименования каталога необходимо указать два параметра - старый каталог и несуществующий новый каталог");
            return;
        }

        if (!Path.IsPathRooted(old_path))
            old_path = Path.Combine(_FileManager.CurrentDirectory.FullName, old_path);

        if (!Path.IsPathRooted(new_path))
            new_path = Path.Combine(_FileManager.CurrentDirectory.FullName, new_path);

        directory = new DirectoryInfo(old_path);

        if (!directory.Exists)
        {
            _UserInterface.WriteLine($"Невозможно переместить несуществующий каталог");
        }
        else if (!Directory.Exists(new_path))
        {
            directory.MoveTo(new_path);
        }
        else
        {
            _UserInterface.WriteLine($"Новый каталог уже существует");
        }
    }
}
