using System;
using System.Linq;
using System.Collections.Generic;

namespace BST
{

  class ArgumentsUtil
  {
    static Func<string, Nullable<int>> parser = input => {
      int? output = null;
      try{
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
      return output;
    };

    public static int validateNode(String value) {
      return parser.Invoke(value) ?? default(int);
    }

    public static int[] validateTreeArgs(string treeArgs)
    {
      IEnumerable<int?> allValues = new List<int?>();
      int[] values = new int[] { };

      try
      {
        allValues = treeArgs.Split(",").Select(parser);
        values = allValues.Select(y => y ?? default(int)).ToArray();
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