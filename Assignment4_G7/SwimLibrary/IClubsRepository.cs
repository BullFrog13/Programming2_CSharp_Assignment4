namespace SwimLibrary
{
    public interface IClubsRepository
    {
        int Number { get; }

        void Add(Club aClub);
        Club GetByRegNum(uint regNumber);
        void Load(string fileName, string delimiter);
        void Save(string fileName, string delimiter);
    }
}