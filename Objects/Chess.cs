using System;
using System.Collections.Generic;

namespace Chess1.Objects
{
  public class Chess
  {
    public int _qxcoord;
    public int _qycoord;
    public int _pxcoord;
    public int _pycoord;

    public Chess (int qxcoord, int qycoord, int pxcoord, int pycoord)
    {
      _qxcoord = qxcoord;
      _qycoord = qycoord;
      _pxcoord = pxcoord;
      _pycoord = pycoord;
    }

    public bool CanAttack()
    {
      if (_qxcoord == _pxcoord)
      {
        return true;
      } else if (_qycoord == _pycoord)
      {
        return true;
      }
      else
      {
        return false;
      }
    }


  }
}
