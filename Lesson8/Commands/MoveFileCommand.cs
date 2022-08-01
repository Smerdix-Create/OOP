using FileManager.Commands.Base;

namespace FileManager.Commands;

public class MoveFileCommand : FileManagerCommand
{
    private readonly IUserInterface _UserInterface;
    private readonly FileManagerLogic _FileManager;

    public override string Description => "Перемещение/Переименование файла";

    public MoveFileCommand(IUserInterface UserInterface, FileManagerLogic FileManager)
    {
        _UserInterface = UserInterface;
        _FileManager = FileManager;
    }

    public override void Execute(string[] args)
    {
        var old_path = args[1];
        var new_path = args[2];

        FileInfo? file;

        if (args.Length != 3 || string.IsNullOrWhiteSpace(args[1]) || string.IsNullOrWhiteSpace(args[2]))
        {
            _UserInterface.WriteLine("Для команды перемещения/переименования файла необходимо указать два параметра - старый каталог файла (с именем файла) и существующий каталог файла (с именем файла)");
            return;
        }

        if (!Path.IsPathRooted(old_path))
            old_path = Path.Combine(_FileManager.CurrentDirectory.FullName, old_path);

        if (!Path.IsPathRooted(new_path))
            new_path = Path.Combine(_FileManager.CurrentDirectory.FullName, new_path);

        file = new FileInfo(old_path);

        if (!file.Exists)
        {
            _UserInterface.WriteLine($"Невозможно переместить несуществующий файл");
        }
        else
        {
            file.MoveTo(new_path);
        }
    }
}
