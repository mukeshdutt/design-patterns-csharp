namespace Singleton
{
    // This is simple and first version of singleton pattern
    public sealed class Logging
    {
        public static Logging logging = null;
        public string Name { get; set; }

        private Logging()
        {
        }

        public static Logging GetInstance()
        {
            if (logging == null)
                logging = new Logging();

            return logging;
        }
    }
}