using System;

namespace SquishIt.Framework.Files
{
    public interface IFileWriter: IDisposable
    {
        void Write(string value);
        void WriteLine(string value);
    }
}