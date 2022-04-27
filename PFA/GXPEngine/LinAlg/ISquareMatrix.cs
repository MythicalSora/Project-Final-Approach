namespace NeoGXP.GXPEngine.LinAlg
{
    public interface ISquareMatrix : IMatrix
    {
         public ISquareMatrix UnitMatrix();

         public float Trace();
         public float Determinant();
         public float[] EigenValues();
         public IVec[] EigenVectors();
         public IMatrix Inverse();
         public bool IsDiagonal();
         public bool IsTriangular();
         public bool IsSymmetric();
         public bool IsOrthogonal();
    }
}