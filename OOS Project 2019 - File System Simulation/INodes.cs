namespace OperatingSystemsProject2019
{
    class IFileNode
    {
        readonly FileMetadata metadata;
        public string CurrentDir { get; set; }
        public int CurrentBlockCount { get; set; }
        public static int MaxBlockCount { get { return 10; } }
        public int FileSize { get; set; }
        public int[,] ptrMatrix; //first row: block addresses; second row: block sizes (respectively)
        public IFileNode()
        {
            metadata = new FileMetadata();
            metadata.Name = metadata.Owner = metadata.CreationTime = CurrentDir = null;
            CurrentBlockCount = FileSize = 0;
            ptrMatrix = new int[MaxBlockCount, MaxBlockCount];
        }
    }
    class IDirNode
    {
        public int OrdinalNumber { get; set; }
        public int IDNumber { get; set; }
        public int FileCount { get; set; }
        public int DirCount { get; set; }
        public int[] iFileArray;
        public int[] iSubDirArray;
        public string Name { get; set; }
        public string Parent { get; set; }
        public IDirNode()
        {
            OrdinalNumber = IDNumber = FileCount = DirCount = 0;
            Name = Parent = null;
            iFileArray = new int[16];
            iSubDirArray = new int[8];
        }
    }
    class FileMetadata
    {
        public string Name { get; set; }
        public string Owner { get; set; }
        public string CreationTime { get; set; }
    }
}