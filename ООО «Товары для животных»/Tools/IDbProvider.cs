namespace ООО__Товары_для_животных_
{
    public interface IDbProvider //это сам интерфейс
    {
        void Authorization(string login, string pass);
    }
}