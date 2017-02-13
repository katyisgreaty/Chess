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
      Chess testChess = new Chess(2, 4, 1, 4);
      Assert.Equal(true, testChess.CanAttack());
    }
  }
}
