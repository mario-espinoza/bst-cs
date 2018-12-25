using System;
using System.Linq;

namespace BST
{

  class ArgumentsUtil
  {
    Func<string, int> parser = input => {
      int output = 0;
      try
      {
        output = int.Parse(input);
      }
      catch (FormatException)
      {
        Console.WriteLine("Unable to convert '{0}'.", input);
      }
      catch (OverflowException)
      {
        Console.WriteLine("value out of range of the Int32 type.");
      }
      return 0;
    };

    public static int[] validateTreeArgs(string treeArgs)
    {
      int[] values = new int[] { };

      try
      {
        values = treeArgs.Split(",").Select(a => int.Parse(a)).ToArray();
      }
      catch (FormatException)
      {
        Console.WriteLine("Unable to convert '{0}'.", treeArgs);
      }
      catch (OverflowException)
      {
        Console.WriteLine("value out of range of the Int32 type.");
      }
      return values;
    }


  }
}