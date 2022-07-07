using Lesson4.Building;

var list = new List<BuildingInfo>()
{
    new BuildingInfo(4, 4, 4),
    new BuildingInfo(5, 5, 5),
    new BuildingInfo(1, 2, 3)
};

foreach (var buildingInfo in list)
{
    buildingInfo.GetHeight();
    buildingInfo.GetEntranceFlats();
    buildingInfo.GetEntrancesFlats();
    Console.WriteLine($"Номер здания: {buildingInfo.Number}");
    Console.WriteLine($"Высота здания: {buildingInfo.Height} м.");
    Console.WriteLine($"Количество этажей: {buildingInfo.Floor}");
    Console.WriteLine($"Количество квартир на 1 этаже: {buildingInfo.Flats}");
    Console.WriteLine($"Количество подъездов в доме: {buildingInfo.Entrance}");
    Console.WriteLine($"Количество квартир в 1 подъезде: {buildingInfo.EntranceFlats}");
    Console.WriteLine($"Количество квартир во всём доме: {buildingInfo.EntrancesFlats}");
    Console.WriteLine();
}

Console.ReadKey(true);
