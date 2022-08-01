using FileManager.Commands.Base;

namespace FileManager.Commands;

public class InfoFileCommand : FileManagerCommand
{
    private readonly IUserInterface _UserInterface;
    private readonly FileManagerLogic _FileManager;
    public override string Description => "Информация о файле";

    public InfoFileCommand(IUserInterface UserInterface, FileManagerLogic FileManager)
    {
        _UserInterface = UserInterface;
        _FileManager = FileManager;
    }
    public override void Execute(string[] args)
    {
        var dir_path = args[1];
        string[] textMass;

        FileInfo? file;

        if (args.Length != 2 || string.IsNullOrWhiteSpace(args[1]))
        {
            _UserInterface.WriteLine("Для данной команды необходимо указать один параметр - целевой файл");
            return;
        }

        if (!Path.IsPathRooted(dir_path))
            dir_path = Path.Combine(_FileManager.CurrentDirectory.FullName, dir_path);

        file = new FileInfo(dir_path);


        if (!file.Exists)
        {        
            _UserInterface.WriteLine($"Файл не найден");
            return;
        }

        var streamReader = new StreamReader(dir_path);
        string readAll = streamReader.ReadToEnd();
        textMass = readAll.Split(' ');
        _UserInterface.WriteLine($"Количество слов: {textMass.Length}");
        streamReader.Close();
        
    }

}

