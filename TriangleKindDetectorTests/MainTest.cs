using TriangleKindDetector;

namespace TriangleKindDetectorTests;

public class MainTest
{
    [Test]
    public void TestRight()
    {
        var a = 3.0;
        var b = 4.0;
        var c = 5.0;
        
        Assert.AreEqual(TriangleKind.Right, TriangleKindDetectorHelper.Detect(a, b, c));
        Assert.AreEqual(TriangleKind.Right, TriangleKindDetectorHelper.Detect(a, c, b));
        Assert.AreEqual(TriangleKind.Right, TriangleKindDetectorHelper.Detect(b, a, c));
        Assert.AreEqual(TriangleKind.Right, TriangleKindDetectorHelper.Detect(b, c, a));
        Assert.AreEqual(TriangleKind.Right, TriangleKindDetectorHelper.Detect(c, a, b));
        Assert.AreEqual(TriangleKind.Right, TriangleKindDetectorHelper.Detect(c, b, a));
    }

    [Test]
    public void TestAcute()
    {
        var a = 3.0;
        var b = 4.0;
        var c = 4.5;
        
        Assert.AreEqual(TriangleKind.Acute, TriangleKindDetectorHelper.Detect(a, b, c));
        Assert.AreEqual(TriangleKind.Acute, TriangleKindDetectorHelper.Detect(a, c, b));
        Assert.AreEqual(TriangleKind.Acute, TriangleKindDetectorHelper.Detect(b, a, c));
        Assert.AreEqual(TriangleKind.Acute, TriangleKindDetectorHelper.Detect(b, c, a));
        Assert.AreEqual(TriangleKind.Acute, TriangleKindDetectorHelper.Detect(c, a, b));
        Assert.AreEqual(TriangleKind.Acute, TriangleKindDetectorHelper.Detect(c, b, a));
    }    
    
    [Test]
    public void TestObtuse()
    {
        var a = 3.0;
        var b = 4.0;
        var c = 6.0;
        
        Assert.AreEqual(TriangleKind.Obtuse, TriangleKindDetectorHelper.Detect(a, b, c));
        Assert.AreEqual(TriangleKind.Obtuse, TriangleKindDetectorHelper.Detect(a, c, b));
        Assert.AreEqual(TriangleKind.Obtuse, TriangleKindDetectorHelper.Detect(b, a, c));
        Assert.AreEqual(TriangleKind.Obtuse, TriangleKindDetectorHelper.Detect(b, c, a));
        Assert.AreEqual(TriangleKind.Obtuse, TriangleKindDetectorHelper.Detect(c, a, b));
        Assert.AreEqual(TriangleKind.Obtuse, TriangleKindDetectorHelper.Detect(c, b, a));
    }
}