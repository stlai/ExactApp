namespace ConsoleApplication.Models
{
    // keep the Dropbox file information and content
    public struct FileContent
    {
        public string Subject { get; set; }
        public string FileName { get; set; }
        public byte[] Content { get; set; }
    }

}
