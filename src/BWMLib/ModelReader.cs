using System;

namespace BWMLib
{
    public class ModelReader
    {
        private int v4;
        private int numMaterialDefinitions;
        private int numMeshDescriptions;
        private int numBones;
        private int numEnts;
        private int numSomething4;
        private int numSomething5;
        private int numVertex;
        private int numStrides;
        private int numIndices;

        private int ReadBoneReference(ContentReader reader, uint boneCount)
        {
            uint num = boneCount >= (uint)byte.MaxValue ? reader.ReadUInt32() : (uint)reader.ReadByte();
            if ((int)num != 0)
                return (int)num - 1;
            else
                return -1;
        }

        private void ReadMaterialDefinition()
        {

        }

        private void ReadMeshDescription()
        {

        }

        private void ReadHeader(ContentReader reader)
        {
            reader.ReadBytes(44);

            if (reader.ReadInt32() != 0x2B00B1E5) // hilarious Lionhead (y)
                throw new Exception("Bad Magic Number");

            v4 = reader.ReadInt32();
            if (v4 != 5 && v4 != 6)
                throw new Exception("Shit Shit Shit");

            reader.ReadInt32(); // header size, do we even need this!!

            reader.ReadBytes(68); // I don't know this.
            numMaterialDefinitions = reader.ReadInt32(); // 68
            numMeshDescriptions = reader.ReadInt32(); // 72
            numBones = reader.ReadInt32(); // 76
            numEnts = reader.ReadInt32(); // 80
            numSomething4 = reader.ReadInt32(); // 84
            numSomething5 = reader.ReadInt32(); // 88
            reader.ReadBytes(20);
            numVertex = reader.ReadInt32(); // 112
            numStrides = reader.ReadInt32(); // 116
            reader.ReadInt32(); // 120
            numIndices = reader.ReadInt32(); // 124
        }
    }
}
