namespace SingletonLibrary
{
    public sealed class PrintSpooler
    {
        private static PrintSpooler Instance;
        private Queue<string> queueFiles;

        private PrintSpooler()
        {
            queueFiles = new Queue<string>();
        }


        public static PrintSpooler GetPrintSpooler()
        {
            if(Instance == null)
                Instance = new PrintSpooler();
            return Instance;
        }

        public void Enqueue(string files)
        {
            queueFiles.Enqueue(files);
        }


        public void PrintALL()
        {
            foreach(string file in queueFiles) 
             Console.WriteLine(file); 
        }



    }
}