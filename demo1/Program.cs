Parallel.Invoke(
    () => Console.WriteLine("Hello World!"),
    () => Console.WriteLine("test")
);