using Xunit;
using System.Collections.Generic;
using Chess1.Objects;

namespace Chess1App
{
  public class ChessTest
  {
    [Fact]
    public void CanAttack_true()
    {
      Chess testChess = new Chess(1, 2, 3, 4);
      Assert.Equal(true, testChess.CanAttack());
    }
  }
}
