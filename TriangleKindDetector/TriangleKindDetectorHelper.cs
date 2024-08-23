namespace TriangleKindDetector;

public class TriangleKindDetectorHelper
{
    /// <summary>
    /// Related to cos of bigger angle.
    /// </summary>
    private const double EPS = 1.0e-10;

    /// <summary>
    /// Assume edges lengths are positive reals (not checked inside method to speedup).
    /// </summary>
    public static TriangleKind Detect(double edgeA, double edgeB, double edgeC)
    {
        // sort edges
        if (edgeB > edgeC) (edgeB, edgeC) = (edgeC, edgeB);
        if (edgeA > edgeB) (edgeA, edgeB) = (edgeB, edgeA);
        if (edgeB > edgeC) (edgeB, edgeC) = (edgeC, edgeB);

        // https://www.quora.com/What-is-the-method-for-determining-if-a-triangle-is-acute-or-obtuse
        // C^2 = A^2 + B^2 - 2*A*B*cos(theta)
        var cosTheta = (edgeA * edgeA + edgeB * edgeB - edgeC * edgeC) / (2 * edgeA * edgeB);

        if (cosTheta < -EPS) return TriangleKind.Obtuse;
        if (cosTheta >  EPS) return TriangleKind.Acute;
        return TriangleKind.Right;
    }
}
