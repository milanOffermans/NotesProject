namespace Notes.Core
{
    public interface IDataStore<T>
    {
        T Read();

        void Write(T content);
    }
}