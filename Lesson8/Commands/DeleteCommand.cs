using FileManager.Commands.Base;

namespace FileManager.Commands;

public class DeleteCommand : FileManagerCommand
{
    private readonly IUserInterface _UserInterface;
    private readonly FileManagerLogic _FileManager;

    public override string Description => "Удаление каталога/файла";

    public DeleteCommand(IUserInterface UserInterface, FileManagerLogic FileManager)
    {
        _UserInterface = UserInterface;
        _FileManager = FileManager;
    }

    public override void Execute(string[] args)
    {
        var dir_path = args[1];

        DirectoryInfo? directory;
        FileInfo? file;

        if (args.Length != 2 || string.IsNullOrWhiteSpace(args[1]))
        {
            _UserInterface.WriteLine("Для команды удаления каталога/файла необходимо указать один параметр - целевой каталог/файл");
            return;
        }

        if (!Path.IsPathRooted(dir_path))
            dir_path = Path.Combine(_FileManager.CurrentDirectory.FullName, dir_path);

        directory = new DirectoryInfo(dir_path);
        file = new FileInfo(dir_path);


        if (directory.Exists)
        {
            directory.Delete(true);
            _UserInterface.WriteLine($"Каталог удален");
            return;
        }
        if (file.Exists)
        {
            file.Delete();
            _UserInterface.WriteLine($"Файл удален");
            return;
        }
        else
        {
            _UserInterface.WriteLine("Не найден файл или каталог");
        }
    }
}

