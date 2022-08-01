using FileManager.Commands.Base;

namespace FileManager.Commands;

public class CreateFileCommand : FileManagerCommand
{
    private readonly IUserInterface _UserInterface;
    private readonly FileManagerLogic _FileManager;

    public override string Description => "Создание файла";

    public CreateFileCommand(IUserInterface UserInterface, FileManagerLogic FileManager)
    {
        _UserInterface = UserInterface;
        _FileManager = FileManager;
    }

    public override void Execute(string[] args)
    {
        var dir_path = args[1];

        FileInfo? file;

        if (args.Length != 2 || string.IsNullOrWhiteSpace(args[1]))
        {
            _UserInterface.WriteLine("Для команды создания файла необходимо указать один параметр - целевой файл");
            return;
        }

        if (!Path.IsPathRooted(dir_path))
            dir_path = Path.Combine(_FileManager.CurrentDirectory.FullName, dir_path);

        file = new FileInfo(dir_path);

        if (!file.Exists)
        {
            file.Create();
            _UserInterface.WriteLine($"Файл создан");
        }
        else
        {
            _UserInterface.WriteLine("Файл уже существуют");
        }

    }
}
