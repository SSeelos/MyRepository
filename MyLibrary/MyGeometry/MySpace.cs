

#region Space

public interface IX
{
    double GetX();
}
public interface IY
{
    double GetY();
}
public interface IZ
{
    double GetZ();
}
public abstract class Space2D : IX, IY
{
    public double X { get; protected set; }
    public double Y { get; protected set; }
    protected Space2D()
    {
    }
    protected Space2D(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double GetX()
    {
        return this.X;
    }

    public double GetY()
    {
        return this.Y;
    }
}
public abstract class SpaceXZ
{
    public double X;
    public double Z;
    protected SpaceXZ()
    {
    }
    protected SpaceXZ(double x, double z)
    {
        X = x;
        Z = z;
    }
}
public abstract class SpaceYZ
{
    public double Y;
    public double Z;
    protected SpaceYZ()
    {
    }
    protected SpaceYZ(double y, double z)
    {
        Y = y;
        Z = z;
    }
}
public abstract class Space3D : Space2D, IZ
{
    public double Z;

    public Space2D XY => Get2D();
    public SpaceXZ XZ => GetXZ();
    public SpaceYZ YZ => GetYZ();
    protected Space3D()
    {
    }

    protected Space3D(double x, double y, double z)
        : base(x, y)
    {
        Z = z;
    }

    public double GetZ()
    {
        return this.Z;
    }

    public void SetXYZ(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    protected abstract Space2D Get2D();
    protected abstract SpaceXZ GetXZ();
    protected abstract SpaceYZ GetYZ();

    public override string ToString()
    {
        return $"({X},{Y},{Z})";
    }
}
#endregion


#region Dimension
public class Dimension2D : Space2D
{
    public Dimension2D()
    {
    }

    public Dimension2D(double x, double y)
        : base(x, y)
    {
    }
    public Dimension2D(Space3D space3D)
    {
        X = space3D.X;
        Y = space3D.Y;
    }
}

public class DimensionXZ : SpaceXZ
{
    public DimensionXZ(double x, double z)
        : base(x, z)
    {
    }
    public DimensionXZ(Dimension3D dimension3D)
    {
        X = dimension3D.X;
        Z = dimension3D.Y;
    }
}

public class DimensionYZ : SpaceYZ
{

    public DimensionYZ(double y, double z)
        : base(y, z)
    {
    }
    public DimensionYZ(Dimension3D dimension3D)
    {
        Y = dimension3D.Y;
        Z = dimension3D.Z;
    }
}

public class Dimension3D : Space3D
{
    public Dimension3D()
    {
    }

    public Dimension3D(double x, double y, double z)
        : base(x, y, z)
    {
    }

    public Dimension3D(Space2D xy, double z)
        : base(xy.X, xy.Y, z)
    {
    }

    public Dimension3D(SpaceXZ xz, double y)
        : base(xz.X, y, xz.Z)
    {
    }

    public Dimension3D(SpaceYZ yz, double x)
        : base(x, yz.Y, yz.Z)
    {
    }

    protected override Space2D Get2D()
    {
        return new Dimension2D(X, Y);
    }
    protected override SpaceXZ GetXZ()
    {
        return new DimensionXZ(X, Z);
    }

    protected override SpaceYZ GetYZ()
    {
        return new DimensionYZ(Y, Z);
    }

    public bool IsEmpty()
    {
        return this.X <= 0 || this.Y <= 0 || this.Z <= 0;
    }

}
#endregion