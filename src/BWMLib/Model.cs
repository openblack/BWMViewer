using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace ModelImporter
{
    #region Structs

    public struct LHPoint
    {
        public float X;
        public float Y;
        public float Z;

        public LHPoint(float x, float y, float z)
        {
            this.X = x; this.Y = y; this.Z = z;
        }
    }

    public struct MaterialDefinition
    {
        public string Texture;
        public string Lightmap;
        public string U3;
        public string SpecularMap;
        public string U5;
        public string U6;
        public string Type;
    }

    public struct MeshDescription
    {
        public int NumFaces;
        public int IndicesPointer;
        public int U1;
        public int NumMaterialRefs;
        public int U2;
        public int ID;
        public string Name;
        public MaterialRef[] MaterialRefs;
    }

    public struct MaterialRef
    {
        public int MaterialDef;
        public int IndicesPointer;
        public int IndicesSize;
        public int VertexPointer;
        public int VertexSize;
        public int FacesPointer;
        public int FacesSize;
        public int Unknown;
    }

    public struct Bone
    {

    }

    public struct Entity
    {
        public string Name;
        public float U1X;
        public float U1Y;
        public float U1Z;
        public float U2X;
        public float U2Y;
        public float U2Z;
        public float U3X;
        public float U3Y;
        public float U3Z;
        public float PosX;
        public float PosY;
        public float PosZ;
    }

    public struct Struct4
    {
        public float X;
        public float Y;
        public float Z;
    }

    public struct Struct5
    {
        public float X;
        public float Y;
        public float Z;
    }

    public struct Strides
    {

    }

    public struct Index
    {
        public short V1;
        public short V2;
        public short V3;
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct Vertex
    {
        [FieldOffset(0)]
        public float X;
        [FieldOffset(4)]
        public float Y;
        [FieldOffset(8)]
        public float Z;
        [FieldOffset(12)]
        public float NX;
        [FieldOffset(16)]
        public float NY;
        [FieldOffset(20)]
        public float NZ;
        [FieldOffset(24)]
        public float U;
        [FieldOffset(28)]
        public float V;
        [FieldOffset(32)]
        public float U1;
        [FieldOffset(36)]
        public float U2;
        [FieldOffset(40)]
        public float U3;
        [FieldOffset(44)]
        public float U4;
    }

    #endregion

    public class Model
    {
        #region Fields

        public MaterialDefinition[] MaterialDefinitions;
        public MeshDescription[] MeshDescriptions;
        public Bone[] Bones;
        public Entity[] Entities;
        public Struct4[] Scruct4s;
        public Struct5[] Scruct5s;
        public int[] Strides;
        public short[] Indices;
        public Vertex[][] Verticies;
        public LHPoint[] ModelCleave;

        #endregion
    }
}
