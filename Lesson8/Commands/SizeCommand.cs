using FileManager.Commands.Base;

namespace FileManager.Commands;

public class SizeCommand : FileManagerCommand
{
    private readonly IUserInterface _UserInterface;
    private readonly FileManagerLogic _FileManager;

    public override string Description => "Размер каталога/файла";

    public SizeCommand(IUserInterface UserInterface, FileManagerLogic FileManager)
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
            _UserInterface.WriteLine("Для команды размера каталога/файла необходимо указать один параметр - целевой каталог/файл");
            return;
        }

        if (!Path.IsPathRooted(dir_path))
            dir_path = Path.Combine(_FileManager.CurrentDirectory.FullName, dir_path);

        directory = new DirectoryInfo(dir_path);
        file = new FileInfo(dir_path);        

        if (directory.Exists)
        {
            _UserInterface.WriteLine($"Размер каталога: {DirSize(directory)} (в байтах)");
            return;
        }
        if (file.Exists)
        {
            _UserInterface.WriteLine($"Размер файла: {FileSize(file)} (в байтах)");
            return;
        }
        else
        {
            _UserInterface.WriteLine("Не найден файл или каталог");
        }

    }

    public static long FileSize(FileInfo f)
    {
        return f.Length;
    }


    public static long DirSize(DirectoryInfo d)
    {
        long size = 0;
        // Add file sizes.
        FileInfo[] fis = d.GetFiles();
        foreach (FileInfo fi in fis)
        {
            size += fi.Length;
        }
        // Add subdirectory sizes.
        DirectoryInfo[] dis = d.GetDirectories();
        foreach (DirectoryInfo di in dis)
        {
            size += DirSize(di);
        }
        return size;
    }

}


