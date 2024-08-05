namespace Singleton.Database
{
    public class Database
    {
        private static Database _database;
        private static object _lock = new object();
        
        private Database() { }

        public static Database GetDatabase()
        {
            if(_database == null)
            {
                lock(_lock) {
                    if(_database == null) { _database = new Database(); }
                }
            }

            return _database;
        }
    }
}
