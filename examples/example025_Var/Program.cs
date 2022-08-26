var data = new int[] {1,2,3,4}
  .Where(e => e > 0)
  .Select(e => new { q = e, w = e + 1});

Console.WriteLine(data.GetType());
