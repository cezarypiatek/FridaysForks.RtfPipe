using System;
using System.Diagnostics;

namespace RtfPipe
{
  [DebuggerDisplay("Color({Red},{Green},{Blue})")]
  public sealed class ColorValue : IEquatable<ColorValue>
  {
    public static readonly ColorValue Black = new ColorValue(0, 0, 0);
    public static readonly ColorValue White = new ColorValue(255, 255, 255);
    public static readonly ColorValue Yellow = new ColorValue(255, 255, 0);
    /// <summary>
    /// Auto or default color. On HTML this is rendered as no color specified (no color tag will be added).
    /// </summary>
    public static readonly ColorValue Auto = new ColorValue();

    public ColorValue() : this(0, 0, 0)
    {
      this.IsAuto = true;
    }

    public ColorValue(byte red, byte green, byte blue)
    {
      this.Red = red;
      this.Green = green;
      this.Blue = blue;
    }

    /// <summary>
    /// True indicates that is Auto or Default color because it is defined as empty on Color's table.
    /// On HTML this is rendered as no color specified (no color tag will be added).
    /// </summary>
    public bool IsAuto { get; } = false;
    public byte Red { get; }
    public byte Green { get; }
    public byte Blue { get; }

    public override bool Equals(object obj)
    {
      if (obj is ColorValue color)
        return Equals(color);
      return false;
    }

    public bool Equals(ColorValue other)
    {
      return IsAuto == other.IsAuto
        && Red == other.Red
        && Green == other.Green
        && Blue == other.Blue;
    }

    public override int GetHashCode()
    {
      return HashTool.AddHashCode(GetType().GetHashCode(), ComputeHashCode());
    }

    private int ComputeHashCode()
    {
      int hash = Red;
      hash = HashTool.AddHashCode(hash, Green);
      hash = HashTool.AddHashCode(hash, Blue);
      hash = HashTool.AddHashCode(hash, IsAuto);
      return hash;
    }

    public override string ToString()
    {
      return IsAuto ? string.Empty : $"{Red:X2}{Green:X2}{Blue:X2}";
    }

    public ColorValue Clone()
    {
      return IsAuto ? ColorValue.Auto : new ColorValue(Red, Green, Blue);
    }

    public static bool operator ==(ColorValue x, ColorValue y)
    {
      if (ReferenceEquals(x, y))
        return true;

      if (ReferenceEquals(x, null) || ReferenceEquals(y, null))
        return false;

      return x.Equals(y);
    }

    public static bool operator !=(ColorValue x, ColorValue y)
    {
      return !(x == y);
    }
  }
}
