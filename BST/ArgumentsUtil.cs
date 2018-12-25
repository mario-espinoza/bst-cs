using System;
using System.Linq;

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

    public static int? validateNode(String value) {
      return parser.Invoke(value);
    }

    public static int?[] validateTreeArgs(string treeArgs)
    {
      int?[] values = new int?[] { };

      try
      {
        values = treeArgs.Split(",").Select(parser).Where(y => y != null) .ToArray();
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