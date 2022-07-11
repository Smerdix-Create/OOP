namespace Lesson4.Building
{
    public class BuildingInfo
    {
        private static int numberBuilding = 1;
       
        public double Height { get; private set; }
       
        public int Floor { get; }
        
        /// <summary>Кол-во квартир на этаже</summary>
        public int Flats { get; }
        
        /// <summary>Кол-во подъездов в доме</summary>
        public int Entrance { get; }
        
        public int EntranceFlats { get; private set; }

        public int EntrancesFlats { get; private set; }

        public int Number { get; private set; }

        public BuildingInfo(int floor, int flats, int entrance)
        {
            Number = GetNumberBuilding();
            this.Floor = floor;
            this.Flats = flats;
            this.Entrance = entrance;
        }

        private static int GetNumberBuilding()
        {
            return numberBuilding++;
        }

        /// <summary>
        /// Получить высоту здания
        /// </summary>
        public void GetHeight()
        {
            Height = Floor * 2.9 + 1.5 + 2;
        }

        /// <summary>
        /// Получить кол-во квартир в 1 подъезде
        /// </summary>
        public void GetEntranceFlats()
        {
            EntranceFlats = Flats * Floor;
        }

        /// <summary>
        /// Получить кол-во квартир во всём доме
        /// </summary>
        public void GetEntrancesFlats()
        {
            EntrancesFlats = EntranceFlats * Entrance;
        }
    }
}
