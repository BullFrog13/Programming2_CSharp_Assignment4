namespace SwimLibrary
{
    public interface ISwimmersRepository
    {
        int Number { get; }

        void Add(Swimmer aSwimmer);
        Registrant GetByRegNum(uint regNumber);
        void Load(string fileName, string delimiter);
        void Save(string fileName, string delimiter);
    }
}