using System;
using System.IO;

namespace BWMLib
{
    class ContentReader : BinaryReader
    {
        public ContentReader(Stream input) : base(input) { }

        public void ReadMatrix()
        {

        }

        public void ReadVector2()
        {

        }

        public void ReadVector3()
        {

        }

        public void ReadVector4()
        {

        }

        public string ReadNullTerminatedString(int bufferSize)
        {
            return "";
        }
    }
}
