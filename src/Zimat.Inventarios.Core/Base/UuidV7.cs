using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

namespace Zimat.Inventarios.Core.Base;

  public readonly struct UuidV7 : IEquatable<UuidV7>, IComparable<UuidV7>
  {
      public readonly Guid Value;

      public UuidV7() : this(DateTimeOffset.UtcNow) { }

      public UuidV7(DateTimeOffset dateTimeOffset)
      {
          // bytes [0-5]: datetimeoffset yyyy-MM-dd hh:mm:ss fff
          // bytes [6]: 4 bits dedicated to guid version (version: 7)
          // bytes [6]: 4 bits dedicated to random part
          // bytes [7-15]: random part
          byte[] uuidAsBytes = new byte[16];
          FillTimePart(ref uuidAsBytes, dateTimeOffset);
          Span<byte> random_part = uuidAsBytes.AsSpan().Slice(6);
          RandomNumberGenerator.Fill(random_part);
          // add mask to set guid version
          uuidAsBytes[6] &= 0x0F;
          uuidAsBytes[6] += 0x70;
          Value = new Guid(uuidAsBytes, true);
      }

      public UuidV7(Guid value)
      {
        Value = new Guid(value.ToString());   
      }

      private static void FillTimePart(ref byte[] uuidAsBytes, DateTimeOffset dateTimeOffset)
      {
          long currentTimestamp = dateTimeOffset.ToUnixTimeMilliseconds();
          byte[] current = BitConverter.GetBytes(currentTimestamp);
          if (BitConverter.IsLittleEndian)
          {
              Array.Reverse(current);
          }
          current[2..8].CopyTo(uuidAsBytes, 0);
      }

  public int CompareTo(UuidV7 other)
  {
    return Value.CompareTo(other.Value);
  }


  public bool Equals(UuidV7 other)
  {
    return Value.Equals(other.Value);
  }

  public static UuidV7 FromGuid(Guid uuid)
  {
    return new UuidV7( uuid);
  }

  public static Guid NewGuid()
  {
    return new UuidV7().Value;
  }

  public override string ToString() => Value.ToString();
  public static bool operator ==(UuidV7 a, UuidV7 b){
    return a.Equals(b);
  }
  public static bool operator !=(UuidV7 a, UuidV7 b){
    return !(a == b);
  }
public override bool Equals([NotNullWhen(true)] object? o) {
    if(!(o is UuidV7))
      return false;
    return this ==(UuidV7)o;
  }

  public override int GetHashCode()  
   {  
      return 0;  
   }  

}
